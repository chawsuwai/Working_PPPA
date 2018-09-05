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

namespace PPP_Project
{
    public partial class Export_ProjectName : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                date = GeneralUtility.ConvertSystemDateStringFormat(txtMonth.Text);
                txtMonth.Text = date1.Substring(3, 7).ToString();               
            }
        }


        protected void btnExport_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text != "" && txtMonth.Text != null)
            {
                #region "For Project Name Not In Project Denominator"

                var projectNameList = new ProjectNames().FindByProjectName(GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),ddlJobName.SelectedValue);

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in projectNameList
                              orderby dd.PROJECT
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                table.Columns.Remove("ID");
                table.Columns.Remove("Createdby");
                //table.Columns.Remove("ImportMonth");
                table.Columns.Remove("CreatedDate");
                table.Columns.Remove("TableName");
                         

                var yrm = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim());
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
                    var fileName = "Project Name List " + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Project");

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

                       
                        
                      //  ws.Cells[2, 2].Style.Font.Name = "Zawgyi-One";

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
                       // Response.Output.Write("<meta http-equiv=\"Content-Type\"content=\"text/html; charset=utf-8\">");
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