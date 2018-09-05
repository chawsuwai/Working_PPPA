using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "SceneRecognition")]
    public class SceneRecognitionEntity : EntityBase
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

        //TotalSceneRecognition	int	NULL,
        [DbColumn(Name = "TotalSceneRecognition")]
        public int TotalSceneRecognition { get; set; }

        //Avgsecondsper_SceneRecognition	int	NULL,
        [DbColumn(Name = "Avgsecondsper_SceneRecognition")]
        public int Avgsecondsper_SceneRecognition { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_SceneRecognition	int	NULL,
        [DbColumn(Name = "ABICA_SceneRecognition")]
        public int ABICA_SceneRecognition { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_SceneRecognition")]
        public int ABITAMSUS_PROD_SceneRecognition { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_SceneRecognition")]
        public int AMERICAS_DEMO_SceneRecognition { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_SceneRecognition	int	NULL,
        [DbColumn(Name = "BATRU_SceneRecognition")]
        public int BATRU_SceneRecognition { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_SceneRecognition	int	NULL,
        [DbColumn(Name = "BIKR_SceneRecognition")]
        public int BIKR_SceneRecognition { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_SceneRecognition	int	NULL,
        [DbColumn(Name = "BIMY_SceneRecognition")]
        public int BIMY_SceneRecognition { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_SceneRecognition	int	NULL,
        [DbColumn(Name = "BIPH_SceneRecognition")]
        public int BIPH_SceneRecognition { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_SceneRecognition	int	NULL,
        [DbColumn(Name = "BISEASK_SceneRecognition")]
        public int BISEASK_SceneRecognition { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_SceneRecognition	int	NULL,
        [DbColumn(Name = "BITH_SceneRecognition")]
        public int BITH_SceneRecognition { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_SceneRecognition	int	NULL,
        [DbColumn(Name = "BIVN_SceneRecognition")]
        public int BIVN_SceneRecognition { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "BPAU_SceneRecognition")]
        public int BPAU_SceneRecognition { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_SceneRecognition	int	NULL,
        [DbColumn(Name = "BRODMANN_SceneRecognition")]
        public int BRODMANN_SceneRecognition { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_SceneRecognition	int	NULL,
        [DbColumn(Name = "CARREFOURAR_SceneRecognition")]
        public int CARREFOURAR_SceneRecognition { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCAAU_SceneRecognition")]
        public int CCAAU_SceneRecognition { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCABIZA_SceneRecognition")]
        public int CCABIZA_SceneRecognition { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCANZ_SceneRecognition")]
        public int CCANZ_SceneRecognition { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_SceneRecognition")]
        public int CCBOTTLERSUS_SceneRecognition { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCBR_PROD_SceneRecognition")]
        public int CCBR_PROD_SceneRecognition { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCJP_SceneRecognition")]
        public int CCJP_SceneRecognition { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCKH_SceneRecognition")]
        public int CCKH_SceneRecognition { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCKR_SceneRecognition")]
        public int CCKR_SceneRecognition { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCMY_SceneRecognition")]
        public int CCMY_SceneRecognition { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCPH_SceneRecognition")]
        public int CCPH_SceneRecognition { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_SceneRecognition")]
        public int CCRPR_PROD_SceneRecognition { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCRU_SceneRecognition")]
        public int CCRU_SceneRecognition { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCTH_SceneRecognition")]
        public int CCTH_SceneRecognition { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCTH_UAT_SceneRecognition")]
        public int CCTH_UAT_SceneRecognition { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCTRADMX_SceneRecognition")]
        public int CCTRADMX_SceneRecognition { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCUS_SceneRecognition")]
        public int CCUS_SceneRecognition { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_SceneRecognition	int	NULL,
        [DbColumn(Name = "CCZA_SceneRecognition")]
        public int CCZA_SceneRecognition { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_SceneRecognition	int	NULL,
        [DbColumn(Name = "CEREBOSTH_SceneRecognition")]
        public int CEREBOSTH_SceneRecognition { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_SceneRecognition	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_SceneRecognition")]
        public int CROWDSOURCE_SceneRecognition { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOAU_SceneRecognition")]
        public int DIAGEOAU_SceneRecognition { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOBR_SceneRecognition")]
        public int DIAGEOBR_SceneRecognition { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOGR_SceneRecognition")]
        public int DIAGEOGR_SceneRecognition { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOIE_SceneRecognition")]
        public int DIAGEOIE_SceneRecognition { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOKE_SceneRecognition")]
        public int DIAGEOKE_SceneRecognition { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOMX_SceneRecognition")]
        public int DIAGEOMX_SceneRecognition { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOPT_SceneRecognition")]
        public int DIAGEOPT_SceneRecognition { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOTW_SceneRecognition")]
        public int DIAGEOTW_SceneRecognition { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOUK_SceneRecognition")]
        public int DIAGEOUK_SceneRecognition { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_SceneRecognition	int	NULL,
        [DbColumn(Name = "DIAGEOZA_SceneRecognition")]
        public int DIAGEOZA_SceneRecognition { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_SceneRecognition")]
        public int EMEA_DEMO_SceneRecognition { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_SceneRecognition	int	NULL,
        [DbColumn(Name = "FERREROIT_SceneRecognition")]
        public int FERREROIT_SceneRecognition { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "GILLETTEUS_SceneRecognition")]
        public int GILLETTEUS_SceneRecognition { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "GOOGLEUS_SceneRecognition")]
        public int GOOGLEUS_SceneRecognition { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_SceneRecognition	int	NULL,
        [DbColumn(Name = "HBCDE_SceneRecognition")]
        public int HBCDE_SceneRecognition { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_SceneRecognition	int	NULL,
        [DbColumn(Name = "HEINEKENCN_SceneRecognition")]
        public int HEINEKENCN_SceneRecognition { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_SceneRecognition")]
        public int HEINEKENUS_PROD_SceneRecognition { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_SceneRecognition	int	NULL,
        [DbColumn(Name = "HEINZCR_SceneRecognition")]
        public int HEINZCR_SceneRecognition { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVAR_SceneRecognition")]
        public int INBEVAR_SceneRecognition { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVBE_SceneRecognition")]
        public int INBEVBE_SceneRecognition { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_SceneRecognition")]
        public int INBEVBE_SAND_SceneRecognition { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVBR_SceneRecognition")]
        public int INBEVBR_SceneRecognition { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_SceneRecognition")]
        public int INBEVBR_ONTRADE_SceneRecognition { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVCL_SceneRecognition")]
        public int INBEVCL_SceneRecognition { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVCN_SceneRecognition")]
        public int INBEVCN_SceneRecognition { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_SceneRecognition")]
        public int INBEVCOOLERAR_SceneRecognition { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_SceneRecognition")]
        public int INBEVCOOLERBR_SceneRecognition { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_SceneRecognition")]
        public int INBEVCOOLERUS_SceneRecognition { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVFR_SceneRecognition")]
        public int INBEVFR_SceneRecognition { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVLU_SceneRecognition")]
        public int INBEVLU_SceneRecognition { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_SceneRecognition")]
        public int INBEVLU_SAND_SceneRecognition { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVMX_SceneRecognition")]
        public int INBEVMX_SceneRecognition { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVNL_SceneRecognition")]
        public int INBEVNL_SceneRecognition { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_SceneRecognition")]
        public int INBEVNL_SAND_SceneRecognition { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVPY_SceneRecognition")]
        public int INBEVPY_SceneRecognition { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_SceneRecognition")]
        public int INBEVTRADMX_SceneRecognition { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVUS_SceneRecognition")]
        public int INBEVUS_SceneRecognition { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_SceneRecognition	int	NULL,
        [DbColumn(Name = "JTIUA_SceneRecognition")]
        public int JTIUA_SceneRecognition { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_SceneRecognition	int	NULL,
        [DbColumn(Name = "KCMY_SceneRecognition")]
        public int KCMY_SceneRecognition { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "KCUS_SceneRecognition")]
        public int KCUS_SceneRecognition { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_SceneRecognition	int	NULL,
        [DbColumn(Name = "KEURIGCA_SceneRecognition")]
        public int KEURIGCA_SceneRecognition { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_SceneRecognition	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_SceneRecognition")]
        public int LABATTPLNOPTCA_SceneRecognition { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_SceneRecognition")]
        public int LAVAZZAAT_SceneRecognition { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_SceneRecognition")]
        public int LAVAZZAAU_SceneRecognition { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZABE_SceneRecognition")]
        public int LAVAZZABE_SceneRecognition { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZABG_SceneRecognition")]
        public int LAVAZZABG_SceneRecognition { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZACA_SceneRecognition")]
        public int LAVAZZACA_SceneRecognition { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZACH_SceneRecognition")]
        public int LAVAZZACH_SceneRecognition { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZACL_SceneRecognition")]
        public int LAVAZZACL_SceneRecognition { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZACN_SceneRecognition")]
        public int LAVAZZACN_SceneRecognition { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_SceneRecognition")]
        public int LAVAZZACZ_SceneRecognition { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZADE_SceneRecognition")]
        public int LAVAZZADE_SceneRecognition { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZADK_SceneRecognition")]
        public int LAVAZZADK_SceneRecognition { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_SceneRecognition")]
        public int LAVAZZAEE_SceneRecognition { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAES_SceneRecognition")]
        public int LAVAZZAES_SceneRecognition { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SceneRecognition")]
        public int LAVAZZAFR_SceneRecognition { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_SceneRecognition")]
        public int LAVAZZAGR_SceneRecognition { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_SceneRecognition")]
        public int LAVAZZAHK_SceneRecognition { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_SceneRecognition")]
        public int LAVAZZAHR_SceneRecognition { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_SceneRecognition")]
        public int LAVAZZAIL_SceneRecognition { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SceneRecognition")]
        public int LAVAZZAIT_SceneRecognition { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_SceneRecognition")]
        public int LAVAZZAJP_SceneRecognition { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_SceneRecognition")]
        public int LAVAZZAKR_SceneRecognition { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZALT_SceneRecognition")]
        public int LAVAZZALT_SceneRecognition { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZALU_SceneRecognition")]
        public int LAVAZZALU_SceneRecognition { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZALV_SceneRecognition")]
        public int LAVAZZALV_SceneRecognition { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_SceneRecognition")]
        public int LAVAZZAMA_SceneRecognition { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZANL_SceneRecognition")]
        public int LAVAZZANL_SceneRecognition { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_SceneRecognition")]
        public int LAVAZZAPL_SceneRecognition { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZARO_SceneRecognition")]
        public int LAVAZZARO_SceneRecognition { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZARU_SceneRecognition")]
        public int LAVAZZARU_SceneRecognition { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZASA_SceneRecognition")]
        public int LAVAZZASA_SceneRecognition { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZASE_SceneRecognition")]
        public int LAVAZZASE_SceneRecognition { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZASG_SceneRecognition")]
        public int LAVAZZASG_SceneRecognition { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_SceneRecognition")]
        public int LAVAZZAUAE_SceneRecognition { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_SceneRecognition")]
        public int LAVAZZAUK_SceneRecognition { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_SceneRecognition")]
        public int LAVAZZAUS_SceneRecognition { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_SceneRecognition")]
        public int LAVAZZAZA_SceneRecognition { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_SceneRecognition	int	NULL,
        [DbColumn(Name = "LRSUK_SceneRecognition")]
        public int LRSUK_SceneRecognition { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_SceneRecognition	int	NULL,
        [DbColumn(Name = "MARSBR_SceneRecognition")]
        public int MARSBR_SceneRecognition { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_SceneRecognition	int	NULL,
        [DbColumn(Name = "MARSIN_SceneRecognition")]
        public int MARSIN_SceneRecognition { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_SceneRecognition	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_SceneRecognition")]
        public int MARSIN_OLD_SceneRecognition { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_SceneRecognition")]
        public int MARSRU_PROD_SceneRecognition { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_SceneRecognition	int	NULL,
        [DbColumn(Name = "MAYORAID_SceneRecognition")]
        public int MAYORAID_SceneRecognition { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_SceneRecognition	int	NULL,
        [DbColumn(Name = "MJNCN_SceneRecognition")]
        public int MJNCN_SceneRecognition { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_SceneRecognition	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_SceneRecognition")]
        public int MOLSONCOOLERHN_SceneRecognition { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_SceneRecognition	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_SceneRecognition")]
        public int MOLSONCOOLERHR_SceneRecognition { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_SceneRecognition	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_SceneRecognition")]
        public int MOLSONCOORSUK_SceneRecognition { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_SceneRecognition	int	NULL,
        [DbColumn(Name = "NESTLEUK_SceneRecognition")]
        public int NESTLEUK_SceneRecognition { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_SceneRecognition	int	NULL,
        [DbColumn(Name = "NIVEAUK_SceneRecognition")]
        public int NIVEAUK_SceneRecognition { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_SceneRecognition")]
        public int NRF2017_DEMO_SceneRecognition { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_SceneRecognition")]
        public int ONE_AMERICAS_DEMO_SceneRecognition { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_SceneRecognition")]
        public int ONE_APAC_DEMO_SceneRecognition { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_SceneRecognition	int	NULL,
        [DbColumn(Name = "PEPSICOBR_SceneRecognition")]
        public int PEPSICOBR_SceneRecognition { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGAU_SceneRecognition")]
        public int PNGAU_SceneRecognition { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_SceneRecognition")]
        public int PNGAU_OLD_SceneRecognition { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGCAREUS_SceneRecognition")]
        public int PNGCAREUS_SceneRecognition { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_SceneRecognition")]
        public int PNGCN_PROD_SceneRecognition { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGJP_SceneRecognition")]
        public int PNGJP_SceneRecognition { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_SceneRecognition")]
        public int PNGJP_OLD_SceneRecognition { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGUS_SceneRecognition")]
        public int PNGUS_SceneRecognition { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_SceneRecognition	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_SceneRecognition")]
        public int PNGUSEPISODIC_SceneRecognition { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "RBUS_SceneRecognition")]
        public int RBUS_SceneRecognition { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_SceneRecognition")]
        public int RE_XSUITE_DEMO_SceneRecognition { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_SceneRecognition")]
        public int REPNGCN_DEMO_SceneRecognition { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "RI_DEMO_SceneRecognition")]
        public int RI_DEMO_SceneRecognition { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_SceneRecognition")]
        public int RI_DIAGEOAU_SceneRecognition { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_SceneRecognition")]
        public int RIALCBEVUK_PROD_SceneRecognition { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_SceneRecognition")]
        public int RICOFFEEUS_SceneRecognition { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "RINIELSENUS_SceneRecognition")]
        public int RINIELSENUS_SceneRecognition { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_SceneRecognition")]
        public int RIPETCAREUK_PROD_SceneRecognition { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_SceneRecognition	int	NULL,
        [DbColumn(Name = "RIUS_SceneRecognition")]
        public int RIUS_SceneRecognition { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_SceneRecognition	int	NULL,
        [DbColumn(Name = "RIUS_DEV_SceneRecognition")]
        public int RIUS_DEV_SceneRecognition { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_SceneRecognition	int	NULL,
        [DbColumn(Name = "RNBDE_SceneRecognition")]
        public int RNBDE_SceneRecognition { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_SceneRecognition	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_SceneRecognition")]
        public int SMARTCOOLER_POC2_SceneRecognition { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_SceneRecognition	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_SceneRecognition")]
        public int SMARTCOOLER_TRN_SceneRecognition { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_SceneRecognition	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_SceneRecognition")]
        public int SMARTCOOLER2_TRN_SceneRecognition { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_SceneRecognition	int	NULL,
        [DbColumn(Name = "SOLARBR_SceneRecognition")]
        public int SOLARBR_SceneRecognition { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_SceneRecognition	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_SceneRecognition")]
        public int STATIC_CAMERA_DEMO_SceneRecognition { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_SceneRecognition	int	NULL,
        [DbColumn(Name = "SWIRECN_SceneRecognition")]
        public int SWIRECN_SceneRecognition { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_SceneRecognition	int	NULL,
        [DbColumn(Name = "SWIREREDCN_SceneRecognition")]
        public int SWIREREDCN_SceneRecognition { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_SceneRecognition	int	NULL,
        [DbColumn(Name = "TNUVAIL_SceneRecognition")]
        public int TNUVAIL_SceneRecognition { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_SceneRecognition	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_SceneRecognition")]
        public int TRAXDEMO_TS_PROD_SceneRecognition { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_SceneRecognition	int	NULL,
        [DbColumn(Name = "TWEAU_SceneRecognition")]
        public int TWEAU_SceneRecognition { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_SceneRecognition	int	NULL,
        [DbColumn(Name = "RI_DEMO2_SceneRecognition")]
        public int RI_DEMO2_SceneRecognition { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_SceneRecognition	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_SceneRecognition")]
        public int COMPASSCCH_SAND_SceneRecognition { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_SceneRecognition")]
        public int LAVAZZAIT_SAND_SceneRecognition { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_SceneRecognition")]
        public int INBEVUS_STG_SceneRecognition { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_SceneRecognition	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_SceneRecognition")]
        public int LAVAZZAFR_SAND_SceneRecognition { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_SceneRecognition")]
        public int INBEVBE_SAND2_SceneRecognition { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_SceneRecognition")]
        public int INBEVLU_SAND2_SceneRecognition { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_SceneRecognition	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_SceneRecognition")]
        public int INBEVNL_SAND2_SceneRecognition { get; set; }

        //CreatedBy [varchar](50) NULL,
        [DbColumn(Name = "CreatedBy")]
        public string CreatedBy { get; set; }

        [DbColumn(Name = "ImportedDate")]
        public string ImportedDate { get; set; }

        [DbColumn(Name = "ImportedYear")]
        public string ImportedYear { get; set; }

         [DbColumn(Name = "B2BRU")]
        public int B2BRU{ get; set; }

        [DbColumn(Name = "BRMUS")]
	    public int BRMUS{ get; set; }

         [DbColumn(Name = "CBCIL")]
	    public int CBCIL{ get; set; }

         [DbColumn(Name = "CCCOOLERMX")]
	    public int CCCOOLERMX{ get; set; }

        [DbColumn(Name = "DIAGEOAR")]
	    public int DIAGEOAR{ get; set; }

        [DbColumn(Name = "DIAGEOBENELUX")]
	    public int DIAGEOBENELUX{ get; set; }

        [DbColumn(Name = "DIAGEOCH")]
	    public int DIAGEOCH{ get; set; }

        [DbColumn(Name = "DIAGEOGA")]
	    public int DIAGEOGA{ get; set; }

        [DbColumn(Name = "DIAGEOGTR")]
	    public int DIAGEOGTR{ get; set; }

        [DbColumn(Name = "DIAGEONORDICS")]
	    public int DIAGEONORDICS{ get; set; }

        [DbColumn(Name = "DIAGEOUS")]
	    public int DIAGEOUS{ get; set; }

        [DbColumn(Name = "FERREROEXTIT")]
	    public int FERREROEXTIT{ get; set; }

        [DbColumn(Name = "GOOGLEHK")]
	    public int GOOGLEHK{ get; set; }

        [DbColumn(Name = "HEINEKENPILOTCN")]
	    public int HEINEKENPILOTCN{ get; set; }

        [DbColumn(Name = "IMBO")]
	    public int IMBO{ get; set; }

        [DbColumn(Name = "INBEVCI")]
	    public int INBEVCI{ get; set; }

        [DbColumn(Name = "INBEVCNTT")]
	    public int INBEVCNTT{ get; set; }

        [DbColumn(Name = "INBEVCO")]
	    public int INBEVCO{ get; set; }

        [DbColumn(Name = "INBEVZA")]
	    public int INBEVZA{ get; set; }

        [DbColumn(Name = "INORU")]
	    public int INORU{ get; set; }

        [DbColumn(Name = "JJSP")]
	    public int JJSP{ get; set; }

        [DbColumn(Name = "JNJES")]
	    public int JNJES{ get; set; }

        [DbColumn(Name = "JNJUK")]
	    public int JNJUK{ get; set; }

        [DbColumn(Name = "JRIJP")]
	    public int JRIJP{ get; set; }

        [DbColumn(Name = "KELLOGSUSPOC")]
	    public int KELLOGSUSPOC{ get; set; }

        [DbColumn(Name = "KRAFTUS")]
	    public int KRAFTUS{ get; set; }

        [DbColumn(Name = "MARS_CHOCO_RU")]
	    public int MARS_CHOCO_RU{ get; set; }

        [DbColumn(Name = "MHUK")]
	    public int MHUK{ get; set; }

        [DbColumn(Name = "MILLERCOORS")]
	    public int MILLERCOORS{ get; set; }

        [DbColumn(Name = "MOLSONONTRADEUK")]
	    public int MOLSONONTRADEUK{ get; set; }

        [DbColumn(Name = "MYCHEMISTAU")]
	    public int MYCHEMISTAU{ get; set; }

        [DbColumn(Name = "NESTLEROAMLERUK")]
	    public int NESTLEROAMLERUK{ get; set; }

        [DbColumn(Name = "NRF2018")]
	    public int NRF2018{ get; set; }

        [DbColumn(Name = "PENAFLORAR")]
	    public int PENAFLORAR{ get; set; }

        [DbColumn(Name = "PMIUA")]
	    public int PMIUA{ get; set; }

        [DbColumn(Name = "PNGAMERICA")]
	    public int PNGAMERICA{ get; set; }

        [DbColumn(Name = "PNGRO")]
	    public int PNGRO{ get; set; }

        [DbColumn(Name = "RBAU")]
	    public int RBAU{ get; set; }

        [DbColumn(Name = "RBCA")]
	    public int RBCA{ get; set; }

        [DbColumn(Name = "RBDK")]
	    public int RBDK{ get; set; }

        [DbColumn(Name = "RBMANUAL")]
	    public int RBMANUAL{ get; set; }

        [DbColumn(Name = "RINIELSENRU_MARS")]
	    public int RINIELSENRU_MARS{ get; set; }

        [DbColumn(Name = "RINIELSENUSQI")]
	    public int RINIELSENUSQI{ get; set; }

        [DbColumn(Name = "RIPANELCN")]
	    public int RIPANELCN{ get; set; }

        [DbColumn(Name = "RISPARKWINEDE")]
	    public int RISPARKWINEDE{ get; set; }

        [DbColumn(Name = "SANOFIAE")]
	    public int SANOFIAE{ get; set; }

        [DbColumn(Name = "SANOFIAU")]
	    public int SANOFIAU{ get; set; }

        [DbColumn(Name = "SANOFIHK")]
	    public int SANOFIHK{ get; set; }

        [DbColumn(Name = "SANOFIKH")]
	    public int SANOFIKH{ get; set; }

        [DbColumn(Name = "SANOFINZ")]
	    public int SANOFINZ{ get; set; }

        [DbColumn(Name = "SANOFIRU")]
	    public int SANOFIRU{ get; set; }

        [DbColumn(Name = "SANOFITR")]
	    public int SANOFITR{ get; set; }

        [DbColumn(Name = "SANOFIUA")]
	    public int SANOFIUA{ get; set; }

        [DbColumn(Name = "SHUFERSALIL")]
	    public int SHUFERSALIL{ get; set; }

        [DbColumn(Name = "SUNTORYJP")]
	    public int SUNTORYJP{ get; set; }

        [DbColumn(Name = "TESCOTH")]
	    public int TESCOTH{ get; set; }

        [DbColumn(Name = "TESCOUK")]
        public int TESCOUK{ get; set; }

        [DbColumn(Name = "TRAXROBOT")]
	    public int TRAXROBOT{ get; set; }

        [DbColumn(Name = "XSUITE_SHOWCASE")]
        public int XSUITE_SHOWCASE{ get; set; }

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