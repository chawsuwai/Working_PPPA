using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Votes")]
    public class VotesEntity:EntityBase
    {
        //ID varchar(50) NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //QAT	varchar(50)	NOT NULL,
        [DbColumn(Name = "QAT")]
        public string QAT { get; set; }

        //Center	varchar(50)	NOT NULL,
        [DbColumn(Name = "Center")]
        public string Center { get; set; }

        //TotalVotes    int     NULL,
        [DbColumn(Name = "TotalVotes")]
        public int TotalVotes { get; set; }

        //AvgsecondsperVotes    int     NULL,
        [DbColumn(Name = "AvgsecondsperVotes")]
        public int AvgsecondsperVotes { get; set; }

        //ABICA int     NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_Votes   int     NULL,
        [DbColumn(Name = "ABICA_Votes")]
        public int ABICA_Votes { get; set; }

        //ABITAMSUS_PROD        int     NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_Votes  int     NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_Votes")]
        public int ABITAMSUS_PROD_Votes { get; set; }

        //AMERICAS_DEMO int     NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_Votes   int     NULL,
        [DbColumn(Name = "AMERICAS_DEMO_Votes")]
        public int AMERICAS_DEMO_Votes { get; set; }

        // BATRU        int     NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_Votes   int     NULL,
        [DbColumn(Name = "BATRU_Votes")]
        public int BATRU_Votes { get; set; }

        //BIKR  int     NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_Votes    int     NULL,
        [DbColumn(Name = "BIKR_Votes")]
        public int BIKR_Votes { get; set; }

        //BIMY  int     NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_Votes    int     NULL,
        [DbColumn(Name = "BIMY_Votes")]
        public int BIMY_Votes { get; set; }

        //BIPH  int     NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_Votes    int     NULL,
        [DbColumn(Name = "BIPH_Votes")]
        public int BIPH_Votes { get; set; }

        //BISEASK       int     NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_Votes int     NULL,
        [DbColumn(Name = "BISEASK_Votes")]
        public int BISEASK_Votes { get; set; }

        //BITH  int     NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_Votes    int     NULL,
        [DbColumn(Name = "BITH_Votes")]
        public int BITH_Votes { get; set; }

        //BIVN  int     NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_Votes    int     NULL,
        [DbColumn(Name = "BIVN_Votes")]
        public int BIVN_Votes { get; set; }

        //BPAU  int     NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_Votes    int     NULL,
        [DbColumn(Name = "BPAU_Votes")]
        public int BPAU_Votes { get; set; }

        //BRODMANN      int     NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_Votes        int     NULL,
        [DbColumn(Name = "BRODMANN_Votes")]
        public int BRODMANN_Votes { get; set; }

        //CARREFOURAR   int     NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_Votes     int     NULL,
        [DbColumn(Name = "CARREFOURAR_Votes")]
        public int CARREFOURAR_Votes { get; set; }

        //CCAAU int     NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_Votes   int     NULL,
        [DbColumn(Name = "CCAAU_Votes")]
        public int CCAAU_Votes { get; set; }

        //CCABIZA       int     NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_Votes int     NULL,
        [DbColumn(Name = "CCABIZA_Votes")]
        public int CCABIZA_Votes { get; set; }

        //CCANZ int     NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_Votes   int     NULL,
        [DbColumn(Name = "CCANZ_Votes")]
        public int CCANZ_Votes { get; set; }

        //CCBOTTLERSUS  int     NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_Votes    int     NULL,
        [DbColumn(Name = "CCBOTTLERSUS_Votes")]
        public int CCBOTTLERSUS_Votes { get; set; }

        //CCBR_PROD     int     NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_Votes       int     NULL,
        [DbColumn(Name = "CCBR_PROD_Votes")]
        public int CCBR_PROD_Votes { get; set; }

        //CCJP  int     NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_Votes    int     NULL,
        [DbColumn(Name = "CCJP_Votes")]
        public int CCJP_Votes { get; set; }

        //CCKH  int     NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_Votes    int     NULL,
        [DbColumn(Name = "CCKH_Votes")]
        public int CCKH_Votes { get; set; }

        //CCKR  int     NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_Votes    int     NULL,
        [DbColumn(Name = "CCKR_Votes")]
        public int CCKR_Votes { get; set; }

        //CCMY  int     NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_Votes    int     NULL,
        [DbColumn(Name = "CCMY_Votes")]
        public int CCMY_Votes { get; set; }

        //CCPH  int     NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_Votes    int     NULL,
        [DbColumn(Name = "CCPH_Votes")]
        public int CCPH_Votes { get; set; }

        //CCRPR_PROD    int     NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_Votes      int     NULL,
        [DbColumn(Name = "CCRPR_PROD_Votes")]
        public int CCRPR_PROD_Votes { get; set; }

        //CCRU  int     NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_Votes    int     NULL,
        [DbColumn(Name = "CCRU_Votes")]
        public int CCRU_Votes { get; set; }

        //CCTH  int     NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_Votes    int     NULL,
        [DbColumn(Name = "CCTH_Votes")]
        public int CCTH_Votes { get; set; }

        //CCTH_UAT      int     NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_Votes        int     NULL,
        [DbColumn(Name = "CCTH_UAT_Votes")]
        public int CCTH_UAT_Votes { get; set; }

        //CCTRADMX      int     NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_Votes        int     NULL,
        [DbColumn(Name = "CCTRADMX_Votes")]
        public int CCTRADMX_Votes { get; set; }

        //CCUS  int     NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_Votes    int     NULL,
        [DbColumn(Name = "CCUS_Votes")]
        public int CCUS_Votes { get; set; }

        //CCZA  int     NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_Votes    int     NULL,
        [DbColumn(Name = "CCZA_Votes")]
        public int CCZA_Votes { get; set; }

        //CEREBOSTH     int     NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_Votes       int     NULL,
        [DbColumn(Name = "CEREBOSTH_Votes")]
        public int CEREBOSTH_Votes { get; set; }

        //CROWDSOURCE   int     NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_Votes     int     NULL,
        [DbColumn(Name = "CROWDSOURCE_Votes")]
        public int CROWDSOURCE_Votes { get; set; }

        //DIAGEOAU      int     NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOAU_Votes")]
        public int DIAGEOAU_Votes { get; set; }

        //DIAGEOBR      int     NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOBR_Votes")]
        public int DIAGEOBR_Votes { get; set; }

        //DIAGEOGR      int     NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOGR_Votes")]
        public int DIAGEOGR_Votes { get; set; }

        //DIAGEOIE      int     NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOIE_Votes")]
        public int DIAGEOIE_Votes { get; set; }

        //DIAGEOKE      int     NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOKE_Votes")]
        public int DIAGEOKE_Votes { get; set; }

        //DIAGEOMX      int     NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOMX_Votes")]
        public int DIAGEOMX_Votes { get; set; }

        //DIAGEOPT      int     NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOPT_Votes")]
        public int DIAGEOPT_Votes { get; set; }

        //DIAGEOTW      int     NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOTW_Votes")]
        public int DIAGEOTW_Votes { get; set; }

        //DIAGEOUK      int     NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOUK_Votes")]
        public int DIAGEOUK_Votes { get; set; }

        //DIAGEOZA      int     NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_Votes        int     NULL,
        [DbColumn(Name = "DIAGEOZA_Votes")]
        public int DIAGEOZA_Votes { get; set; }

        //EMEA_DEMO     int     NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_Votes       int     NULL,
        [DbColumn(Name = "EMEA_DEMO_Votes")]
        public int EMEA_DEMO_Votes { get; set; }

        //FERREROIT     int     NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_Votes       int     NULL,
        [DbColumn(Name = "FERREROIT_Votes")]
        public int FERREROIT_Votes { get; set; }

        //GILLETTEUS    int     NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_Votes      int     NULL,
        [DbColumn(Name = "GILLETTEUS_Votes")]
        public int GILLETTEUS_Votes { get; set; }

        //GOOGLEUS      int     NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_Votes        int     NULL,
        [DbColumn(Name = "GOOGLEUS_Votes")]
        public int GOOGLEUS_Votes { get; set; }

        //HBCDE int     NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_Votes   int     NULL,
        [DbColumn(Name = "HBCDE_Votes")]
        public int HBCDE_Votes { get; set; }

        //HEINEKENCN    int     NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_Votes      int     NULL,
        [DbColumn(Name = "HEINEKENCN_Votes")]
        public int HEINEKENCN_Votes { get; set; }

        //HEINEKENUS_PROD       int     NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_Votes int     NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_Votes")]
        public int HEINEKENUS_PROD_Votes { get; set; }

        //HEINZCR       int     NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_Votes int     NULL,
        [DbColumn(Name = "HEINZCR_Votes")]
        public int HEINZCR_Votes { get; set; }

        //INBEVAR       int     NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_Votes int     NULL,
        [DbColumn(Name = "INBEVAR_Votes")]
        public int INBEVAR_Votes { get; set; }

        //INBEVBE       int     NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_Votes int     NULL,
        [DbColumn(Name = "INBEVBE_Votes")]
        public int INBEVBE_Votes { get; set; }

        //INBEVBE_SAND  int     NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_Votes    int     NULL,
        [DbColumn(Name = "INBEVBE_SAND_Votes")]
        public int INBEVBE_SAND_Votes { get; set; }

        //INBEVBR       int     NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_Votes int     NULL,
        [DbColumn(Name = "INBEVBR_Votes")]
        public int INBEVBR_Votes { get; set; }

        //INBEVBR_ONTRADE       int     NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_Votes int     NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_Votes")]
        public int INBEVBR_ONTRADE_Votes { get; set; }

        //INBEVCL       int     NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_Votes int     NULL,
        [DbColumn(Name = "INBEVCL_Votes")]
        public int INBEVCL_Votes { get; set; }

        //INBEVCN       int     NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_Votes int     NULL,
        [DbColumn(Name = "INBEVCN_Votes")]
        public int INBEVCN_Votes { get; set; }

        //INBEVCOOLERAR int     NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_Votes   int     NULL,
        [DbColumn(Name = "INBEVCOOLERAR_Votes")]
        public int INBEVCOOLERAR_Votes { get; set; }

        //INBEVCOOLERBR int     NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_Votes   int     NULL,
        [DbColumn(Name = "INBEVCOOLERBR_Votes")]
        public int INBEVCOOLERBR_Votes { get; set; }

        //INBEVCOOLERUS int     NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_Votes   int     NULL,
        [DbColumn(Name = "INBEVCOOLERUS_Votes")]
        public int INBEVCOOLERUS_Votes { get; set; }

        //INBEVFR       int     NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_Votes int     NULL,
        [DbColumn(Name = "INBEVFR_Votes")]
        public int INBEVFR_Votes { get; set; }

        //INBEVLU       int     NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_Votes int     NULL,
        [DbColumn(Name = "INBEVLU_Votes")]
        public int INBEVLU_Votes { get; set; }

        //INBEVLU_SAND  int     NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_Votes    int     NULL,
        [DbColumn(Name = "INBEVLU_SAND_Votes")]
        public int INBEVLU_SAND_Votes { get; set; }

        //INBEVMX       int     NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_Votes int     NULL,
        [DbColumn(Name = "INBEVMX_Votes")]
        public int INBEVMX_Votes { get; set; }

        //INBEVNL       int     NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_Votes int     NULL,
        [DbColumn(Name = "INBEVNL_Votes")]
        public int INBEVNL_Votes { get; set; }

        //INBEVNL_SAND  int     NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_Votes    int     NULL,
        [DbColumn(Name = "INBEVNL_SAND_Votes")]
        public int INBEVNL_SAND_Votes { get; set; }

        //INBEVPY       int     NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_Votes int     NULL,
        [DbColumn(Name = "INBEVPY_Votes")]
        public int INBEVPY_Votes { get; set; }

        //INBEVTRADMX   int     NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_Votes     int     NULL,
        [DbColumn(Name = "INBEVTRADMX_Votes")]
        public int INBEVTRADMX_Votes { get; set; }

        //INBEVUS       int     NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_Votes int     NULL,
        [DbColumn(Name = "INBEVUS_Votes")]
        public int INBEVUS_Votes { get; set; }

        //JTIUA int     NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_Votes   int     NULL,
        [DbColumn(Name = "JTIUA_Votes")]
        public int JTIUA_Votes { get; set; }

        //KCMY  int     NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_Votes    int     NULL,
        [DbColumn(Name = "KCMY_Votes")]
        public int KCMY_Votes { get; set; }

        //KCUS  int     NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_Votes    int     NULL,
        [DbColumn(Name = "KCUS_Votes")]
        public int KCUS_Votes { get; set; }

        //KEURIGCA      int     NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_Votes        int     NULL,
        [DbColumn(Name = "KEURIGCA_Votes")]
        public int KEURIGCA_Votes { get; set; }

        //LABATTPLNOPTCA        int     NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_Votes  int     NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_Votes")]
        public int LABATTPLNOPTCA_Votes { get; set; }

        //LAVAZZAAT     int     NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAAT_Votes")]
        public int LAVAZZAAT_Votes { get; set; }

        //LAVAZZAAU     int     NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAAU_Votes")]
        public int LAVAZZAAU_Votes { get; set; }

        //LAVAZZABE     int     NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZABE_Votes")]
        public int LAVAZZABE_Votes { get; set; }

        //LAVAZZABG     int     NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZABG_Votes")]
        public int LAVAZZABG_Votes { get; set; }

        //LAVAZZACA     int     NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZACA_Votes")]
        public int LAVAZZACA_Votes { get; set; }

        //LAVAZZACH     int     NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZACH_Votes")]
        public int LAVAZZACH_Votes { get; set; }

        //LAVAZZACL     int     NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZACL_Votes")]
        public int LAVAZZACL_Votes { get; set; }

        //LAVAZZACN     int     NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZACN_Votes")]
        public int LAVAZZACN_Votes { get; set; }

        //LAVAZZACZ     int     NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZACZ_Votes")]
        public int LAVAZZACZ_Votes { get; set; }

        //LAVAZZADE     int     NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZADE_Votes")]
        public int LAVAZZADE_Votes { get; set; }

        //LAVAZZADK     int     NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZADK_Votes")]
        public int LAVAZZADK_Votes { get; set; }

        //LAVAZZAEE     int     NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAEE_Votes")]
        public int LAVAZZAEE_Votes { get; set; }

        //LAVAZZAES     int     NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAES_Votes")]
        public int LAVAZZAES_Votes { get; set; }

        //LAVAZZAFR     int     NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAFR_Votes")]
        public int LAVAZZAFR_Votes { get; set; }

        //LAVAZZAGR     int     NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAGR_Votes")]
        public int LAVAZZAGR_Votes { get; set; }

        //LAVAZZAHK     int     NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAHK_Votes")]
        public int LAVAZZAHK_Votes { get; set; }

        //LAVAZZAHR     int     NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAHR_Votes")]
        public int LAVAZZAHR_Votes { get; set; }

        //LAVAZZAIL     int     NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAIL_Votes")]
        public int LAVAZZAIL_Votes { get; set; }

        //LAVAZZAIT     int     NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAIT_Votes")]
        public int LAVAZZAIT_Votes { get; set; }

        //LAVAZZAJP     int     NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAJP_Votes")]
        public int LAVAZZAJP_Votes { get; set; }

        //LAVAZZAKR     int     NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAKR_Votes")]
        public int LAVAZZAKR_Votes { get; set; }

        //LAVAZZALT     int     NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZALT_Votes")]
        public int LAVAZZALT_Votes { get; set; }

        //LAVAZZALU     int     NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZALU_Votes")]
        public int LAVAZZALU_Votes { get; set; }

        //LAVAZZALV     int     NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZALV_Votes")]
        public int LAVAZZALV_Votes { get; set; }

        //LAVAZZAMA     int     NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAMA_Votes")]
        public int LAVAZZAMA_Votes { get; set; }

        //LAVAZZANL     int     NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZANL_Votes")]
        public int LAVAZZANL_Votes { get; set; }

        //LAVAZZAPL     int     NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAPL_Votes")]
        public int LAVAZZAPL_Votes { get; set; }

        //LAVAZZARO     int     NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZARO_Votes")]
        public int LAVAZZARO_Votes { get; set; }

        //LAVAZZARU     int     NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZARU_Votes")]
        public int LAVAZZARU_Votes { get; set; }

        //LAVAZZASA     int     NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZASA_Votes")]
        public int LAVAZZASA_Votes { get; set; }

        //LAVAZZASE     int     NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZASE_Votes")]
        public int LAVAZZASE_Votes { get; set; }

        //LAVAZZASG     int     NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZASG_Votes")]
        public int LAVAZZASG_Votes { get; set; }

        //LAVAZZAUAE    int     NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_Votes      int     NULL,
        [DbColumn(Name = "LAVAZZAUAE_Votes")]
        public int LAVAZZAUAE_Votes { get; set; }

        //LAVAZZAUK     int     NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAUK_Votes")]
        public int LAVAZZAUK_Votes { get; set; }

        //LAVAZZAUS     int     NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAUS_Votes")]
        public int LAVAZZAUS_Votes { get; set; }

        //LAVAZZAZA     int     NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_Votes       int     NULL,
        [DbColumn(Name = "LAVAZZAZA_Votes")]
        public int LAVAZZAZA_Votes { get; set; }

        //LRSUK int     NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_Votes   int     NULL,
        [DbColumn(Name = "LRSUK_Votes")]
        public int LRSUK_Votes { get; set; }

        //MARSBR        int     NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_Votes  int     NULL,
        [DbColumn(Name = "MARSBR_Votes")]
        public int MARSBR_Votes { get; set; }

        //MARSIN        int     NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_Votes  int     NULL,
        [DbColumn(Name = "MARSIN_Votes")]
        public int MARSIN_Votes { get; set; }

        //MARSIN_OLD    int     NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_Votes      int     NULL,
        [DbColumn(Name = "MARSIN_OLD_Votes")]
        public int MARSIN_OLD_Votes { get; set; }

        //MARSRU_PROD   int     NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_Votes     int     NULL,
        [DbColumn(Name = "MARSRU_PROD_Votes")]
        public int MARSRU_PROD_Votes { get; set; }

        //MAYORAID      int     NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_Votes        int     NULL,
        [DbColumn(Name = "MAYORAID_Votes")]
        public int MAYORAID_Votes { get; set; }

        //MJNCN int     NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_Votes   int     NULL,
        [DbColumn(Name = "MJNCN_Votes")]
        public int MJNCN_Votes { get; set; }

        //MOLSONCOOLERHN        int     NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_Votes  int     NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_Votes")]
        public int MOLSONCOOLERHN_Votes { get; set; }

        //MOLSONCOOLERHR        int     NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_Votes  int     NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_Votes")]
        public int MOLSONCOOLERHR_Votes { get; set; }

        //MOLSONCOORSUK int     NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_Votes   int     NULL,
        [DbColumn(Name = "MOLSONCOORSUK_Votes")]
        public int MOLSONCOORSUK_Votes { get; set; }

        //NESTLEUK      int     NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_Votes        int     NULL,
        [DbColumn(Name = "NESTLEUK_Votes")]
        public int NESTLEUK_Votes { get; set; }

        //NIVEAUK       int     NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_Votes int     NULL,
        [DbColumn(Name = "NIVEAUK_Votes")]
        public int NIVEAUK_Votes { get; set; }

        //NRF2017_DEMO  int     NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_Votes    int     NULL,
        [DbColumn(Name = "NRF2017_DEMO_Votes")]
        public int NRF2017_DEMO_Votes { get; set; }

        //ONE_AMERICAS_DEMO     int     NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_Votes       int     NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_Votes")]
        public int ONE_AMERICAS_DEMO_Votes { get; set; }

        //ONE_APAC_DEMO int     NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_Votes   int     NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_Votes")]
        public int ONE_APAC_DEMO_Votes { get; set; }

        //PEPSICOBR     int     NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_Votes       int     NULL,
        [DbColumn(Name = "PEPSICOBR_Votes")]
        public int PEPSICOBR_Votes { get; set; }

        //PNGAU int     NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_Votes   int     NULL,
        [DbColumn(Name = "PNGAU_Votes")]
        public int PNGAU_Votes { get; set; }

        //PNGAU_OLD     int     NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_Votes       int     NULL,
        [DbColumn(Name = "PNGAU_OLD_Votes")]
        public int PNGAU_OLD_Votes { get; set; }

        //PNGCAREUS     int     NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_Votes       int     NULL,
        [DbColumn(Name = "PNGCAREUS_Votes")]
        public int PNGCAREUS_Votes { get; set; }

        //PNGCN_PROD    int     NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_Votes      int     NULL,
        [DbColumn(Name = "PNGCN_PROD_Votes")]
        public int PNGCN_PROD_Votes { get; set; }

        //PNGJP int     NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_Votes   int     NULL,
        [DbColumn(Name = "PNGJP_Votes")]
        public int PNGJP_Votes { get; set; }

        //PNGJP_OLD     int     NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_Votes       int     NULL,
        [DbColumn(Name = "PNGJP_OLD_Votes")]
        public int PNGJP_OLD_Votes { get; set; }

        //PNGUS int     NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_Votes   int     NULL,
        [DbColumn(Name = "PNGUS_Votes")]
        public int PNGUS_Votes { get; set; }

        //PNGUSEPISODIC int     NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_Votes   int     NULL,
        [DbColumn(Name = "PNGUSEPISODIC_Votes")]
        public int PNGUSEPISODIC_Votes { get; set; }

        //RBUS  int     NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_Votes    int     NULL,
        [DbColumn(Name = "RBUS_Votes")]
        public int RBUS_Votes { get; set; }

        //RE_XSUITE_DEMO        int     NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_Votes  int     NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_Votes")]
        public int RE_XSUITE_DEMO_Votes { get; set; }

        //REPNGCN_DEMO  int     NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_Votes    int     NULL,
        [DbColumn(Name = "REPNGCN_DEMO_Votes")]
        public int REPNGCN_DEMO_Votes { get; set; }

        //RI_DEMO       int     NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_Votes int     NULL,
        [DbColumn(Name = "RI_DEMO_Votes")]
        public int RI_DEMO_Votes { get; set; }
        //RI_DIAGEOAU   int     NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_Votes     int     NULL,
        [DbColumn(Name = "RI_DIAGEOAU_Votes")]
        public int RI_DIAGEOAU_Votes { get; set; }

        //RIALCBEVUK_PROD       int     NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_Votes int     NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_Votes")]
        public int RIALCBEVUK_PROD_Votes { get; set; }

        //RICOFFEEUS    int     NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_Votes      int     NULL,
        [DbColumn(Name = "RICOFFEEUS_Votes")]
        public int RICOFFEEUS_Votes { get; set; }

        //RINIELSENUS   int     NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_Votes     int     NULL,
        [DbColumn(Name = "RINIELSENUS_Votes")]
        public int RINIELSENUS_Votes { get; set; }

        //RIPETCAREUK_PROD      int     NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_Votes        int     NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_Votes")]
        public int RIPETCAREUK_PROD_Votes { get; set; }

        //RIUS  int     NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_Votes    int     NULL,
        [DbColumn(Name = "RIUS_Votes")]
        public int RIUS_Votes { get; set; }

        //RIUS_DEV      int     NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_Votes        int     NULL,
        [DbColumn(Name = "RIUS_DEV_Votes")]
        public int RIUS_DEV_Votes { get; set; }

        //RNBDE int     NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_Votes   int     NULL,
        [DbColumn(Name = "RNBDE_Votes")]
        public int RNBDE_Votes { get; set; }

        //SMARTCOOLER_POC2      int     NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_Votes        int     NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_Votes")]
        public int SMARTCOOLER_POC2_Votes { get; set; }

        //SMARTCOOLER_TRN       int     NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_Votes int     NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_Votes")]
        public int SMARTCOOLER_TRN_Votes { get; set; }

        //SMARTCOOLER2_TRN      int     NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_Votes        int     NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_Votes")]
        public int SMARTCOOLER2_TRN_Votes { get; set; }

        //SOLARBR       int     NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_Votes int     NULL,
        [DbColumn(Name = "SOLARBR_Votes")]
        public int SOLARBR_Votes { get; set; }

        //STATIC_CAMERA_DEMO    int     NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_Votes      int     NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_Votes")]
        public int STATIC_CAMERA_DEMO_Votes { get; set; }

        //SWIRECN       int     NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_Votes int     NULL,
        [DbColumn(Name = "SWIRECN_Votes")]
        public int SWIRECN_Votes { get; set; }

        //SWIREREDCN    int     NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_Votes      int     NULL,
        [DbColumn(Name = "SWIREREDCN_Votes")]
        public int SWIREREDCN_Votes { get; set; }

        //TNUVAIL       int     NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_Votes int     NULL,
        [DbColumn(Name = "TNUVAIL_Votes")]
        public int TNUVAIL_Votes { get; set; }

        //TRAXDEMO_TS_PROD      int     NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_Votes        int     NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_Votes")]
        public int TRAXDEMO_TS_PROD_Votes { get; set; }

        //TWEAU int     NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_Votes   int     NULL,
        [DbColumn(Name = "TWEAU_Votes")]
        public int TWEAU_Votes { get; set; }

        //RI_DEMO2      int     NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_Votes        int     NULL,
        [DbColumn(Name = "RI_DEMO2_Votes")]
        public int RI_DEMO2_Votes { get; set; }

        //COMPASSCCH_SAND       int     NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_Votes int     NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_Votes")]
        public int COMPASSCCH_SAND_Votes { get; set; }

        //LAVAZZAIT_SAND        int     NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_Votes  int     NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_Votes")]
        public int LAVAZZAIT_SAND_Votes { get; set; }

        //INBEVUS_STG   int     NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_Votes     int     NULL,
        [DbColumn(Name = "INBEVUS_STG_Votes")]
        public int INBEVUS_STG_Votes { get; set; }

        //LAVAZZAFR_SAND        int     NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_Votes  int     NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_Votes")]
        public int LAVAZZAFR_SAND_Votes { get; set; }

        //INBEVBE_SAND2 int     NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_Votes   int     NULL,
        [DbColumn(Name = "INBEVBE_SAND2_Votes")]
        public int INBEVBE_SAND2_Votes { get; set; }

        //INBEVLU_SAND2 int     NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_Votes   int     NULL,
        [DbColumn(Name = "INBEVLU_SAND2_Votes")]
        public int INBEVLU_SAND2_Votes { get; set; }

        //INBEVNL_SAND2 int     NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_Votes   int     NULL,
        [DbColumn(Name = "INBEVNL_SAND2_Votes")]
        public int INBEVNL_SAND2_Votes { get; set; }

        //CreatedBy [varchar](50) NULL,
        [DbColumn(Name = "CreatedBy")]
        public string CreatedBy { get; set; }

        [DbColumn(Name = "ImportedDate")]
        public string ImportedDate { get; set; }

        [DbColumn(Name = "ImportedYear")]
        public string ImportedYear { get; set; }

        [DbColumn(Name = "B2BRU")]
        public int B2BRU { get; set; }

        [DbColumn(Name = "BRMUS")]
        public int BRMUS { get; set; }

        [DbColumn(Name = "CBCIL")]
        public int CBCIL { get; set; }

        [DbColumn(Name = "CCCOOLERMX")]
        public int CCCOOLERMX { get; set; }

        [DbColumn(Name = "DIAGEOAR")]
        public int DIAGEOAR { get; set; }

        [DbColumn(Name = "DIAGEOBENELUX")]
        public int DIAGEOBENELUX { get; set; }

        [DbColumn(Name = "DIAGEOCH")]
        public int DIAGEOCH { get; set; }

        [DbColumn(Name = "DIAGEOGA")]
        public int DIAGEOGA { get; set; }

        [DbColumn(Name = "DIAGEOGTR")]
        public int DIAGEOGTR { get; set; }

        [DbColumn(Name = "DIAGEONORDICS")]
        public int DIAGEONORDICS { get; set; }

        [DbColumn(Name = "DIAGEOUS")]
        public int DIAGEOUS { get; set; }

        [DbColumn(Name = "FERREROEXTIT")]
        public int FERREROEXTIT { get; set; }

        [DbColumn(Name = "GOOGLEHK")]
        public int GOOGLEHK { get; set; }

        [DbColumn(Name = "HEINEKENPILOTCN")]
        public int HEINEKENPILOTCN { get; set; }

        [DbColumn(Name = "IMBO")]
        public int IMBO { get; set; }

        [DbColumn(Name = "INBEVCI")]
        public int INBEVCI { get; set; }

        [DbColumn(Name = "INBEVCNTT")]
        public int INBEVCNTT { get; set; }

        [DbColumn(Name = "INBEVCO")]
        public int INBEVCO { get; set; }

        [DbColumn(Name = "INBEVZA")]
        public int INBEVZA { get; set; }

        [DbColumn(Name = "INORU")]
        public int INORU { get; set; }

        [DbColumn(Name = "JJSP")]
        public int JJSP { get; set; }

        [DbColumn(Name = "JNJES")]
        public int JNJES { get; set; }

        [DbColumn(Name = "JNJUK")]
        public int JNJUK { get; set; }

        [DbColumn(Name = "JRIJP")]
        public int JRIJP { get; set; }

        [DbColumn(Name = "KELLOGSUSPOC")]
        public int KELLOGSUSPOC { get; set; }

        [DbColumn(Name = "KRAFTUS")]
        public int KRAFTUS { get; set; }

        [DbColumn(Name = "MARS_CHOCO_RU")]
        public int MARS_CHOCO_RU { get; set; }

        [DbColumn(Name = "MHUK")]
        public int MHUK { get; set; }

        [DbColumn(Name = "MILLERCOORS")]
        public int MILLERCOORS { get; set; }

        [DbColumn(Name = "MOLSONONTRADEUK")]
        public int MOLSONONTRADEUK { get; set; }

        [DbColumn(Name = "MYCHEMISTAU")]
        public int MYCHEMISTAU { get; set; }

        [DbColumn(Name = "NESTLEROAMLERUK")]
        public int NESTLEROAMLERUK { get; set; }

        [DbColumn(Name = "NRF2018")]
        public int NRF2018 { get; set; }

        [DbColumn(Name = "PENAFLORAR")]
        public int PENAFLORAR { get; set; }

        [DbColumn(Name = "PMIUA")]
        public int PMIUA { get; set; }

        [DbColumn(Name = "PNGAMERICA")]
        public int PNGAMERICA { get; set; }

        [DbColumn(Name = "PNGRO")]
        public int PNGRO { get; set; }

        [DbColumn(Name = "RBAU")]
        public int RBAU { get; set; }

        [DbColumn(Name = "RBCA")]
        public int RBCA { get; set; }

        [DbColumn(Name = "RBDK")]
        public int RBDK { get; set; }

        [DbColumn(Name = "RBMANUAL")]
        public int RBMANUAL { get; set; }

        [DbColumn(Name = "RINIELSENRU_MARS")]
        public int RINIELSENRU_MARS { get; set; }

        [DbColumn(Name = "RINIELSENUSQI")]
        public int RINIELSENUSQI { get; set; }

        [DbColumn(Name = "RIPANELCN")]
        public int RIPANELCN { get; set; }

        [DbColumn(Name = "RISPARKWINEDE")]
        public int RISPARKWINEDE { get; set; }

        [DbColumn(Name = "SANOFIAE")]
        public int SANOFIAE { get; set; }

        [DbColumn(Name = "SANOFIAU")]
        public int SANOFIAU { get; set; }

        [DbColumn(Name = "SANOFIHK")]
        public int SANOFIHK { get; set; }

        [DbColumn(Name = "SANOFIKH")]
        public int SANOFIKH { get; set; }

        [DbColumn(Name = "SANOFINZ")]
        public int SANOFINZ { get; set; }

        [DbColumn(Name = "SANOFIRU")]
        public int SANOFIRU { get; set; }

        [DbColumn(Name = "SANOFITR")]
        public int SANOFITR { get; set; }

        [DbColumn(Name = "SANOFIUA")]
        public int SANOFIUA { get; set; }

        [DbColumn(Name = "SHUFERSALIL")]
        public int SHUFERSALIL { get; set; }

        [DbColumn(Name = "SUNTORYJP")]
        public int SUNTORYJP { get; set; }

        [DbColumn(Name = "TESCOTH")]
        public int TESCOTH { get; set; }

        [DbColumn(Name = "TESCOUK")]
        public int TESCOUK { get; set; }

        [DbColumn(Name = "TRAXROBOT")]
        public int TRAXROBOT { get; set; }

        [DbColumn(Name = "XSUITE_SHOWCASE")]
        public int XSUITE_SHOWCASE { get; set; }

        [DbColumn(Name = "ABIUS")]
        public int ABIUS { get; set; }

        [DbColumn(Name = "BADGERROBOT")]
        public int BADGERROBOT { get; set; }

        [DbColumn(Name = "CUBAU")]
        public int CUBAU { get; set; }

        [DbColumn(Name = "DIAGEORU")]
        public int DIAGEORU { get; set; }

        [DbColumn(Name = "GFKFR")]
        public int GFKFR { get; set; }

        [DbColumn(Name = "JNJIT")]
        public int JNJIT { get; set; }

        [DbColumn(Name = "LIGHTTRAX")]
        public int LIGHTTRAX { get; set; }

        [DbColumn(Name = "LIGHTTRAXOFFLINE")]
        public int LIGHTTRAXOFFLINE { get; set; }

        [DbColumn(Name = "RINIELSENFR")]
        public int RINIELSENFR { get; set; }

        [DbColumn(Name = "SANOFIKZ")]
        public int SANOFIKZ { get; set; }

        [DbColumn(Name = "SANOFILB")]
        public int SANOFILB { get; set; }

        [DbColumn(Name = "SANOFISA")]
        public int SANOFISA { get; set; }

        [DbColumn(Name = "SANOFIZA")]
        public int SANOFIZA { get; set; }

        [DbColumn(Name = "WATSONSHK")]
        public int WATSONSHK { get; set; }

        [DbColumn(Name = "KELLOGGUS")]
        public int KELLOGGUS { get; set; }

        [DbColumn(Name = "TSINGTAOBEERCN")]
        public int TSINGTAOBEERCN { get; set; }
    }
}