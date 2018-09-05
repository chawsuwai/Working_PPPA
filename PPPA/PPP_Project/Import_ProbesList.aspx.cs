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
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace PPP_Project
{
    public partial class Import_ProbesList : System.Web.UI.Page
    {
        string fromDate;
        string toDate;
        string eve = "Submit";

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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        //public DataTable ConvertListToDataTable(List<string[]> list)
        //{
            
        //}


        protected void btnExport_Click(object sender, EventArgs e)
        {
            fromDate = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text);
            toDate = GeneralUtility.ConvertSystemDateStringFormat(txtToDate.Text);

            var branchcode = string.Empty;

            if (ddlCenterName.SelectedItem.Value != "All")
            {
                branchcode = ddlCenterName.SelectedValue.ToString();
            }

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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in probesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "ProbesList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";                                               

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();                        

                    }

                } // End Probes Export Block

            }
            #endregion // End Probes
            #region "Pricing Probes"
            else if (ddlJobName.SelectedValue =="Pricing Probes")
            {
                var pricingprobesList = new PricingProbes
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in pricingprobesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "PricingProbesList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in masksList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "MasksList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in votesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "VotesList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in repricingList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "RepricingList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in scenesList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "ScenesList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in scenerecognitionList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "SceneRecognitionList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in categoryexpertList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                //for (int i = table.Columns.Count - 1; i >= 0; i--)

                table.Columns.Remove(table.Columns[0]);
                table.Columns.Remove("TableName");

                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "CategoryExpertList_Export.xlsx";
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
            #endregion
            #region "Smart Stitching"
            else if (ddlJobName.SelectedValue == "Smart Stitching")
            {
                var smartstitchingList = new SmartStitching
                {
                    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                    {
                        CenterName = branchcode,
                        FromDate = fromDate,
                        ToDate = toDate,
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in smartstitchingList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                table.Columns.Remove(table.Columns[0]); // this is Table ID Field
                table.Columns.Remove("TableName"); // this is Default DataTableName Field


                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }     

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "SmartStitchingList_Export.xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Smart Stitching");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
                        var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        pkg.Workbook.Properties.Title = "Attempts";

                        this.Response.BinaryWrite(pkg.GetAsByteArray());
                        this.Response.End();

                    }

                } // End Pricing Probes Export Block

            }
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
                    }

                }.FindByCriteria();

                DataTable attTbl = new DataTable();

                attTbl.Clear();
                attTbl.Columns.Clear();

                var result = (from dd in categoryexpertvotingList
                              orderby dd.Center
                              select dd).ToList();

                // Convert to DataTable.
                DataTable table = ConvertToDataTable(result);

                table.Columns.Remove(table.Columns[0]); // this is Table ID Field
                table.Columns.Remove("TableName"); // this is Default DataTableName Field


                if (result.Count() != 0)
                {
                    for (int i = table.Columns.Count - 1; i >= 0; i--) // this is mean (table.Columns.Count - 1) last column count
                    {
                        DataRow row = table.Rows[table.Rows.Count - 1];
                        //row["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(Convert.ToDateTime(table.AsEnumerable().Last())); //(row["CreatedDate"]) // not good

                        int totalRows = table.Rows.Count;
                        int totalCols = table.Columns.Count;

                        string value = table.Rows[totalRows - 1][totalCols - 1].ToString();

                        for (int j = 0; j < totalRows; j++)
                        {
                            table.Rows[j]["CreatedDate"] = GeneralUtility.ConvertDisplayDateStringFormat(value); // this is change to String Datetime to Display String Date in DataTable

                            table.AcceptChanges();
                        }

                    }
                }                

                //DataTable finalProbesdt2 = table.CopyToDataTable();

                DataTable finalProbesdt = SupressEmptyColumns(table);

                //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

                if (result.Count().Equals(0))
                {
                    MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
                }
                else
                {
                    var fileName = "SmartStitchingList_Export.xlsx";
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

                        ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Smart Stitching");

                        ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

                        #region "No need region"
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


                        var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
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