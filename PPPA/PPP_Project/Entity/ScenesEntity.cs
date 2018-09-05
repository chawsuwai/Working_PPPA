using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Scenes")]
    public class ScenesEntity : EntityBase
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

        //TotalScenes	int	NULL,
        [DbColumn(Name = "TotalScenes")]
        public int TotalScenes { get; set; }

        //AvgsecondsperScenes	int	NULL,
        [DbColumn(Name = "AvgsecondsperScenes")]
        public int AvgsecondsperScenes { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_Scenes	int	NULL,
        [DbColumn(Name = "ABICA_Scenes")]
        public int ABICA_Scenes { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_Scenes	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_Scenes")]
        public int ABITAMSUS_PROD_Scenes { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_Scenes")]
        public int AMERICAS_DEMO_Scenes { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_Scenes	int	NULL,
        [DbColumn(Name = "BATRU_Scenes")]
        public int BATRU_Scenes { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_Scenes	int	NULL,
        [DbColumn(Name = "BIKR_Scenes")]
        public int BIKR_Scenes { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_Scenes	int	NULL,
        [DbColumn(Name = "BIMY_Scenes")]
        public int BIMY_Scenes { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_Scenes	int	NULL,
        [DbColumn(Name = "BIPH_Scenes")]
        public int BIPH_Scenes { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_Scenes	int	NULL,
        [DbColumn(Name = "BISEASK_Scenes")]
        public int BISEASK_Scenes { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_Scenes	int	NULL,
        [DbColumn(Name = "BITH_Scenes")]
        public int BITH_Scenes { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_Scenes	int	NULL,
        [DbColumn(Name = "BIVN_Scenes")]
        public int BIVN_Scenes { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_Scenes	int	NULL,
        [DbColumn(Name = "BPAU_Scenes")]
        public int BPAU_Scenes { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_Scenes	int	NULL,
        [DbColumn(Name = "BRODMANN_Scenes")]
        public int BRODMANN_Scenes { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_Scenes	int	NULL,
        [DbColumn(Name = "CARREFOURAR_Scenes")]
        public int CARREFOURAR_Scenes { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_Scenes	int	NULL,
        [DbColumn(Name = "CCAAU_Scenes")]
        public int CCAAU_Scenes { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_Scenes	int	NULL,
        [DbColumn(Name = "CCABIZA_Scenes")]
        public int CCABIZA_Scenes { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_Scenes	int	NULL,
        [DbColumn(Name = "CCANZ_Scenes")]
        public int CCANZ_Scenes { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_Scenes	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_Scenes")]
        public int CCBOTTLERSUS_Scenes { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_Scenes	int	NULL,
        [DbColumn(Name = "CCBR_PROD_Scenes")]
        public int CCBR_PROD_Scenes { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_Scenes	int	NULL,
        [DbColumn(Name = "CCJP_Scenes")]
        public int CCJP_Scenes { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_Scenes	int	NULL,
        [DbColumn(Name = "CCKH_Scenes")]
        public int CCKH_Scenes { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_Scenes	int	NULL,
        [DbColumn(Name = "CCKR_Scenes")]
        public int CCKR_Scenes { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_Scenes	int	NULL,
        [DbColumn(Name = "CCMY_Scenes")]
        public int CCMY_Scenes { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_Scenes	int	NULL,
        [DbColumn(Name = "CCPH_Scenes")]
        public int CCPH_Scenes { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_Scenes	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_Scenes")]
        public int CCRPR_PROD_Scenes { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_Scenes	int	NULL,
        [DbColumn(Name = "CCRU_Scenes")]
        public int CCRU_Scenes { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_Scenes	int	NULL,
        [DbColumn(Name = "CCTH_Scenes")]
        public int CCTH_Scenes { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_Scenes	int	NULL,
        [DbColumn(Name = "CCTH_UAT_Scenes")]
        public int CCTH_UAT_Scenes { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_Scenes	int	NULL,
        [DbColumn(Name = "CCTRADMX_Scenes")]
        public int CCTRADMX_Scenes { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_Scenes	int	NULL,
        [DbColumn(Name = "CCUS_Scenes")]
        public int CCUS_Scenes { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_Scenes	int	NULL,
        [DbColumn(Name = "CCZA_Scenes")]
        public int CCZA_Scenes { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_Scenes	int	NULL,
        [DbColumn(Name = "CEREBOSTH_Scenes")]
        public int CEREBOSTH_Scenes { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_Scenes	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_Scenes")]
        public int CROWDSOURCE_Scenes { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOAU_Scenes")]
        public int DIAGEOAU_Scenes { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOBR_Scenes")]
        public int DIAGEOBR_Scenes { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOGR_Scenes")]
        public int DIAGEOGR_Scenes { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOIE_Scenes")]
        public int DIAGEOIE_Scenes { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOKE_Scenes")]
        public int DIAGEOKE_Scenes { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOMX_Scenes")]
        public int DIAGEOMX_Scenes { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOPT_Scenes")]
        public int DIAGEOPT_Scenes { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOTW_Scenes")]
        public int DIAGEOTW_Scenes { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOUK_Scenes")]
        public int DIAGEOUK_Scenes { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_Scenes	int	NULL,
        [DbColumn(Name = "DIAGEOZA_Scenes")]
        public int DIAGEOZA_Scenes { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_Scenes")]
        public int EMEA_DEMO_Scenes { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_Scenes	int	NULL,
        [DbColumn(Name = "FERREROIT_Scenes")]
        public int FERREROIT_Scenes { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_Scenes	int	NULL,
        [DbColumn(Name = "GILLETTEUS_Scenes")]
        public int GILLETTEUS_Scenes { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_Scenes	int	NULL,
        [DbColumn(Name = "GOOGLEUS_Scenes")]
        public int GOOGLEUS_Scenes { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_Scenes	int	NULL,
        [DbColumn(Name = "HBCDE_Scenes")]
        public int HBCDE_Scenes { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_Scenes	int	NULL,
        [DbColumn(Name = "HEINEKENCN_Scenes")]
        public int HEINEKENCN_Scenes { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_Scenes	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_Scenes")]
        public int HEINEKENUS_PROD_Scenes { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_Scenes	int	NULL,
        [DbColumn(Name = "HEINZCR_Scenes")]
        public int HEINZCR_Scenes { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_Scenes	int	NULL,
        [DbColumn(Name = "INBEVAR_Scenes")]
        public int INBEVAR_Scenes { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_Scenes	int	NULL,
        [DbColumn(Name = "INBEVBE_Scenes")]
        public int INBEVBE_Scenes { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_Scenes	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_Scenes")]
        public int INBEVBE_SAND_Scenes { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_Scenes	int	NULL,
        [DbColumn(Name = "INBEVBR_Scenes")]
        public int INBEVBR_Scenes { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_Scenes	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_Scenes")]
        public int INBEVBR_ONTRADE_Scenes { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_Scenes	int	NULL,
        [DbColumn(Name = "INBEVCL_Scenes")]
        public int INBEVCL_Scenes { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_Scenes	int	NULL,
        [DbColumn(Name = "INBEVCN_Scenes")]
        public int INBEVCN_Scenes { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_Scenes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_Scenes")]
        public int INBEVCOOLERAR_Scenes { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_Scenes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_Scenes")]
        public int INBEVCOOLERBR_Scenes { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_Scenes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_Scenes")]
        public int INBEVCOOLERUS_Scenes { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_Scenes	int	NULL,
        [DbColumn(Name = "INBEVFR_Scenes")]
        public int INBEVFR_Scenes { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_Scenes	int	NULL,
        [DbColumn(Name = "INBEVLU_Scenes")]
        public int INBEVLU_Scenes { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_Scenes	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_Scenes")]
        public int INBEVLU_SAND_Scenes { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_Scenes	int	NULL,
        [DbColumn(Name = "INBEVMX_Scenes")]
        public int INBEVMX_Scenes { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_Scenes	int	NULL,
        [DbColumn(Name = "INBEVNL_Scenes")]
        public int INBEVNL_Scenes { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_Scenes	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_Scenes")]
        public int INBEVNL_SAND_Scenes { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_Scenes	int	NULL,
        [DbColumn(Name = "INBEVPY_Scenes")]
        public int INBEVPY_Scenes { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_Scenes	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_Scenes")]
        public int INBEVTRADMX_Scenes { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_Scenes	int	NULL,
        [DbColumn(Name = "INBEVUS_Scenes")]
        public int INBEVUS_Scenes { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_Scenes	int	NULL,
        [DbColumn(Name = "JTIUA_Scenes")]
        public int JTIUA_Scenes { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_Scenes	int	NULL,
        [DbColumn(Name = "KCMY_Scenes")]
        public int KCMY_Scenes { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_Scenes	int	NULL,
        [DbColumn(Name = "KCUS_Scenes")]
        public int KCUS_Scenes { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_Scenes	int	NULL,
        [DbColumn(Name = "KEURIGCA_Scenes")]
        public int KEURIGCA_Scenes { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_Scenes	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_Scenes")]
        public int LABATTPLNOPTCA_Scenes { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_Scenes")]
        public int LAVAZZAAT_Scenes { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_Scenes")]
        public int LAVAZZAAU_Scenes { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZABE_Scenes")]
        public int LAVAZZABE_Scenes { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZABG_Scenes")]
        public int LAVAZZABG_Scenes { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZACA_Scenes")]
        public int LAVAZZACA_Scenes { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZACH_Scenes")]
        public int LAVAZZACH_Scenes { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZACL_Scenes")]
        public int LAVAZZACL_Scenes { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZACN_Scenes")]
        public int LAVAZZACN_Scenes { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_Scenes")]
        public int LAVAZZACZ_Scenes { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZADE_Scenes")]
        public int LAVAZZADE_Scenes { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZADK_Scenes")]
        public int LAVAZZADK_Scenes { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_Scenes")]
        public int LAVAZZAEE_Scenes { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAES_Scenes")]
        public int LAVAZZAES_Scenes { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_Scenes")]
        public int LAVAZZAFR_Scenes { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_Scenes")]
        public int LAVAZZAGR_Scenes { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_Scenes")]
        public int LAVAZZAHK_Scenes { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_Scenes")]
        public int LAVAZZAHR_Scenes { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_Scenes")]
        public int LAVAZZAIL_Scenes { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_Scenes")]
        public int LAVAZZAIT_Scenes { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_Scenes")]
        public int LAVAZZAJP_Scenes { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_Scenes")]
        public int LAVAZZAKR_Scenes { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZALT_Scenes")]
        public int LAVAZZALT_Scenes { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZALU_Scenes")]
        public int LAVAZZALU_Scenes { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZALV_Scenes")]
        public int LAVAZZALV_Scenes { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_Scenes")]
        public int LAVAZZAMA_Scenes { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZANL_Scenes")]
        public int LAVAZZANL_Scenes { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_Scenes")]
        public int LAVAZZAPL_Scenes { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZARO_Scenes")]
        public int LAVAZZARO_Scenes { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZARU_Scenes")]
        public int LAVAZZARU_Scenes { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZASA_Scenes")]
        public int LAVAZZASA_Scenes { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZASE_Scenes")]
        public int LAVAZZASE_Scenes { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZASG_Scenes")]
        public int LAVAZZASG_Scenes { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_Scenes")]
        public int LAVAZZAUAE_Scenes { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_Scenes")]
        public int LAVAZZAUK_Scenes { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_Scenes")]
        public int LAVAZZAUS_Scenes { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_Scenes")]
        public int LAVAZZAZA_Scenes { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_Scenes	int	NULL,
        [DbColumn(Name = "LRSUK_Scenes")]
        public int LRSUK_Scenes { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_Scenes	int	NULL,
        [DbColumn(Name = "MARSBR_Scenes")]
        public int MARSBR_Scenes { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_Scenes	int	NULL,
        [DbColumn(Name = "MARSIN_Scenes")]
        public int MARSIN_Scenes { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_Scenes	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_Scenes")]
        public int MARSIN_OLD_Scenes { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_Scenes	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_Scenes")]
        public int MARSRU_PROD_Scenes { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_Scenes	int	NULL,
        [DbColumn(Name = "MAYORAID_Scenes")]
        public int MAYORAID_Scenes { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_Scenes	int	NULL,
        [DbColumn(Name = "MJNCN_Scenes")]
        public int MJNCN_Scenes { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_Scenes	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_Scenes")]
        public int MOLSONCOOLERHN_Scenes { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_Scenes	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_Scenes")]
        public int MOLSONCOOLERHR_Scenes { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_Scenes	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_Scenes")]
        public int MOLSONCOORSUK_Scenes { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_Scenes	int	NULL,
        [DbColumn(Name = "NESTLEUK_Scenes")]
        public int NESTLEUK_Scenes { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_Scenes	int	NULL,
        [DbColumn(Name = "NIVEAUK_Scenes")]
        public int NIVEAUK_Scenes { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_Scenes")]
        public int NRF2017_DEMO_Scenes { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_Scenes")]
        public int ONE_AMERICAS_DEMO_Scenes { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_Scenes")]
        public int ONE_APAC_DEMO_Scenes { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_Scenes	int	NULL,
        [DbColumn(Name = "PEPSICOBR_Scenes")]
        public int PEPSICOBR_Scenes { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_Scenes	int	NULL,
        [DbColumn(Name = "PNGAU_Scenes")]
        public int PNGAU_Scenes { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_Scenes	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_Scenes")]
        public int PNGAU_OLD_Scenes { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_Scenes	int	NULL,
        [DbColumn(Name = "PNGCAREUS_Scenes")]
        public int PNGCAREUS_Scenes { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_Scenes	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_Scenes")]
        public int PNGCN_PROD_Scenes { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_Scenes	int	NULL,
        [DbColumn(Name = "PNGJP_Scenes")]
        public int PNGJP_Scenes { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_Scenes	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_Scenes")]
        public int PNGJP_OLD_Scenes { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_Scenes	int	NULL,
        [DbColumn(Name = "PNGUS_Scenes")]
        public int PNGUS_Scenes { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_Scenes	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_Scenes")]
        public int PNGUSEPISODIC_Scenes { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_Scenes	int	NULL,
        [DbColumn(Name = "RBUS_Scenes")]
        public int RBUS_Scenes { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_Scenes")]
        public int RE_XSUITE_DEMO_Scenes { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_Scenes")]
        public int REPNGCN_DEMO_Scenes { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "RI_DEMO_Scenes")]
        public int RI_DEMO_Scenes { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_Scenes	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_Scenes")]
        public int RI_DIAGEOAU_Scenes { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_Scenes	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_Scenes")]
        public int RIALCBEVUK_PROD_Scenes { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_Scenes	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_Scenes")]
        public int RICOFFEEUS_Scenes { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_Scenes	int	NULL,
        [DbColumn(Name = "RINIELSENUS_Scenes")]
        public int RINIELSENUS_Scenes { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_Scenes	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_Scenes")]
        public int RIPETCAREUK_PROD_Scenes { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_Scenes	int	NULL,
        [DbColumn(Name = "RIUS_Scenes")]
        public int RIUS_Scenes { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_Scenes	int	NULL,
        [DbColumn(Name = "RIUS_DEV_Scenes")]
        public int RIUS_DEV_Scenes { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_Scenes	int	NULL,
        [DbColumn(Name = "RNBDE_Scenes")]
        public int RNBDE_Scenes { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_Scenes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_Scenes")]
        public int SMARTCOOLER_POC2_Scenes { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_Scenes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_Scenes")]
        public int SMARTCOOLER_TRN_Scenes { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_Scenes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_Scenes")]
        public int SMARTCOOLER2_TRN_Scenes { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_Scenes	int	NULL,
        [DbColumn(Name = "SOLARBR_Scenes")]
        public int SOLARBR_Scenes { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_Scenes	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_Scenes")]
        public int STATIC_CAMERA_DEMO_Scenes { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_Scenes	int	NULL,
        [DbColumn(Name = "SWIRECN_Scenes")]
        public int SWIRECN_Scenes { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_Scenes	int	NULL,
        [DbColumn(Name = "SWIREREDCN_Scenes")]
        public int SWIREREDCN_Scenes { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_Scenes	int	NULL,
        [DbColumn(Name = "TNUVAIL_Scenes")]
        public int TNUVAIL_Scenes { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_Scenes	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_Scenes")]
        public int TRAXDEMO_TS_PROD_Scenes { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_Scenes	int	NULL,
        [DbColumn(Name = "TWEAU_Scenes")]
        public int TWEAU_Scenes { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_Scenes	int	NULL,
        [DbColumn(Name = "RI_DEMO2_Scenes")]
        public int RI_DEMO2_Scenes { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_Scenes	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_Scenes")]
        public int COMPASSCCH_SAND_Scenes { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_Scenes")]
        public int LAVAZZAIT_SAND_Scenes { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_Scenes	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_Scenes")]
        public int INBEVUS_STG_Scenes { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_Scenes	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_Scenes")]
        public int LAVAZZAFR_SAND_Scenes { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_Scenes	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_Scenes")]
        public int INBEVBE_SAND2_Scenes { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_Scenes	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_Scenes")]
        public int INBEVLU_SAND2_Scenes { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_Scenes	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_Scenes")]
        public int INBEVNL_SAND2_Scenes { get; set; }

        //CreatedBy [varchar](50) NULL,
        [DbColumn(Name = "CreatedBy")]
        public string CreatedBy { get; set; }

        [DbColumn(Name = "ImportedDate")]
        public string ImportedDate { get; set; }

        [DbColumn(Name = "ImportedYear")]
        public string ImportedYear { get; set; }

        [DbColumn(Name = "B2BRU_Scenes")]
        public int B2BRU_Scenes { get; set; }

        [DbColumn(Name = "BRMUS_Scenes")]
        public int BRMUS_Scenes { get; set; }

        [DbColumn(Name = "CBCIL_Scenes")]
        public int CBCIL_Scenes { get; set; }

        [DbColumn(Name = "CCCOOLERMX_Scenes")]
        public int CCCOOLERMX_Scenes { get; set; }

        [DbColumn(Name = "DIAGEOAR_Scenes")]
        public int DIAGEOAR_Scenes { get; set; }

        [DbColumn(Name = "DIAGEOBENELUX_Scenes")]
        public int DIAGEOBENELUX_Scenes { get; set; }

        [DbColumn(Name = "DIAGEOCH_Scenes")]
        public int DIAGEOCH_Scenes { get; set; }

        [DbColumn(Name = "DIAGEOGA_Scenes")]
        public int DIAGEOGA_Scenes { get; set; }

        [DbColumn(Name = "DIAGEOGTR_Scenes")]
        public int DIAGEOGTR_Scenes { get; set; }

        [DbColumn(Name = "DIAGEONORDICS_Scenes")]
        public int DIAGEONORDICS_Scenes { get; set; }

        [DbColumn(Name = "DIAGEOUS_Scenes")]
        public int DIAGEOUS_Scenes { get; set; }

        [DbColumn(Name = "FERREROEXTIT_Scenes")]
        public int FERREROEXTIT_Scenes { get; set; }

        [DbColumn(Name = "GOOGLEHK_Scenes")]
        public int GOOGLEHK_Scenes { get; set; }

        [DbColumn(Name = "HEINEKENPILOTCN_Scenes")]
        public int HEINEKENPILOTCN_Scenes { get; set; }

        [DbColumn(Name = "IMBO_Scenes")]
        public int IMBO_Scenes { get; set; }

        [DbColumn(Name = "INBEVCI_Scenes")]
        public int INBEVCI_Scenes { get; set; }

        [DbColumn(Name = "INBEVCNTT_Scenes")]
        public int INBEVCNTT_Scenes { get; set; }

        [DbColumn(Name = "INBEVCO_Scenes")]
        public int INBEVCO_Scenes { get; set; }

        [DbColumn(Name = "INBEVZA_Scenes")]
        public int INBEVZA_Scenes { get; set; }

        [DbColumn(Name = "INORU_Scenes")]
        public int INORU_Scenes { get; set; }

        [DbColumn(Name = "JJSP_Scenes")]
        public int JJSP_Scenes { get; set; }

        [DbColumn(Name = "JNJES_Scenes")]
        public int JNJES_Scenes { get; set; }

        [DbColumn(Name = "JNJUK_Scenes")]
        public int JNJUK_Scenes { get; set; }

        [DbColumn(Name = "JRIJP_Scenes")]
        public int JRIJP_Scenes { get; set; }

        [DbColumn(Name = "KELLOGSUSPOC_Scenes")]
        public int KELLOGSUSPOC_Scenes { get; set; }

        [DbColumn(Name = "KRAFTUS_Scenes")]
        public int KRAFTUS_Scenes { get; set; }

        [DbColumn(Name = "MARS_CHOCO_RU_Scenes")]
        public int MARS_CHOCO_RU_Scenes { get; set; }

        [DbColumn(Name = "MHUK_Scenes")]
        public int MHUK_Scenes { get; set; }

        [DbColumn(Name = "MILLERCOORS_Scenes")]
        public int MILLERCOORS_Scenes { get; set; }

        [DbColumn(Name = "MOLSONONTRADEUK_Scenes")]
        public int MOLSONONTRADEUK_Scenes { get; set; }

        [DbColumn(Name = "MYCHEMISTAU_Scenes")]
        public int MYCHEMISTAU_Scenes { get; set; }

        [DbColumn(Name = "NESTLEROAMLERUK_Scenes")]
        public int NESTLEROAMLERUK_Scenes { get; set; }

        [DbColumn(Name = "NRF2018_Scenes")]
        public int NRF2018_Scenes { get; set; }

        [DbColumn(Name = "PENAFLORAR_Scenes")]
        public int PENAFLORAR_Scenes { get; set; }

        [DbColumn(Name = "PMIUA_Scenes")]
        public int PMIUA_Scenes { get; set; }

        [DbColumn(Name = "PNGAMERICA_Scenes")]
        public int PNGAMERICA_Scenes { get; set; }

        [DbColumn(Name = "PNGRO_Scenes")]
        public int PNGRO_Scenes { get; set; }

        [DbColumn(Name = "RBAU_Scenes")]
        public int RBAU_Scenes { get; set; }

        [DbColumn(Name = "RBCA_Scenes")]
        public int RBCA_Scenes { get; set; }

        [DbColumn(Name = "RBDK_Scenes")]
        public int RBDK_Scenes { get; set; }

        [DbColumn(Name = "RBMANUAL_Scenes")]
        public int RBMANUAL_Scenes { get; set; }

        [DbColumn(Name = "RINIELSENRU_MARS_Scenes")]
        public int RINIELSENRU_MARS_Scenes { get; set; }

        [DbColumn(Name = "RINIELSENUSQI_Scenes")]
        public int RINIELSENUSQI_Scenes { get; set; }

        [DbColumn(Name = "RIPANELCN_Scenes")]
        public int RIPANELCN_Scenes { get; set; }

        [DbColumn(Name = "RISPARKWINEDE_Scenes")]
        public int RISPARKWINEDE_Scenes { get; set; }

        [DbColumn(Name = "SANOFIAE_Scenes")]
        public int SANOFIAE_Scenes { get; set; }

        [DbColumn(Name = "SANOFIAU_Scenes")]
        public int SANOFIAU_Scenes { get; set; }

        [DbColumn(Name = "SANOFIHK_Scenes")]
        public int SANOFIHK_Scenes { get; set; }

        [DbColumn(Name = "SANOFIKH_Scenes")]
        public int SANOFIKH_Scenes { get; set; }

        [DbColumn(Name = "SANOFINZ_Scenes")]
        public int SANOFINZ_Scenes { get; set; }

        [DbColumn(Name = "SANOFIRU_Scenes")]
        public int SANOFIRU_Scenes { get; set; }

        [DbColumn(Name = "SANOFITR_Scenes")]
        public int SANOFITR_Scenes { get; set; }

        [DbColumn(Name = "SANOFIUA_Scenes")]
        public int SANOFIUA_Scenes { get; set; }

        [DbColumn(Name = "SHUFERSALIL_Scenes")]
        public int SHUFERSALIL_Scenes { get; set; }

        [DbColumn(Name = "SUNTORYJP_Scenes")]
        public int SUNTORYJP_Scenes { get; set; }

        [DbColumn(Name = "TESCOTH_Scenes")]
        public int TESCOTH_Scenes { get; set; }

        [DbColumn(Name = "TESCOUK_Scenes")]
        public int TESCOUK_Scenes { get; set; }

        [DbColumn(Name = "TRAXROBOT_Scenes")]
        public int TRAXROBOT_Scenes { get; set; }

        [DbColumn(Name = "XSUITE_SHOWCASE_Scenes")]
        public int XSUITE_SHOWCASE_Scenes { get; set; }

        [DbColumn(Name = "ABIUS_Scenes")]
        public int ABIUS_Scenes { get; set; }

        [DbColumn(Name = "BADGERROBOT_Scenes")]
        public int BADGERROBOT_Scenes { get; set; }

        [DbColumn(Name = "CUBAU_Scenes")]
        public int CUBAU_Scenes { get; set; }

        [DbColumn(Name = "DIAGEORU_Scenes")]
        public int DIAGEORU_Scenes { get; set; }

        [DbColumn(Name = "GFKFR_Scenes")]
        public int GFKFR_Scenes { get; set; }

        [DbColumn(Name = "JNJIT_Scenes")]
        public int JNJIT_Scenes { get; set; }

        [DbColumn(Name = "LIGHTTRAX_Scenes")]
        public int LIGHTTRAX_Scenes { get; set; }

        [DbColumn(Name = "LIGHTTRAXOFFLINE_Scenes")]
        public int LIGHTTRAXOFFLINE_Scenes { get; set; }

        [DbColumn(Name = "RINIELSENFR_Scenes")]
        public int RINIELSENFR_Scenes { get; set; }

        [DbColumn(Name = "SANOFIKZ_Scenes")]
        public int SANOFIKZ_Scenes { get; set; }

        [DbColumn(Name = "SANOFILB_Scenes")]
        public int SANOFILB_Scenes { get; set; }

        [DbColumn(Name = "SANOFISA_Scenes")]
        public int SANOFISA_Scenes { get; set; }

        [DbColumn(Name = "SANOFIZA_Scenes")]
        public int SANOFIZA_Scenes { get; set; }

        [DbColumn(Name = "WATSONSHK_Scenes")]
        public int WATSONSHK_Scenes { get; set; }

        [DbColumn(Name = "KELLOGGUS_Scenes")]
        public int KELLOGGUS_Scenes { get; set; }

        [DbColumn(Name = "TSINGTAOBEERCN_Scenes")]
        public int TSINGTAOBEERCN_Scenes { get; set; }
    }
}