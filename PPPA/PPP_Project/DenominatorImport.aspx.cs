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

namespace PPP_Project
{
    public partial class DenominatorImport : System.Web.UI.Page
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

        protected void btnDenoImport_Click(object sender, EventArgs e)
        {
            var denolist = new List<ProjectDenominatorsEntity>(); // NEED 1 (first)
            if (txtImportDate.Text != "" && txtImportDate.Text != null)
            {
                var projectDeno = new ProjectDenominators().FindByImportedDate(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()));
                if (projectDeno.Count() == 0)
                {
                    if (FileUpload1.HasFile)
                    {
                        if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                        {
                            ExcelPackage package = new ExcelPackage(FileUpload1.FileContent); // NEED 2 (first) 
                            ExcelWorksheet workSheet = package.Workbook.Worksheets.First(); // NEED 2 (first)     
                            workSheet.DeleteRow(1); // NEED 3 (first)          
                            Deno_BindBusiness(denolist, workSheet); // NEED 4 (first)

                        }
                    }

                    #region Save Probes (first)

                    ProjectDenominators itemBusiness = new ProjectDenominators();

                    using (TransactionScope Scope = new TransactionScope())
                    {
                        try
                        {
                            foreach (var v in denolist)
                            {
                                itemBusiness.Entity = v;
                                itemBusiness.Save();
                            }

                            Scope.Complete();
                            MessageBox.MessageShow(this.GetType(), "Project Denominators Import Successfully!.", ClientScript);
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

        private void Deno_BindBusiness(List<ProjectDenominatorsEntity> denolist, ExcelWorksheet ws)
        {
            var userEntity = (UserEntity)Session["ID"];
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            {
                var denoEntity = new ProjectDenominatorsEntity();

                denoEntity.ID = GeneralUtility.GeneratedKey;

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {
                   // var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();
                    try
                    {
                        if (true)
                        {
                            switch (colNumber)
                            {
                                #region
                                case 1:
                                    denoEntity.PROJECT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 2:
                                    denoEntity.Probes = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 3:
                                    denoEntity.Pricingprobes = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 4:
                                    denoEntity.Masks = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 5:
                                    denoEntity.Repricing = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 6:
                                    denoEntity.SceneRecog = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 7:
                                    denoEntity.Expert = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);                                   
                                    break;
                                case 8:
                                    denoEntity.ProbesperScene = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
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


                denoEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
                denoEntity.DenoMonth = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);                 
                //probesEntity.ImportTime = GeneralUtility.ConvertSystemTimeFormat(System.DateTime.Now);
                denoEntity.Createdby = userEntity.ID;


                denolist.Add(denoEntity);

                #endregion
            }
        }
    }
}