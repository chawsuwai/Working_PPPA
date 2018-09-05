using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Masks")]
    public class MasksEntity:EntityBase
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

        //TotalMasks	int	NULL,
        [DbColumn(Name = "TotalMasks")]
        public int TotalMasks { get; set; }

        //AvgsecondsperMasks	int	NULL,
        [DbColumn(Name = "AvgsecondsperMasks")]
        public int AvgsecondsperMasks { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_Masks	int	NULL,
        [DbColumn(Name = "ABICA_Masks")]
        public int ABICA_Masks { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_Masks	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_Masks")]
        public int ABITAMSUS_PROD_Masks { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_Masks	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_Masks")]
        public int AMERICAS_DEMO_Masks { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_Masks	int	NULL,
        [DbColumn(Name = "BATRU_Masks")]
        public int BATRU_Masks { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_Masks	int	NULL,
        [DbColumn(Name = "BIKR_Masks")]
        public int BIKR_Masks { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_Masks	int	NULL,
        [DbColumn(Name = "BIMY_Masks")]
        public int BIMY_Masks { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_Masks	int	NULL,
        [DbColumn(Name = "BIPH_Masks")]
        public int BIPH_Masks { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_Masks	int	NULL,
        [DbColumn(Name = "BISEASK_Masks")]
        public int BISEASK_Masks { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_Masks	int	NULL,
        [DbColumn(Name = "BITH_Masks")]
        public int BITH_Masks { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_Masks	int	NULL,
        [DbColumn(Name = "BIVN_Masks")]
        public int BIVN_Masks { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_Masks	int	NULL,
        [DbColumn(Name = "BPAU_Masks")]
        public int BPAU_Masks { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_Masks	int	NULL,
        [DbColumn(Name = "BRODMANN_Masks")]
        public int BRODMANN_Masks { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_Masks	int	NULL,
        [DbColumn(Name = "CARREFOURAR_Masks")]
        public int CARREFOURAR_Masks { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_Masks	int	NULL,
        [DbColumn(Name = "CCAAU_Masks")]
        public int CCAAU_Masks { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_Masks	int	NULL,
        [DbColumn(Name = "CCABIZA_Masks")]
        public int CCABIZA_Masks { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_Masks	int	NULL,
        [DbColumn(Name = "CCANZ_Masks")]
        public int CCANZ_Masks { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_Masks	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_Masks")]
        public int CCBOTTLERSUS_Masks { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_Masks	int	NULL,
        [DbColumn(Name = "CCBR_PROD_Masks")]
        public int CCBR_PROD_Masks { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_Masks	int	NULL,
        [DbColumn(Name = "CCJP_Masks")]
        public int CCJP_Masks { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_Masks	int	NULL,
        [DbColumn(Name = "CCKH_Masks")]
        public int CCKH_Masks { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_Masks	int	NULL,
        [DbColumn(Name = "CCKR_Masks")]
        public int CCKR_Masks { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_Masks	int	NULL,
        [DbColumn(Name = "CCMY_Masks")]
        public int CCMY_Masks { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_Masks	int	NULL,
        [DbColumn(Name = "CCPH_Masks")]
        public int CCPH_Masks { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_Masks	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_Masks")]
        public int CCRPR_PROD_Masks { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_Masks	int	NULL,
        [DbColumn(Name = "CCRU_Masks")]
        public int CCRU_Masks { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_Masks	int	NULL,
        [DbColumn(Name = "CCTH_Masks")]
        public int CCTH_Masks { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_Masks	int	NULL,
        [DbColumn(Name = "CCTH_UAT_Masks")]
        public int CCTH_UAT_Masks { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_Masks	int	NULL,
        [DbColumn(Name = "CCTRADMX_Masks")]
        public int CCTRADMX_Masks { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_Masks	int	NULL,
        [DbColumn(Name = "CCUS_Masks")]
        public int CCUS_Masks { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_Masks	int	NULL,
        [DbColumn(Name = "CCZA_Masks")]
        public int CCZA_Masks { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_Masks	int	NULL,
        [DbColumn(Name = "CEREBOSTH_Masks")]
        public int CEREBOSTH_Masks { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_Masks	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_Masks")]
        public int CROWDSOURCE_Masks { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOAU_Masks")]
        public int DIAGEOAU_Masks { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOBR_Masks")]
        public int DIAGEOBR_Masks { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOGR_Masks")]
        public int DIAGEOGR_Masks { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOIE_Masks")]
        public int DIAGEOIE_Masks { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOKE_Masks")]
        public int DIAGEOKE_Masks { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOMX_Masks")]
        public int DIAGEOMX_Masks { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOPT_Masks")]
        public int DIAGEOPT_Masks { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOTW_Masks")]
        public int DIAGEOTW_Masks { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOUK_Masks")]
        public int DIAGEOUK_Masks { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_Masks	int	NULL,
        [DbColumn(Name = "DIAGEOZA_Masks")]
        public int DIAGEOZA_Masks { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_Masks	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_Masks")]
        public int EMEA_DEMO_Masks { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_Masks	int	NULL,
        [DbColumn(Name = "FERREROIT_Masks")]
        public int FERREROIT_Masks { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_Masks	int	NULL,
        [DbColumn(Name = "GILLETTEUS_Masks")]
        public int GILLETTEUS_Masks { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_Masks	int	NULL,
        [DbColumn(Name = "GOOGLEUS_Masks")]
        public int GOOGLEUS_Masks { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_Masks	int	NULL,
        [DbColumn(Name = "HBCDE_Masks")]
        public int HBCDE_Masks { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_Masks	int	NULL,
        [DbColumn(Name = "HEINEKENCN_Masks")]
        public int HEINEKENCN_Masks { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_Masks	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_Masks")]
        public int HEINEKENUS_PROD_Masks { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_Masks	int	NULL,
        [DbColumn(Name = "HEINZCR_Masks")]
        public int HEINZCR_Masks { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_Masks	int	NULL,
        [DbColumn(Name = "INBEVAR_Masks")]
        public int INBEVAR_Masks { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_Masks	int	NULL,
        [DbColumn(Name = "INBEVBE_Masks")]
        public int INBEVBE_Masks { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_Masks	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_Masks")]
        public int INBEVBE_SAND_Masks { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_Masks	int	NULL,
        [DbColumn(Name = "INBEVBR_Masks")]
        public int INBEVBR_Masks { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_Masks	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_Masks")]
        public int INBEVBR_ONTRADE_Masks { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_Masks	int	NULL,
        [DbColumn(Name = "INBEVCL_Masks")]
        public int INBEVCL_Masks { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_Masks	int	NULL,
        [DbColumn(Name = "INBEVCN_Masks")]
        public int INBEVCN_Masks { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_Masks	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_Masks")]
        public int INBEVCOOLERAR_Masks { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_Masks	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_Masks")]
        public int INBEVCOOLERBR_Masks { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_Masks	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_Masks")]
        public int INBEVCOOLERUS_Masks { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_Masks	int	NULL,
        [DbColumn(Name = "INBEVFR_Masks")]
        public int INBEVFR_Masks { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_Masks	int	NULL,
        [DbColumn(Name = "INBEVLU_Masks")]
        public int INBEVLU_Masks { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_Masks	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_Masks")]
        public int INBEVLU_SAND_Masks { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_Masks	int	NULL,
        [DbColumn(Name = "INBEVMX_Masks")]
        public int INBEVMX_Masks { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_Masks	int	NULL,
        [DbColumn(Name = "INBEVNL_Masks")]
        public int INBEVNL_Masks { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_Masks	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_Masks")]
        public int INBEVNL_SAND_Masks { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_Masks	int	NULL,
        [DbColumn(Name = "INBEVPY_Masks")]
        public int INBEVPY_Masks { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_Masks	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_Masks")]
        public int INBEVTRADMX_Masks { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_Masks	int	NULL,
        [DbColumn(Name = "INBEVUS_Masks")]
        public int INBEVUS_Masks { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_Masks	int	NULL,
        [DbColumn(Name = "JTIUA_Masks")]
        public int JTIUA_Masks { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_Masks	int	NULL,
        [DbColumn(Name = "KCMY_Masks")]
        public int KCMY_Masks { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_Masks	int	NULL,
        [DbColumn(Name = "KCUS_Masks")]
        public int KCUS_Masks { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_Masks	int	NULL,
        [DbColumn(Name = "KEURIGCA_Masks")]
        public int KEURIGCA_Masks { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_Masks	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_Masks")]
        public int LABATTPLNOPTCA_Masks { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_Masks")]
        public int LAVAZZAAT_Masks { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_Masks")]
        public int LAVAZZAAU_Masks { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZABE_Masks")]
        public int LAVAZZABE_Masks { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZABG_Masks")]
        public int LAVAZZABG_Masks { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZACA_Masks")]
        public int LAVAZZACA_Masks { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZACH_Masks")]
        public int LAVAZZACH_Masks { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZACL_Masks")]
        public int LAVAZZACL_Masks { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZACN_Masks")]
        public int LAVAZZACN_Masks { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_Masks")]
        public int LAVAZZACZ_Masks { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZADE_Masks")]
        public int LAVAZZADE_Masks { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZADK_Masks")]
        public int LAVAZZADK_Masks { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_Masks")]
        public int LAVAZZAEE_Masks { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAES_Masks")]
        public int LAVAZZAES_Masks { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_Masks")]
        public int LAVAZZAFR_Masks { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_Masks")]
        public int LAVAZZAGR_Masks { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_Masks")]
        public int LAVAZZAHK_Masks { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_Masks")]
        public int LAVAZZAHR_Masks { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_Masks")]
        public int LAVAZZAIL_Masks { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_Masks")]
        public int LAVAZZAIT_Masks { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_Masks")]
        public int LAVAZZAJP_Masks { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_Masks")]
        public int LAVAZZAKR_Masks { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZALT_Masks")]
        public int LAVAZZALT_Masks { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZALU_Masks")]
        public int LAVAZZALU_Masks { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZALV_Masks")]
        public int LAVAZZALV_Masks { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_Masks")]
        public int LAVAZZAMA_Masks { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZANL_Masks")]
        public int LAVAZZANL_Masks { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_Masks")]
        public int LAVAZZAPL_Masks { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZARO_Masks")]
        public int LAVAZZARO_Masks { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZARU_Masks")]
        public int LAVAZZARU_Masks { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZASA_Masks")]
        public int LAVAZZASA_Masks { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZASE_Masks")]
        public int LAVAZZASE_Masks { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZASG_Masks")]
        public int LAVAZZASG_Masks { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_Masks")]
        public int LAVAZZAUAE_Masks { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_Masks")]
        public int LAVAZZAUK_Masks { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_Masks")]
        public int LAVAZZAUS_Masks { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_Masks")]
        public int LAVAZZAZA_Masks { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_Masks	int	NULL,
        [DbColumn(Name = "LRSUK_Masks")]
        public int LRSUK_Masks { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_Masks	int	NULL,
        [DbColumn(Name = "MARSBR_Masks")]
        public int MARSBR_Masks { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_Masks	int	NULL,
        [DbColumn(Name = "MARSIN_Masks")]
        public int MARSIN_Masks { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_Masks	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_Masks")]
        public int MARSIN_OLD_Masks { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_Masks	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_Masks")]
        public int MARSRU_PROD_Masks { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_Masks	int	NULL,
        [DbColumn(Name = "MAYORAID_Masks")]
        public int MAYORAID_Masks { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_Masks	int	NULL,
        [DbColumn(Name = "MJNCN_Masks")]
        public int MJNCN_Masks { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_Masks	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_Masks")]
        public int MOLSONCOOLERHN_Masks { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_Masks	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_Masks")]
        public int MOLSONCOOLERHR_Masks { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_Masks	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_Masks")]
        public int MOLSONCOORSUK_Masks { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_Masks	int	NULL,
        [DbColumn(Name = "NESTLEUK_Masks")]
        public int NESTLEUK_Masks { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_Masks	int	NULL,
        [DbColumn(Name = "NIVEAUK_Masks")]
        public int NIVEAUK_Masks { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_Masks	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_Masks")]
        public int NRF2017_DEMO_Masks { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_Masks	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_Masks")]
        public int ONE_AMERICAS_DEMO_Masks { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_Masks	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_Masks")]
        public int ONE_APAC_DEMO_Masks { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_Masks	int	NULL,
        [DbColumn(Name = "PEPSICOBR_Masks")]
        public int PEPSICOBR_Masks { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_Masks	int	NULL,
        [DbColumn(Name = "PNGAU_Masks")]
        public int PNGAU_Masks { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_Masks	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_Masks")]
        public int PNGAU_OLD_Masks { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_Masks	int	NULL,
        [DbColumn(Name = "PNGCAREUS_Masks")]
        public int PNGCAREUS_Masks { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_Masks	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_Masks")]
        public int PNGCN_PROD_Masks { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_Masks	int	NULL,
        [DbColumn(Name = "PNGJP_Masks")]
        public int PNGJP_Masks { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_Masks	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_Masks")]
        public int PNGJP_OLD_Masks { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_Masks	int	NULL,
        [DbColumn(Name = "PNGUS_Masks")]
        public int PNGUS_Masks { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_Masks	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_Masks")]
        public int PNGUSEPISODIC_Masks { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_Masks	int	NULL,
        [DbColumn(Name = "RBUS_Masks")]
        public int RBUS_Masks { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_Masks	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_Masks")]
        public int RE_XSUITE_DEMO_Masks { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_Masks	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_Masks")]
        public int REPNGCN_DEMO_Masks { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_Masks	int	NULL,
        [DbColumn(Name = "RI_DEMO_Masks")]
        public int RI_DEMO_Masks { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_Masks	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_Masks")]
        public int RI_DIAGEOAU_Masks { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_Masks	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_Masks")]
        public int RIALCBEVUK_PROD_Masks { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_Masks	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_Masks")]
        public int RICOFFEEUS_Masks { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_Masks	int	NULL,
        [DbColumn(Name = "RINIELSENUS_Masks")]
        public int RINIELSENUS_Masks { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_Masks	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_Masks")]
        public int RIPETCAREUK_PROD_Masks { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_Masks	int	NULL,
        [DbColumn(Name = "RIUS_Masks")]
        public int RIUS_Masks { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_Masks	int	NULL,
        [DbColumn(Name = "RIUS_DEV_Masks")]
        public int RIUS_DEV_Masks { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_Masks	int	NULL,
        [DbColumn(Name = "RNBDE_Masks")]
        public int RNBDE_Masks { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_Masks	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_Masks")]
        public int SMARTCOOLER_POC2_Masks { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_Masks	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_Masks")]
        public int SMARTCOOLER_TRN_Masks { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_Masks	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_Masks")]
        public int SMARTCOOLER2_TRN_Masks { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_Masks	int	NULL,
        [DbColumn(Name = "SOLARBR_Masks")]
        public int SOLARBR_Masks { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_Masks	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_Masks")]
        public int STATIC_CAMERA_DEMO_Masks { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_Masks	int	NULL,
        [DbColumn(Name = "SWIRECN_Masks")]
        public int SWIRECN_Masks { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_Masks	int	NULL,
        [DbColumn(Name = "SWIREREDCN_Masks")]
        public int SWIREREDCN_Masks { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_Masks	int	NULL,
        [DbColumn(Name = "TNUVAIL_Masks")]
        public int TNUVAIL_Masks { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_Masks	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_Masks")]
        public int TRAXDEMO_TS_PROD_Masks { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_Masks	int	NULL,
        [DbColumn(Name = "TWEAU_Masks")]
        public int TWEAU_Masks { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_Masks	int	NULL,
        [DbColumn(Name = "RI_DEMO2_Masks")]
        public int RI_DEMO2_Masks { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_Masks	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_Masks")]
        public int COMPASSCCH_SAND_Masks { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_Masks")]
        public int LAVAZZAIT_SAND_Masks { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_Masks	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_Masks")]
        public int INBEVUS_STG_Masks { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_Masks	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_Masks")]
        public int LAVAZZAFR_SAND_Masks { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_Masks	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_Masks")]
        public int INBEVBE_SAND2_Masks { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_Masks	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_Masks")]
        public int INBEVLU_SAND2_Masks { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_Masks	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_Masks")]
        public int INBEVNL_SAND2_Masks { get; set; }

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

        public int test { get; set; }
    }
}