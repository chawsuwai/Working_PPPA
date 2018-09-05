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
    public partial class Export_QAT : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                date = GeneralUtility.ConvertSystemDateStringFormat(txtMonth.Text);
                txtMonth.Text = date1.Substring(3, 7).ToString();

                var Probes = new Probes();
                var result = Probes.FindAllBranch();

               // ddlCenterName.Items.Insert(0, "All");
                for (int i = 0; i < result.Count; i++)
                {
                    ddlCenterName.Items.Insert(i , new ListItem(result[i].BranchName, result[i].BranchCode));
                }
            }
        }


        protected void btnExport_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text != "" && txtMonth.Text != null)
            {
                #region "QAT"

                var center = ddlCenterName.SelectedValue.ToString();

                var QATList = new QAT().AllQAT();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in QATList.Where(x => x.Center == this.ddlCenterName.SelectedValue).ToList()
                              orderby dd.QAT
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                table.Columns.Remove("ID");
                table.Columns.Remove("Createdby");
                table.Columns.Remove("Month");
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
                    var fileName = "QATList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("QAT");

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

                      
                        #endregion

                        if (result.Count() > 0)
                        {
                            count = result.Count() + 2;
                        
                        }

                        pkg.Workbook.Worksheets.FirstOrDefault().DefaultColWidth = 20;
                        pkg.Workbook.Worksheets.FirstOrDefault().Row(1).Height = 25;

                       
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