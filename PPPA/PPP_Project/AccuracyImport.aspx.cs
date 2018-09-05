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
using System.Data.OleDb;
using System.Data.SqlClient;
using PPP_Project.Common.Enum;
using System.Configuration;
using System.Data;

namespace PPP_Project
{
    public partial class AccuracyImport : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
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



        //protected void btnAccImport_Click(object sender, EventArgs e)
        //{
        //    Import_ByBulkCopy();
        //}

        //private void Import_ByBulkCopy()
        //{
        //    string excelConnectionString;

        //    if (txtImportDate.Text != "" && txtImportDate.Text != null)
        //    {
        //        var center = ddlCenterName.SelectedValue.ToString();
                

        //        var accPercent = new AccuracyPercentage().FindByAccPerDate(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), center);
        //        if (accPercent.Count() == 0)
        //        {
        //            if (FileUpload1.HasFile)
        //            {
        //                String physicalPath = HttpContext.Current.Request.PhysicalApplicationPath + FileUpload1.FileName;

                     

        //                string filePath, fileName;
        //                filePath = FileUpload1.PostedFile.FileName; // file name with path.
        //                fileName = FileUpload1.FileName;// Only file name.

        //                string b = HttpContext.Current.Request.MapPath("~/June.xlsx");

        //                string path = System.IO.Path.GetFullPath(FileUpload1.PostedFile.FileName);
        //                string exPath = Server.MapPath(FileUpload1.FileName);

        //                string excelPath = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);

        //                string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
        //                switch (extension)
        //                {
        //                    case ".xls": //Excel 97-03
        //                        excelConnectionString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
        //                        break;
        //                    case ".xlsx": //Excel 07 or higher
        //                        excelConnectionString = ConfigurationManager.ConnectionStrings["Excel07+ConString"].ConnectionString;
        //                        break;

        //                }

        //                string localFileName = hidLocalPath.Value;

        //                if (System.IO.File.Exists(excelPath))
        //                {
        //                    System.IO.File.Delete(excelPath);
        //                }

        //                FileUpload1.SaveAs(excelPath);

                       

        //                if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
        //                {
        //                    //excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=D:\\PPPA_30052018\\June3.xls;" +
        //                    //"Extended Properties=Excel 8.0;";

        //                    //excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:\\PPPA_30052018\\June2.xlsx;" +
        //                    //"Extended Properties=\"Excel 12.0;HDR=NO;\"";
        //                    //excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\PPPA_30052018\\June2.xlsx;" +
        //                    //    "Extended Properties='Excel 12.0 Xml'";

        //                    excelConnectionString = ConfigurationManager.ConnectionStrings["Excel08+ConString"].ConnectionString;


        //                    //1. conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0;Data Source=C:\Users\Input.xlsx;Extended Properties='Excel 15.0 Xml'");
        //                    // 2. conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source="+FilePath+";Extended Properties='Excel 14.0 Xml'");
        //                    // 3. conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Input.xlsx;Extended Properties='Excel 12.0 Xml'");



        //                    excelConnectionString = string.Format(excelConnectionString, excelPath);

        //                    using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
        //                    {

        //                        OleDbCommand command = new OleDbCommand("Select * FROM [Sheet1$]", connection);

        //                        connection.Open();

        //                        // Create DbDataReader to Data Worksheet `
        //                        using (OleDbDataReader dr = command.ExecuteReader())
        //                        {
        //                            // SQL Server Connection String 
        //                            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Client"].ConnectionString;

        //                            // Bulk Copy to SQL Server 
        //                            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlConnectionString))
        //                            {
        //                                bulkCopy.DestinationTableName = "Accuracy_xls";
        //                                bulkCopy.WriteToServer(dr);
        //                            }

        //                        }

                               
                               

        //                        MessageBox.MessageShow(this.GetType(), "Project Accuracy Import Successfully!.", ClientScript);
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.MessageShow(this.GetType(), "Please Choose Import Date!.", ClientScript);
        //    }
        //}

        //private void Import_ByEntity()
        //{
        //    var acclist = new List<AccuracyEntity>(); // NEED 1 (first)
        //    var userEntity = (UserEntity)Session["ID"];
        //    if (txtImportDate.Text != "" && txtImportDate.Text != null)
        //    {
        //        var center = ddlCenterName.SelectedValue.ToString();

        //        var accPercent = new AccuracyPercentage().FindByAccPerDate(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), center);
        //        if (accPercent.Count() == 0)
        //        {
        //            if (FileUpload1.HasFile)
        //            {
        //                if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
        //                {
        //                    ExcelPackage package = new ExcelPackage(FileUpload1.FileContent); // NEED 2 (first) 
        //                    ExcelWorksheet workSheet = package.Workbook.Worksheets.First(); // NEED 2 (first)     
        //                    workSheet.DeleteRow(1); // NEED 3 (first)          
        //                    Acc_BindBusiness(acclist, workSheet); // NEED 4 (first)

        //                }
        //            }

        //            #region Save Accuracy (first)

        //            AccuracyPercentage itemBusiness = new AccuracyPercentage();

        //            using (TransactionScope Scope = new TransactionScope())
        //            {
        //                try
        //                {
        //                    foreach (var v in acclist)
        //                    {
        //                        itemBusiness.Entity = v;
        //                        itemBusiness.Save();
        //                    }
        //                    itemBusiness.ReplaceQATAccuracy(center);
        //                    Scope.Complete();

        //                    MessageBox.MessageShow(this.GetType(), "Project Accuracy Import Successfully!.", ClientScript);
        //                }
        //                catch (Exception ex)
        //                {
        //                    Response.Redirect("error.aspx");
        //                    throw ex;
        //                }

        //            }

        //            #endregion
        //        }
        //        else
        //        {
        //            MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.MessageShow(this.GetType(), "Please Choose Import Date!.", ClientScript);
        //    }
        //}



        public int BulkInsertIntoAccuracy(List<AccuracyEntity> accuracys)
        {
            using (var scope = new TransactionScope())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Client"].ConnectionString;
                var sqlConnection = new SqlConnection(connectionString);
                var sqlBulkCopy = new SqlBulkCopy(sqlConnection)
                {
                    DestinationTableName = "Accuracy",
                    //BulkCopyTimeout = 6000
                };
                var dataTable = GetDataTableForAccuracy(accuracys);
                sqlConnection.Open();

                sqlBulkCopy.WriteToServer(dataTable);

                scope.Complete();
                sqlBulkCopy.Close();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            return accuracys.Count;
        }


        private DataTable GetDataTableForAccuracy(List<AccuracyEntity> accuracys)
        {
            var table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("QAT", typeof(string));
            table.Columns.Add("Center", typeof(string));
            table.Columns.Add("AccuracyPercent", typeof(decimal));
            table.Columns.Add("CreatedDate", typeof(string));
            table.Columns.Add("Createdby", typeof(string));
            table.Columns.Add("AccMonth", typeof(string));

            // note : the order of the field is very important
            // and should be same as the defined in table structure.
            accuracys.ForEach(data => table.Rows.Add(
                                                data.ID
                                                , data.QAT
                                                , data.Center
                                                , data.AccuracyPercent
                                                , data.CreatedDate
                                                , data.Createdby
                                                , data.AccMonth
                                                ));
            return table;
        }


        //public static void UpdateData<T>(List<AccuracyEntity> list, string TableName)
        //{
        //    DataTable dt = new DataTable("MyTable");
        //    dt = ConvertToDataTable(list);

        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SchoolSoulDataEntitiesForReport"].ConnectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand("", conn))
        //        {
        //            try
        //            {
        //                conn.Open();

        //                //Creating temp table on database
        //                command.CommandText = "CREATE TABLE #TmpTable(...)";
        //                command.ExecuteNonQuery();

        //                //Bulk insert into temp table
        //                using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
        //                {
        //                    bulkcopy.BulkCopyTimeout = 660;
        //                    bulkcopy.DestinationTableName = "#TmpTable";
        //                    bulkcopy.WriteToServer(dt);
        //                    bulkcopy.Close();
        //                }

        //                // Updating destination table, and dropping temp table
        //                command.CommandTimeout = 300;
        //                command.CommandText = "UPDATE T SET ... FROM " + TableName + " T INNER JOIN #TmpTable Temp ON ...; DROP TABLE #TmpTable;";
        //                command.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle exception properly
        //            }
        //            finally
        //            {
        //                conn.Close();
        //            }
        //        }
        //    }
        //}




        protected void btnAccImport_Click(object sender, EventArgs e)
        {
            var acclist = new List<AccuracyEntity>(); // NEED 1 (first)
            var userEntity = (UserEntity)Session["ID"];
            if (txtImportDate.Text != "" && txtImportDate.Text != null)
            {
                var center = ddlCenterName.SelectedValue.ToString();

                var accPercent = new AccuracyPercentage().FindByAccPerDate(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), center);
                if (accPercent.Count() == 0)
                {
                    if (FileUpload1.HasFile)
                    {
                        if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                        {
                            ExcelPackage package = new ExcelPackage(FileUpload1.FileContent); // NEED 2 (first) 
                            ExcelWorksheet workSheet = package.Workbook.Worksheets.First(); // NEED 2 (first)     
                            //workSheet.DeleteRow(1); // NEED 3 (first)          
                            Acc_BindBusiness(acclist, workSheet); // NEED 4 (first)

                        }
                    }

                    int i = BulkInsertIntoAccuracy(acclist);

                    MessageBox.MessageShow(this.GetType(), "Project Accuracy Import Successfully!.", ClientScript);

                    //#region Save Accuracy (first)

                    //AccuracyPercentage itemBusiness = new AccuracyPercentage();

                    //using (TransactionScope Scope = new TransactionScope(
                    //            ))
                    //{
                    //    try
                    //    {
                    //        foreach (var v in acclist)
                    //        {
                    //            itemBusiness.Entity = v;
                    //            itemBusiness.Save();
                    //        }
                    //        itemBusiness.ReplaceQATAccuracy(center);
                    //        Scope.Complete();

                    //        MessageBox.MessageShow(this.GetType(), "Project Accuracy Import Successfully!.", ClientScript);
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        //Response.Redirect("error.aspx");
                    //        throw ex;
                    //    }

                    //}

                    //#endregion
                }
                else
                {
                    MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
                }
            }
            else
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Import Date!.", ClientScript);
            }
        }

        private void Acc_BindBusiness(List<AccuracyEntity> denolist, ExcelWorksheet ws)
        {
             var userEntity = (UserEntity)Session["ID"];
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            {
                var accEntity = new AccuracyEntity();

                accEntity.ID = GeneralUtility.GeneratedKey;

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {

                    try
                    {
                        if (true)
                        {
                            switch (colNumber)
                            {
                                #region
                                case 1:
                                    accEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 2:
                                   // accEntity.AccuracyPercent
                                    //#REF!

                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() != "" && Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() != "-" && Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() != null && Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() != "#DIV/0!" && Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() != "#REF!")
                                    {                                        
                                      
                                        var orgPercent = ws.Cells[rowNumber, colNumber].Value.ToString().Trim(new[] { '%' });
                                        if (orgPercent == "100")
                                        {
                                            accEntity.AccuracyPercent = Convert.ToDecimal(orgPercent);
                                        }
                                        else
                                        {
                                            accEntity.AccuracyPercent = Convert.ToDecimal(orgPercent)*100;
                                        }
                                    }
                                    //if (orgPercent.Length != 0 && orgPercent!="0")
                                    //{
                                    //    var percent= orgPercent.Substring(0, orgPercent.Length-1);
                                    //    accEntity.AccuracyPercent = Convert.ToDecimal(percent);
                                    //}
                                    //accEntity.AccuracyPercent = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                              
                                //case 9:
                                //    denoEntity.AMERICAS_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                //    break;                               

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


                accEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
                accEntity.AccMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                accEntity.Center =ddlCenterName.SelectedValue.ToString();
                //probesEntity.ImportTime = GeneralUtility.ConvertSystemTimeFormat(System.DateTime.Now);
                accEntity.Createdby = userEntity.ID;


                denolist.Add(accEntity);

                #endregion
            }
        }
   
    }
}