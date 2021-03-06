﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Repricing")]
    public class RepricingEntity:EntityBase
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

        //TotalRepricing	int	NULL,
        [DbColumn(Name = "TotalRepricing")]
        public int TotalRepricing { get; set; }

        //AvgsecondsperRepricing	int	NULL,
        [DbColumn(Name = "AvgsecondsperRepricing")]
        public int AvgsecondsperRepricing { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_Repricing	int	NULL,
        [DbColumn(Name = "ABICA_Repricing")]
        public int ABICA_Repricing { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_Repricing	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_Repricing")]
        public int ABITAMSUS_PROD_Repricing { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_Repricing")]
        public int AMERICAS_DEMO_Repricing { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_Repricing	int	NULL,
        [DbColumn(Name = "BATRU_Repricing")]
        public int BATRU_Repricing { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_Repricing	int	NULL,
        [DbColumn(Name = "BIKR_Repricing")]
        public int BIKR_Repricing { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_Repricing	int	NULL,
        [DbColumn(Name = "BIMY_Repricing")]
        public int BIMY_Repricing { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_Repricing	int	NULL,
        [DbColumn(Name = "BIPH_Repricing")]
        public int BIPH_Repricing { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_Repricing	int	NULL,
        [DbColumn(Name = "BISEASK_Repricing")]
        public int BISEASK_Repricing { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_Repricing	int	NULL,
        [DbColumn(Name = "BITH_Repricing")]
        public int BITH_Repricing { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_Repricing	int	NULL,
        [DbColumn(Name = "BIVN_Repricing")]
        public int BIVN_Repricing { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_Repricing	int	NULL,
        [DbColumn(Name = "BPAU_Repricing")]
        public int BPAU_Repricing { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_Repricing	int	NULL,
        [DbColumn(Name = "BRODMANN_Repricing")]
        public int BRODMANN_Repricing { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_Repricing	int	NULL,
        [DbColumn(Name = "CARREFOURAR_Repricing")]
        public int CARREFOURAR_Repricing { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_Repricing	int	NULL,
        [DbColumn(Name = "CCAAU_Repricing")]
        public int CCAAU_Repricing { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_Repricing	int	NULL,
        [DbColumn(Name = "CCABIZA_Repricing")]
        public int CCABIZA_Repricing { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_Repricing	int	NULL,
        [DbColumn(Name = "CCANZ_Repricing")]
        public int CCANZ_Repricing { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_Repricing	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_Repricing")]
        public int CCBOTTLERSUS_Repricing { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_Repricing	int	NULL,
        [DbColumn(Name = "CCBR_PROD_Repricing")]
        public int CCBR_PROD_Repricing { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_Repricing	int	NULL,
        [DbColumn(Name = "CCJP_Repricing")]
        public int CCJP_Repricing { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_Repricing	int	NULL,
        [DbColumn(Name = "CCKH_Repricing")]
        public int CCKH_Repricing { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_Repricing	int	NULL,
        [DbColumn(Name = "CCKR_Repricing")]
        public int CCKR_Repricing { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_Repricing	int	NULL,
        [DbColumn(Name = "CCMY_Repricing")]
        public int CCMY_Repricing { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_Repricing	int	NULL,
        [DbColumn(Name = "CCPH_Repricing")]
        public int CCPH_Repricing { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_Repricing	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_Repricing")]
        public int CCRPR_PROD_Repricing { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_Repricing	int	NULL,
        [DbColumn(Name = "CCRU_Repricing")]
        public int CCRU_Repricing { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_Repricing	int	NULL,
        [DbColumn(Name = "CCTH_Repricing")]
        public int CCTH_Repricing { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_Repricing	int	NULL,
        [DbColumn(Name = "CCTH_UAT_Repricing")]
        public int CCTH_UAT_Repricing { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_Repricing	int	NULL,
        [DbColumn(Name = "CCTRADMX_Repricing")]
        public int CCTRADMX_Repricing { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_Repricing	int	NULL,
        [DbColumn(Name = "CCUS_Repricing")]
        public int CCUS_Repricing { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_Repricing	int	NULL,
        [DbColumn(Name = "CCZA_Repricing")]
        public int CCZA_Repricing { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_Repricing	int	NULL,
        [DbColumn(Name = "CEREBOSTH_Repricing")]
        public int CEREBOSTH_Repricing { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_Repricing	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_Repricing")]
        public int CROWDSOURCE_Repricing { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOAU_Repricing")]
        public int DIAGEOAU_Repricing { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOBR_Repricing")]
        public int DIAGEOBR_Repricing { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOGR_Repricing")]
        public int DIAGEOGR_Repricing { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOIE_Repricing")]
        public int DIAGEOIE_Repricing { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOKE_Repricing")]
        public int DIAGEOKE_Repricing { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOMX_Repricing")]
        public int DIAGEOMX_Repricing { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOPT_Repricing")]
        public int DIAGEOPT_Repricing { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOTW_Repricing")]
        public int DIAGEOTW_Repricing { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOUK_Repricing")]
        public int DIAGEOUK_Repricing { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_Repricing	int	NULL,
        [DbColumn(Name = "DIAGEOZA_Repricing")]
        public int DIAGEOZA_Repricing { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_Repricing")]
        public int EMEA_DEMO_Repricing { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_Repricing	int	NULL,
        [DbColumn(Name = "FERREROIT_Repricing")]
        public int FERREROIT_Repricing { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_Repricing	int	NULL,
        [DbColumn(Name = "GILLETTEUS_Repricing")]
        public int GILLETTEUS_Repricing { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_Repricing	int	NULL,
        [DbColumn(Name = "GOOGLEUS_Repricing")]
        public int GOOGLEUS_Repricing { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_Repricing	int	NULL,
        [DbColumn(Name = "HBCDE_Repricing")]
        public int HBCDE_Repricing { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_Repricing	int	NULL,
        [DbColumn(Name = "HEINEKENCN_Repricing")]
        public int HEINEKENCN_Repricing { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_Repricing	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_Repricing")]
        public int HEINEKENUS_PROD_Repricing { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_Repricing	int	NULL,
        [DbColumn(Name = "HEINZCR_Repricing")]
        public int HEINZCR_Repricing { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_Repricing	int	NULL,
        [DbColumn(Name = "INBEVAR_Repricing")]
        public int INBEVAR_Repricing { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_Repricing	int	NULL,
        [DbColumn(Name = "INBEVBE_Repricing")]
        public int INBEVBE_Repricing { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_Repricing	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_Repricing")]
        public int INBEVBE_SAND_Repricing { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_Repricing	int	NULL,
        [DbColumn(Name = "INBEVBR_Repricing")]
        public int INBEVBR_Repricing { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_Repricing	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_Repricing")]
        public int INBEVBR_ONTRADE_Repricing { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_Repricing	int	NULL,
        [DbColumn(Name = "INBEVCL_Repricing")]
        public int INBEVCL_Repricing { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_Repricing	int	NULL,
        [DbColumn(Name = "INBEVCN_Repricing")]
        public int INBEVCN_Repricing { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_Repricing	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_Repricing")]
        public int INBEVCOOLERAR_Repricing { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_Repricing	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_Repricing")]
        public int INBEVCOOLERBR_Repricing { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_Repricing	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_Repricing")]
        public int INBEVCOOLERUS_Repricing { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_Repricing	int	NULL,
        [DbColumn(Name = "INBEVFR_Repricing")]
        public int INBEVFR_Repricing { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_Repricing	int	NULL,
        [DbColumn(Name = "INBEVLU_Repricing")]
        public int INBEVLU_Repricing { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_Repricing	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_Repricing")]
        public int INBEVLU_SAND_Repricing { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_Repricing	int	NULL,
        [DbColumn(Name = "INBEVMX_Repricing")]
        public int INBEVMX_Repricing { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_Repricing	int	NULL,
        [DbColumn(Name = "INBEVNL_Repricing")]
        public int INBEVNL_Repricing { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_Repricing	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_Repricing")]
        public int INBEVNL_SAND_Repricing { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_Repricing	int	NULL,
        [DbColumn(Name = "INBEVPY_Repricing")]
        public int INBEVPY_Repricing { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_Repricing	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_Repricing")]
        public int INBEVTRADMX_Repricing { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_Repricing	int	NULL,
        [DbColumn(Name = "INBEVUS_Repricing")]
        public int INBEVUS_Repricing { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_Repricing	int	NULL,
        [DbColumn(Name = "JTIUA_Repricing")]
        public int JTIUA_Repricing { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_Repricing	int	NULL,
        [DbColumn(Name = "KCMY_Repricing")]
        public int KCMY_Repricing { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_Repricing	int	NULL,
        [DbColumn(Name = "KCUS_Repricing")]
        public int KCUS_Repricing { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_Repricing	int	NULL,
        [DbColumn(Name = "KEURIGCA_Repricing")]
        public int KEURIGCA_Repricing { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_Repricing	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_Repricing")]
        public int LABATTPLNOPTCA_Repricing { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_Repricing")]
        public int LAVAZZAAT_Repricing { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_Repricing")]
        public int LAVAZZAAU_Repricing { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZABE_Repricing")]
        public int LAVAZZABE_Repricing { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZABG_Repricing")]
        public int LAVAZZABG_Repricing { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZACA_Repricing")]
        public int LAVAZZACA_Repricing { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZACH_Repricing")]
        public int LAVAZZACH_Repricing { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZACL_Repricing")]
        public int LAVAZZACL_Repricing { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZACN_Repricing")]
        public int LAVAZZACN_Repricing { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_Repricing")]
        public int LAVAZZACZ_Repricing { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZADE_Repricing")]
        public int LAVAZZADE_Repricing { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZADK_Repricing")]
        public int LAVAZZADK_Repricing { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_Repricing")]
        public int LAVAZZAEE_Repricing { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAES_Repricing")]
        public int LAVAZZAES_Repricing { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_Repricing")]
        public int LAVAZZAFR_Repricing { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_Repricing")]
        public int LAVAZZAGR_Repricing { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_Repricing")]
        public int LAVAZZAHK_Repricing { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_Repricing")]
        public int LAVAZZAHR_Repricing { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_Repricing")]
        public int LAVAZZAIL_Repricing { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_Repricing")]
        public int LAVAZZAIT_Repricing { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_Repricing")]
        public int LAVAZZAJP_Repricing { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_Repricing")]
        public int LAVAZZAKR_Repricing { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZALT_Repricing")]
        public int LAVAZZALT_Repricing { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZALU_Repricing")]
        public int LAVAZZALU_Repricing { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZALV_Repricing")]
        public int LAVAZZALV_Repricing { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_Repricing")]
        public int LAVAZZAMA_Repricing { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZANL_Repricing")]
        public int LAVAZZANL_Repricing { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_Repricing")]
        public int LAVAZZAPL_Repricing { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZARO_Repricing")]
        public int LAVAZZARO_Repricing { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZARU_Repricing")]
        public int LAVAZZARU_Repricing { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZASA_Repricing")]
        public int LAVAZZASA_Repricing { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZASE_Repricing")]
        public int LAVAZZASE_Repricing { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZASG_Repricing")]
        public int LAVAZZASG_Repricing { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_Repricing")]
        public int LAVAZZAUAE_Repricing { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_Repricing")]
        public int LAVAZZAUK_Repricing { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_Repricing")]
        public int LAVAZZAUS_Repricing { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_Repricing")]
        public int LAVAZZAZA_Repricing { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_Repricing	int	NULL,
        [DbColumn(Name = "LRSUK_Repricing")]
        public int LRSUK_Repricing { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_Repricing	int	NULL,
        [DbColumn(Name = "MARSBR_Repricing")]
        public int MARSBR_Repricing { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_Repricing	int	NULL,
        [DbColumn(Name = "MARSIN_Repricing")]
        public int MARSIN_Repricing { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_Repricing	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_Repricing")]
        public int MARSIN_OLD_Repricing { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_Repricing	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_Repricing")]
        public int MARSRU_PROD_Repricing { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_Repricing	int	NULL,
        [DbColumn(Name = "MAYORAID_Repricing")]
        public int MAYORAID_Repricing { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_Repricing	int	NULL,
        [DbColumn(Name = "MJNCN_Repricing")]
        public int MJNCN_Repricing { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_Repricing	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_Repricing")]
        public int MOLSONCOOLERHN_Repricing { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_Repricing	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_Repricing")]
        public int MOLSONCOOLERHR_Repricing { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_Repricing	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_Repricing")]
        public int MOLSONCOORSUK_Repricing { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_Repricing	int	NULL,
        [DbColumn(Name = "NESTLEUK_Repricing")]
        public int NESTLEUK_Repricing { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_Repricing	int	NULL,
        [DbColumn(Name = "NIVEAUK_Repricing")]
        public int NIVEAUK_Repricing { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_Repricing")]
        public int NRF2017_DEMO_Repricing { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_Repricing")]
        public int ONE_AMERICAS_DEMO_Repricing { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_Repricing")]
        public int ONE_APAC_DEMO_Repricing { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_Repricing	int	NULL,
        [DbColumn(Name = "PEPSICOBR_Repricing")]
        public int PEPSICOBR_Repricing { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_Repricing	int	NULL,
        [DbColumn(Name = "PNGAU_Repricing")]
        public int PNGAU_Repricing { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_Repricing	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_Repricing")]
        public int PNGAU_OLD_Repricing { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_Repricing	int	NULL,
        [DbColumn(Name = "PNGCAREUS_Repricing")]
        public int PNGCAREUS_Repricing { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_Repricing	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_Repricing")]
        public int PNGCN_PROD_Repricing { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_Repricing	int	NULL,
        [DbColumn(Name = "PNGJP_Repricing")]
        public int PNGJP_Repricing { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_Repricing	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_Repricing")]
        public int PNGJP_OLD_Repricing { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_Repricing	int	NULL,
        [DbColumn(Name = "PNGUS_Repricing")]
        public int PNGUS_Repricing { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_Repricing	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_Repricing")]
        public int PNGUSEPISODIC_Repricing { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_Repricing	int	NULL,
        [DbColumn(Name = "RBUS_Repricing")]
        public int RBUS_Repricing { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_Repricing")]
        public int RE_XSUITE_DEMO_Repricing { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_Repricing")]
        public int REPNGCN_DEMO_Repricing { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "RI_DEMO_Repricing")]
        public int RI_DEMO_Repricing { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_Repricing	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_Repricing")]
        public int RI_DIAGEOAU_Repricing { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_Repricing	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_Repricing")]
        public int RIALCBEVUK_PROD_Repricing { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_Repricing	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_Repricing")]
        public int RICOFFEEUS_Repricing { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_Repricing	int	NULL,
        [DbColumn(Name = "RINIELSENUS_Repricing")]
        public int RINIELSENUS_Repricing { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_Repricing	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_Repricing")]
        public int RIPETCAREUK_PROD_Repricing { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_Repricing	int	NULL,
        [DbColumn(Name = "RIUS_Repricing")]
        public int RIUS_Repricing { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_Repricing	int	NULL,
        [DbColumn(Name = "RIUS_DEV_Repricing")]
        public int RIUS_DEV_Repricing { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_Repricing	int	NULL,
        [DbColumn(Name = "RNBDE_Repricing")]
        public int RNBDE_Repricing { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_Repricing	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_Repricing")]
        public int SMARTCOOLER_POC2_Repricing { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_Repricing	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_Repricing")]
        public int SMARTCOOLER_TRN_Repricing { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_Repricing	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_Repricing")]
        public int SMARTCOOLER2_TRN_Repricing { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_Repricing	int	NULL,
        [DbColumn(Name = "SOLARBR_Repricing")]
        public int SOLARBR_Repricing { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_Repricing	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_Repricing")]
        public int STATIC_CAMERA_DEMO_Repricing { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_Repricing	int	NULL,
        [DbColumn(Name = "SWIRECN_Repricing")]
        public int SWIRECN_Repricing { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_Repricing	int	NULL,
        [DbColumn(Name = "SWIREREDCN_Repricing")]
        public int SWIREREDCN_Repricing { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_Repricing	int	NULL,
        [DbColumn(Name = "TNUVAIL_Repricing")]
        public int TNUVAIL_Repricing { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_Repricing	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_Repricing")]
        public int TRAXDEMO_TS_PROD_Repricing { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_Repricing	int	NULL,
        [DbColumn(Name = "TWEAU_Repricing")]
        public int TWEAU_Repricing { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_Repricing	int	NULL,
        [DbColumn(Name = "RI_DEMO2_Repricing")]
        public int RI_DEMO2_Repricing { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_Repricing	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_Repricing")]
        public int COMPASSCCH_SAND_Repricing { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_Repricing")]
        public int LAVAZZAIT_SAND_Repricing { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_Repricing	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_Repricing")]
        public int INBEVUS_STG_Repricing { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_Repricing	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_Repricing")]
        public int LAVAZZAFR_SAND_Repricing { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_Repricing	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_Repricing")]
        public int INBEVBE_SAND2_Repricing { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_Repricing	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_Repricing")]
        public int INBEVLU_SAND2_Repricing { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_Repricing	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_Repricing")]
        public int INBEVNL_SAND2_Repricing { get; set; }

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