using System;
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
using System.Globalization;

namespace PPP_Project
{
    public partial class DenominatorImportForAllProjectDaily : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                //date = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text);
                //txtImportDate.Text = date1.Substring(3, 7).ToString();
            }
        }

        protected void btnDenoImport_Click(object sender, EventArgs e)
        {
            DateTime vSetDate, vFromDate, vToDate;

            var denochangelist = new List<DenoChangeEntity>(); // NEED 1 (first)
            if (txtImportDate.Text != "" && txtImportDate.Text != null )
            {
                if (txtImportDate.Text != "" && txtImportDateTo.Text == "")
                {
                    txtImportDateTo.Text = txtImportDate.Text;
                }
                

                string count = "";
                vFromDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtImportDate.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    //Convert.ToDateTime(txtImportDate.Text.Trim());
                vToDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtImportDateTo.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //Convert.ToDateTime(txtImportDateTo.Text.Trim());



                if (vToDate < vFromDate)
                {
                    MessageBox.MessageShow(this.GetType(), "Invalid To Date.", ClientScript);
                    return;
                }

                vSetDate = vFromDate;

                DenoChange change = new DenoChange();
                count = change.getCountForProjectByDate(GeneralUtility.ConvertSystemDateStringFormat(vSetDate));
                  
                        //if (count == "0")
                        //{
                            if (FileUpload1.HasFile)
                            {
                                if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                                {
                                    ExcelPackage package = new ExcelPackage(FileUpload1.FileContent); // NEED 2 (first) 
                                    ExcelWorksheet workSheet = package.Workbook.Worksheets.First(); // NEED 2 (first)     
                                    workSheet.DeleteRow(1); // NEED 3 (first)          
                                    DenoChange_BindBusiness(denochangelist, workSheet); // NEED 4 (first)

                                }
                            }

                            #region Save Probes (first)

                            DenoChange itemBusiness = new DenoChange();

                            using (TransactionScope Scope = new TransactionScope())
                            {
                                try
                                {
                                    while (vSetDate <= vToDate)
                                    {
                                        foreach (var v in denochangelist)
                                        {
                                            itemBusiness.Entity = v;
                                            v.DCDate = GeneralUtility.ConvertSystemDateStringFormat(vSetDate);
                                            var ID = GeneralUtility.GeneratedKey;
                                            v.ID = ID;

                                            var entity = itemBusiness.FindByProjectAndChangeDate(v);

                                            if (entity == null)
                                            {
                                                itemBusiness.Save();
                                            }

                                            else
                                            {
                                                v.ID = entity.ID;
                                                itemBusiness.Entity = v;
                                                itemBusiness.Update();
                                            }


                                        }
                                        vSetDate = vSetDate.AddDays(1);
                                    }
                                    itemBusiness.DeleteNullValue();
                                    Scope.Complete();
                                    MessageBox.MessageShow(this.GetType(), "Project Denominators Times For All Projects Daily Import Successfully!.", ClientScript);
                                }
                                catch (Exception ex)
                                {
                                    Response.Redirect("error.aspx");
                                    throw ex;
                                }

                            }

                            #endregion
                        //}

                       
                //else
                //{
                //    MessageBox.MessageShow(this.GetType(), "This Excel File has already been Imported!", ClientScript);
                //}
            }
            else
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Import Date!.", ClientScript);
            }
        }

        private void DenoChange_BindBusiness(List<DenoChangeEntity> denochangelist, ExcelWorksheet ws)
        {
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            {
                var denochangeEntity = new DenoChangeEntity();

               // denochangeEntity.ID = GeneralUtility.GeneratedKey;               

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
                                    denochangeEntity.PROJECT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 2:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.Probes = null;
                                        denochangeEntity.Votes = null;
                                    }

                                    else
                                    {
                                        denochangeEntity.Probes = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                        denochangeEntity.Votes = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                    }
                                    //denochangeEntity.Probes = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                   // denochangeEntity.Votes = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                 //  Convert.ToDecimal(
                                    break;
                                case 3:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.Pricingprobes = null;                                     
                                    }

                                    else
                                    {
                                        denochangeEntity.Pricingprobes = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                       
                                    }
                                   // denochangeEntity.Pricingprobes = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 4:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.Masks = null;
                                    }

                                    else
                                    {
                                        denochangeEntity.Masks = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);

                                    }
                                   // denochangeEntity.Masks = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 5:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.Repricing = null;
                                    }

                                    else
                                    {
                                        denochangeEntity.Repricing = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);

                                    }
                                    //denochangeEntity.Repricing = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 6:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.SceneRecog = null;
                                    }

                                    else
                                    {
                                        denochangeEntity.SceneRecog = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);

                                    }
                                   // denochangeEntity.SceneRecog = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 7:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.Expert = null;
                                        denochangeEntity.ExpertVoting = null;
                                    }

                                    else
                                    {
                                        denochangeEntity.Expert = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                        denochangeEntity.ExpertVoting = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                    }
                                    //denochangeEntity.Expert = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                    //denochangeEntity.ExpertVoting = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
                                    break;
                                case 8:
                                    if (Convert.ToString(ws.Cells[rowNumber, colNumber].Value) == "0" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null)
                                    {
                                        denochangeEntity.ProbesperScene = null;
                                    }

                                    else
                                    {
                                        denochangeEntity.ProbesperScene = Convert.ToDecimal(ws.Cells[rowNumber, colNumber].Value);
                                    }
                                  //  denochangeEntity.ProbesperScene = Convert.ToDecimal(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "-" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? null : ws.Cells[rowNumber, colNumber].Value);
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


                denochangeEntity.CreatedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);              
                //denochangeEntity.DCDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());
                //probesEntity.ImportTime = GeneralUtility.ConvertSystemTimeFormat(System.DateTime.Now);
                denochangeEntity.Createdby = "admin";


                denochangelist.Add(denochangeEntity);

                #endregion


            }
        }
    }
}