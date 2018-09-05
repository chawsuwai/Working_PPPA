using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPP_Project.Base;
using PPP_Project.Common;
using PPP_Project.CommonAttributes;
using PPP_Project.Common.Utility;
using PPP_Project.Common.Message;
using PPP_Project.Entity;
using PPP_Project.Criteria;
using System.IO;
using System.Transactions;
using OfficeOpenXml;
using PPP_Project.Business;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using PPP_Project.Common.Enum;
using System.Configuration;
using System.Data;

namespace PPP_Project
{
    public partial class CancelImport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string date;
            if (!IsPostBack)
            {
                var Probes = new Probes();
                var result = Probes.FindAllBranch();

                for (int i = 0; i < result.Count; i++)
                {
                    ddlCenterName.Items.Insert(i, new ListItem(result[i].BranchName, result[i].BranchCode));
                }
                var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                date = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text);
                txtImportDate.Text = date1.Substring(3, 7).ToString();
            }
        }

        protected void btnCancelImport_Click(object sender, EventArgs e)
        {           
            List<string> import_successList = new List<string>();

            if (ddlJobName.SelectedIndex!= 0)
            {

                if (FileUpload1.HasFile)
                {
                    if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                    {
                        #region "Multi Sheet or Sheet by Sheet Import" (third thinking => )

                        using (ExcelPackage ex_package = new ExcelPackage(FileUpload1.FileContent))
                        {
                            int ws_count = ex_package.Workbook.Worksheets.Count();

                            if (ws_count == 1)
                            {                                                     
                                var jobName = ddlJobName.SelectedValue.ToString();
                                var center = ddlCenterName.SelectedValue.ToString();

                                #region "For Probes"

                                if (jobName.ToString().Trim() == "Probes") //job_name == "Probes"
                                {
                                    var cancel = new Cancel().FindByCancelMonthAndJob(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), jobName,center);
                                    if (cancel.Count() == 0)
                                    {
                                        var cancel_list = new List<CancelEntity>();

                                        ExcelWorksheet cancel_workSheet = ex_package.Workbook.Worksheets[1];
                                        //  probes_workSheet.DeleteRow(1);

                                        if (cancel_workSheet.Dimension != null)
                                        {
                                            Cancel_Probes_BindBusiness(cancel_list, cancel_workSheet);

                                            #region Save Cancel Probes

                                            Cancel itemBusiness = new Cancel();

                                            int i = BulkInsertIntoCancel(cancel_list);
                                            MessageBox.MessageShow(this.GetType(), "Cancel Probes Import Successfully!.", ClientScript);

                                            //using (TransactionScope Scope = new TransactionScope())
                                            //{
                                            //    try
                                            //    {
                                            //        //probes_list.RemoveAt(0);
                                            //        foreach (var v in cancel_list)
                                            //        {
                                            //            itemBusiness.Entity = v;
                                            //            itemBusiness.Save();

                                            //        }                                                   
                                            //        Scope.Complete();
                                            //        import_successList.Add("Cancel Probes Import Successfully!\n");
                                            //        MessageBox.MessageShow(this.GetType(), "Cancel Probes Import Successfully!.", ClientScript);
                                            //    }
                                            //    catch (Exception ex)
                                            //    {
                                            //        Response.Redirect("error.aspx");
                                            //        throw ex;
                                            //    }

                                            //}

                                            #endregion
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
                                    }
                                }
                                #endregion

                                #region "For Scenes"

                                if (jobName.ToString().Trim() == "Scenes") //job_name == "Probes"
                                {
                                    var cancel = new Cancel().FindByCancelMonthAndJob(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), jobName,center);
                                    if (cancel.Count() == 0)
                                    {
                                        var cancel_list = new List<CancelEntity>();

                                        ExcelWorksheet cancel_workSheet = ex_package.Workbook.Worksheets[1];
                                        //  probes_workSheet.DeleteRow(1);

                                        if (cancel_workSheet.Dimension != null)
                                        {
                                            Cancel_Scenes_BindBusiness(cancel_list, cancel_workSheet);

                                            #region Save Cancel Probes

                                            Cancel itemBusiness = new Cancel();

                                            int i = BulkInsertIntoCancel(cancel_list);

                                            MessageBox.MessageShow(this.GetType(), "Cancel Scenes Import Successfully!.", ClientScript);

                                            //using (TransactionScope Scope = new TransactionScope())
                                            //{
                                            //    try
                                            //    {
                                            //        //probes_list.RemoveAt(0);
                                            //        foreach (var v in cancel_list)
                                            //        {
                                            //            itemBusiness.Entity = v;
                                            //            itemBusiness.Save();

                                            //        }
                                            //        Scope.Complete();
                                            //        import_successList.Add("Cancel Scenes Import Successfully!\n");
                                            //        MessageBox.MessageShow(this.GetType(), "Cancel Scenes Import Successfully!.", ClientScript);
                                            //    }
                                            //    catch (Exception ex)
                                            //    {
                                            //        Response.Redirect("error.aspx");
                                            //        throw ex;
                                            //    }

                                            //}

                                            #endregion
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
                                    }
                                }
                                #endregion


                                #region "For Stitching"

                                if (jobName.ToString().Trim() == "Stitching") //job_name == "Stitching"
                                {
                                    var cancel = new Cancel().FindByCancelMonthAndJob(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), jobName, center);
                                    if (cancel.Count() == 0)
                                    {
                                        var cancel_list = new List<CancelEntity>();

                                        ExcelWorksheet cancel_workSheet = ex_package.Workbook.Worksheets[1];
                                        //  probes_workSheet.DeleteRow(1);

                                        if (cancel_workSheet.Dimension != null)
                                        {
                                            Cancel_Stitching_BindBusiness(cancel_list, cancel_workSheet);

                                            #region Save Cancel Probes

                                            Cancel itemBusiness = new Cancel();

                                            int i = BulkInsertIntoCancel(cancel_list);
                                            MessageBox.MessageShow(this.GetType(), "Cancel Probes Import Successfully!.", ClientScript);

                                            //using (TransactionScope Scope = new TransactionScope())
                                            //{
                                            //    try
                                            //    {
                                            //        //probes_list.RemoveAt(0);
                                            //        foreach (var v in cancel_list)
                                            //        {
                                            //            itemBusiness.Entity = v;
                                            //            itemBusiness.Save();

                                            //        }                                                   
                                            //        Scope.Complete();
                                            //        import_successList.Add("Cancel Probes Import Successfully!\n");
                                            //        MessageBox.MessageShow(this.GetType(), "Cancel Probes Import Successfully!.", ClientScript);
                                            //    }
                                            //    catch (Exception ex)
                                            //    {
                                            //        Response.Redirect("error.aspx");
                                            //        throw ex;
                                            //    }

                                            //}

                                            #endregion
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
                                    }
                                }
                                #endregion

                              
                            }
                            else
                            {
                                MessageBox.MessageShow(this.GetType(), "Not Provided Multiple Sheet Import!", ClientScript);
                            }
                         
                        }
                        #endregion

                    }
                }
            }
            else
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Job Name!.", ClientScript);
            }

            

        }

        private void Cancel_Probes_BindBusiness(List<CancelEntity> cancellist, ExcelWorksheet ws)
        {
            var userEntity = (UserEntity)Session["ID"];
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            #region for Loop Row
            {
                var cancelEntity = new CancelEntity();

                cancelEntity.ID = GeneralUtility.GeneratedKey;

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {
                    var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();               
                  
                    try
                    {
                        if (true && rowNumber > 1)
                        {
                            switch (columnName1)
                                {
                                    #region
                                    //case 1:
                                    case "Date": //QAT
                                        cancelEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                        break;
                                    //case 2:
                                    case "TOTAL":
                                        cancelEntity.Probes = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                        break;                                
                                  
                                    #endregion

                                    default: break;

                                    #endregion
                                }                           

                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("error.aspx");
                        throw ex;
                    }
                }


                if (rowNumber > 1)
                {
                    cancelEntity.Center = ddlCenterName.SelectedValue.ToString();
                    cancelEntity.CancelMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                    cancelEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);
                    cancelEntity.Createdby = userEntity.ID;
                    cancellist.Add(cancelEntity);
                }


                #endregion
            }
            
        }

        private void Cancel_Scenes_BindBusiness(List<CancelEntity> cancellist, ExcelWorksheet ws)
        {
            var userEntity = (UserEntity)Session["ID"];
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            #region for Loop Row
            {
                var cancelEntity = new CancelEntity();

                cancelEntity.ID = GeneralUtility.GeneratedKey;

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {
                    var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();

                    try
                    {
                        if (true && rowNumber > 1)
                        {
                            switch (columnName1)
                            {
                                #region
                                //case 1:
                                case "Date": //QAT
                                    cancelEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                //case 2:
                                case "TOTAL":
                                    cancelEntity.Scenes = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                    break;

                                #endregion

                                default: break;

                #endregion
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("error.aspx");
                        throw ex;
                    }
                }


                if (rowNumber > 1)
                {
                    cancelEntity.Center = ddlCenterName.SelectedValue.ToString();
                    cancelEntity.CancelMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                    cancelEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);
                    cancelEntity.Createdby = userEntity.ID;
                    cancellist.Add(cancelEntity);
                }


            #endregion
            }

        }



        private void Cancel_Stitching_BindBusiness(List<CancelEntity> cancellist, ExcelWorksheet ws)
        {
            var userEntity = (UserEntity)Session["ID"];
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            #region for Loop Row
            {
                var cancelEntity = new CancelEntity();

                cancelEntity.ID = GeneralUtility.GeneratedKey;

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {
                    var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();

                    try
                    {
                        if (true && rowNumber > 1)
                        {
                            switch (columnName1)
                            {
                                #region
                                //case 1:
                                case "user id": //QAT
                                    cancelEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                //case 2:
                                case "Total Deduct Count":
                                    cancelEntity.Stitching = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                    break;

                                #endregion

                                default: break;

                #endregion
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("error.aspx");
                        throw ex;
                    }
                }


                if (rowNumber > 1)
                {
                    cancelEntity.Center = ddlCenterName.SelectedValue.ToString();
                    cancelEntity.CancelMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                    cancelEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);
                    cancelEntity.Createdby = userEntity.ID;
                    cancellist.Add(cancelEntity);
                }


            #endregion
            }

        }




        public int BulkInsertIntoCancel(List<CancelEntity> cancel)
        {
            using (var scope = new TransactionScope())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Client"].ConnectionString;
                var sqlConnection = new SqlConnection(connectionString);
                var sqlBulkCopy = new SqlBulkCopy(sqlConnection)
                {
                    DestinationTableName = "Cancel",
                    //BulkCopyTimeout = 6000
                };
                var dataTable = GetDataTableForCancel(cancel);
                sqlConnection.Open();

                sqlBulkCopy.WriteToServer(dataTable);

                scope.Complete();
                sqlBulkCopy.Close();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            return cancel.Count;
        }


        private DataTable GetDataTableForCancel(List<CancelEntity> cancel)
        {
            var table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("QAT", typeof(string));
            table.Columns.Add("Probes", typeof(decimal));
            table.Columns.Add("Scenes", typeof(decimal));
            table.Columns.Add("Stitching", typeof(decimal));
            table.Columns.Add("Center", typeof(string));
            table.Columns.Add("CreatedDate", typeof(string));
            table.Columns.Add("CreatedBy", typeof(string));
            table.Columns.Add("CancelMonth", typeof(string));

            // note : the order of the field is very important
            // and should be same as the defined in table structure.
            cancel.ForEach(data => table.Rows.Add(
                                                data.ID
                                            , data.QAT
                                            , data.Probes
                                            , data.Scenes
                                            ,data.Stitching
                                            , data.Center
                                            , data.CreatedDate
                                            , data.Createdby
                                            , data.CancelMonth
                                                ));
            return table;
        }
    }
}