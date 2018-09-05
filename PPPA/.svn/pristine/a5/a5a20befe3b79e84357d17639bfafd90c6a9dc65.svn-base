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
    public partial class QATImport : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                date = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text);
                txtImportDate.Text = date1.Substring(3, 7).ToString();

                var Probes = new Probes();
                var result = Probes.FindAllBranch();

                for (int i = 0; i < result.Count; i++)
                {
                    ddlCenterName.Items.Insert(i, new ListItem(result[i].BranchName, result[i].BranchCode));
                }
            }
        }

        protected void btnQATImport_Click(object sender, EventArgs e)
        {
            var QATlist = new List<QATEntity>(); // NEED 1 (first)
            if (txtImportDate.Text != "" && txtImportDate.Text != null)
            {
                var center = ddlCenterName.SelectedValue.ToString();
                var projectQAT = new QAT().FindByImportedDate(GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text.Trim()), center);
                if (projectQAT.Count() == 0)
                {
                    if (FileUpload1.HasFile)
                    {
                        if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                        {
                            ExcelPackage package = new ExcelPackage(FileUpload1.FileContent); // NEED 2 (first) 
                            ExcelWorksheet workSheet = package.Workbook.Worksheets.First(); // NEED 2 (first)     
                         //   workSheet.DeleteRow(1); // NEED 3 (first)          
                            QAT_BindBusiness(QATlist, workSheet, center);

                        }
                    }

                    #region Save Probes (first)

                    QAT itemBusiness = new QAT();

                    using (TransactionScope Scope = new TransactionScope())
                    {
                        try
                        {
                            foreach (var v in QATlist)
                            {
                                itemBusiness.Entity = v;
                                itemBusiness.Save();
                            }

                            itemBusiness.ReplaceQAT(center);
                            Scope.Complete();
                            MessageBox.MessageShow(this.GetType(), "QAT Import Successfully!", ClientScript);
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

        private void QAT_BindBusiness(List<QATEntity> QATlist, ExcelWorksheet ws, string center)
        {
            var userEntity = (UserEntity)Session["ID"];

            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            {
                var qatEntity = new QATEntity();

                qatEntity.ID = GeneralUtility.GeneratedKey;

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
                                    qatEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 2:
                                    qatEntity.Name = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                                

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


                qatEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());           
                qatEntity.Month = GeneralUtility.ConvertMonthYearStringFormat(txtImportDate.Text);
                qatEntity.Center = ddlCenterName.SelectedValue.ToString();
                qatEntity.Createdby = userEntity.ID;


                QATlist.Add(qatEntity);

                #endregion
            }
        }
    }
}