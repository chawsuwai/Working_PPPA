using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "CategoryExpertHunt")]
    public class CategoryExpertHuntEntity : EntityBase
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

        //TotalCategoryExpertHunt	int	NULL,
        [DbColumn(Name = "TotalCategoryExpertHunt")]
        public int TotalCategoryExpertHunt { get; set; }

        //AvgsecondsperCategoryExpertHunt	int	NULL,
        [DbColumn(Name = "AvgsecondsperCategoryExpertHunt")]
        public int AvgsecondsperCategoryExpertHunt { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "ABICA_CategoryExpertHunt")]
        public int ABICA_CategoryExpertHunt { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_CategoryExpertHunt")]
        public int ABITAMSUS_PROD_CategoryExpertHunt { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_CategoryExpertHunt")]
        public int AMERICAS_DEMO_CategoryExpertHunt { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BATRU_CategoryExpertHunt")]
        public int BATRU_CategoryExpertHunt { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BIKR_CategoryExpertHunt")]
        public int BIKR_CategoryExpertHunt { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BIMY_CategoryExpertHunt")]
        public int BIMY_CategoryExpertHunt { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BIPH_CategoryExpertHunt")]
        public int BIPH_CategoryExpertHunt { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BISEASK_CategoryExpertHunt")]
        public int BISEASK_CategoryExpertHunt { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BITH_CategoryExpertHunt")]
        public int BITH_CategoryExpertHunt { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BIVN_CategoryExpertHunt")]
        public int BIVN_CategoryExpertHunt { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BPAU_CategoryExpertHunt")]
        public int BPAU_CategoryExpertHunt { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "BRODMANN_CategoryExpertHunt")]
        public int BRODMANN_CategoryExpertHunt { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CARREFOURAR_CategoryExpertHunt")]
        public int CARREFOURAR_CategoryExpertHunt { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCAAU_CategoryExpertHunt")]
        public int CCAAU_CategoryExpertHunt { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCABIZA_CategoryExpertHunt")]
        public int CCABIZA_CategoryExpertHunt { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCANZ_CategoryExpertHunt")]
        public int CCANZ_CategoryExpertHunt { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_CategoryExpertHunt")]
        public int CCBOTTLERSUS_CategoryExpertHunt { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCBR_PROD_CategoryExpertHunt")]
        public int CCBR_PROD_CategoryExpertHunt { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCJP_CategoryExpertHunt")]
        public int CCJP_CategoryExpertHunt { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCKH_CategoryExpertHunt")]
        public int CCKH_CategoryExpertHunt { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCKR_CategoryExpertHunt")]
        public int CCKR_CategoryExpertHunt { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCMY_CategoryExpertHunt")]
        public int CCMY_CategoryExpertHunt { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCPH_CategoryExpertHunt")]
        public int CCPH_CategoryExpertHunt { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_CategoryExpertHunt")]
        public int CCRPR_PROD_CategoryExpertHunt { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCRU_CategoryExpertHunt")]
        public int CCRU_CategoryExpertHunt { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCTH_CategoryExpertHunt")]
        public int CCTH_CategoryExpertHunt { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCTH_UAT_CategoryExpertHunt")]
        public int CCTH_UAT_CategoryExpertHunt { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCTRADMX_CategoryExpertHunt")]
        public int CCTRADMX_CategoryExpertHunt { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCUS_CategoryExpertHunt")]
        public int CCUS_CategoryExpertHunt { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CCZA_CategoryExpertHunt")]
        public int CCZA_CategoryExpertHunt { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CEREBOSTH_CategoryExpertHunt")]
        public int CEREBOSTH_CategoryExpertHunt { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_CategoryExpertHunt")]
        public int CROWDSOURCE_CategoryExpertHunt { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOAU_CategoryExpertHunt")]
        public int DIAGEOAU_CategoryExpertHunt { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOBR_CategoryExpertHunt")]
        public int DIAGEOBR_CategoryExpertHunt { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOGR_CategoryExpertHunt")]
        public int DIAGEOGR_CategoryExpertHunt { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOIE_CategoryExpertHunt")]
        public int DIAGEOIE_CategoryExpertHunt { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOKE_CategoryExpertHunt")]
        public int DIAGEOKE_CategoryExpertHunt { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOMX_CategoryExpertHunt")]
        public int DIAGEOMX_CategoryExpertHunt { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOPT_CategoryExpertHunt")]
        public int DIAGEOPT_CategoryExpertHunt { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOTW_CategoryExpertHunt")]
        public int DIAGEOTW_CategoryExpertHunt { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOUK_CategoryExpertHunt")]
        public int DIAGEOUK_CategoryExpertHunt { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "DIAGEOZA_CategoryExpertHunt")]
        public int DIAGEOZA_CategoryExpertHunt { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_CategoryExpertHunt")]
        public int EMEA_DEMO_CategoryExpertHunt { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "FERREROIT_CategoryExpertHunt")]
        public int FERREROIT_CategoryExpertHunt { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "GILLETTEUS_CategoryExpertHunt")]
        public int GILLETTEUS_CategoryExpertHunt { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "GOOGLEUS_CategoryExpertHunt")]
        public int GOOGLEUS_CategoryExpertHunt { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "HBCDE_CategoryExpertHunt")]
        public int HBCDE_CategoryExpertHunt { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "HEINEKENCN_CategoryExpertHunt")]
        public int HEINEKENCN_CategoryExpertHunt { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_CategoryExpertHunt")]
        public int HEINEKENUS_PROD_CategoryExpertHunt { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "HEINZCR_CategoryExpertHunt")]
        public int HEINZCR_CategoryExpertHunt { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVAR_CategoryExpertHunt")]
        public int INBEVAR_CategoryExpertHunt { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVBE_CategoryExpertHunt")]
        public int INBEVBE_CategoryExpertHunt { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_CategoryExpertHunt")]
        public int INBEVBE_SAND_CategoryExpertHunt { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVBR_CategoryExpertHunt")]
        public int INBEVBR_CategoryExpertHunt { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_CategoryExpertHunt")]
        public int INBEVBR_ONTRADE_CategoryExpertHunt { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVCL_CategoryExpertHunt")]
        public int INBEVCL_CategoryExpertHunt { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVCN_CategoryExpertHunt")]
        public int INBEVCN_CategoryExpertHunt { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_CategoryExpertHunt")]
        public int INBEVCOOLERAR_CategoryExpertHunt { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_CategoryExpertHunt")]
        public int INBEVCOOLERBR_CategoryExpertHunt { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_CategoryExpertHunt")]
        public int INBEVCOOLERUS_CategoryExpertHunt { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVFR_CategoryExpertHunt")]
        public int INBEVFR_CategoryExpertHunt { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVLU_CategoryExpertHunt")]
        public int INBEVLU_CategoryExpertHunt { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_CategoryExpertHunt")]
        public int INBEVLU_SAND_CategoryExpertHunt { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVMX_CategoryExpertHunt")]
        public int INBEVMX_CategoryExpertHunt { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVNL_CategoryExpertHunt")]
        public int INBEVNL_CategoryExpertHunt { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_CategoryExpertHunt")]
        public int INBEVNL_SAND_CategoryExpertHunt { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVPY_CategoryExpertHunt")]
        public int INBEVPY_CategoryExpertHunt { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_CategoryExpertHunt")]
        public int INBEVTRADMX_CategoryExpertHunt { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVUS_CategoryExpertHunt")]
        public int INBEVUS_CategoryExpertHunt { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "JTIUA_CategoryExpertHunt")]
        public int JTIUA_CategoryExpertHunt { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "KCMY_CategoryExpertHunt")]
        public int KCMY_CategoryExpertHunt { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "KCUS_CategoryExpertHunt")]
        public int KCUS_CategoryExpertHunt { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "KEURIGCA_CategoryExpertHunt")]
        public int KEURIGCA_CategoryExpertHunt { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_CategoryExpertHunt")]
        public int LABATTPLNOPTCA_CategoryExpertHunt { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_CategoryExpertHunt")]
        public int LAVAZZAAT_CategoryExpertHunt { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_CategoryExpertHunt")]
        public int LAVAZZAAU_CategoryExpertHunt { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZABE_CategoryExpertHunt")]
        public int LAVAZZABE_CategoryExpertHunt { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZABG_CategoryExpertHunt")]
        public int LAVAZZABG_CategoryExpertHunt { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZACA_CategoryExpertHunt")]
        public int LAVAZZACA_CategoryExpertHunt { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZACH_CategoryExpertHunt")]
        public int LAVAZZACH_CategoryExpertHunt { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZACL_CategoryExpertHunt")]
        public int LAVAZZACL_CategoryExpertHunt { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZACN_CategoryExpertHunt")]
        public int LAVAZZACN_CategoryExpertHunt { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_CategoryExpertHunt")]
        public int LAVAZZACZ_CategoryExpertHunt { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZADE_CategoryExpertHunt")]
        public int LAVAZZADE_CategoryExpertHunt { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZADK_CategoryExpertHunt")]
        public int LAVAZZADK_CategoryExpertHunt { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_CategoryExpertHunt")]
        public int LAVAZZAEE_CategoryExpertHunt { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAES_CategoryExpertHunt")]
        public int LAVAZZAES_CategoryExpertHunt { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_CategoryExpertHunt")]
        public int LAVAZZAFR_CategoryExpertHunt { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_CategoryExpertHunt")]
        public int LAVAZZAGR_CategoryExpertHunt { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_CategoryExpertHunt")]
        public int LAVAZZAHK_CategoryExpertHunt { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_CategoryExpertHunt")]
        public int LAVAZZAHR_CategoryExpertHunt { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_CategoryExpertHunt")]
        public int LAVAZZAIL_CategoryExpertHunt { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_CategoryExpertHunt")]
        public int LAVAZZAIT_CategoryExpertHunt { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_CategoryExpertHunt")]
        public int LAVAZZAJP_CategoryExpertHunt { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_CategoryExpertHunt")]
        public int LAVAZZAKR_CategoryExpertHunt { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZALT_CategoryExpertHunt")]
        public int LAVAZZALT_CategoryExpertHunt { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZALU_CategoryExpertHunt")]
        public int LAVAZZALU_CategoryExpertHunt { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZALV_CategoryExpertHunt")]
        public int LAVAZZALV_CategoryExpertHunt { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_CategoryExpertHunt")]
        public int LAVAZZAMA_CategoryExpertHunt { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZANL_CategoryExpertHunt")]
        public int LAVAZZANL_CategoryExpertHunt { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_CategoryExpertHunt")]
        public int LAVAZZAPL_CategoryExpertHunt { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZARO_CategoryExpertHunt")]
        public int LAVAZZARO_CategoryExpertHunt { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZARU_CategoryExpertHunt")]
        public int LAVAZZARU_CategoryExpertHunt { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZASA_CategoryExpertHunt")]
        public int LAVAZZASA_CategoryExpertHunt { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZASE_CategoryExpertHunt")]
        public int LAVAZZASE_CategoryExpertHunt { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZASG_CategoryExpertHunt")]
        public int LAVAZZASG_CategoryExpertHunt { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_CategoryExpertHunt")]
        public int LAVAZZAUAE_CategoryExpertHunt { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_CategoryExpertHunt")]
        public int LAVAZZAUK_CategoryExpertHunt { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_CategoryExpertHunt")]
        public int LAVAZZAUS_CategoryExpertHunt { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_CategoryExpertHunt")]
        public int LAVAZZAZA_CategoryExpertHunt { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LRSUK_CategoryExpertHunt")]
        public int LRSUK_CategoryExpertHunt { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MARSBR_CategoryExpertHunt")]
        public int MARSBR_CategoryExpertHunt { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MARSIN_CategoryExpertHunt")]
        public int MARSIN_CategoryExpertHunt { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_CategoryExpertHunt")]
        public int MARSIN_OLD_CategoryExpertHunt { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_CategoryExpertHunt")]
        public int MARSRU_PROD_CategoryExpertHunt { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MAYORAID_CategoryExpertHunt")]
        public int MAYORAID_CategoryExpertHunt { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MJNCN_CategoryExpertHunt")]
        public int MJNCN_CategoryExpertHunt { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_CategoryExpertHunt")]
        public int MOLSONCOOLERHN_CategoryExpertHunt { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_CategoryExpertHunt")]
        public int MOLSONCOOLERHR_CategoryExpertHunt { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_CategoryExpertHunt")]
        public int MOLSONCOORSUK_CategoryExpertHunt { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "NESTLEUK_CategoryExpertHunt")]
        public int NESTLEUK_CategoryExpertHunt { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "NIVEAUK_CategoryExpertHunt")]
        public int NIVEAUK_CategoryExpertHunt { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_CategoryExpertHunt")]
        public int NRF2017_DEMO_CategoryExpertHunt { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_CategoryExpertHunt")]
        public int ONE_AMERICAS_DEMO_CategoryExpertHunt { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_CategoryExpertHunt")]
        public int ONE_APAC_DEMO_CategoryExpertHunt { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PEPSICOBR_CategoryExpertHunt")]
        public int PEPSICOBR_CategoryExpertHunt { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGAU_CategoryExpertHunt")]
        public int PNGAU_CategoryExpertHunt { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_CategoryExpertHunt")]
        public int PNGAU_OLD_CategoryExpertHunt { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGCAREUS_CategoryExpertHunt")]
        public int PNGCAREUS_CategoryExpertHunt { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_CategoryExpertHunt")]
        public int PNGCN_PROD_CategoryExpertHunt { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGJP_CategoryExpertHunt")]
        public int PNGJP_CategoryExpertHunt { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_CategoryExpertHunt")]
        public int PNGJP_OLD_CategoryExpertHunt { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGUS_CategoryExpertHunt")]
        public int PNGUS_CategoryExpertHunt { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_CategoryExpertHunt")]
        public int PNGUSEPISODIC_CategoryExpertHunt { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RBUS_CategoryExpertHunt")]
        public int RBUS_CategoryExpertHunt { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_CategoryExpertHunt")]
        public int RE_XSUITE_DEMO_CategoryExpertHunt { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_CategoryExpertHunt")]
        public int REPNGCN_DEMO_CategoryExpertHunt { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RI_DEMO_CategoryExpertHunt")]
        public int RI_DEMO_CategoryExpertHunt { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_CategoryExpertHunt")]
        public int RI_DIAGEOAU_CategoryExpertHunt { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_CategoryExpertHunt")]
        public int RIALCBEVUK_PROD_CategoryExpertHunt { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_CategoryExpertHunt")]
        public int RICOFFEEUS_CategoryExpertHunt { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RINIELSENUS_CategoryExpertHunt")]
        public int RINIELSENUS_CategoryExpertHunt { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_CategoryExpertHunt")]
        public int RIPETCAREUK_PROD_CategoryExpertHunt { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RIUS_CategoryExpertHunt")]
        public int RIUS_CategoryExpertHunt { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RIUS_DEV_CategoryExpertHunt")]
        public int RIUS_DEV_CategoryExpertHunt { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RNBDE_CategoryExpertHunt")]
        public int RNBDE_CategoryExpertHunt { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_CategoryExpertHunt")]
        public int SMARTCOOLER_POC2_CategoryExpertHunt { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_CategoryExpertHunt")]
        public int SMARTCOOLER_TRN_CategoryExpertHunt { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_CategoryExpertHunt")]
        public int SMARTCOOLER2_TRN_CategoryExpertHunt { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "SOLARBR_CategoryExpertHunt")]
        public int SOLARBR_CategoryExpertHunt { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_CategoryExpertHunt")]
        public int STATIC_CAMERA_DEMO_CategoryExpertHunt { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "SWIRECN_CategoryExpertHunt")]
        public int SWIRECN_CategoryExpertHunt { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "SWIREREDCN_CategoryExpertHunt")]
        public int SWIREREDCN_CategoryExpertHunt { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "TNUVAIL_CategoryExpertHunt")]
        public int TNUVAIL_CategoryExpertHunt { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_CategoryExpertHunt")]
        public int TRAXDEMO_TS_PROD_CategoryExpertHunt { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "TWEAU_CategoryExpertHunt")]
        public int TWEAU_CategoryExpertHunt { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "RI_DEMO2_CategoryExpertHunt")]
        public int RI_DEMO2_CategoryExpertHunt { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_CategoryExpertHunt")]
        public int COMPASSCCH_SAND_CategoryExpertHunt { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_CategoryExpertHunt")]
        public int LAVAZZAIT_SAND_CategoryExpertHunt { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_CategoryExpertHunt")]
        public int INBEVUS_STG_CategoryExpertHunt { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_CategoryExpertHunt")]
        public int LAVAZZAFR_SAND_CategoryExpertHunt { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_CategoryExpertHunt")]
        public int INBEVBE_SAND2_CategoryExpertHunt { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_CategoryExpertHunt")]
        public int INBEVLU_SAND2_CategoryExpertHunt { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_CategoryExpertHunt	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_CategoryExpertHunt")]
        public int INBEVNL_SAND2_CategoryExpertHunt { get; set; }

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