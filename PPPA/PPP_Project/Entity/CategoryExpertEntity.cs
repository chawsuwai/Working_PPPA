using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "CategoryExpert")]
    public class CategoryExpertEntity : EntityBase
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

        //TotalCategoryExpert	int	NULL,
        [DbColumn(Name = "TotalCategoryExpert")]
        public int TotalCategoryExpert { get; set; }

        //AvgsecondsperCategoryExpert	int	NULL,
        [DbColumn(Name = "AvgsecondsperCategoryExpert")]
        public int AvgsecondsperCategoryExpert { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_CategoryExpert	int	NULL,
        [DbColumn(Name = "ABICA_CategoryExpert")]
        public int ABICA_CategoryExpert { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_CategoryExpert")]
        public int ABITAMSUS_PROD_CategoryExpert { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_CategoryExpert")]
        public int AMERICAS_DEMO_CategoryExpert { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_CategoryExpert	int	NULL,
        [DbColumn(Name = "BATRU_CategoryExpert")]
        public int BATRU_CategoryExpert { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_CategoryExpert	int	NULL,
        [DbColumn(Name = "BIKR_CategoryExpert")]
        public int BIKR_CategoryExpert { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_CategoryExpert	int	NULL,
        [DbColumn(Name = "BIMY_CategoryExpert")]
        public int BIMY_CategoryExpert { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_CategoryExpert	int	NULL,
        [DbColumn(Name = "BIPH_CategoryExpert")]
        public int BIPH_CategoryExpert { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_CategoryExpert	int	NULL,
        [DbColumn(Name = "BISEASK_CategoryExpert")]
        public int BISEASK_CategoryExpert { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_CategoryExpert	int	NULL,
        [DbColumn(Name = "BITH_CategoryExpert")]
        public int BITH_CategoryExpert { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_CategoryExpert	int	NULL,
        [DbColumn(Name = "BIVN_CategoryExpert")]
        public int BIVN_CategoryExpert { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "BPAU_CategoryExpert")]
        public int BPAU_CategoryExpert { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_CategoryExpert	int	NULL,
        [DbColumn(Name = "BRODMANN_CategoryExpert")]
        public int BRODMANN_CategoryExpert { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_CategoryExpert	int	NULL,
        [DbColumn(Name = "CARREFOURAR_CategoryExpert")]
        public int CARREFOURAR_CategoryExpert { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCAAU_CategoryExpert")]
        public int CCAAU_CategoryExpert { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCABIZA_CategoryExpert")]
        public int CCABIZA_CategoryExpert { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCANZ_CategoryExpert")]
        public int CCANZ_CategoryExpert { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_CategoryExpert")]
        public int CCBOTTLERSUS_CategoryExpert { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCBR_PROD_CategoryExpert")]
        public int CCBR_PROD_CategoryExpert { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCJP_CategoryExpert")]
        public int CCJP_CategoryExpert { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCKH_CategoryExpert")]
        public int CCKH_CategoryExpert { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCKR_CategoryExpert")]
        public int CCKR_CategoryExpert { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCMY_CategoryExpert")]
        public int CCMY_CategoryExpert { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCPH_CategoryExpert")]
        public int CCPH_CategoryExpert { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_CategoryExpert")]
        public int CCRPR_PROD_CategoryExpert { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCRU_CategoryExpert")]
        public int CCRU_CategoryExpert { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCTH_CategoryExpert")]
        public int CCTH_CategoryExpert { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCTH_UAT_CategoryExpert")]
        public int CCTH_UAT_CategoryExpert { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCTRADMX_CategoryExpert")]
        public int CCTRADMX_CategoryExpert { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCUS_CategoryExpert")]
        public int CCUS_CategoryExpert { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_CategoryExpert	int	NULL,
        [DbColumn(Name = "CCZA_CategoryExpert")]
        public int CCZA_CategoryExpert { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_CategoryExpert	int	NULL,
        [DbColumn(Name = "CEREBOSTH_CategoryExpert")]
        public int CEREBOSTH_CategoryExpert { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_CategoryExpert	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_CategoryExpert")]
        public int CROWDSOURCE_CategoryExpert { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOAU_CategoryExpert")]
        public int DIAGEOAU_CategoryExpert { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOBR_CategoryExpert")]
        public int DIAGEOBR_CategoryExpert { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOGR_CategoryExpert")]
        public int DIAGEOGR_CategoryExpert { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOIE_CategoryExpert")]
        public int DIAGEOIE_CategoryExpert { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOKE_CategoryExpert")]
        public int DIAGEOKE_CategoryExpert { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOMX_CategoryExpert")]
        public int DIAGEOMX_CategoryExpert { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOPT_CategoryExpert")]
        public int DIAGEOPT_CategoryExpert { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOTW_CategoryExpert")]
        public int DIAGEOTW_CategoryExpert { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOUK_CategoryExpert")]
        public int DIAGEOUK_CategoryExpert { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_CategoryExpert	int	NULL,
        [DbColumn(Name = "DIAGEOZA_CategoryExpert")]
        public int DIAGEOZA_CategoryExpert { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_CategoryExpert")]
        public int EMEA_DEMO_CategoryExpert { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_CategoryExpert	int	NULL,
        [DbColumn(Name = "FERREROIT_CategoryExpert")]
        public int FERREROIT_CategoryExpert { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "GILLETTEUS_CategoryExpert")]
        public int GILLETTEUS_CategoryExpert { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "GOOGLEUS_CategoryExpert")]
        public int GOOGLEUS_CategoryExpert { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_CategoryExpert	int	NULL,
        [DbColumn(Name = "HBCDE_CategoryExpert")]
        public int HBCDE_CategoryExpert { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_CategoryExpert	int	NULL,
        [DbColumn(Name = "HEINEKENCN_CategoryExpert")]
        public int HEINEKENCN_CategoryExpert { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_CategoryExpert")]
        public int HEINEKENUS_PROD_CategoryExpert { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_CategoryExpert	int	NULL,
        [DbColumn(Name = "HEINZCR_CategoryExpert")]
        public int HEINZCR_CategoryExpert { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVAR_CategoryExpert")]
        public int INBEVAR_CategoryExpert { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVBE_CategoryExpert")]
        public int INBEVBE_CategoryExpert { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_CategoryExpert")]
        public int INBEVBE_SAND_CategoryExpert { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVBR_CategoryExpert")]
        public int INBEVBR_CategoryExpert { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_CategoryExpert")]
        public int INBEVBR_ONTRADE_CategoryExpert { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVCL_CategoryExpert")]
        public int INBEVCL_CategoryExpert { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVCN_CategoryExpert")]
        public int INBEVCN_CategoryExpert { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_CategoryExpert")]
        public int INBEVCOOLERAR_CategoryExpert { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_CategoryExpert")]
        public int INBEVCOOLERBR_CategoryExpert { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_CategoryExpert")]
        public int INBEVCOOLERUS_CategoryExpert { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVFR_CategoryExpert")]
        public int INBEVFR_CategoryExpert { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVLU_CategoryExpert")]
        public int INBEVLU_CategoryExpert { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_CategoryExpert")]
        public int INBEVLU_SAND_CategoryExpert { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVMX_CategoryExpert")]
        public int INBEVMX_CategoryExpert { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVNL_CategoryExpert")]
        public int INBEVNL_CategoryExpert { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_CategoryExpert")]
        public int INBEVNL_SAND_CategoryExpert { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVPY_CategoryExpert")]
        public int INBEVPY_CategoryExpert { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_CategoryExpert")]
        public int INBEVTRADMX_CategoryExpert { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVUS_CategoryExpert")]
        public int INBEVUS_CategoryExpert { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_CategoryExpert	int	NULL,
        [DbColumn(Name = "JTIUA_CategoryExpert")]
        public int JTIUA_CategoryExpert { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_CategoryExpert	int	NULL,
        [DbColumn(Name = "KCMY_CategoryExpert")]
        public int KCMY_CategoryExpert { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "KCUS_CategoryExpert")]
        public int KCUS_CategoryExpert { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_CategoryExpert	int	NULL,
        [DbColumn(Name = "KEURIGCA_CategoryExpert")]
        public int KEURIGCA_CategoryExpert { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_CategoryExpert	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_CategoryExpert")]
        public int LABATTPLNOPTCA_CategoryExpert { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_CategoryExpert")]
        public int LAVAZZAAT_CategoryExpert { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_CategoryExpert")]
        public int LAVAZZAAU_CategoryExpert { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZABE_CategoryExpert")]
        public int LAVAZZABE_CategoryExpert { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZABG_CategoryExpert")]
        public int LAVAZZABG_CategoryExpert { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZACA_CategoryExpert")]
        public int LAVAZZACA_CategoryExpert { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZACH_CategoryExpert")]
        public int LAVAZZACH_CategoryExpert { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZACL_CategoryExpert")]
        public int LAVAZZACL_CategoryExpert { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZACN_CategoryExpert")]
        public int LAVAZZACN_CategoryExpert { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_CategoryExpert")]
        public int LAVAZZACZ_CategoryExpert { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZADE_CategoryExpert")]
        public int LAVAZZADE_CategoryExpert { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZADK_CategoryExpert")]
        public int LAVAZZADK_CategoryExpert { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_CategoryExpert")]
        public int LAVAZZAEE_CategoryExpert { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAES_CategoryExpert")]
        public int LAVAZZAES_CategoryExpert { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_CategoryExpert")]
        public int LAVAZZAFR_CategoryExpert { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_CategoryExpert")]
        public int LAVAZZAGR_CategoryExpert { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_CategoryExpert")]
        public int LAVAZZAHK_CategoryExpert { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_CategoryExpert")]
        public int LAVAZZAHR_CategoryExpert { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_CategoryExpert")]
        public int LAVAZZAIL_CategoryExpert { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_CategoryExpert")]
        public int LAVAZZAIT_CategoryExpert { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_CategoryExpert")]
        public int LAVAZZAJP_CategoryExpert { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_CategoryExpert")]
        public int LAVAZZAKR_CategoryExpert { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZALT_CategoryExpert")]
        public int LAVAZZALT_CategoryExpert { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZALU_CategoryExpert")]
        public int LAVAZZALU_CategoryExpert { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZALV_CategoryExpert")]
        public int LAVAZZALV_CategoryExpert { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_CategoryExpert")]
        public int LAVAZZAMA_CategoryExpert { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZANL_CategoryExpert")]
        public int LAVAZZANL_CategoryExpert { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_CategoryExpert")]
        public int LAVAZZAPL_CategoryExpert { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZARO_CategoryExpert")]
        public int LAVAZZARO_CategoryExpert { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZARU_CategoryExpert")]
        public int LAVAZZARU_CategoryExpert { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZASA_CategoryExpert")]
        public int LAVAZZASA_CategoryExpert { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZASE_CategoryExpert")]
        public int LAVAZZASE_CategoryExpert { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZASG_CategoryExpert")]
        public int LAVAZZASG_CategoryExpert { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_CategoryExpert")]
        public int LAVAZZAUAE_CategoryExpert { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_CategoryExpert")]
        public int LAVAZZAUK_CategoryExpert { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_CategoryExpert")]
        public int LAVAZZAUS_CategoryExpert { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_CategoryExpert")]
        public int LAVAZZAZA_CategoryExpert { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_CategoryExpert	int	NULL,
        [DbColumn(Name = "LRSUK_CategoryExpert")]
        public int LRSUK_CategoryExpert { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_CategoryExpert	int	NULL,
        [DbColumn(Name = "MARSBR_CategoryExpert")]
        public int MARSBR_CategoryExpert { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_CategoryExpert	int	NULL,
        [DbColumn(Name = "MARSIN_CategoryExpert")]
        public int MARSIN_CategoryExpert { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_CategoryExpert	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_CategoryExpert")]
        public int MARSIN_OLD_CategoryExpert { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_CategoryExpert")]
        public int MARSRU_PROD_CategoryExpert { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_CategoryExpert	int	NULL,
        [DbColumn(Name = "MAYORAID_CategoryExpert")]
        public int MAYORAID_CategoryExpert { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_CategoryExpert	int	NULL,
        [DbColumn(Name = "MJNCN_CategoryExpert")]
        public int MJNCN_CategoryExpert { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_CategoryExpert	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_CategoryExpert")]
        public int MOLSONCOOLERHN_CategoryExpert { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_CategoryExpert	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_CategoryExpert")]
        public int MOLSONCOOLERHR_CategoryExpert { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_CategoryExpert	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_CategoryExpert")]
        public int MOLSONCOORSUK_CategoryExpert { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_CategoryExpert	int	NULL,
        [DbColumn(Name = "NESTLEUK_CategoryExpert")]
        public int NESTLEUK_CategoryExpert { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_CategoryExpert	int	NULL,
        [DbColumn(Name = "NIVEAUK_CategoryExpert")]
        public int NIVEAUK_CategoryExpert { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_CategoryExpert")]
        public int NRF2017_DEMO_CategoryExpert { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_CategoryExpert")]
        public int ONE_AMERICAS_DEMO_CategoryExpert { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_CategoryExpert")]
        public int ONE_APAC_DEMO_CategoryExpert { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_CategoryExpert	int	NULL,
        [DbColumn(Name = "PEPSICOBR_CategoryExpert")]
        public int PEPSICOBR_CategoryExpert { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGAU_CategoryExpert")]
        public int PNGAU_CategoryExpert { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_CategoryExpert")]
        public int PNGAU_OLD_CategoryExpert { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGCAREUS_CategoryExpert")]
        public int PNGCAREUS_CategoryExpert { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_CategoryExpert")]
        public int PNGCN_PROD_CategoryExpert { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGJP_CategoryExpert")]
        public int PNGJP_CategoryExpert { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_CategoryExpert")]
        public int PNGJP_OLD_CategoryExpert { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGUS_CategoryExpert")]
        public int PNGUS_CategoryExpert { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_CategoryExpert	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_CategoryExpert")]
        public int PNGUSEPISODIC_CategoryExpert { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "RBUS_CategoryExpert")]
        public int RBUS_CategoryExpert { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_CategoryExpert")]
        public int RE_XSUITE_DEMO_CategoryExpert { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_CategoryExpert")]
        public int REPNGCN_DEMO_CategoryExpert { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "RI_DEMO_CategoryExpert")]
        public int RI_DEMO_CategoryExpert { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_CategoryExpert")]
        public int RI_DIAGEOAU_CategoryExpert { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_CategoryExpert")]
        public int RIALCBEVUK_PROD_CategoryExpert { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_CategoryExpert")]
        public int RICOFFEEUS_CategoryExpert { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "RINIELSENUS_CategoryExpert")]
        public int RINIELSENUS_CategoryExpert { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_CategoryExpert")]
        public int RIPETCAREUK_PROD_CategoryExpert { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_CategoryExpert	int	NULL,
        [DbColumn(Name = "RIUS_CategoryExpert")]
        public int RIUS_CategoryExpert { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_CategoryExpert	int	NULL,
        [DbColumn(Name = "RIUS_DEV_CategoryExpert")]
        public int RIUS_DEV_CategoryExpert { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_CategoryExpert	int	NULL,
        [DbColumn(Name = "RNBDE_CategoryExpert")]
        public int RNBDE_CategoryExpert { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_CategoryExpert	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_CategoryExpert")]
        public int SMARTCOOLER_POC2_CategoryExpert { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_CategoryExpert	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_CategoryExpert")]
        public int SMARTCOOLER_TRN_CategoryExpert { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_CategoryExpert	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_CategoryExpert")]
        public int SMARTCOOLER2_TRN_CategoryExpert { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_CategoryExpert	int	NULL,
        [DbColumn(Name = "SOLARBR_CategoryExpert")]
        public int SOLARBR_CategoryExpert { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_CategoryExpert	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_CategoryExpert")]
        public int STATIC_CAMERA_DEMO_CategoryExpert { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_CategoryExpert	int	NULL,
        [DbColumn(Name = "SWIRECN_CategoryExpert")]
        public int SWIRECN_CategoryExpert { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_CategoryExpert	int	NULL,
        [DbColumn(Name = "SWIREREDCN_CategoryExpert")]
        public int SWIREREDCN_CategoryExpert { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_CategoryExpert	int	NULL,
        [DbColumn(Name = "TNUVAIL_CategoryExpert")]
        public int TNUVAIL_CategoryExpert { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_CategoryExpert	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_CategoryExpert")]
        public int TRAXDEMO_TS_PROD_CategoryExpert { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_CategoryExpert	int	NULL,
        [DbColumn(Name = "TWEAU_CategoryExpert")]
        public int TWEAU_CategoryExpert { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_CategoryExpert	int	NULL,
        [DbColumn(Name = "RI_DEMO2_CategoryExpert")]
        public int RI_DEMO2_CategoryExpert { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_CategoryExpert	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_CategoryExpert")]
        public int COMPASSCCH_SAND_CategoryExpert { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_CategoryExpert")]
        public int LAVAZZAIT_SAND_CategoryExpert { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_CategoryExpert")]
        public int INBEVUS_STG_CategoryExpert { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_CategoryExpert	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_CategoryExpert")]
        public int LAVAZZAFR_SAND_CategoryExpert { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_CategoryExpert")]
        public int INBEVBE_SAND2_CategoryExpert { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_CategoryExpert")]
        public int INBEVLU_SAND2_CategoryExpert { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_CategoryExpert	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_CategoryExpert")]
        public int INBEVNL_SAND2_CategoryExpert { get; set; }

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