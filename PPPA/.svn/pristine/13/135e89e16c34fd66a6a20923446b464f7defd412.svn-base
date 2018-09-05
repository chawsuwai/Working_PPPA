using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPP_Project.Base;
using PPP_Project.Common;
using PPP_Project.Common.Utility;
using PPP_Project.Criteria;
using PPP_Project.Common.Message;
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;


namespace PPP_Project
{
    public partial class JobsImport_List2 : System.Web.UI.Page
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

                #region "Not Used"
                //var Probes = new Probes();
                //var result = Probes.Finds().Select(x => x.Center).Distinct().ToList();

                //ddlCenterName.Items.Insert(0, "All");
                //for (int i = 0; i < result.Count; i++)
                //{
                //    ddlCenterName.Items.Insert(i + 1, new ListItem(result[i], result[i]));
                //}
                #endregion
            }
        }


        protected void btnExport_Click(object sender, EventArgs e)
        {
            fromDate = GeneralUtility.ConvertSystemDateStringFormat(txtFromDate.Text);
            toDate = GeneralUtility.ConvertSystemDateStringFormat(txtToDate.Text);

            var branchcode = string.Empty;

            if (ddlCenterName.SelectedItem.Value != "All")
            {
                branchcode = ddlCenterName.SelectedValue.ToString();
            }


            var probesList = new Probes
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindProbesJobImportList(); // FindByCriteria(); // for Probes // 

            #region "Probes"

            DataTable attTbl = new DataTable();
            attTbl.Clear();
            attTbl.Columns.Clear();


            #endregion

            var pricingprobesList = new PricingProbes
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindPricingProbesJobImportList(); //FindByCriteria(); // for PricingProbes

            var masksList = new Masks
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindMasksJobImportList();  //FindByCriteria(); // for Masks

            var votesList = new Votes
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindVotesJobImportList(); //FindByCriteria(); // for Votes

            var repricingList = new Repricing
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindRepricingJobImportList(); //FindByCriteria(); // for repricing

            var scenesList = new Scenes
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindScenesJobImportList(); //FindByCriteria(); // for scenes

            var scenerecognitionList = new SceneRecognition
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindSceneRecognitionJobImport(); //.FindByCriteria(); // for scenerecognition

            var categoryexpertList = new CategoryExpert
            {
                Criteria = new PPP_Project.Criteria.ImportJobsCriteria
                {
                    CenterName = branchcode,
                    FromDate = fromDate,
                    ToDate = toDate,
                }

            }.FindCategoryExpertJobImport(); //FindByCriteria(); // for categoryexpert

            #region "Currently No Need"

            //var smartstitchingList = new SmartStitching
            //{
            //    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
            //    {
            //        CenterName = branchcode,
            //        FromDate = fromDate,
            //        ToDate = toDate,
            //    }
            //}.FindSmartStitchingJobImportList(); //FindByCriteria(); // for smartstitching

            //var categoryexpertvotingList = new CategoryExpertVoting
            //{
            //    Criteria = new PPP_Project.Criteria.ImportJobsCriteria
            //    {
            //        CenterName = branchcode,
            //        FromDate = fromDate,
            //        ToDate = toDate,
            //    }
            //}.FindCategoryExpertVotingJobImportList(); // for categoryexpert

            #endregion


            #region "For Probes"
            //if (ddlJobName.SelectedValue == "Probes")
            //{
            //    var probesList = new Probes
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

            //    var result = (from dd in probesList
            //                  orderby dd.Center
            //                  select dd).ToList();

            //    // Convert to DataTable.
            //    DataTable table = ConvertToDataTable(result);

            //    //for (int i = table.Columns.Count - 1; i >= 0; i--)

            //    table.Columns.Remove(table.Columns[0]);
            //    table.Columns.Remove("TableName");

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

            //    DataTable finalProbesdt = SupressEmptyColumns(table);

            //    //int sum = finalProbesdt.AsEnumerable().Sum(s => s.Field<int>("Total Probes"));

            //    if (result.Count().Equals(0))
            //    {
            //        MessageBox.MessageShow(GetType(), "No Export Data.!", ClientScript);
            //    }
            //    else
            //    {
            //        var fileName = "ProbesList_Export.xlsx";
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

            //            ExcelWorksheet ws = pkg.Workbook.Worksheets.Add("Probes");

            //            ws.Cells["A1"].LoadFromDataTable(finalProbesdt, true);

            //            #region "No need region"
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


            //            var modelTable = pkg.Workbook.Worksheets.FirstOrDefault().Cells["A1:MP" + (count - 1)]; //+ (count - 1)
            //            var border = modelTable.Style.Border.Top.Style = modelTable.Style.Border.Left.Style = modelTable.Style.Border.Right.Style = modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            //            pkg.Workbook.Properties.Title = "Attempts";

            //            this.Response.BinaryWrite(pkg.GetAsByteArray());
            //            this.Response.End();

            //        }

            //    } // End Probes Export Block

            //}
            #endregion // End Probes
           
            //MessageBox.MessageShow(this.GetType(), "Please Choose Job Name!.", ClientScript);
            


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