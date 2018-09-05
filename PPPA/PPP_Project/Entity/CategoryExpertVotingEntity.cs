﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "CategoryExpertVoting")]
    public class CategoryExpertVotingEntity : EntityBase
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

        //TotalCategoryExpertVoting	int	NULL,
        [DbColumn(Name = "TotalCategoryExpertVoting")]
        public int TotalCategoryExpertVoting { get; set; }

        //AvgsecondsperCategoryExpertVoting	int	NULL,
        [DbColumn(Name = "AvgsecondsperCategoryExpertVoting")]
        public int AvgsecondsperCategoryExpertVoting { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "ABICA_CategoryExpertVoting")]
        public int ABICA_CategoryExpertVoting { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_CategoryExpertVoting")]
        public int ABITAMSUS_PROD_CategoryExpertVoting { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_CategoryExpertVoting")]
        public int AMERICAS_DEMO_CategoryExpertVoting { get; set; }

        // BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BATRU_CategoryExpertVoting")]
        public int BATRU_CategoryExpertVoting { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BIKR_CategoryExpertVoting")]
        public int BIKR_CategoryExpertVoting { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BIMY_CategoryExpertVoting")]
        public int BIMY_CategoryExpertVoting { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BIPH_CategoryExpertVoting")]
        public int BIPH_CategoryExpertVoting { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BISEASK_CategoryExpertVoting")]
        public int BISEASK_CategoryExpertVoting { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BITH_CategoryExpertVoting")]
        public int BITH_CategoryExpertVoting { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BIVN_CategoryExpertVoting")]
        public int BIVN_CategoryExpertVoting { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BPAU_CategoryExpertVoting")]
        public int BPAU_CategoryExpertVoting { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "BRODMANN_CategoryExpertVoting")]
        public int BRODMANN_CategoryExpertVoting { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CARREFOURAR_CategoryExpertVoting")]
        public int CARREFOURAR_CategoryExpertVoting { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCAAU_CategoryExpertVoting")]
        public int CCAAU_CategoryExpertVoting { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCABIZA_CategoryExpertVoting")]
        public int CCABIZA_CategoryExpertVoting { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCANZ_CategoryExpertVoting")]
        public int CCANZ_CategoryExpertVoting { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_CategoryExpertVoting")]
        public int CCBOTTLERSUS_CategoryExpertVoting { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCBR_PROD_CategoryExpertVoting")]
        public int CCBR_PROD_CategoryExpertVoting { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCJP_CategoryExpertVoting")]
        public int CCJP_CategoryExpertVoting { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCKH_CategoryExpertVoting")]
        public int CCKH_CategoryExpertVoting { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCKR_CategoryExpertVoting")]
        public int CCKR_CategoryExpertVoting { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCMY_CategoryExpertVoting")]
        public int CCMY_CategoryExpertVoting { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCPH_CategoryExpertVoting")]
        public int CCPH_CategoryExpertVoting { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_CategoryExpertVoting")]
        public int CCRPR_PROD_CategoryExpertVoting { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCRU_CategoryExpertVoting")]
        public int CCRU_CategoryExpertVoting { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCTH_CategoryExpertVoting")]
        public int CCTH_CategoryExpertVoting { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCTH_UAT_CategoryExpertVoting")]
        public int CCTH_UAT_CategoryExpertVoting { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCTRADMX_CategoryExpertVoting")]
        public int CCTRADMX_CategoryExpertVoting { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCUS_CategoryExpertVoting")]
        public int CCUS_CategoryExpertVoting { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CCZA_CategoryExpertVoting")]
        public int CCZA_CategoryExpertVoting { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CEREBOSTH_CategoryExpertVoting")]
        public int CEREBOSTH_CategoryExpertVoting { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_CategoryExpertVoting")]
        public int CROWDSOURCE_CategoryExpertVoting { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOAU_CategoryExpertVoting")]
        public int DIAGEOAU_CategoryExpertVoting { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOBR_CategoryExpertVoting")]
        public int DIAGEOBR_CategoryExpertVoting { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOGR_CategoryExpertVoting")]
        public int DIAGEOGR_CategoryExpertVoting { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOIE_CategoryExpertVoting")]
        public int DIAGEOIE_CategoryExpertVoting { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOKE_CategoryExpertVoting")]
        public int DIAGEOKE_CategoryExpertVoting { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOMX_CategoryExpertVoting")]
        public int DIAGEOMX_CategoryExpertVoting { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOPT_CategoryExpertVoting")]
        public int DIAGEOPT_CategoryExpertVoting { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOTW_CategoryExpertVoting")]
        public int DIAGEOTW_CategoryExpertVoting { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOUK_CategoryExpertVoting")]
        public int DIAGEOUK_CategoryExpertVoting { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "DIAGEOZA_CategoryExpertVoting")]
        public int DIAGEOZA_CategoryExpertVoting { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_CategoryExpertVoting")]
        public int EMEA_DEMO_CategoryExpertVoting { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "FERREROIT_CategoryExpertVoting")]
        public int FERREROIT_CategoryExpertVoting { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "GILLETTEUS_CategoryExpertVoting")]
        public int GILLETTEUS_CategoryExpertVoting { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "GOOGLEUS_CategoryExpertVoting")]
        public int GOOGLEUS_CategoryExpertVoting { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "HBCDE_CategoryExpertVoting")]
        public int HBCDE_CategoryExpertVoting { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "HEINEKENCN_CategoryExpertVoting")]
        public int HEINEKENCN_CategoryExpertVoting { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_CategoryExpertVoting")]
        public int HEINEKENUS_PROD_CategoryExpertVoting { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "HEINZCR_CategoryExpertVoting")]
        public int HEINZCR_CategoryExpertVoting { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVAR_CategoryExpertVoting")]
        public int INBEVAR_CategoryExpertVoting { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVBE_CategoryExpertVoting")]
        public int INBEVBE_CategoryExpertVoting { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_CategoryExpertVoting")]
        public int INBEVBE_SAND_CategoryExpertVoting { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVBR_CategoryExpertVoting")]
        public int INBEVBR_CategoryExpertVoting { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_CategoryExpertVoting")]
        public int INBEVBR_ONTRADE_CategoryExpertVoting { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVCL_CategoryExpertVoting")]
        public int INBEVCL_CategoryExpertVoting { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVCN_CategoryExpertVoting")]
        public int INBEVCN_CategoryExpertVoting { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_CategoryExpertVoting")]
        public int INBEVCOOLERAR_CategoryExpertVoting { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_CategoryExpertVoting")]
        public int INBEVCOOLERBR_CategoryExpertVoting { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_CategoryExpertVoting")]
        public int INBEVCOOLERUS_CategoryExpertVoting { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVFR_CategoryExpertVoting")]
        public int INBEVFR_CategoryExpertVoting { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVLU_CategoryExpertVoting")]
        public int INBEVLU_CategoryExpertVoting { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_CategoryExpertVoting")]
        public int INBEVLU_SAND_CategoryExpertVoting { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVMX_CategoryExpertVoting")]
        public int INBEVMX_CategoryExpertVoting { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVNL_CategoryExpertVoting")]
        public int INBEVNL_CategoryExpertVoting { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_CategoryExpertVoting")]
        public int INBEVNL_SAND_CategoryExpertVoting { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVPY_CategoryExpertVoting")]
        public int INBEVPY_CategoryExpertVoting { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_CategoryExpertVoting")]
        public int INBEVTRADMX_CategoryExpertVoting { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVUS_CategoryExpertVoting")]
        public int INBEVUS_CategoryExpertVoting { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "JTIUA_CategoryExpertVoting")]
        public int JTIUA_CategoryExpertVoting { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "KCMY_CategoryExpertVoting")]
        public int KCMY_CategoryExpertVoting { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "KCUS_CategoryExpertVoting")]
        public int KCUS_CategoryExpertVoting { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "KEURIGCA_CategoryExpertVoting")]
        public int KEURIGCA_CategoryExpertVoting { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_CategoryExpertVoting")]
        public int LABATTPLNOPTCA_CategoryExpertVoting { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_CategoryExpertVoting")]
        public int LAVAZZAAT_CategoryExpertVoting { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_CategoryExpertVoting")]
        public int LAVAZZAAU_CategoryExpertVoting { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZABE_CategoryExpertVoting")]
        public int LAVAZZABE_CategoryExpertVoting { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZABG_CategoryExpertVoting")]
        public int LAVAZZABG_CategoryExpertVoting { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZACA_CategoryExpertVoting")]
        public int LAVAZZACA_CategoryExpertVoting { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZACH_CategoryExpertVoting")]
        public int LAVAZZACH_CategoryExpertVoting { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZACL_CategoryExpertVoting")]
        public int LAVAZZACL_CategoryExpertVoting { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZACN_CategoryExpertVoting")]
        public int LAVAZZACN_CategoryExpertVoting { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_CategoryExpertVoting")]
        public int LAVAZZACZ_CategoryExpertVoting { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZADE_CategoryExpertVoting")]
        public int LAVAZZADE_CategoryExpertVoting { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZADK_CategoryExpertVoting")]
        public int LAVAZZADK_CategoryExpertVoting { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_CategoryExpertVoting")]
        public int LAVAZZAEE_CategoryExpertVoting { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAES_CategoryExpertVoting")]
        public int LAVAZZAES_CategoryExpertVoting { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_CategoryExpertVoting")]
        public int LAVAZZAFR_CategoryExpertVoting { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_CategoryExpertVoting")]
        public int LAVAZZAGR_CategoryExpertVoting { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_CategoryExpertVoting")]
        public int LAVAZZAHK_CategoryExpertVoting { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_CategoryExpertVoting")]
        public int LAVAZZAHR_CategoryExpertVoting { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_CategoryExpertVoting")]
        public int LAVAZZAIL_CategoryExpertVoting { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_CategoryExpertVoting")]
        public int LAVAZZAIT_CategoryExpertVoting { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_CategoryExpertVoting")]
        public int LAVAZZAJP_CategoryExpertVoting { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_CategoryExpertVoting")]
        public int LAVAZZAKR_CategoryExpertVoting { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZALT_CategoryExpertVoting")]
        public int LAVAZZALT_CategoryExpertVoting { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZALU_CategoryExpertVoting")]
        public int LAVAZZALU_CategoryExpertVoting { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZALV_CategoryExpertVoting")]
        public int LAVAZZALV_CategoryExpertVoting { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_CategoryExpertVoting")]
        public int LAVAZZAMA_CategoryExpertVoting { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZANL_CategoryExpertVoting")]
        public int LAVAZZANL_CategoryExpertVoting { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_CategoryExpertVoting")]
        public int LAVAZZAPL_CategoryExpertVoting { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZARO_CategoryExpertVoting")]
        public int LAVAZZARO_CategoryExpertVoting { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZARU_CategoryExpertVoting")]
        public int LAVAZZARU_CategoryExpertVoting { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZASA_CategoryExpertVoting")]
        public int LAVAZZASA_CategoryExpertVoting { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZASE_CategoryExpertVoting")]
        public int LAVAZZASE_CategoryExpertVoting { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZASG_CategoryExpertVoting")]
        public int LAVAZZASG_CategoryExpertVoting { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_CategoryExpertVoting")]
        public int LAVAZZAUAE_CategoryExpertVoting { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_CategoryExpertVoting")]
        public int LAVAZZAUK_CategoryExpertVoting { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_CategoryExpertVoting")]
        public int LAVAZZAUS_CategoryExpertVoting { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_CategoryExpertVoting")]
        public int LAVAZZAZA_CategoryExpertVoting { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LRSUK_CategoryExpertVoting")]
        public int LRSUK_CategoryExpertVoting { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MARSBR_CategoryExpertVoting")]
        public int MARSBR_CategoryExpertVoting { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MARSIN_CategoryExpertVoting")]
        public int MARSIN_CategoryExpertVoting { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_CategoryExpertVoting")]
        public int MARSIN_OLD_CategoryExpertVoting { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_CategoryExpertVoting")]
        public int MARSRU_PROD_CategoryExpertVoting { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MAYORAID_CategoryExpertVoting")]
        public int MAYORAID_CategoryExpertVoting { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MJNCN_CategoryExpertVoting")]
        public int MJNCN_CategoryExpertVoting { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_CategoryExpertVoting")]
        public int MOLSONCOOLERHN_CategoryExpertVoting { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_CategoryExpertVoting")]
        public int MOLSONCOOLERHR_CategoryExpertVoting { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_CategoryExpertVoting")]
        public int MOLSONCOORSUK_CategoryExpertVoting { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "NESTLEUK_CategoryExpertVoting")]
        public int NESTLEUK_CategoryExpertVoting { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "NIVEAUK_CategoryExpertVoting")]
        public int NIVEAUK_CategoryExpertVoting { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_CategoryExpertVoting")]
        public int NRF2017_DEMO_CategoryExpertVoting { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_CategoryExpertVoting")]
        public int ONE_AMERICAS_DEMO_CategoryExpertVoting { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_CategoryExpertVoting")]
        public int ONE_APAC_DEMO_CategoryExpertVoting { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PEPSICOBR_CategoryExpertVoting")]
        public int PEPSICOBR_CategoryExpertVoting { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGAU_CategoryExpertVoting")]
        public int PNGAU_CategoryExpertVoting { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_CategoryExpertVoting")]
        public int PNGAU_OLD_CategoryExpertVoting { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGCAREUS_CategoryExpertVoting")]
        public int PNGCAREUS_CategoryExpertVoting { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_CategoryExpertVoting")]
        public int PNGCN_PROD_CategoryExpertVoting { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGJP_CategoryExpertVoting")]
        public int PNGJP_CategoryExpertVoting { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_CategoryExpertVoting")]
        public int PNGJP_OLD_CategoryExpertVoting { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGUS_CategoryExpertVoting")]
        public int PNGUS_CategoryExpertVoting { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_CategoryExpertVoting")]
        public int PNGUSEPISODIC_CategoryExpertVoting { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RBUS_CategoryExpertVoting")]
        public int RBUS_CategoryExpertVoting { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_CategoryExpertVoting")]
        public int RE_XSUITE_DEMO_CategoryExpertVoting { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_CategoryExpertVoting")]
        public int REPNGCN_DEMO_CategoryExpertVoting { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RI_DEMO_CategoryExpertVoting")]
        public int RI_DEMO_CategoryExpertVoting { get; set; }
        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_CategoryExpertVoting")]
        public int RI_DIAGEOAU_CategoryExpertVoting { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_CategoryExpertVoting")]
        public int RIALCBEVUK_PROD_CategoryExpertVoting { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_CategoryExpertVoting")]
        public int RICOFFEEUS_CategoryExpertVoting { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RINIELSENUS_CategoryExpertVoting")]
        public int RINIELSENUS_CategoryExpertVoting { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_CategoryExpertVoting")]
        public int RIPETCAREUK_PROD_CategoryExpertVoting { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RIUS_CategoryExpertVoting")]
        public int RIUS_CategoryExpertVoting { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RIUS_DEV_CategoryExpertVoting")]
        public int RIUS_DEV_CategoryExpertVoting { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RNBDE_CategoryExpertVoting")]
        public int RNBDE_CategoryExpertVoting { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_CategoryExpertVoting")]
        public int SMARTCOOLER_POC2_CategoryExpertVoting { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_CategoryExpertVoting")]
        public int SMARTCOOLER_TRN_CategoryExpertVoting { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_CategoryExpertVoting")]
        public int SMARTCOOLER2_TRN_CategoryExpertVoting { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "SOLARBR_CategoryExpertVoting")]
        public int SOLARBR_CategoryExpertVoting { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_CategoryExpertVoting")]
        public int STATIC_CAMERA_DEMO_CategoryExpertVoting { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "SWIRECN_CategoryExpertVoting")]
        public int SWIRECN_CategoryExpertVoting { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "SWIREREDCN_CategoryExpertVoting")]
        public int SWIREREDCN_CategoryExpertVoting { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "TNUVAIL_CategoryExpertVoting")]
        public int TNUVAIL_CategoryExpertVoting { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_CategoryExpertVoting")]
        public int TRAXDEMO_TS_PROD_CategoryExpertVoting { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "TWEAU_CategoryExpertVoting")]
        public int TWEAU_CategoryExpertVoting { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "RI_DEMO2_CategoryExpertVoting")]
        public int RI_DEMO2_CategoryExpertVoting { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_CategoryExpertVoting")]
        public int COMPASSCCH_SAND_CategoryExpertVoting { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_CategoryExpertVoting")]
        public int LAVAZZAIT_SAND_CategoryExpertVoting { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_CategoryExpertVoting")]
        public int INBEVUS_STG_CategoryExpertVoting { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_CategoryExpertVoting")]
        public int LAVAZZAFR_SAND_CategoryExpertVoting { get; set; }

        //INBEVBE_SAND2	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_CategoryExpertVoting")]
        public int INBEVBE_SAND2_CategoryExpertVoting { get; set; }

        //INBEVLU_SAND2	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_CategoryExpertVoting")]
        public int INBEVLU_SAND2_CategoryExpertVoting { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_CategoryExpertVoting	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_CategoryExpertVoting")]
        public int INBEVNL_SAND2_CategoryExpertVoting { get; set; }

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