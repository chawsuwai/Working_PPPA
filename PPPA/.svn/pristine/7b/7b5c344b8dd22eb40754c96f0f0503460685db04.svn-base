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


namespace PPP_Project
{
    public partial class ProjectNameImport : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                date = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text);
                txtImportDate.Text = date1.Substring(3, 7).ToString();
            }
        }

        protected void btnProjectImport_Click(object sender, EventArgs e)
        {
            var projectnamelist = new List<ProjectNamesEntity>(); // NEED 1 (first)
            if (txtImportDate.Text != "" && txtImportDate.Text != null)
            {
                var projectDeno = new ProjectNames().FindByImportedDateWithSheet(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()),ddlJobName.SelectedValue,ddlStatus.SelectedValue);
                if (projectDeno.Count() == 0)
                {
                    if (FileUpload1.HasFile)
                    {
                        if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                        {
                            ExcelPackage package = new ExcelPackage(FileUpload1.FileContent); // NEED 2 (first) 
                            ExcelWorksheet workSheet = package.Workbook.Worksheets.First(); // NEED 2 (first)     
                           // workSheet.DeleteRow(1); // NEED 3 (first)          
                            ProjectName_BindBusiness(projectnamelist, workSheet); // NEED 4 (first)

                        }
                    }

                    #region Save Project Names (first)

                    ProjectNames itemBusiness = new ProjectNames();

                    using (TransactionScope Scope = new TransactionScope())
                    {
                        try
                        {
                            foreach (var v in projectnamelist)
                            {
                                itemBusiness.Entity = v;
                                itemBusiness.Save();
                            }

                            Scope.Complete();
                            MessageBox.MessageShow(this.GetType(), "Project Names Import Successfully!.", ClientScript);
                        }
                        catch (Exception ex)
                        {
                            Response.Redirect("error.aspx");
                            throw ex;
                        }

                    }

                    #endregion
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

        private void ProjectName_BindBusiness(List<ProjectNamesEntity> projectnamelist, ExcelWorksheet ws)
        {
            for (var rowNumber = 1; rowNumber <= 1; rowNumber++)
            {


                

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {
                    var projectnameEntity = new ProjectNamesEntity();
                    var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();
                   // var columnName2 = string.Empty;

                    try
                    {
                        if (true)
                        {
                            projectnameEntity.ID = GeneralUtility.GeneratedKey;
                            projectnameEntity.PROJECT = columnName1;
                            projectnameEntity.Sheet = ddlJobName.SelectedValue;
                            projectnameEntity.Status = ddlStatus.SelectedValue;
                            projectnameEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
                            projectnameEntity.ImportMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                            projectnameEntity.Createdby = "admin";
                            projectnamelist.Add(projectnameEntity);

                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("error.aspx");
                        throw ex;
                    }


                }



                //if (rowNumber== 1)
                //{
                //    projectnameEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
                //    projectnameEntity.ImportMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                //    projectnameEntity.Createdby = "admin";
                //    projectnamelist.Add(projectnameEntity);
                //}


                #endregion
            }
        }

        //private void ProjectName_BindBusiness(List<ProjectNamesEntity> projectnamelist, ExcelWorksheet ws)
        //{
        //    for (var rowNumber = 1; rowNumber <= 1; rowNumber++)
        //    {
                

                

        //        #region Populate Excel data

        //        for (var colNumber = 5; colNumber <= ws.Dimension.End.Column; colNumber++)
        //        {
        //            var projectnameEntity = new ProjectNamesEntity();
        //            var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();
        //            var columnName2 = string.Empty;
                 
        //            if (colNumber % 2 != 0)
        //            {

        //                projectnameEntity.ID = GeneralUtility.GeneratedKey;
        //                columnName2 = columnName1;
        //            }
        //            try
        //            {
        //                if (true && colNumber % 2 != 0)
        //                {
        //                    projectnameEntity.PROJECT = columnName2;
        //                    projectnameEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
        //                    projectnameEntity.ImportMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
        //                    projectnameEntity.Createdby = "admin";
        //                    projectnamelist.Add(projectnameEntity);
                             
        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                Response.Redirect("error.aspx");
        //                throw ex;
        //            }

                
        //        }



        //        //if (rowNumber== 1)
        //        //{
        //        //    projectnameEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
        //        //    projectnameEntity.ImportMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
        //        //    projectnameEntity.Createdby = "admin";
        //        //    projectnamelist.Add(projectnameEntity);
        //        //}
               

        //        #endregion
        //    }
        //}


     
    }
}