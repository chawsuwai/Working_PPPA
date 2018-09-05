using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Drawing;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using PPP_Project.Entity;
using PPP_Project.Criteria;
using System.Transactions;
using PPP_Project.Common.Utility;
using OfficeOpenXml.DataValidation;
using PPP_Project.Common.BranchConfiguration;
using System.Text;
using PPP_Project.Common.Message;
using PPP_Project.Common.Enum;
using System.Reflection;
using System.ComponentModel;
using PPP_Project.Common.Extension;
using PPP_Project.Business;
using System.IO;

namespace PPP_Project
{
    public partial class TicTacImport : System.Web.UI.Page
    {
        private static string globalCenterName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //txtImportDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now); 
                globalCenterName = string.Empty;
                var Probes = new Probes();
                var result = Probes.FindAllBranch();

                for (int i = 0; i < result.Count; i++)
                {
                    ddlCenterName.Items.Insert(i, new ListItem(result[i].BranchName, result[i].BranchCode));
                }

            }
        }

        protected void btnTicTacImport_Click(object sender, EventArgs e)
        {
            //var plist = new List<TicTacEntity>(); // NEED 1 (first)
            List<string> import_successList = new List<string>();

            if (txtImportDate.Text != "" && txtImportDate.Text != null)
            {

                if (FileUpload1.HasFile)
                {
                    if (Path.GetExtension(FileUpload1.FileName) == ".xlsx")
                    {
                        #region "Multi Sheet or Sheet by Sheet Import" (third thinking => )

                        using (ExcelPackage ex_package = new ExcelPackage(FileUpload1.FileContent))
                        {
                            int ws_count = ex_package.Workbook.Worksheets.Count();

                           // if (ws_count == 1) //for (int i = 1; i <= ws_count; i++)    'Edited
                             for (int i = 1; i <= ws_count; i++)
                            {
                                //var probes_list = new List<TicTacEntity>();
                                var sheet_name = ex_package.Workbook.Worksheets[i].Name;
                                var center = ddlCenterName.SelectedValue.ToString();

                                #region "For Tic Tac"

                                if (sheet_name.ToString().Trim() == "TIC TAC usage") //sheet_name == "Probes"
                                {
                                    var tictacs = new TicTac().FindByImportedDateAndCenter(GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim()), center);
                                    if (tictacs.Count() == 0)
                                    {
                                        var tictacs_list = new List<TicTacEntity>();

                                        ExcelWorksheet tictac_workSheet = ex_package.Workbook.Worksheets[i];
                                        //  probes_workSheet.DeleteRow(1);

                                        if (tictac_workSheet.Dimension != null)
                                        {
                                            TicTacs_BindBusiness(tictacs_list, tictac_workSheet, center);

                                            #region Save Tic Tacs

                                            TicTac itemBusiness = new TicTac();

                                            using (TransactionScope Scope = new TransactionScope())
                                            {
                                                try
                                                {
                                                    //probes_list.RemoveAt(0);
                                                    foreach (var v in tictacs_list)
                                                    {
                                                        itemBusiness.Entity = v;
                                                        itemBusiness.Save();

                                                    }                                                 
                                                    Scope.Complete();
                                                    import_successList.Add("Tic Tacs Import Successfully!\n");
                                                    MessageBox.MessageShow(this.GetType(), "Tic Tacs Import Successfully!.", ClientScript);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Response.Redirect("error.aspx");
                                                    throw ex;
                                                }

                                            }

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
                        
                        }
                        #endregion

                    }
                }
            }
            else
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Import Date!.", ClientScript);
            }

         

        }

        private void TicTacs_BindBusiness(List<TicTacEntity> tictacslist, ExcelWorksheet ws, string center)
        {
            var userEntity = (UserEntity)Session["ID"];
            for (var rowNumber = 1; rowNumber <= ws.Dimension.End.Row; rowNumber++)
            #region for Loop Row
            {
                var TicTacEntity = new TicTacEntity();

                TicTacEntity.ID = GeneralUtility.GeneratedKey;

                #region Populate Excel data

                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
                {

                    var columnName = ws.Cells[1, colNumber].Value.ToString().Trim();                  
                    
                    try
                    {
                        if (true && rowNumber > 1)
                        {
                                switch (columnName)
                                {
                                    #region
                                    //case 1:
                                    case "user":
                                        TicTacEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                        break;

                                    case "project_name":
                                        TicTacEntity.Project = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
                                        break;

                                    case "Number of Tic Tacs":
                                        TicTacEntity.Qty = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
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


                if (rowNumber > 1)
                {
                    TicTacEntity.Center = ddlCenterName.SelectedValue.ToString();
                    TicTacEntity.TicTacDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);             
                    TicTacEntity.TicTacYear = TicTacEntity.TicTacDate.Substring(0, 6);
                    //TicTacEntity.ImportTime = GeneralUtility.ConvertSystemTimeFormat(System.DateTime.Now);
                    TicTacEntity.CreatedBy = userEntity.ID;


                    tictacslist.Add(TicTacEntity);
                }


                #endregion
            }
            #endregion
        }

      

    
    }
}