//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace PPP_Project.Entity
//{
//    public class Class1
//    {


//           #region Populate Excel data

//                for (var colNumber = 1; colNumber <= ws.Dimension.End.Column; colNumber++)
//                {
//                    var columnName1 = ws.Cells[1, colNumber].Value.ToString().Trim();
//                    var columnName2 = string.Empty;
//                    string columnName3 = string.Empty;
//                    if (columnName1 == "Probes")
//                    {
//                        columnName2 = ws.Cells[1, colNumber - 1].Value.ToString();
//                        columnName3 = columnName2 + "-" + columnName1;
//                    }
//                    else
//                    {
//                        columnName3 = columnName1;
//                    }
//                    try
//                    {
//                        if (true && rowNumber > 1)
//                        {

//                            //switch (colNumber)
//                            switch (columnName3)
//                            {
//                                #region
//                                //case 1:
//                                case "QAT":
//                                    probesEntity.QAT = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 2:
//                                case "Center":
//                                    probesEntity.Center = Convert.ToString(ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 3:
//                                case "Total Probes":
//                                    probesEntity.TotalProbes = Convert.ToInt32(ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                case "Avg seconds per Probes":
//                                    //case 4:
//                                    probesEntity.AvgsecondsperProbes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 5:
//                                case "ABICA":
//                                    probesEntity.ABICA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 6:

//                                case "ABICA-Probes":
//                                    probesEntity.ABICA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 7:
//                                case "ABITAMSUS-PROD":
//                                    probesEntity.ABITAMSUS_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 8:
//                                case "ABITAMSUS-PROD-Probes":
//                                    probesEntity.ABITAMSUS_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 9:
//                                case "AMERICAS-DEMO":
//                                    probesEntity.AMERICAS_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 10:
//                                case "AMERICAS-DEMO-Probes":
//                                    probesEntity.AMERICAS_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 11:
//                                case "BATRU":
//                                    probesEntity.BATRU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 12:
//                                case "BATRU-Probes":
//                                    probesEntity.BATRU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 13:
//                                case "BIKR":
//                                    probesEntity.BIKR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 14:
//                                case "BIKR-Probes":
//                                    probesEntity.BIKR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 15:
//                                case "BIMY":
//                                    probesEntity.BIMY = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 16:
//                                case "BIMY-Probes":
//                                    probesEntity.BIMY_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 17:
//                                case "BIPH":
//                                    probesEntity.BIPH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 18:
//                                case "BIPH-Probes":
//                                    probesEntity.BIPH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 19:
//                                case "BISEASK":
//                                    probesEntity.BISEASK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 20:
//                                case "BISEASK-Probes":
//                                    probesEntity.BISEASK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 21:
//                                case "BITH":
//                                    probesEntity.BITH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 22:
//                                case "BITH-Probes":
//                                    probesEntity.BITH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 23:
//                                case "BIVN":
//                                    probesEntity.BIVN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 24:
//                                case "BIVN-Probes":
//                                    probesEntity.BIVN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 25:
//                                case "BPAU":
//                                    probesEntity.BPAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 26:
//                                case "BPAU-Probes":
//                                    probesEntity.BPAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 27:
//                                case "BRODMANN":
//                                    probesEntity.BRODMANN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 28:
//                                case "BRODMANN-Probes":
//                                    probesEntity.BRODMANN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 29:
//                                case "CARREFOURAR":
//                                    probesEntity.CARREFOURAR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 30:
//                                case "CARREFOURAR-Probes":
//                                    probesEntity.CARREFOURAR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                //case 31:
//                                case "CCAAU":
//                                    probesEntity.CCAAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 32:
//                                case "CCAAU-Probes":
//                                    probesEntity.CCAAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 33:
//                                case "CCABIZA":
//                                    probesEntity.CCABIZA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 34:
//                                case "CCABIZA-Probes":
//                                    probesEntity.CCABIZA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 35:
//                                case "CCANZ":
//                                    probesEntity.CCANZ = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 36:
//                                case "CCANZ-Probes":
//                                    probesEntity.CCANZ_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 37:
//                                case "CCBOTTLERSUS":
//                                    probesEntity.CCBOTTLERSUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 38:
//                                case "CCBOTTLERSUS-Probes":
//                                    probesEntity.CCBOTTLERSUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 39:
//                                case "CCBR-PROD":
//                                    probesEntity.CCBR_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 40:
//                                case "CCBR-PROD-Probes":
//                                    probesEntity.CCBR_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 41:
//                                case "CCJP":
//                                    probesEntity.CCJP = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 42:
//                                case "CCJP-Probes":
//                                    probesEntity.CCJP_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 43:
//                                case "CCKH":
//                                    probesEntity.CCKH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 44:
//                                case "CCKH-Probes":
//                                    probesEntity.CCKH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 45:
//                                case "CCKR":
//                                    probesEntity.CCKR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 46:
//                                case "CCKR-Probes":
//                                    probesEntity.CCKR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 47:
//                                case "CCMY":
//                                    probesEntity.CCMY = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 48:
//                                case "CCMY-Probes":
//                                    probesEntity.CCMY_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 49:
//                                case "CCPH":
//                                    probesEntity.CCPH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 50:
//                                case "CCPH-Probes":
//                                    probesEntity.CCPH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 51:
//                                case "CCRPR-PROD":
//                                    probesEntity.CCRPR_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 52:
//                                case "CCRPR-PROD-Probes":
//                                    probesEntity.CCRPR_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 53:
//                                case "CCRU":
//                                    probesEntity.CCRU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 54:
//                                case "CCRU-Probes":
//                                    probesEntity.CCRU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 55:
//                                case "CCTH":
//                                    probesEntity.CCTH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 56:
//                                case "CCTH-Probes":
//                                    probesEntity.CCTH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 57:
//                                case "CCTH-UAT":
//                                    probesEntity.CCTH_UAT = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 58:
//                                case "CCTH-UAT-Probes":
//                                    probesEntity.CCTH_UAT_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 59:
//                                case "CCTRADMX":
//                                    probesEntity.CCTRADMX = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 60:
//                                case "CCTRADMX-Probes":
//                                    probesEntity.CCTRADMX_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 61:
//                                case "CCUS":
//                                    probesEntity.CCUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 62:
//                                case "CCUS-Probes":
//                                    probesEntity.CCUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 63:
//                                case "CCZA":
//                                    probesEntity.CCZA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 64:
//                                case "CCZA-Probes":
//                                    probesEntity.CCZA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 65:
//                                case "CEREBOSTH":
//                                    probesEntity.CEREBOSTH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 66:
//                                case "CEREBOSTH-Probes":
//                                    probesEntity.CEREBOSTH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 67:
//                                case "CROWDSOURCE":
//                                    probesEntity.CROWDSOURCE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 68:
//                                case "CROWDSOURCE-Probes":
//                                    probesEntity.CROWDSOURCE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 69:
//                                case "DIAGEOAU":
//                                    probesEntity.DIAGEOAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 70:
//                                case "DIAGEOAU-Probes":
//                                    probesEntity.DIAGEOAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 71:
//                                case "DIAGEOBR":
//                                    probesEntity.DIAGEOBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 72:
//                                case "DIAGEOBR-Probes":
//                                    probesEntity.DIAGEOBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 73:
//                                case "DIAGEOGR":
//                                    probesEntity.DIAGEOGR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 74:
//                                case "DIAGEOGR-Probes":
//                                    probesEntity.DIAGEOGR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 75:
//                                case "DIAGEOIE":
//                                    probesEntity.DIAGEOIE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 76:
//                                case "DIAGEOIE-Probes":
//                                    probesEntity.DIAGEOIE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 77:
//                                case "DIAGEOKE":
//                                    probesEntity.DIAGEOKE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 78:
//                                case "DIAGEOKE-Probes":
//                                    probesEntity.DIAGEOKE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                //case 79:
//                                case "DIAGEOMX":
//                                    probesEntity.DIAGEOMX = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                 //case 80:
//                                    case "DIAGEOMX-Probes":
//                                    probesEntity.DIAGEOMX_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 81:
//                                case "DIAGEOPT":
//                                    probesEntity.DIAGEOPT = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 82:
//                                case "DIAGEOPT-Probes":
//                                    probesEntity.DIAGEOPT_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 83:
//                                case "DIAGEOTW":
//                                    probesEntity.DIAGEOTW = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 84:
//                                case "DIAGEOTW-Probes":
//                                    probesEntity.DIAGEOTW_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 85:
//                                case "DIAGEOUK":
//                                    probesEntity.DIAGEOUK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 86:
//                                case "DIAGEOUK-Probes":
//                                    probesEntity.DIAGEOUK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 87:
//                                case "DIAGEOZA":
//                                    probesEntity.DIAGEOZA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 88:
//                                case "DIAGEOZA-Probes":
//                                    probesEntity.DIAGEOZA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 89:
//                                case "EMEA-DEMO":
//                                    probesEntity.EMEA_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 90:
//                                case "EMEA-DEMO-Probes":
//                                    probesEntity.EMEA_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 91:
//                                case "FERREROIT":
//                                    probesEntity.FERREROIT = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 92:
//                                case "FERREROIT-Probes":
//                                    probesEntity.FERREROIT_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 93:
//                                case "GILLETTEUS":
//                                    probesEntity.GILLETTEUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 94:
//                                case "GILLETTEUS-Probes":
//                                    probesEntity.GILLETTEUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 95:
//                                case "GOOGLEUS":
//                                    probesEntity.GOOGLEUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 96:
//                                case "GOOGLEUS-Probes":
//                                    probesEntity.GOOGLEUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 97:
//                                case "HBCDE":
//                                    probesEntity.HBCDE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 98:
//                                case "HBCDE-Probes":
//                                    probesEntity.HBCDE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 99:
//                                case "HEINEKENCN":
//                                    probesEntity.HEINEKENCN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 100:
//                                case "HEINEKENCN-Probes":
//                                    probesEntity.HEINEKENCN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                //case 101:
//                                case "HEINEKENUS-PROD":
//                                    probesEntity.HEINEKENUS_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 102:
//                                case "HEINEKENUS-PROD-Probes":
//                                    probesEntity.HEINEKENUS_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 103:
//                                case "HEINZCR":
//                                    probesEntity.HEINZCR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 104:
//                                case "HEINZCR-Probes":
//                                    probesEntity.HEINZCR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 105:
//                                case "INBEVAR":
//                                    probesEntity.INBEVAR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 106:
//                                case "INBEVAR-Probes":
//                                    probesEntity.INBEVAR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 107:
//                                case "INBEVBE":
//                                    probesEntity.INBEVBE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 108:
//                                case "INBEVBE-Probes":
//                                    probesEntity.INBEVBE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 109:
//                                //case "INBEVBE-SAND":
//                                //    probesEntity.INBEVBE_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                ////case 110:
//                                //case "INBEVBE-SAND-Probes":
//                                //    probesEntity.INBEVBE_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 111:
//                                case "INBEVBR":
//                                    probesEntity.INBEVBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 112:
//                                case "INBEVBR-Probes":
//                                    probesEntity.INBEVBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 113:
//                                case "INBEVBR_ONTRADE":
//                                    probesEntity.INBEVBR_ONTRADE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 114:
//                                case "INBEVBR_ONTRADE-Probes":
//                                    probesEntity.INBEVBR_ONTRADE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 115:
//                                case "INBEVCL":
//                                    probesEntity.INBEVCL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 116:
//                                case "INBEVCL-Probes":
//                                    probesEntity.INBEVCL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 117:
//                                case "INBEVCN":
//                                    probesEntity.INBEVCN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 118:
//                                case "INBEVCN-Probes":
//                                    probesEntity.INBEVCN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                //case 119:
//                                case "INBEVCOOLERAR":
//                                    probesEntity.INBEVCOOLERAR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 120:
//                                case "INBEVCOOLERAR-Probes":
//                                    probesEntity.INBEVCOOLERAR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 121:
//                                case "INBEVCOOLERBR":
//                                    probesEntity.INBEVCOOLERBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 122:
//                                case "INBEVCOOLERBR-Probes":
//                                    probesEntity.INBEVCOOLERBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 123:
//                                case "INBEVCOOLERUS":
//                                    probesEntity.INBEVCOOLERUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 124:
//                                case "INBEVCOOLERUS-Probes":
//                                    probesEntity.INBEVCOOLERUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 125:
//                                case "INBEVFR":
//                                    probesEntity.INBEVFR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 126:
//                                case "INBEVFR-Probes":
//                                    probesEntity.INBEVFR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 127:
//                                case "INBEVLU":
//                                    probesEntity.INBEVLU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 128:
//                                case "INBEVLU-Probes":
//                                    probesEntity.INBEVLU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 129:
//                                case "INBEVLU-SAND":
//                                    probesEntity.INBEVLU_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 130:
//                                case "INBEVLU-SAND-Probes":
//                                    probesEntity.INBEVLU_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 131:
//                                case "INBEVMX":
//                                    probesEntity.INBEVMX = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 132:
//                                case "INBEVMX-Probes":
//                                    probesEntity.INBEVMX_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                //case 133:
//                                case "INBEVNL":
//                                    probesEntity.INBEVNL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 134:
//                                case "INBEVNL-Probes":
//                                    probesEntity.INBEVNL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 135:
//                                case "INBEVNL-SAND":
//                                    probesEntity.INBEVNL_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 136:
//                                case "INBEVNL-SAND-Probes":
//                                    probesEntity.INBEVNL_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 137:
//                                case "INBEVPY":
//                                    probesEntity.INBEVPY = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 138:
//                                case "INBEVPY-Probes":
//                                    probesEntity.INBEVPY_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 139:
//                                case "INBEVTRADMX":
//                                    probesEntity.INBEVTRADMX = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 140:
//                                case "INBEVTRADMX-Probes":
//                                    probesEntity.INBEVTRADMX_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 141:
//                                case "INBEVUS":
//                                    probesEntity.INBEVUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 142:
//                                case "INBEVUS-Probes":
//                                    probesEntity.INBEVUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 143:
//                                case "JTIUA":
//                                    probesEntity.JTIUA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 144:
//                                case "JTIUA-Probes":
//                                    probesEntity.JTIUA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 145:
//                                case "KCMY":
//                                    probesEntity.KCMY = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 146:
//                                case "KCMY-Probes":
//                                    probesEntity.KCMY_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 147:
//                                case "KCUS":
//                                    probesEntity.KCUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 148:
//                                case "KCUS-Probes":
//                                    probesEntity.KCUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 149:
//                                case "KEURIGCA":
//                                    probesEntity.KEURIGCA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 150:
//                                case "KEURIGCA-Probes":
//                                    probesEntity.KEURIGCA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////// just only finished 150 //////////////
//                                //case 151:
//                                case "LABATTPLNOPTCA":
//                                    probesEntity.LABATTPLNOPTCA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 152:
//                                case "LABATTPLNOPTCA-Probes":
//                                    probesEntity.LABATTPLNOPTCA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 153:
//                                case "LAVAZZAAT":
//                                    probesEntity.LAVAZZAAT = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 154:
//                                case "LAVAZZAAT-Probes":
//                                    probesEntity.LAVAZZAAT_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 155:
//                                case "LAVAZZAAU":
//                                    probesEntity.LAVAZZAAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 156:
//                                case "LAVAZZAAU-Probes":
//                                    probesEntity.LAVAZZAAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 157:
//                                case "LAVAZZABE":
//                                    probesEntity.LAVAZZABE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 158:
//                                case "LAVAZZABE-Probes":
//                                    probesEntity.LAVAZZABE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 159:
//                                case "LAVAZZABG":
//                                    probesEntity.LAVAZZABG = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 160:
//                                case "LAVAZZABG-Probes":
//                                    probesEntity.LAVAZZABG_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 161:
//                                case "LAVAZZACA":
//                                    probesEntity.LAVAZZACA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 162:
//                                case "LAVAZZACA-Probes":
//                                    probesEntity.LAVAZZACA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 163:
//                                case "LAVAZZACH":
//                                    probesEntity.LAVAZZACH = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 164:
//                                case "LAVAZZACH-Probes":
//                                    probesEntity.LAVAZZACH_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 165:
//                                case "LAVAZZACL":
//                                    probesEntity.LAVAZZACL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 166:
//                                case "LAVAZZACL-Probes":
//                                    probesEntity.LAVAZZACL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 167:
//                                case "LAVAZZACN":
//                                    probesEntity.LAVAZZACN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 168:
//                                case "LAVAZZACN-Probes":
//                                    probesEntity.LAVAZZACN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 169:
//                                case "LAVAZZACZ":
//                                    probesEntity.LAVAZZACZ = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 170:
//                                case "LAVAZZACZ-Probes":
//                                    probesEntity.LAVAZZACZ_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 171:
//                                case "LAVAZZADE":
//                                    probesEntity.LAVAZZADE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 172:
//                                case "LAVAZZADE-Probes":
//                                    probesEntity.LAVAZZADE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 173:
//                                case "LAVAZZADK":
//                                    probesEntity.LAVAZZADK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 174:
//                                case "LAVAZZADK-Probes":
//                                    probesEntity.LAVAZZADK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 175:
//                                case "LAVAZZAEE":
//                                    probesEntity.LAVAZZAEE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 176:
//                                case "LAVAZZAEE-Probes":
//                                    probesEntity.LAVAZZAEE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 177:
//                                case "LAVAZZAES":
//                                    probesEntity.LAVAZZAES = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 178:
//                                case "LAVAZZAES-Probes":
//                                    probesEntity.LAVAZZAES_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 179:
//                                case "LAVAZZAFR":
//                                    probesEntity.LAVAZZAFR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 180:
//                                case "LAVAZZAFR-Probes":
//                                    probesEntity.LAVAZZAFR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 181:
//                                case "LAVAZZAGR":
//                                    probesEntity.LAVAZZAGR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 182:
//                                case "LAVAZZAGR-Probes":
//                                    probesEntity.LAVAZZAGR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 183:
//                                case "LAVAZZAHK":
//                                    probesEntity.LAVAZZAHK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 184:
//                                case "LAVAZZAHK-Probes":
//                                    probesEntity.LAVAZZAHK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 185:
//                                case "LAVAZZAHR":
//                                    probesEntity.LAVAZZAHR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 186:
//                                case "LAVAZZAHR-Probes":
//                                    probesEntity.LAVAZZAHR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                //case 187:
//                                case "LAVAZZAIL":
//                                    probesEntity.LAVAZZAIL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 188:
//                                case "LAVAZZAIL-Probes":
//                                    probesEntity.LAVAZZAIL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 189:
//                                case "LAVAZZAIT":
//                                    probesEntity.LAVAZZAIT = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 190:
//                                case "LAVAZZAIT-Probes":
//                                    probesEntity.LAVAZZAIT_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 191:
//                                case "LAVAZZAJP":
//                                    probesEntity.LAVAZZAJP = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 192:
//                                case "LAVAZZAJP-Probes":
//                                    probesEntity.LAVAZZAJP_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 193:
//                                case "LAVAZZAKR":
//                                    probesEntity.LAVAZZAKR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 194:
//                                case "LAVAZZAKR-Probes":
//                                    probesEntity.LAVAZZAKR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 195:
//                                case "LAVAZZALT":
//                                    probesEntity.LAVAZZALT = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 196:
//                                case "LAVAZZALT-Probes":
//                                    probesEntity.LAVAZZALT_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 197:
//                                case "LAVAZZALU":
//                                    probesEntity.LAVAZZALU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 198:
//                                case "LAVAZZALU-Probes":
//                                    probesEntity.LAVAZZALU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 199:
//                                case "LAVAZZALV":
//                                    probesEntity.LAVAZZALV = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 200:
//                                case "LAVAZZALV-Probes":
//                                    probesEntity.LAVAZZALV_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 201:
//                                case "LAVAZZAMA":
//                                    probesEntity.LAVAZZAMA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 202:
//                                case "LAVAZZAMA-Probes":
//                                    probesEntity.LAVAZZAMA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 203:
//                                case "LAVAZZANL":
//                                    probesEntity.LAVAZZANL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 204:
//                                case "LAVAZZANL-Probes":
//                                    probesEntity.LAVAZZANL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 205:
//                                case "LAVAZZAPL":
//                                    probesEntity.LAVAZZAPL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 206:
//                                case "LAVAZZAPL-Probes":
//                                    probesEntity.LAVAZZAPL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 207:
//                                case "LAVAZZARO":
//                                    probesEntity.LAVAZZARO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 208:
//                                case "LAVAZZARO-Probes":
//                                    probesEntity.LAVAZZARO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 209:
//                                case "LAVAZZARU":
//                                    probesEntity.LAVAZZARU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 210:
//                                case "LAVAZZARU-Probes":
//                                    probesEntity.LAVAZZARU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 211:
//                                case "LAVAZZASA":
//                                    probesEntity.LAVAZZASA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 212:
//                                case "LAVAZZASA-Probes":
//                                    probesEntity.LAVAZZASA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 213:
//                                case "LAVAZZASE":
//                                    probesEntity.LAVAZZASE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 214:
//                                case "LAVAZZASE-Probes":
//                                    probesEntity.LAVAZZASE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 215:
//                                case "LAVAZZASG":
//                                    probesEntity.LAVAZZASG = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 216:
//                                case "LAVAZZASG-Probes":
//                                    probesEntity.LAVAZZASG_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 217:
//                                case "LAVAZZAUAE":
//                                    probesEntity.LAVAZZAUAE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 218:
//                                case "LAVAZZAUAE-Probes":
//                                    probesEntity.LAVAZZAUAE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 219:
//                                case "LAVAZZAUK":
//                                    probesEntity.LAVAZZAUK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 220:
//                                case "LAVAZZAUK-Probes":
//                                    probesEntity.LAVAZZAUK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 221:
//                                case "LAVAZZAUS":
//                                    probesEntity.LAVAZZAUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 222:
//                                case "LAVAZZAUS-Probes":
//                                    probesEntity.LAVAZZAUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 223:
                           
//                                case "LAVAZZAZA":
//                                    probesEntity.LAVAZZAZA = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                case "LAVAZZAZA-Probes":
//                                    probesEntity.LAVAZZAZA_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 225:
//                                case "LRSUK":
//                                    probesEntity.LRSUK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 226:
//                                case "LRSUK-Probes":
//                                    probesEntity.LRSUK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 227:
//                                case "MARSBR":
//                                    probesEntity.MARSBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 228:
//                                case "MARSBR-Probes":
//                                    probesEntity.MARSBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 229:
//                                case "MARSIN":
//                                    probesEntity.MARSIN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 230:
//                                case "MARSIN-Probes":
//                                    probesEntity.MARSIN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 231:
//                                case "MARSIN-OLD":
//                                    probesEntity.MARSIN_OLD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 232:
//                                case "MARSIN-OLD-Probes":
//                                    probesEntity.MARSIN_OLD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 233:
//                                case "MARSRU-PROD":
//                                    probesEntity.MARSRU_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 234:
//                                case "MARSRU-PROD-Probes":
//                                    probesEntity.MARSRU_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 235:
//                                case "MAYORAID":
//                                    probesEntity.MAYORAID = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 236:
//                                case "MAYORAID-Probes":
//                                    probesEntity.MAYORAID_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 237:
//                                case "MJNCN":
//                                    probesEntity.MJNCN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 238:
//                                case "MJNCN-Probes":
//                                    probesEntity.MJNCN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 239:
//                                case "MOLSONCOOLERHN":
//                                    probesEntity.MOLSONCOOLERHN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 240:
//                                case "MOLSONCOOLERHN-Probes":
//                                    probesEntity.MOLSONCOOLERHN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 241:
//                                case "MOLSONCOOLERHR":
//                                    probesEntity.MOLSONCOOLERHR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 242:
//                                case "MOLSONCOOLERHR-Probes":
//                                    probesEntity.MOLSONCOOLERHR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 243:
//                                case "MOLSONCOORSUK":
//                                    probesEntity.MOLSONCOORSUK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 244:
//                                case "MOLSONCOORSUK-Probes":
//                                    probesEntity.MOLSONCOORSUK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 245:
//                                case "NESTLEUK":
//                                    probesEntity.NESTLEUK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 246:
//                                case "NESTLEUK-Probes":
//                                    probesEntity.NESTLEUK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 247:
//                                case "NIVEAUK":
//                                    probesEntity.NIVEAUK = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 248:
//                                case "NIVEAUK-Probes":
//                                    probesEntity.NIVEAUK_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 249:
//                                case "NRF2017-DEMO":
//                                    probesEntity.NRF2017_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 250:
//                                case "NRF2017-DEMO-Probes":
//                                    probesEntity.NRF2017_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                    //case 251:
//                                    case "ONE-AMERICAS-DEMO":
//                                        probesEntity.ONE_AMERICAS_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                        break;
//                                    //case 252:                                  
//                                  case "ONE-AMERICAS-DEMO-Probes":
//                                    probesEntity.ONE_AMERICAS_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 253:
//                                case "ONE-APAC-DEMO":
//                                    probesEntity.ONE_APAC_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 254:
//                                case "ONE-APAC-DEMO-Probes":
//                                    probesEntity.ONE_APAC_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 255:
//                                case "PEPSICOBR":
//                                    probesEntity.PEPSICOBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 256:
//                                case "PEPSICOBR-Probes":
//                                    probesEntity.PEPSICOBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 257:
//                                case "PNGAU":
//                                    probesEntity.PNGAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 258:
//                                case "PNGAU-Probes":
//                                    probesEntity.PNGAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 259:
//                                case "PNGAU-OLD":
//                                    probesEntity.PNGAU_OLD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 260:
//                                case "PNGAU-OLD-Probes":
//                                    probesEntity.PNGAU_OLD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 261:
//                                case "PNGCAREUS":
//                                    probesEntity.PNGCAREUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 262:
//                                case "PNGCAREUS-Probes":
//                                    probesEntity.PNGCAREUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 263:
//                                case "PNGCN-PROD":
//                                    probesEntity.PNGCN_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 264:
//                                case "PNGCN-PROD-Probes":
//                                    probesEntity.PNGCN_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 265:
//                                case "PNGJP":
//                                    probesEntity.PNGJP = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 266:
//                                case "PNGJP-Probes":
//                                    probesEntity.PNGJP_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 267:
//                                case "PNGJP-OLD":
//                                    probesEntity.PNGJP_OLD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 268:
//                                case "PNGJP-OLD-Probes":
//                                    probesEntity.PNGJP_OLD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 269:
//                                case "PNGUS":
//                                    probesEntity.PNGUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 270:
//                                case "PNGUS-Probes":
//                                    probesEntity.PNGUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 271:
//                                case "PNGUSEPISODIC":
//                                    probesEntity.PNGUSEPISODIC = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 272:
//                                case "PNGUSEPISODIC-Probes":
//                                    probesEntity.PNGUSEPISODIC_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 273:
//                                case "RBUS":
//                                    probesEntity.RBUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 274:
//                                case "RBUS-Probes":
//                                    probesEntity.RBUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 275:
//                                case "RE-XSUITE-DEMO":
//                                    probesEntity.RE_XSUITE_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 276:
//                                case "RE-XSUITE-DEMO-Probes":
//                                    probesEntity.RE_XSUITE_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                    //case 277:
//                                    case "REPNGCN-DEMO":
//                                        probesEntity.REPNGCN_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                        break;
//                                    //case 278:
//                                    case "REPNGCN-DEMO-Probes":
//                                    probesEntity.REPNGCN_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 279:
//                                case "RI-DEMO":
//                                    probesEntity.RI_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 280:
//                                case "RI-DEMO-Probes":
//                                    probesEntity.RI_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 281:
//                                case "RI-DIAGEOAU":
//                                    probesEntity.RI_DIAGEOAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 282:
//                                case "RI-DIAGEOAU-Probes":
//                                    probesEntity.RI_DIAGEOAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 283:
//                                case "RIALCBEVUK-PROD":
//                                    probesEntity.RIALCBEVUK_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 284:
//                                case "RIALCBEVUK-PROD-Probes":
//                                    probesEntity.RIALCBEVUK_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 285:
//                                case "RICOFFEEUS":
//                                    probesEntity.RICOFFEEUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 286:
//                                case "RICOFFEEUS-Probes":
//                                    probesEntity.RICOFFEEUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 287:
//                                case "RINIELSENUS":
//                                    probesEntity.RINIELSENUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 288:
//                                case "RINIELSENUS-Probes":
//                                    probesEntity.RINIELSENUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 289:
//                                case "RIPETCAREUK-PROD":
//                                    probesEntity.RIPETCAREUK_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 290:
//                                case "RIPETCAREUK-PROD-Probes":
//                                    probesEntity.RIPETCAREUK_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 291:
//                                case "RIUS":
//                                    probesEntity.RIUS = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 292:
//                                case "RIUS-Probes":
//                                    probesEntity.RIUS_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 293:
//                                case "RIUS-DEV":
//                                    probesEntity.RIUS_DEV = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 294:
//                                case "RIUS-DEV-Probes":
//                                    probesEntity.RIUS_DEV_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 295:
//                                case "RNBDE":
//                                    probesEntity.RNBDE = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 296:
//                                case "RNBDE-Probes":
//                                    probesEntity.RNBDE_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 297:
//                                case "SMARTCOOLER-POC2":
//                                    probesEntity.SMARTCOOLER_POC2 = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 298:
//                                case "SMARTCOOLER-POC2-Probes":
//                                    probesEntity.SMARTCOOLER_POC2_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 299:
//                                case "SMARTCOOLER-TRN":
//                                    probesEntity.SMARTCOOLER_TRN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 300:
//                                case "SMARTCOOLER-TRN-Probes":
//                                    probesEntity.SMARTCOOLER_TRN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 301:
//                                case "SMARTCOOLER2-TRN":
//                                    probesEntity.SMARTCOOLER2_TRN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 302:
//                                case "SMARTCOOLER2-TRN-Probes":
//                                    probesEntity.SMARTCOOLER2_TRN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 303:
//                                case "SOLARBR":
//                                    probesEntity.SOLARBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 304:
//                                case "SOLARBR-Probes":
//                                    probesEntity.SOLARBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                    //case 305:
//                                    case "STATIC-CAMERA-DEMO":
//                                        probesEntity.STATIC_CAMERA_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                        break;
//                                    //case 306:
//                                    case "STATIC-CAMERA-DEMO-Probes":
//                                    probesEntity.STATIC_CAMERA_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 307:
//                                case "SWIRECN":
//                                    probesEntity.SWIRECN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 308:
//                                case "SWIRECN-Probes":
//                                    probesEntity.SWIRECN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 309:
//                                case "SWIREREDCN":
//                                    probesEntity.SWIREREDCN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 310:
//                                case "SWIREREDCN-Probes":
//                                    probesEntity.SWIREREDCN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 311:
//                                case "TNUVAIL":
//                                    probesEntity.TNUVAIL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 312:
//                                case "TNUVAIL-Probes":
//                                    probesEntity.TNUVAIL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 313:
//                                case "TRAXDEMO-TS-PROD":
//                                    probesEntity.TRAXDEMO_TS_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 314:
//                                case "TRAXDEMO-TS-PROD-Probes":
//                                    probesEntity.TRAXDEMO_TS_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 315:
//                                case "TWEAU":
//                                    probesEntity.TWEAU = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 316:
//                                case "TWEAU-Probes":
//                                    probesEntity.TWEAU_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 317:
//                                case "RI-DEMO2":
//                                    probesEntity.RI_DEMO2 = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 318:
//                                case "RI-DEMO2-Probes":
//                                    probesEntity.RI_DEMO2_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 319:
//                                case "COMPASSCCH-SAND":
//                                    probesEntity.COMPASSCCH_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 320:
//                                case "COMPASSCCH-SAND-Probes":
//                                    probesEntity.COMPASSCCH_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 321:
//                                case "LAVAZZAIT-SAND":
//                                    probesEntity.LAVAZZAIT_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 322:
//                                case "LAVAZZAIT-SAND-Probes":
//                                    probesEntity.LAVAZZAIT_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                ////////////////////////
//                                //case 323:
//                                case "INBEVUS-STG":
//                                    probesEntity.INBEVUS_STG = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 324:
//                                case "INBEVUS-STG-Probes":
//                                    probesEntity.INBEVUS_STG_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 325:
//                                case "LAVAZZAFR-SAND":
//                                    probesEntity.LAVAZZAFR_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 326:
//                                case "LAVAZZAFR-SAND-Probes":
//                                    probesEntity.LAVAZZAFR_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;

//                                 //case 327:
//                                case "INBEVBE-SAND":
//                                    probesEntity.INBEVBE_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 328:
//                                case "INBEVBE-SAND-Probes":
//                                    probesEntity.INBEVBE_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                    break;
//                                //case 329:
//                                //case "INBEVLU-SAND":
//                                //    probesEntity.INBEVLU_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 330:
//                                //case "330":
//                                //    probesEntity.INBEVLU_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 331:
//                                //case "INBEVNL-SAND":
//                                //    probesEntity.INBEVNL_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                ////case 332:
//                                //case "332":
//                                //    probesEntity.INBEVNL_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;

//                                #region "No need region"
//                                //case 333:
//                                //    probesEntity.SOLARBR = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 334:
//                                //    probesEntity.SOLARBR_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 335:
//                                //    probesEntity.STATIC_CAMERA_DEMO = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 336:
//                                //    probesEntity.STATIC_CAMERA_DEMO_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 337:
//                                //    probesEntity.SWIRECN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 338:
//                                //    probesEntity.SWIRECN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 339:
//                                //    probesEntity.SWIREREDCN = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 340:
//                                //    probesEntity.SWIREREDCN_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 341:
//                                //    probesEntity.TNUVAIL = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 342:
//                                //    probesEntity.TNUVAIL_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 343:
//                                //    probesEntity.TRAXDEMO_TS_PROD = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 344:
//                                //    probesEntity.TRAXDEMO_TS_PROD_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 345:
//                                //    probesEntity.RI_DEMO2 = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 346:
//                                //    probesEntity.RI_DEMO2_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 347:
//                                //    probesEntity.COMPASSCCH_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 348:
//                                //    probesEntity.COMPASSCCH_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 349:
//                                //    probesEntity.LAVAZZAIT_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 350:
//                                //    probesEntity.LAVAZZAIT_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 351:
//                                //    probesEntity.INBEVUS_STG = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 352:
//                                //    probesEntity.INBEVUS_STG_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 353:
//                                //    probesEntity.LAVAZZAFR_SAND = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                //case 354:
//                                //    probesEntity.LAVAZZAFR_SAND_Probes = Convert.ToInt32(Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == "" || Convert.ToString(ws.Cells[rowNumber, colNumber].Value).Trim() == null ? 0 : ws.Cells[rowNumber, colNumber].Value);
//                                //    break;
//                                #endregion

//                                default: break;


//                                #endregion
//                            }
//                        }

//                    }
//                    catch (Exception ex)
//                    {
//                        Response.Redirect("error.aspx");
//                        throw ex;
//                    }
//                }

           

//                    probesEntity.ImportedDate = GeneralUtility.ConvertSystemDateStringFormat(txtImportDate.Text.Trim());//GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);             
//                    probesEntity.ImportedYear = probesEntity.ImportedDate.Substring(0, 6);
//                    //probesEntity.ImportTime = GeneralUtility.ConvertSystemTimeFormat(System.DateTime.Now);
//                    probesEntity.CreatedBy = "admin";


//                    probeslist.Add(probesEntity);
                

//                #endregion


//    }
//}