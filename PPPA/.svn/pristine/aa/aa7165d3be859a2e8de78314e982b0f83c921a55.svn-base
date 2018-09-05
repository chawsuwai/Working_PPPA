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
using PPP_Project.CommonAttributes;
using PPP_Project.Business;
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace PPP_Project
{
    public partial class Export_List_With_Deno : System.Web.UI.Page
    {
        string fromDate;
        string toDate;
        string eve = "Submit";
        string Month1, Month2, FromDate2, ToDate2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFromDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                txtToDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);

                var Probes = new Probes();
                var result = Probes.FindAllBranch();

                ddlCenterName.Items.Insert(0, "All");
                for (int i = 0; i < result.Count; i++)
                {
                    ddlCenterName.Items.Insert(i + 1, new ListItem(result[i].BranchName, result[i].BranchCode));
                }
            }
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            fromDate = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text);
            toDate = GeneralUtility.ConvertSystemDateStringFormat(txtToDate.Text);

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
                //string comparedate = new AccuracyPercentage().FindMonthAndYear(fromDate);
                //string comparemonth = comparedate.Substring(3, 2);
                //string compareyear = comparedate.Substring(6, 4);

                string comparedate = new AccuracyPercentage().FindMonthAndYear(fromDate);
                DateTime fromtime = DateTime.Parse(comparedate);
                var date = GeneralUtility.ConvertSystemDateStringFormat(fromtime);
                string comparemonth = date.Substring(4, 2);
                string compareyear = date.Substring(0, 4);

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

            //(branchcode, Month1, 7500, 96, fromDate, toDate, Month2, FromDate2, ToDate2); 

            var branchcode = string.Empty;

            if (ddlCenterName.SelectedItem.Value != "All")
            {
                branchcode = ddlCenterName.SelectedValue.ToString();
            }

            #region "For All"
            if (ddlJobName.SelectedValue == "All")
            {
                var probesList = new Probes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForAll();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in probesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                table.Columns.Remove("ImportedDate");

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);
      

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("All");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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

                } // End All Export Block

            }
            #endregion // End For All

            
            #region "For Probes"
            if (ddlJobName.SelectedValue == "Probes")
            {
                var probesList = new Probes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1=Month1,
                        Month2=Month2,
                        FromDate2=FromDate2,
                        ToDate2=ToDate2,
                    }

                }.FindByCriteriaDenominatorForProbes();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in probesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);            

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorProbesList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Probes");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                     //   var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Probes Export Block

            }
            #endregion // End Probes
            #region "Pricing Probes"
            else if (ddlJobName.SelectedValue == "Pricing Probes")
            {
                var pricingprobesList = new PricingProbes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForPricingProbes();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in pricingprobesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //           // table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorPricingProbesList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Pricing Probes");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                        //var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Masks"
            else if (ddlJobName.SelectedValue == "Masks")
            {
                var masksList = new Masks
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForMasks();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in masksList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));
                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorMasksList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Masks");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                       // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Votes"
            else if (ddlJobName.SelectedValue == "Votes")
            {
                var votesList = new Votes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForVotes();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in votesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));
                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorVotesList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Votes");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                       // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Repricing"
            else if (ddlJobName.SelectedValue == "Repricing")
            {
                var repricingList = new Repricing
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForRepricing();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in repricingList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorRepricingList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Repricing");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                       // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Scenes"
            else if (ddlJobName.SelectedValue == "Scenes")
            {
                var scenesList = new Scenes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForScenes();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in scenesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorScenesList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Scenes");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                       // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Scene Recognition"
            else if (ddlJobName.SelectedValue == "Scene Recognition")
            {
                var scenerecognitionList = new SceneRecognition
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,

                    }

                }.FindByCriteriaDenominatorForSceneRecognition();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in scenerecognitionList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable
                //            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); 

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorSceneRecognitionList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Scene Recognition");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                       // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Category Expert"
            else if (ddlJobName.SelectedValue == "Category Expert")
            {
                var categoryexpertList = new CategoryExpert
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,

                    }

                }.FindByCriteriaDenominatorForCategoryExpert();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in categoryexpertList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorCategoryExpertList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Category Expert");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                      //  var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Smart Stitching"
            //else if (ddlJobName.SelectedValue == "Smart Stitching")
            //{
            //    var smartstitchingList = new SmartStitching
            //    {
            //        Criteria = new PPP_Project.Criteria.ImportJobsCriteria
            //        {
            //            CenterName = branchcode,
            //            FromDate = fromDate,
            //            ToDate = toDate,
            //        }

            //    }.FindByCriteria();

            //    DataTable attTbl = new DataTable();

            //    attTbl.Clear();
            //    attTbl.Columns.Clear();

            //    var result = (from dd in smartstitchingList
            //                  orderby dd.Center
            //                  select dd).ToList();

            //    // Convert to DataTable.
            //    DataTable table = ConvertToDataTable(result);

            //    table.Columns.Remove(table.Columns[0]); // this is Table ID Field
            //    table.Columns.Remove("TableName"); // this is Default DataTableName Field


            //    if (result.Count() != 0)
            //    {
            //        for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
            //        {
            //            DataRow row = table.Rows[table.Rows.Count - 1];
            //            //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

            //            int totalRows = table.Rows.Count;
            //            int totalCols = table.Columns.Count;

            //            string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

            //            for (int j = 0; j < totalRows; j++)
            //            {
            //                table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

            //                table.AcceptChanges();
            //            }

            //        }
            //    }

            //    //DataTable finalProbesdt2 = table.CopyToDataTable();

            //    DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

            //    //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

            //    var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
            //    int yr = Convert.ToInt32(yrm.Substring(0, 4).ToString());
            //    int mth = Convert.ToInt32(yrm.Substring(4, 2).ToString());
            //    DateTime date = new DateTime(yr, mth, 1);
            //    var mm = date.ToString("MMMM");
            //    var yy = date.ToString("yy");

            //    if (result.Count().Equals(0))
            //    {
            //        MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
            //    }
            //    else
            //    {
            //        var fileName = "Denominator_SmartStitchingList_" + mm + "'" + yy + ".xlsx";
            //        int count = 0;
            //        Response.Clear();
            //        Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //        //Response.AddHeader("content-disposition", "attachment;filename=" + HttpUtility.UrlEncode("Probes_List_Export.xlsx", System.Text.Encoding.UTF8));
            //        this.Response.AddHeader(
            //                    "content-disposition",
            //                    string.Format("attachment;  filename={0}", fileName));

            //        ExcelPackage pkg = new ExcelPackage();

            //        using (pkg)
            //        {

            //            ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Smart Stitching");

            //            ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

            //            #region "No need region"
            //            using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
            //            {
            //                rng.Style.Font.Bold = true;
            //                //Set Pattern for the background to Solid
            //                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
            //                //Set color to dark blue
            //                rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
            //                //  rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(122,160,205));
            //                rng.Style.Font.Color.SetColor(System.Drawing.Color.White);
            //            }
            //            //ws.Cells["A1:MT"].Style.Font.Bold = true;
            //            ////ws.Cells["A1"].Style.Font.Bold = true;
            //            //using (ExcelRange rng = ws.Cells["A1:U" + (colcount - 1)])
            //            //{
            //            //    rng.Style.Font.Bold = true;
            //            //}

            //            //var headerCell = ws.Cells["A5:MT"];
            //            //headerCell.Style.Fill.PatternType = ExcelFillStyle.Solid;
            //            //headerCell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.BurlyWood);
            //            //var headerFont = headerCell.Style.Font;
            //            //headerFont.Bold = true;

            //            //ws.Cells[1, 30].Style.Fill.PatternType = ExcelFillStyle.Solid;
            //            //ws.Cells[1, 30].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
            //            //ws.Cells[1, 30].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            //            //ws.Cells[1, 30].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            //            #endregion

            //            if (result.Count() > 0)
            //            {
            //                count = result.Count() + 2;
            //                //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Value = sum;//result.Sum(x => x.TotalProbes);
            //                //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Font.Bold = true;
            //                //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Font.UnderLine = true;
            //                //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Font.Color.SetColor(System.Drawing.Color.Blue);
            //                //    pkg.Workbook.Worksheets.FirstOrDefault().Cells[count, 3].Style.Border.BorderAround(ExcelBorderStyle.Thin);
            //            }

            //            pkg.Workbook.Worksheets.FirstOrDefault().DefaultColWidth = 20;
            //            pkg.Workbook.Worksheets.FirstOrDefault().Row(1).Height = 25;


            //          //  var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
            //            var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
            //            var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            //            pkg.Workbook.Properties.Title = "Attempts";

            //            this.Response.BinaryWrite(pkg.GetAsByteArray());
            //            this.Response.End();

            //        }

            //    } // End Pricing Probes Export Block

            //}
            #endregion
            #region "Category Expert Voting"
            else if (ddlJobName.SelectedValue == "Category Expert Voting")
            {
                var categoryexpertvotingList = new CategoryExpertVoting
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,

                    }

                }.FindByCriteriaDenominatorForCategoryExpertVoting();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in categoryexpertvotingList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //table.Columns.Remove(table.Columns[0]); // this is Table ID Field
                //table.Columns.Remove("TableName"); // this is Default DataTableName Field


                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "DenominatorCategoryExpertVotingList" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Category Expert Voting");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                       // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion


            #region "Masks Detail"
            else if (ddlJobName.SelectedValue == "MasksDetail")
            {
                var masksList = new Masks
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                        Month1 = Month1,
                        Month2 = Month2,
                        FromDate2 = FromDate2,
                        ToDate2 = ToDate2,
                    }

                }.FindByCriteriaDenominatorForMasksDetail();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in masksList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                //table.Columns.Remove(table.Columns[0]);
                //table.Columns.Remove("TableName");

                //if (result.Count() != 0)
                //{
                //    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                //    {
                //        DataRow row = table.Rows[table.Rows.Count - 1];
                //        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                //        int totalRows = table.Rows.Count;
                //        int totalCols = table.Columns.Count;

                //        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                //        for (int j = 0; j < totalRows; j++)
                //        {
                //            table.Rows[j]["ImportedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                //            table.AcceptChanges();
                //        }

                //    }
                //}

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumnsForDenominator(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));
                var yrm = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text.Trim());
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
                    var fileName = "Denominator_MasksListDetail_" + mm + "'" + yy + ".xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Masks");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
                        using (ExcelRange rng = ws.Cells[1, 1, 1, finalProbesdt.Columns.Count])
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


                        // var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells[ws.Dimension.Start.Row, 1, ws.Dimension.Start.Row + table.Rows.Count, table.Columns.Count]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            else
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Job Name!.", ClientScript);
            }

        } // //MessageBox.MessageShow(this.GetType(), "Still Doing!.", ClientScript);

        private DataTable SupressEmptyColumns(DataTable dtSource)
        {
            //the DataTable is dynamic, loop thru each col and thru each row to
            // determine if that column is empty.

            System.Collections.ArrayList columnsToRemove = new System.Collections.ArrayList();

            foreach (DataColumn dc in dtSource.Columns)
            {
                bool colEmpty = true;
                foreach (DataRow dr in dtSource.Rows)
                {
                    if (Convert.ToString(dr[dc.ColumnName]) != "0")//string.Empty
                    {
                        colEmpty = false;
                    }
                }

                if (colEmpty == true)
                {
                    columnsToRemove.Add(dc.ColumnName);
                }
            }

            //remove all columns that are empty
            foreach (string columnName in columnsToRemove)
            {
                dtSource.Columns.Remove(columnName);
            }

            return dtSource;
        }

        private DataTable SupressEmptyColumnsForAllJob(DataTable dtSource)
        {
            //the DataTable is dynamic, loop thru each col and thru each row to
            // determine if that column is empty.

            System.Collections.ArrayList columnsToRemove = new System.Collections.ArrayList();

            foreach (DataColumn dc in dtSource.Columns)
            {
                bool colEmpty = true;
                foreach (DataRow dr in dtSource.Rows)
                {
                    if (dc.ColumnName == "QAT" || dc.ColumnName == "Center" || dc.ColumnName == "TotalProbes" || dc.ColumnName == "TotalPricingProbes" || dc.ColumnName == "TotalMasks" || dc.ColumnName == "TotalVotes" || dc.ColumnName == "TotalRepricing" || dc.ColumnName == "TotalScenes" || dc.ColumnName == "TotalSceneRecognition" || dc.ColumnName == "TotalCategoryExpert" || dc.ColumnName == "TotalCategoryExpertVoting")
                    {
                        colEmpty = false;
                    }
                }

                if (colEmpty == true)
                {
                    columnsToRemove.Add(dc.ColumnName);
                }
            }

            //remove all columns that are empty
            foreach (string columnName in columnsToRemove)
            {
                dtSource.Columns.Remove(columnName);
            }

            return dtSource;
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

        private DataTable SupressEmptyColumnsForDenominator(DataTable dtSource)
        {
            //the DataTable is dynamic, loop thru each col and thru each row to
            // determine if that column is empty.

            System.Collections.ArrayList columnsToRemove = new System.Collections.ArrayList();

            foreach (DataColumn dc in dtSource.Columns)
            {
                bool colEmpty = true;
                foreach (DataRow dr in dtSource.Rows)
                {
                    if (Convert.ToString(dr[dc.ColumnName]) != "0.00" && Convert.ToString(dr[dc.ColumnName]) != "0")//string.Empty
                    {
                        colEmpty = false;
                    }
                }

                if (colEmpty == true)
                {
                    columnsToRemove.Add(dc.ColumnName);
                }
            }

            //remove all columns that are empty
            foreach (string columnName in columnsToRemove)
            {
                dtSource.Columns.Remove(columnName);
            }

            return dtSource;
        }

    }
}