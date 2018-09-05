using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPP_Project.Base;
using PPP_Project.Common;
using PPP_Project.Common.Utility;
using PPP_Project.Common.Message;
using PPP_Project.Entity;
using PPP_Project.Criteria;
using PPP_Project.Business;
using PPP_Project.CommonAttributes;
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Globalization;

namespace PPP_Project
{
    public partial class Export_Accuracy_3PA_GSS : System.Web.UI.Page
    {
        string date;
        string fromDate;
        string toDate;
        string Month1, Month2, FromDate2, ToDate2;

        string calculateMonth;

        string calculateFromDate;
        string calculateToDate;
        string cMonth2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                date = GeneralUtility.ConvertSystemDateStringFormat(txtMonth.Text);
                txtMonth.Text = date1.Substring(3, 7).ToString();

                txtFromDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                txtToDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);

                var Probes = new Probes();
                var result = Probes.FindAllBranch();

                //ddlCenterName.Items.Insert(0, "All");
                ddlCenterName.Items.Insert(0, "--Select--");
                for (int i = 0; i < result.Count; i++)
                {
                    ddlCenterName.Items.Insert(i + 1, new ListItem(result[i].BranchName, result[i].BranchCode));
                }
            }
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text != "" && txtMonth.Text != null)
            {
                #region "For Above 96%+5K"

                string count1 = "0";
                string count2 = "0";

                calculateMonth = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim());

                //calculateFromDate = calculateMonth + "16";  //calculateFromDate          

                calculateToDate = calculateMonth + "15";  //calculateToDate  

                string calculatedate = new AccuracyPercentage().FindPreviousMonth(calculateToDate);
                DateTime calfromtime = DateTime.Parse(calculatedate);
                var cdate = GeneralUtility.ConvertSystemDateStringFormat(calfromtime);
                string cmonth = cdate.Substring(4, 2);
                string cyear = cdate.Substring(0, 4);
                cMonth2 = cyear + cmonth;

                //calculateToDate = cMonth2 + "15"; //calculateToDate

                calculateFromDate = cMonth2 + "16"; //calculateFromDate

                if ((txtFromDate.Text == "" || txtFromDate.Text == null) || (txtToDate.Text == "" || txtToDate.Text == null))
                {
                    MessageBox.MessageShow(this.GetType(), "Please Choose From/To Date!.", ClientScript);
                    return;
                }

                else
                {             

               

                fromDate = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text);
                toDate = GeneralUtility.ConvertSystemDateStringFormat(txtToDate.Text);

                DateTime dtStartDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtFromDate.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dtEndDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtToDate.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);


                count1 = new Probes().CheckDate(calculateFromDate, calculateToDate, fromDate);
                count2 = new Probes().CheckDate(calculateFromDate, calculateToDate, toDate);

                if (count1 == "0" || count2 == "0")
                {
                    MessageBox.MessageShow(this.GetType(), "Please Check From/To Date Range!.", ClientScript);
                    return;
                }

                if ((dtEndDate.Date != dtStartDate.Date))
                {
                    if (!(dtEndDate.Date > dtStartDate.Date))
                    {
                        MessageBox.MessageShow(this.GetType(), "Invalid End Date.", ClientScript);
                        //this.txtToDate.Focus();
                        return;
                    }
                }

                string fromYear = fromDate.Substring(0, 4);
                string fromMonth = fromDate.Substring(4, 2);

                string toYear = toDate.Substring(0, 4);
                string toMonth = toDate.Substring(4, 2);

                if (fromYear == toYear && fromMonth == toMonth)
                {
                    Month1 = fromYear + fromMonth;
                    Month2 = string.Empty;
                    FromDate2 = string.Empty;
                    ToDate2 = string.Empty;
                }
                else
                {
                    //string comparedate=new AccuracyPercentage().FindMonthAndYear(fromDate);
                    //string comparemonth = comparedate.Substring(3, 2);
                    //string compareyear = comparedate.Substring(6, 4);

                    string comparedate = new AccuracyPercentage().FindMonthAndYear(fromDate);
                    DateTime fromtime = DateTime.Parse(comparedate);
                    var fdate = GeneralUtility.ConvertSystemDateStringFormat(fromtime);
                    string comparemonth = fdate.Substring(4, 2);
                    string compareyear = fdate.Substring(0, 4);

                    if (compareyear != toYear || comparemonth != toMonth)
                    {
                        MessageBox.MessageShow(this.GetType(), "Please Check FromDate and ToDate!.", ClientScript);
                        return;
                    }

                    Month1 = fromYear + fromMonth;
                    Month2 = compareyear + comparemonth;
                    FromDate2 = Month2 + "01";
                    ToDate2 = toDate;
                    toDate = new AccuracyPercentage().FindLastDayOfMonth(fromDate);


                }

            }
                // FindByMonthFor3PA(branchcode, GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),fromDate,toDate,month2,fromDate2,toDate2);
                //@Center nvarchar(30),@Month nvarchar(30),@FromDate VARCHAR(8), @ToDate VARCHAR(8),@Month2 nvarchar(30),@FromDate2 VARCHAR(8), @ToDate2 VARCHAR(8)

                //var branchcode = string.Empty;

                //if (ddlCenterName.SelectedItem.Value != "All")
                //{
                //    branchcode = ddlCenterName.SelectedValue.ToString();
                //}

                var branchcode = string.Empty;

                if (ddlCenterName.SelectedIndex != 0)
                {
                    branchcode = ddlCenterName.SelectedValue.ToString();
                }
                else
                {
                    MessageBox.MessageShow(this.GetType(), "Please Choose Center!.", ClientScript);
                    return;
                }

                new Probes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = calculateFromDate,
                        ToDate = calculateToDate,
                        Month1 = cMonth2,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.CalculateTotalProbes();

                var finalAccuracyList = new AccuracyPercentage().FindByMonthFor3PAGSS(branchcode, cMonth2, fromDate, toDate, Month2, FromDate2, ToDate2);

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in finalAccuracyList
                              orderby dd.QAT
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                table.Columns.Remove("RQuality");
                table.Columns.Remove("AmountforProbes");
                table.Columns.Remove("AmountforAccuracy");
                table.Columns.Remove("PPPA");
                table.Columns.Remove("Center");
                table.Columns.Remove("Month");
                table.Columns.Remove("Quality");
                table.Columns.Remove("Name");

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(calculateToDate);
                int yr = Convert.ToInt32(yrm.Substring(0, 4).ToString());
                int mth = Convert.ToInt32(yrm.Substring(4, 2).ToString());
                DateTime date = new DateTime(yr, mth, 1);
                var mm = date.ToString("MMMM");
                var yy = date.ToString("yy");

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "3PA" + mm + "'" + yy + ".xlsx";
                    int count = 0;
                    Response.Clear();
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    //Response.AddHeader("content-disposition", "attachment;filename=" + HttpUtility.UrlEncode("Probes_List_Export.xlsx", System.Text.Encoding.UTF8));
                    this.Response.AddHeader(
                                "content-disposition",
                                string.Format("attachment;  filename={0}", fileName));

                    ExcelPackage pkg = new ExcelPackage();

                    using (pkg)
                    {

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("3PA Ori");

                        ws.Cells["A1"].LoadFromDataTable(table, true);

                        #region "No need region"
                        // using (ExcelRange rng = ws.Cells["A1:W1"])                         
                        //  using (ExcelRange r = workSheet.Cells[startRowFrom, 1, startRowFrom, dataTable.Columns.Count]) 
                        using (ExcelRange rng = ws.Cells[1, 1, 1, table.Columns.Count])
                        {
                            rng.Style.Font.Bold = true;
                            //Set Pattern for the background to Solid
                            rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            //Set color to dark blue
                            rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
                            //  rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(122,160,205));
                            rng.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        }

                        //ws.Cells["A1:MT"].Style.Font.Bold = true;
                        ////ws.Cells["A1"].Style.Font.Bold = true;
                        //using (ExcelRange rng = ws.Cells["A1:U" + (colcount - 1)])
                        //{
                        //    rng.Style.Font.Bold = true;
                        //}

                        //var headerCell = ws.Cells["A5:MT"];
                        //headerCell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        //headerCell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.BurlyWood);
                        //var headerFont = headerCell.Style.Font;
                        //headerFont.Bold = true;

                        //ws.Cells[1, 30].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        //ws.Cells[1, 30].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        //ws.Cells[1, 30].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        //ws.Cells[1, 30].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        #endregion

                        if (result.Count() > 0)
                        {
                            count = result.Count() + 2;
                            //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Value = sum;//result.Sum(x => x.TotalProbes);
                            //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Font.Bold = true;
                            //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Font.UnderLine = true;
                            //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Font.Color.SetColor(System.Drawing.Color.Blue);
                            //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }

                        pkg.Workbook.Worksheets.FirstOrDefault().DefaultColWidth = 20;
                        pkg.Workbook.Worksheets.FirstOrDefault().Row(1).Height = 25;

                        // using (ExcelRange r = workSheet.Cells[startRowFrom + 1, 1, startRowFrom + dataTable.Rows.Count, dataTable.Columns.Count]) 
                        // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)

                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Export Block


                #endregion // End Probes
            }
            else
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Export Date!.", ClientScript);
            }
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}