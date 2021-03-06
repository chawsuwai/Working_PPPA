﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "PricingProbes")]
    public class PricingProbesEntity:EntityBase
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

        //TotalPricingProbes	int	NULL,
        [DbColumn(Name = "TotalPricingProbes")]
        public int TotalPricingProbes { get; set; }

        //AvgsecondsperPricingProbes	int	NULL,
        [DbColumn(Name = "AvgsecondsperPricingProbes")]
        public int AvgsecondsperPricingProbes { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_PricingProbes	int	NULL,
        [DbColumn(Name = "ABICA_PricingProbes")]
        public int ABICA_PricingProbes { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_PricingProbes")]
        public int ABITAMSUS_PROD_PricingProbes { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_PricingProbes")]
        public int AMERICAS_DEMO_PricingProbes { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_PricingProbes	int	NULL,
        [DbColumn(Name = "BATRU_PricingProbes")]
        public int BATRU_PricingProbes { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_PricingProbes	int	NULL,
        [DbColumn(Name = "BIKR_PricingProbes")]
        public int BIKR_PricingProbes { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_PricingProbes	int	NULL,
        [DbColumn(Name = "BIMY_PricingProbes")]
        public int BIMY_PricingProbes { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_PricingProbes	int	NULL,
        [DbColumn(Name = "BIPH_PricingProbes")]
        public int BIPH_PricingProbes { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_PricingProbes	int	NULL,
        [DbColumn(Name = "BISEASK_PricingProbes")]
        public int BISEASK_PricingProbes { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_PricingProbes	int	NULL,
        [DbColumn(Name = "BITH_PricingProbes")]
        public int BITH_PricingProbes { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_PricingProbes	int	NULL,
        [DbColumn(Name = "BIVN_PricingProbes")]
        public int BIVN_PricingProbes { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_PricingProbes	int	NULL,
        [DbColumn(Name = "BPAU_PricingProbes")]
        public int BPAU_PricingProbes { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_PricingProbes	int	NULL,
        [DbColumn(Name = "BRODMANN_PricingProbes")]
        public int BRODMANN_PricingProbes { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_PricingProbes	int	NULL,
        [DbColumn(Name = "CARREFOURAR_PricingProbes")]
        public int CARREFOURAR_PricingProbes { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_PricingProbes	int	NULL,
        [DbColumn(Name = "CCAAU_PricingProbes")]
        public int CCAAU_PricingProbes { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_PricingProbes	int	NULL,
        [DbColumn(Name = "CCABIZA_PricingProbes")]
        public int CCABIZA_PricingProbes { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_PricingProbes	int	NULL,
        [DbColumn(Name = "CCANZ_PricingProbes")]
        public int CCANZ_PricingProbes { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_PricingProbes	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_PricingProbes")]
        public int CCBOTTLERSUS_PricingProbes { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "CCBR_PROD_PricingProbes")]
        public int CCBR_PROD_PricingProbes { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_PricingProbes	int	NULL,
        [DbColumn(Name = "CCJP_PricingProbes")]
        public int CCJP_PricingProbes { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_PricingProbes	int	NULL,
        [DbColumn(Name = "CCKH_PricingProbes")]
        public int CCKH_PricingProbes { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_PricingProbes	int	NULL,
        [DbColumn(Name = "CCKR_PricingProbes")]
        public int CCKR_PricingProbes { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_PricingProbes	int	NULL,
        [DbColumn(Name = "CCMY_PricingProbes")]
        public int CCMY_PricingProbes { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_PricingProbes	int	NULL,
        [DbColumn(Name = "CCPH_PricingProbes")]
        public int CCPH_PricingProbes { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_PricingProbes")]
        public int CCRPR_PROD_PricingProbes { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_PricingProbes	int	NULL,
        [DbColumn(Name = "CCRU_PricingProbes")]
        public int CCRU_PricingProbes { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_PricingProbes	int	NULL,
        [DbColumn(Name = "CCTH_PricingProbes")]
        public int CCTH_PricingProbes { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_PricingProbes	int	NULL,
        [DbColumn(Name = "CCTH_UAT_PricingProbes")]
        public int CCTH_UAT_PricingProbes { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_PricingProbes	int	NULL,
        [DbColumn(Name = "CCTRADMX_PricingProbes")]
        public int CCTRADMX_PricingProbes { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_PricingProbes	int	NULL,
        [DbColumn(Name = "CCUS_PricingProbes")]
        public int CCUS_PricingProbes { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_PricingProbes	int	NULL,
        [DbColumn(Name = "CCZA_PricingProbes")]
        public int CCZA_PricingProbes { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_PricingProbes	int	NULL,
        [DbColumn(Name = "CEREBOSTH_PricingProbes")]
        public int CEREBOSTH_PricingProbes { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_PricingProbes	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_PricingProbes")]
        public int CROWDSOURCE_PricingProbes { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOAU_PricingProbes")]
        public int DIAGEOAU_PricingProbes { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOBR_PricingProbes")]
        public int DIAGEOBR_PricingProbes { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOGR_PricingProbes")]
        public int DIAGEOGR_PricingProbes { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOIE_PricingProbes")]
        public int DIAGEOIE_PricingProbes { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOKE_PricingProbes")]
        public int DIAGEOKE_PricingProbes { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOMX_PricingProbes")]
        public int DIAGEOMX_PricingProbes { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOPT_PricingProbes")]
        public int DIAGEOPT_PricingProbes { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOTW_PricingProbes")]
        public int DIAGEOTW_PricingProbes { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOUK_PricingProbes")]
        public int DIAGEOUK_PricingProbes { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_PricingProbes	int	NULL,
        [DbColumn(Name = "DIAGEOZA_PricingProbes")]
        public int DIAGEOZA_PricingProbes { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_PricingProbes")]
        public int EMEA_DEMO_PricingProbes { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_PricingProbes	int	NULL,
        [DbColumn(Name = "FERREROIT_PricingProbes")]
        public int FERREROIT_PricingProbes { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_PricingProbes	int	NULL,
        [DbColumn(Name = "GILLETTEUS_PricingProbes")]
        public int GILLETTEUS_PricingProbes { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_PricingProbes	int	NULL,
        [DbColumn(Name = "GOOGLEUS_PricingProbes")]
        public int GOOGLEUS_PricingProbes { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_PricingProbes	int	NULL,
        [DbColumn(Name = "HBCDE_PricingProbes")]
        public int HBCDE_PricingProbes { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_PricingProbes	int	NULL,
        [DbColumn(Name = "HEINEKENCN_PricingProbes")]
        public int HEINEKENCN_PricingProbes { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_PricingProbes")]
        public int HEINEKENUS_PROD_PricingProbes { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_PricingProbes	int	NULL,
        [DbColumn(Name = "HEINZCR_PricingProbes")]
        public int HEINZCR_PricingProbes { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVAR_PricingProbes")]
        public int INBEVAR_PricingProbes { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVBE_PricingProbes")]
        public int INBEVBE_PricingProbes { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_PricingProbes")]
        public int INBEVBE_SAND_PricingProbes { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVBR_PricingProbes")]
        public int INBEVBR_PricingProbes { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_PricingProbes")]
        public int INBEVBR_ONTRADE_PricingProbes { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVCL_PricingProbes")]
        public int INBEVCL_PricingProbes { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVCN_PricingProbes")]
        public int INBEVCN_PricingProbes { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_PricingProbes")]
        public int INBEVCOOLERAR_PricingProbes { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_PricingProbes")]
        public int INBEVCOOLERBR_PricingProbes { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_PricingProbes")]
        public int INBEVCOOLERUS_PricingProbes { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVFR_PricingProbes")]
        public int INBEVFR_PricingProbes { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVLU_PricingProbes")]
        public int INBEVLU_PricingProbes { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_PricingProbes")]
        public int INBEVLU_SAND_PricingProbes { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVMX_PricingProbes")]
        public int INBEVMX_PricingProbes { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVNL_PricingProbes")]
        public int INBEVNL_PricingProbes { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_PricingProbes")]
        public int INBEVNL_SAND_PricingProbes { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVPY_PricingProbes")]
        public int INBEVPY_PricingProbes { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_PricingProbes")]
        public int INBEVTRADMX_PricingProbes { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVUS_PricingProbes")]
        public int INBEVUS_PricingProbes { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_PricingProbes	int	NULL,
        [DbColumn(Name = "JTIUA_PricingProbes")]
        public int JTIUA_PricingProbes { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_PricingProbes	int	NULL,
        [DbColumn(Name = "KCMY_PricingProbes")]
        public int KCMY_PricingProbes { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_PricingProbes	int	NULL,
        [DbColumn(Name = "KCUS_PricingProbes")]
        public int KCUS_PricingProbes { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_PricingProbes	int	NULL,
        [DbColumn(Name = "KEURIGCA_PricingProbes")]
        public int KEURIGCA_PricingProbes { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_PricingProbes	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_PricingProbes")]
        public int LABATTPLNOPTCA_PricingProbes { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_PricingProbes")]
        public int LAVAZZAAT_PricingProbes { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_PricingProbes")]
        public int LAVAZZAAU_PricingProbes { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZABE_PricingProbes")]
        public int LAVAZZABE_PricingProbes { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZABG_PricingProbes")]
        public int LAVAZZABG_PricingProbes { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZACA_PricingProbes")]
        public int LAVAZZACA_PricingProbes { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZACH_PricingProbes")]
        public int LAVAZZACH_PricingProbes { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZACL_PricingProbes")]
        public int LAVAZZACL_PricingProbes { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZACN_PricingProbes")]
        public int LAVAZZACN_PricingProbes { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_PricingProbes")]
        public int LAVAZZACZ_PricingProbes { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZADE_PricingProbes")]
        public int LAVAZZADE_PricingProbes { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZADK_PricingProbes")]
        public int LAVAZZADK_PricingProbes { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_PricingProbes")]
        public int LAVAZZAEE_PricingProbes { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAES_PricingProbes")]
        public int LAVAZZAES_PricingProbes { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_PricingProbes")]
        public int LAVAZZAFR_PricingProbes { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_PricingProbes")]
        public int LAVAZZAGR_PricingProbes { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_PricingProbes")]
        public int LAVAZZAHK_PricingProbes { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_PricingProbes")]
        public int LAVAZZAHR_PricingProbes { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_PricingProbes")]
        public int LAVAZZAIL_PricingProbes { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_PricingProbes")]
        public int LAVAZZAIT_PricingProbes { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_PricingProbes")]
        public int LAVAZZAJP_PricingProbes { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_PricingProbes")]
        public int LAVAZZAKR_PricingProbes { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZALT_PricingProbes")]
        public int LAVAZZALT_PricingProbes { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZALU_PricingProbes")]
        public int LAVAZZALU_PricingProbes { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZALV_PricingProbes")]
        public int LAVAZZALV_PricingProbes { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_PricingProbes")]
        public int LAVAZZAMA_PricingProbes { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZANL_PricingProbes")]
        public int LAVAZZANL_PricingProbes { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_PricingProbes")]
        public int LAVAZZAPL_PricingProbes { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZARO_PricingProbes")]
        public int LAVAZZARO_PricingProbes { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZARU_PricingProbes")]
        public int LAVAZZARU_PricingProbes { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZASA_PricingProbes")]
        public int LAVAZZASA_PricingProbes { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZASE_PricingProbes")]
        public int LAVAZZASE_PricingProbes { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZASG_PricingProbes")]
        public int LAVAZZASG_PricingProbes { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_PricingProbes")]
        public int LAVAZZAUAE_PricingProbes { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_PricingProbes")]
        public int LAVAZZAUK_PricingProbes { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_PricingProbes")]
        public int LAVAZZAUS_PricingProbes { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_PricingProbes")]
        public int LAVAZZAZA_PricingProbes { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_PricingProbes	int	NULL,
        [DbColumn(Name = "LRSUK_PricingProbes")]
        public int LRSUK_PricingProbes { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_PricingProbes	int	NULL,
        [DbColumn(Name = "MARSBR_PricingProbes")]
        public int MARSBR_PricingProbes { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_PricingProbes	int	NULL,
        [DbColumn(Name = "MARSIN_PricingProbes")]
        public int MARSIN_PricingProbes { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_PricingProbes	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_PricingProbes")]
        public int MARSIN_OLD_PricingProbes { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_PricingProbes")]
        public int MARSRU_PROD_PricingProbes { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_PricingProbes	int	NULL,
        [DbColumn(Name = "MAYORAID_PricingProbes")]
        public int MAYORAID_PricingProbes { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_PricingProbes	int	NULL,
        [DbColumn(Name = "MJNCN_PricingProbes")]
        public int MJNCN_PricingProbes { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_PricingProbes	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_PricingProbes")]
        public int MOLSONCOOLERHN_PricingProbes { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_PricingProbes	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_PricingProbes")]
        public int MOLSONCOOLERHR_PricingProbes { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_PricingProbes	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_PricingProbes")]
        public int MOLSONCOORSUK_PricingProbes { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_PricingProbes	int	NULL,
        [DbColumn(Name = "NESTLEUK_PricingProbes")]
        public int NESTLEUK_PricingProbes { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_PricingProbes	int	NULL,
        [DbColumn(Name = "NIVEAUK_PricingProbes")]
        public int NIVEAUK_PricingProbes { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_PricingProbes")]
        public int NRF2017_DEMO_PricingProbes { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_PricingProbes")]
        public int ONE_AMERICAS_DEMO_PricingProbes { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_PricingProbes")]
        public int ONE_APAC_DEMO_PricingProbes { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_PricingProbes	int	NULL,
        [DbColumn(Name = "PEPSICOBR_PricingProbes")]
        public int PEPSICOBR_PricingProbes { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGAU_PricingProbes")]
        public int PNGAU_PricingProbes { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_PricingProbes")]
        public int PNGAU_OLD_PricingProbes { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGCAREUS_PricingProbes")]
        public int PNGCAREUS_PricingProbes { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_PricingProbes")]
        public int PNGCN_PROD_PricingProbes { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGJP_PricingProbes")]
        public int PNGJP_PricingProbes { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_PricingProbes")]
        public int PNGJP_OLD_PricingProbes { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGUS_PricingProbes")]
        public int PNGUS_PricingProbes { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_PricingProbes	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_PricingProbes")]
        public int PNGUSEPISODIC_PricingProbes { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_PricingProbes	int	NULL,
        [DbColumn(Name = "RBUS_PricingProbes")]
        public int RBUS_PricingProbes { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_PricingProbes")]
        public int RE_XSUITE_DEMO_PricingProbes { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_PricingProbes")]
        public int REPNGCN_DEMO_PricingProbes { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "RI_DEMO_PricingProbes")]
        public int RI_DEMO_PricingProbes { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_PricingProbes	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_PricingProbes")]
        public int RI_DIAGEOAU_PricingProbes { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_PricingProbes")]
        public int RIALCBEVUK_PROD_PricingProbes { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_PricingProbes	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_PricingProbes")]
        public int RICOFFEEUS_PricingProbes { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_PricingProbes	int	NULL,
        [DbColumn(Name = "RINIELSENUS_PricingProbes")]
        public int RINIELSENUS_PricingProbes { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_PricingProbes")]
        public int RIPETCAREUK_PROD_PricingProbes { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_PricingProbes	int	NULL,
        [DbColumn(Name = "RIUS_PricingProbes")]
        public int RIUS_PricingProbes { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_PricingProbes	int	NULL,
        [DbColumn(Name = "RIUS_DEV_PricingProbes")]
        public int RIUS_DEV_PricingProbes { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_PricingProbes	int	NULL,
        [DbColumn(Name = "RNBDE_PricingProbes")]
        public int RNBDE_PricingProbes { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_PricingProbes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_PricingProbes")]
        public int SMARTCOOLER_POC2_PricingProbes { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_PricingProbes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_PricingProbes")]
        public int SMARTCOOLER_TRN_PricingProbes { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_PricingProbes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_PricingProbes")]
        public int SMARTCOOLER2_TRN_PricingProbes { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_PricingProbes	int	NULL,
        [DbColumn(Name = "SOLARBR_PricingProbes")]
        public int SOLARBR_PricingProbes { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_PricingProbes	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_PricingProbes")]
        public int STATIC_CAMERA_DEMO_PricingProbes { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_PricingProbes	int	NULL,
        [DbColumn(Name = "SWIRECN_PricingProbes")]
        public int SWIRECN_PricingProbes { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_PricingProbes	int	NULL,
        [DbColumn(Name = "SWIREREDCN_PricingProbes")]
        public int SWIREREDCN_PricingProbes { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_PricingProbes	int	NULL,
        [DbColumn(Name = "TNUVAIL_PricingProbes")]
        public int TNUVAIL_PricingProbes { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_PricingProbes	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_PricingProbes")]
        public int TRAXDEMO_TS_PROD_PricingProbes { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_PricingProbes	int	NULL,
        [DbColumn(Name = "TWEAU_PricingProbes")]
        public int TWEAU_PricingProbes { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_PricingProbes	int	NULL,
        [DbColumn(Name = "RI_DEMO2_PricingProbes")]
        public int RI_DEMO2_PricingProbes { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_PricingProbes	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_PricingProbes")]
        public int COMPASSCCH_SAND_PricingProbes { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_PricingProbes")]
        public int LAVAZZAIT_SAND_PricingProbes { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_PricingProbes")]
        public int INBEVUS_STG_PricingProbes { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_PricingProbes	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_PricingProbes")]
        public int LAVAZZAFR_SAND_PricingProbes { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_PricingProbes")]
        public int INBEVBE_SAND2_PricingProbes { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_PricingProbes")]
        public int INBEVLU_SAND2_PricingProbes { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_PricingProbes	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_PricingProbes")]
        public int INBEVNL_SAND2_PricingProbes { get; set; }

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