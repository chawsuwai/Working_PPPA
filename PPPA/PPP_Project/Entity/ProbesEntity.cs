﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Probes")]
    public class ProbesEntity:EntityBase
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
        
        //TotalProbes	int	NULL,
        [DbColumn(Name = "TotalProbes")]
        public int TotalProbes { get; set; }

        //AvgsecondsperProbes	int	NULL,
        [DbColumn(Name = "AvgsecondsperProbes")]
        public int AvgsecondsperProbes { get; set; }

        //ABICA	int	NULL,
        [DbColumn(Name = "ABICA")]
        public int ABICA { get; set; }

        //ABICA_Probes	int	NULL,
        [DbColumn(Name = "ABICA_Probes")]
        public int ABICA_Probes { get; set; }

        //ABITAMSUS_PROD	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD")]
        public int ABITAMSUS_PROD { get; set; }

        //ABITAMSUS_PROD_Probes	int	NULL,
        [DbColumn(Name = "ABITAMSUS_PROD_Probes")]
        public int ABITAMSUS_PROD_Probes { get; set; }

        //AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO")]
        public int AMERICAS_DEMO { get; set; }

        //AMERICAS_DEMO_Probes	int	NULL,
        [DbColumn(Name = "AMERICAS_DEMO_Probes")]
        public int AMERICAS_DEMO_Probes { get; set; }

        //BATRU	int	NULL,
        [DbColumn(Name = "BATRU")]
        public int BATRU { get; set; }

        //BATRU_Probes	int	NULL,
        [DbColumn(Name = "BATRU_Probes")]
        public int BATRU_Probes { get; set; }

        //BIKR	int	NULL,
        [DbColumn(Name = "BIKR")]
        public int BIKR { get; set; }

        //BIKR_Probes	int	NULL,
        [DbColumn(Name = "BIKR_Probes")]
        public int BIKR_Probes { get; set; }

        //BIMY	int	NULL,
        [DbColumn(Name = "BIMY")]
        public int BIMY { get; set; }

        //BIMY_Probes	int	NULL,
        [DbColumn(Name = "BIMY_Probes")]
        public int BIMY_Probes { get; set; }

        //BIPH	int	NULL,
        [DbColumn(Name = "BIPH")]
        public int BIPH { get; set; }

        //BIPH_Probes	int	NULL,
        [DbColumn(Name = "BIPH_Probes")]
        public int BIPH_Probes { get; set; }

        //BISEASK	int	NULL,
        [DbColumn(Name = "BISEASK")]
        public int BISEASK { get; set; }

        //BISEASK_Probes	int	NULL,
        [DbColumn(Name = "BISEASK_Probes")]
        public int BISEASK_Probes { get; set; }

        //BITH	int	NULL,
        [DbColumn(Name = "BITH")]
        public int BITH { get; set; }

        //BITH_Probes	int	NULL,
        [DbColumn(Name = "BITH_Probes")]
        public int BITH_Probes { get; set; }

        //BIVN	int	NULL,
        [DbColumn(Name = "BIVN")]
        public int BIVN { get; set; }

        //BIVN_Probes	int	NULL,
        [DbColumn(Name = "BIVN_Probes")]
        public int BIVN_Probes { get; set; }

        //BPAU	int	NULL,
        [DbColumn(Name = "BPAU")]
        public int BPAU { get; set; }

        //BPAU_Probes	int	NULL,
        [DbColumn(Name = "BPAU_Probes")]
        public int BPAU_Probes { get; set; }

        //BRODMANN	int	NULL,
        [DbColumn(Name = "BRODMANN")]
        public int BRODMANN { get; set; }

        //BRODMANN_Probes	int	NULL,
        [DbColumn(Name = "BRODMANN_Probes")]
        public int BRODMANN_Probes { get; set; }

        //CARREFOURAR	int	NULL,
        [DbColumn(Name = "CARREFOURAR")]
        public int CARREFOURAR { get; set; }

        //CARREFOURAR_Probes	int	NULL,
        [DbColumn(Name = "CARREFOURAR_Probes")]
        public int CARREFOURAR_Probes { get; set; }

        //CCAAU	int	NULL,
        [DbColumn(Name = "CCAAU")]
        public int CCAAU { get; set; }

        //CCAAU_Probes	int	NULL,
        [DbColumn(Name = "CCAAU_Probes")]
        public int CCAAU_Probes { get; set; }

        //CCABIZA	int	NULL,
        [DbColumn(Name = "CCABIZA")]
        public int CCABIZA { get; set; }

        //CCABIZA_Probes	int	NULL,
        [DbColumn(Name = "CCABIZA_Probes")]
        public int CCABIZA_Probes { get; set; }

        //CCANZ	int	NULL,
        [DbColumn(Name = "CCANZ")]
        public int CCANZ { get; set; }

        //CCANZ_Probes	int	NULL,
        [DbColumn(Name = "CCANZ_Probes")]
        public int CCANZ_Probes { get; set; }

        //CCBOTTLERSUS	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS")]
        public int CCBOTTLERSUS { get; set; }

        //CCBOTTLERSUS_Probes	int	NULL,
        [DbColumn(Name = "CCBOTTLERSUS_Probes")]
        public int CCBOTTLERSUS_Probes { get; set; }

        //CCBR_PROD	int	NULL,
        [DbColumn(Name = "CCBR_PROD")]
        public int CCBR_PROD { get; set; }

        //CCBR_PROD_Probes	int	NULL,
        [DbColumn(Name = "CCBR_PROD_Probes")]
        public int CCBR_PROD_Probes { get; set; }

        //CCJP	int	NULL,
        [DbColumn(Name = "CCJP")]
        public int CCJP { get; set; }

        //CCJP_Probes	int	NULL,
        [DbColumn(Name = "CCJP_Probes")]
        public int CCJP_Probes { get; set; }

        //CCKH	int	NULL,
        [DbColumn(Name = "CCKH")]
        public int CCKH { get; set; }

        //CCKH_Probes	int	NULL,
        [DbColumn(Name = "CCKH_Probes")]
        public int CCKH_Probes { get; set; }

        //CCKR	int	NULL,
        [DbColumn(Name = "CCKR")]
        public int CCKR { get; set; }

        //CCKR_Probes	int	NULL,
        [DbColumn(Name = "CCKR_Probes")]
        public int CCKR_Probes { get; set; }

        //CCMY	int	NULL,
        [DbColumn(Name = "CCMY")]
        public int CCMY { get; set; }

        //CCMY_Probes	int	NULL,
        [DbColumn(Name = "CCMY_Probes")]
        public int CCMY_Probes { get; set; }

        //CCPH	int	NULL,
        [DbColumn(Name = "CCPH")]
        public int CCPH { get; set; }

        //CCPH_Probes	int	NULL,
        [DbColumn(Name = "CCPH_Probes")]
        public int CCPH_Probes { get; set; }

        //CCRPR_PROD	int	NULL,
        [DbColumn(Name = "CCRPR_PROD")]
        public int CCRPR_PROD { get; set; }

        //CCRPR_PROD_Probes	int	NULL,
        [DbColumn(Name = "CCRPR_PROD_Probes")]
        public int CCRPR_PROD_Probes { get; set; }

        //CCRU	int	NULL,
        [DbColumn(Name = "CCRU")]
        public int CCRU { get; set; }

        //CCRU_Probes	int	NULL,
        [DbColumn(Name = "CCRU_Probes")]
        public int CCRU_Probes { get; set; }

        //CCTH	int	NULL,
        [DbColumn(Name = "CCTH")]
        public int CCTH { get; set; }

        //CCTH_Probes	int	NULL,
        [DbColumn(Name = "CCTH_Probes")]
        public int CCTH_Probes { get; set; }

        //CCTH_UAT	int	NULL,
        [DbColumn(Name = "CCTH_UAT")]
        public int CCTH_UAT { get; set; }

        //CCTH_UAT_Probes	int	NULL,
        [DbColumn(Name = "CCTH_UAT_Probes")]
        public int CCTH_UAT_Probes { get; set; }

        //CCTRADMX	int	NULL,
        [DbColumn(Name = "CCTRADMX")]
        public int CCTRADMX { get; set; }

        //CCTRADMX_Probes	int	NULL,
        [DbColumn(Name = "CCTRADMX_Probes")]
        public int CCTRADMX_Probes { get; set; }

        //CCUS	int	NULL,
        [DbColumn(Name = "CCUS")]
        public int CCUS { get; set; }

        //CCUS_Probes	int	NULL,
        [DbColumn(Name = "CCUS_Probes")]
        public int CCUS_Probes { get; set; }

        //CCZA	int	NULL,
        [DbColumn(Name = "CCZA")]
        public int CCZA { get; set; }

        //CCZA_Probes	int	NULL,
        [DbColumn(Name = "CCZA_Probes")]
        public int CCZA_Probes { get; set; }

        //CEREBOSTH	int	NULL,
        [DbColumn(Name = "CEREBOSTH")]
        public int CEREBOSTH { get; set; }

        //CEREBOSTH_Probes	int	NULL,
        [DbColumn(Name = "CEREBOSTH_Probes")]
        public int CEREBOSTH_Probes { get; set; }

        //CROWDSOURCE	int	NULL,
        [DbColumn(Name = "CROWDSOURCE")]
        public int CROWDSOURCE { get; set; }

        //CROWDSOURCE_Probes	int	NULL,
        [DbColumn(Name = "CROWDSOURCE_Probes")]
        public int CROWDSOURCE_Probes { get; set; }

        //DIAGEOAU	int	NULL,
        [DbColumn(Name = "DIAGEOAU")]
        public int DIAGEOAU { get; set; }

        //DIAGEOAU_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOAU_Probes")]
        public int DIAGEOAU_Probes { get; set; }

        //DIAGEOBR	int	NULL,
        [DbColumn(Name = "DIAGEOBR")]
        public int DIAGEOBR { get; set; }

        //DIAGEOBR_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOBR_Probes")]
        public int DIAGEOBR_Probes { get; set; }

        //DIAGEOGR	int	NULL,
        [DbColumn(Name = "DIAGEOGR")]
        public int DIAGEOGR { get; set; }

        //DIAGEOGR_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOGR_Probes")]
        public int DIAGEOGR_Probes { get; set; }

        //DIAGEOIE	int	NULL,
        [DbColumn(Name = "DIAGEOIE")]
        public int DIAGEOIE { get; set; }

        //DIAGEOIE_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOIE_Probes")]
        public int DIAGEOIE_Probes { get; set; }

        //DIAGEOKE	int	NULL,
        [DbColumn(Name = "DIAGEOKE")]
        public int DIAGEOKE { get; set; }

        //DIAGEOKE_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOKE_Probes")]
        public int DIAGEOKE_Probes { get; set; }

        //DIAGEOMX	int	NULL,
        [DbColumn(Name = "DIAGEOMX")]
        public int DIAGEOMX { get; set; }

        //DIAGEOMX_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOMX_Probes")]
        public int DIAGEOMX_Probes { get; set; }

        //DIAGEOPT	int	NULL,
        [DbColumn(Name = "DIAGEOPT")]
        public int DIAGEOPT { get; set; }

        //DIAGEOPT_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOPT_Probes")]
        public int DIAGEOPT_Probes { get; set; }

        //DIAGEOTW	int	NULL,
        [DbColumn(Name = "DIAGEOTW")]
        public int DIAGEOTW { get; set; }

        //DIAGEOTW_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOTW_Probes")]
        public int DIAGEOTW_Probes { get; set; }

        //DIAGEOUK	int	NULL,
        [DbColumn(Name = "DIAGEOUK")]
        public int DIAGEOUK { get; set; }

        //DIAGEOUK_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOUK_Probes")]
        public int DIAGEOUK_Probes { get; set; }

        //DIAGEOZA	int	NULL,
        [DbColumn(Name = "DIAGEOZA")]
        public int DIAGEOZA { get; set; }

        //DIAGEOZA_Probes	int	NULL,
        [DbColumn(Name = "DIAGEOZA_Probes")]
        public int DIAGEOZA_Probes { get; set; }

        //EMEA_DEMO	int	NULL,
        [DbColumn(Name = "EMEA_DEMO")]
        public int EMEA_DEMO { get; set; }

        //EMEA_DEMO_Probes	int	NULL,
        [DbColumn(Name = "EMEA_DEMO_Probes")]
        public int EMEA_DEMO_Probes { get; set; }

        //FERREROIT	int	NULL,
        [DbColumn(Name = "FERREROIT")]
        public int FERREROIT { get; set; }

        //FERREROIT_Probes	int	NULL,
        [DbColumn(Name = "FERREROIT_Probes")]
        public int FERREROIT_Probes { get; set; }

        //GILLETTEUS	int	NULL,
        [DbColumn(Name = "GILLETTEUS")]
        public int GILLETTEUS { get; set; }

        //GILLETTEUS_Probes	int	NULL,
        [DbColumn(Name = "GILLETTEUS_Probes")]
        public int GILLETTEUS_Probes { get; set; }

        //GOOGLEUS	int	NULL,
        [DbColumn(Name = "GOOGLEUS")]
        public int GOOGLEUS { get; set; }

        //GOOGLEUS_Probes	int	NULL,
        [DbColumn(Name = "GOOGLEUS_Probes")]
        public int GOOGLEUS_Probes { get; set; }

        //HBCDE	int	NULL,
        [DbColumn(Name = "HBCDE")]
        public int HBCDE { get; set; }

        //HBCDE_Probes	int	NULL,
        [DbColumn(Name = "HBCDE_Probes")]
        public int HBCDE_Probes { get; set; }

        //HEINEKENCN	int	NULL,
        [DbColumn(Name = "HEINEKENCN")]
        public int HEINEKENCN { get; set; }

        //HEINEKENCN_Probes	int	NULL,
        [DbColumn(Name = "HEINEKENCN_Probes")]
        public int HEINEKENCN_Probes { get; set; }

        //HEINEKENUS_PROD	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD")]
        public int HEINEKENUS_PROD { get; set; }

        //HEINEKENUS_PROD_Probes	int	NULL,
        [DbColumn(Name = "HEINEKENUS_PROD_Probes")]
        public int HEINEKENUS_PROD_Probes { get; set; }

        //HEINZCR	int	NULL,
        [DbColumn(Name = "HEINZCR")]
        public int HEINZCR { get; set; }

        //HEINZCR_Probes	int	NULL,
        [DbColumn(Name = "HEINZCR_Probes")]
        public int HEINZCR_Probes { get; set; }

        //INBEVAR	int	NULL,
        [DbColumn(Name = "INBEVAR")]
        public int INBEVAR { get; set; }

        //INBEVAR_Probes	int	NULL,
        [DbColumn(Name = "INBEVAR_Probes")]
        public int INBEVAR_Probes { get; set; }

        //INBEVBE	int	NULL,
        [DbColumn(Name = "INBEVBE")]
        public int INBEVBE { get; set; }

        //INBEVBE_Probes	int	NULL,
        [DbColumn(Name = "INBEVBE_Probes")]
        public int INBEVBE_Probes { get; set; }

        //INBEVBE_SAND	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND")]
        public int INBEVBE_SAND { get; set; }

        //INBEVBE_SAND_Probes	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND_Probes")]
        public int INBEVBE_SAND_Probes { get; set; }

        //INBEVBR	int	NULL,
        [DbColumn(Name = "INBEVBR")]
        public int INBEVBR { get; set; }

        //INBEVBR_Probes	int	NULL,
        [DbColumn(Name = "INBEVBR_Probes")]
        public int INBEVBR_Probes { get; set; }

        //INBEVBR_ONTRADE	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE")]
        public int INBEVBR_ONTRADE { get; set; }

        //INBEVBR_ONTRADE_Probes	int	NULL,
        [DbColumn(Name = "INBEVBR_ONTRADE_Probes")]
        public int INBEVBR_ONTRADE_Probes { get; set; }

        //INBEVCL	int	NULL,
        [DbColumn(Name = "INBEVCL")]
        public int INBEVCL { get; set; }

        //INBEVCL_Probes	int	NULL,
        [DbColumn(Name = "INBEVCL_Probes")]
        public int INBEVCL_Probes { get; set; }

        //INBEVCN	int	NULL,
        [DbColumn(Name = "INBEVCN")]
        public int INBEVCN { get; set; }

        //INBEVCN_Probes	int	NULL,
        [DbColumn(Name = "INBEVCN_Probes")]
        public int INBEVCN_Probes { get; set; }

        //INBEVCOOLERAR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR")]
        public int INBEVCOOLERAR { get; set; }

        //INBEVCOOLERAR_Probes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERAR_Probes")]
        public int INBEVCOOLERAR_Probes { get; set; }

        //INBEVCOOLERBR	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR")]
        public int INBEVCOOLERBR { get; set; }

        //INBEVCOOLERBR_Probes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERBR_Probes")]
        public int INBEVCOOLERBR_Probes { get; set; }

        //INBEVCOOLERUS	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS")]
        public int INBEVCOOLERUS { get; set; }

        //INBEVCOOLERUS_Probes	int	NULL,
        [DbColumn(Name = "INBEVCOOLERUS_Probes")]
        public int INBEVCOOLERUS_Probes { get; set; }

        //INBEVFR	int	NULL,
        [DbColumn(Name = "INBEVFR")]
        public int INBEVFR { get; set; }

        //INBEVFR_Probes	int	NULL,
        [DbColumn(Name = "INBEVFR_Probes")]
        public int INBEVFR_Probes { get; set; }

        //INBEVLU	int	NULL,
        [DbColumn(Name = "INBEVLU")]
        public int INBEVLU { get; set; }

        //INBEVLU_Probes	int	NULL,
        [DbColumn(Name = "INBEVLU_Probes")]
        public int INBEVLU_Probes { get; set; }

        //INBEVLU_SAND	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND")]
        public int INBEVLU_SAND { get; set; }

        //INBEVLU_SAND_Probes	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND_Probes")]
        public int INBEVLU_SAND_Probes { get; set; }

        //INBEVMX	int	NULL,
        [DbColumn(Name = "INBEVMX")]
        public int INBEVMX { get; set; }

        //INBEVMX_Probes	int	NULL,
        [DbColumn(Name = "INBEVMX_Probes")]
        public int INBEVMX_Probes { get; set; }

        //INBEVNL	int	NULL,
        [DbColumn(Name = "INBEVNL")]
        public int INBEVNL { get; set; }

        //INBEVNL_Probes	int	NULL,
        [DbColumn(Name = "INBEVNL_Probes")]
        public int INBEVNL_Probes { get; set; }

        //INBEVNL_SAND	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND")]
        public int INBEVNL_SAND { get; set; }

        //INBEVNL_SAND_Probes	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND_Probes")]
        public int INBEVNL_SAND_Probes { get; set; }

        //INBEVPY	int	NULL,
        [DbColumn(Name = "INBEVPY")]
        public int INBEVPY { get; set; }

        //INBEVPY_Probes	int	NULL,
        [DbColumn(Name = "INBEVPY_Probes")]
        public int INBEVPY_Probes { get; set; }

        //INBEVTRADMX	int	NULL,
        [DbColumn(Name = "INBEVTRADMX")]
        public int INBEVTRADMX { get; set; }

        //INBEVTRADMX_Probes	int	NULL,
        [DbColumn(Name = "INBEVTRADMX_Probes")]
        public int INBEVTRADMX_Probes { get; set; }

        //INBEVUS	int	NULL,
        [DbColumn(Name = "INBEVUS")]
        public int INBEVUS { get; set; }

        //INBEVUS_Probes	int	NULL,
        [DbColumn(Name = "INBEVUS_Probes")]
        public int INBEVUS_Probes { get; set; }

        //JTIUA	int	NULL,
        [DbColumn(Name = "JTIUA")]
        public int JTIUA { get; set; }

        //JTIUA_Probes	int	NULL,
        [DbColumn(Name = "JTIUA_Probes")]
        public int JTIUA_Probes { get; set; }

        //KCMY	int	NULL,
        [DbColumn(Name = "KCMY")]
        public int KCMY { get; set; }

        //KCMY_Probes	int	NULL,
        [DbColumn(Name = "KCMY_Probes")]
        public int KCMY_Probes { get; set; }

        //KCUS	int	NULL,
        [DbColumn(Name = "KCUS")]
        public int KCUS { get; set; }

        //KCUS_Probes	int	NULL,
        [DbColumn(Name = "KCUS_Probes")]
        public int KCUS_Probes { get; set; }

        //KEURIGCA	int	NULL,
        [DbColumn(Name = "KEURIGCA")]
        public int KEURIGCA { get; set; }

        //KEURIGCA_Probes	int	NULL,
        [DbColumn(Name = "KEURIGCA_Probes")]
        public int KEURIGCA_Probes { get; set; }

        //LABATTPLNOPTCA	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA")]
        public int LABATTPLNOPTCA { get; set; }

        //LABATTPLNOPTCA_Probes	int	NULL,
        [DbColumn(Name = "LABATTPLNOPTCA_Probes")]
        public int LABATTPLNOPTCA_Probes { get; set; }

        //LAVAZZAAT	int	NULL,
        [DbColumn(Name = "LAVAZZAAT")]
        public int LAVAZZAAT { get; set; }

        //LAVAZZAAT_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAAT_Probes")]
        public int LAVAZZAAT_Probes { get; set; }

        //LAVAZZAAU	int	NULL,
        [DbColumn(Name = "LAVAZZAAU")]
        public int LAVAZZAAU { get; set; }

        //LAVAZZAAU_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAAU_Probes")]
        public int LAVAZZAAU_Probes { get; set; }

        //LAVAZZABE	int	NULL,
        [DbColumn(Name = "LAVAZZABE")]
        public int LAVAZZABE { get; set; }

        //LAVAZZABE_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZABE_Probes")]
        public int LAVAZZABE_Probes { get; set; }

        //LAVAZZABG	int	NULL,
        [DbColumn(Name = "LAVAZZABG")]
        public int LAVAZZABG { get; set; }

        //LAVAZZABG_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZABG_Probes")]
        public int LAVAZZABG_Probes { get; set; }

        //LAVAZZACA	int	NULL,
        [DbColumn(Name = "LAVAZZACA")]
        public int LAVAZZACA { get; set; }

        //LAVAZZACA_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZACA_Probes")]
        public int LAVAZZACA_Probes { get; set; }

        //LAVAZZACH	int	NULL,
        [DbColumn(Name = "LAVAZZACH")]
        public int LAVAZZACH { get; set; }

        //LAVAZZACH_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZACH_Probes")]
        public int LAVAZZACH_Probes { get; set; }

        //LAVAZZACL	int	NULL,
        [DbColumn(Name = "LAVAZZACL")]
        public int LAVAZZACL { get; set; }

        //LAVAZZACL_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZACL_Probes")]
        public int LAVAZZACL_Probes { get; set; }

        //LAVAZZACN	int	NULL,
        [DbColumn(Name = "LAVAZZACN")]
        public int LAVAZZACN { get; set; }

        //LAVAZZACN_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZACN_Probes")]
        public int LAVAZZACN_Probes { get; set; }

        //LAVAZZACZ	int	NULL,
        [DbColumn(Name = "LAVAZZACZ")]
        public int LAVAZZACZ { get; set; }

        //LAVAZZACZ_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZACZ_Probes")]
        public int LAVAZZACZ_Probes { get; set; }

        //LAVAZZADE	int	NULL,
        [DbColumn(Name = "LAVAZZADE")]
        public int LAVAZZADE { get; set; }

        //LAVAZZADE_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZADE_Probes")]
        public int LAVAZZADE_Probes { get; set; }

        //LAVAZZADK	int	NULL,
        [DbColumn(Name = "LAVAZZADK")]
        public int LAVAZZADK { get; set; }

        //LAVAZZADK_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZADK_Probes")]
        public int LAVAZZADK_Probes { get; set; }

        //LAVAZZAEE	int	NULL,
        [DbColumn(Name = "LAVAZZAEE")]
        public int LAVAZZAEE { get; set; }

        //LAVAZZAEE_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAEE_Probes")]
        public int LAVAZZAEE_Probes { get; set; }

        //LAVAZZAES	int	NULL,
        [DbColumn(Name = "LAVAZZAES")]
        public int LAVAZZAES { get; set; }

        //LAVAZZAES_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAES_Probes")]
        public int LAVAZZAES_Probes { get; set; }

        //LAVAZZAFR	int	NULL,
        [DbColumn(Name = "LAVAZZAFR")]
        public int LAVAZZAFR { get; set; }

        //LAVAZZAFR_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_Probes")]
        public int LAVAZZAFR_Probes { get; set; }

        //LAVAZZAGR	int	NULL,
        [DbColumn(Name = "LAVAZZAGR")]
        public int LAVAZZAGR { get; set; }

        //LAVAZZAGR_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAGR_Probes")]
        public int LAVAZZAGR_Probes { get; set; }

        //LAVAZZAHK	int	NULL,
        [DbColumn(Name = "LAVAZZAHK")]
        public int LAVAZZAHK { get; set; }

        //LAVAZZAHK_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAHK_Probes")]
        public int LAVAZZAHK_Probes { get; set; }

        //LAVAZZAHR	int	NULL,
        [DbColumn(Name = "LAVAZZAHR")]
        public int LAVAZZAHR { get; set; }

        //LAVAZZAHR_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAHR_Probes")]
        public int LAVAZZAHR_Probes { get; set; }

        //LAVAZZAIL	int	NULL,
        [DbColumn(Name = "LAVAZZAIL")]
        public int LAVAZZAIL { get; set; }

        //LAVAZZAIL_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAIL_Probes")]
        public int LAVAZZAIL_Probes { get; set; }

        //LAVAZZAIT	int	NULL,
        [DbColumn(Name = "LAVAZZAIT")]
        public int LAVAZZAIT { get; set; }

        //LAVAZZAIT_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_Probes")]
        public int LAVAZZAIT_Probes { get; set; }

        //LAVAZZAJP	int	NULL,
        [DbColumn(Name = "LAVAZZAJP")]
        public int LAVAZZAJP { get; set; }

        //LAVAZZAJP_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAJP_Probes")]
        public int LAVAZZAJP_Probes { get; set; }

        //LAVAZZAKR	int	NULL,
        [DbColumn(Name = "LAVAZZAKR")]
        public int LAVAZZAKR { get; set; }

        //LAVAZZAKR_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAKR_Probes")]
        public int LAVAZZAKR_Probes { get; set; }

        //LAVAZZALT	int	NULL,
        [DbColumn(Name = "LAVAZZALT")]
        public int LAVAZZALT { get; set; }

        //LAVAZZALT_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZALT_Probes")]
        public int LAVAZZALT_Probes { get; set; }

        //LAVAZZALU	int	NULL,
        [DbColumn(Name = "LAVAZZALU")]
        public int LAVAZZALU { get; set; }

        //LAVAZZALU_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZALU_Probes")]
        public int LAVAZZALU_Probes { get; set; }

        //LAVAZZALV	int	NULL,
        [DbColumn(Name = "LAVAZZALV")]
        public int LAVAZZALV { get; set; }

        //LAVAZZALV_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZALV_Probes")]
        public int LAVAZZALV_Probes { get; set; }

        //LAVAZZAMA	int	NULL,
        [DbColumn(Name = "LAVAZZAMA")]
        public int LAVAZZAMA { get; set; }

        //LAVAZZAMA_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAMA_Probes")]
        public int LAVAZZAMA_Probes { get; set; }

        //LAVAZZANL	int	NULL,
        [DbColumn(Name = "LAVAZZANL")]
        public int LAVAZZANL { get; set; }

        //LAVAZZANL_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZANL_Probes")]
        public int LAVAZZANL_Probes { get; set; }

        //LAVAZZAPL	int	NULL,
        [DbColumn(Name = "LAVAZZAPL")]
        public int LAVAZZAPL { get; set; }

        //LAVAZZAPL_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAPL_Probes")]
        public int LAVAZZAPL_Probes { get; set; }

        //LAVAZZARO	int	NULL,
        [DbColumn(Name = "LAVAZZARO")]
        public int LAVAZZARO { get; set; }

        //LAVAZZARO_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZARO_Probes")]
        public int LAVAZZARO_Probes { get; set; }

        //LAVAZZARU	int	NULL,
        [DbColumn(Name = "LAVAZZARU")]
        public int LAVAZZARU { get; set; }

        //LAVAZZARU_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZARU_Probes")]
        public int LAVAZZARU_Probes { get; set; }

        //LAVAZZASA	int	NULL,
        [DbColumn(Name = "LAVAZZASA")]
        public int LAVAZZASA { get; set; }

        //LAVAZZASA_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZASA_Probes")]
        public int LAVAZZASA_Probes { get; set; }

        //LAVAZZASE	int	NULL,
        [DbColumn(Name = "LAVAZZASE")]
        public int LAVAZZASE { get; set; }

        //LAVAZZASE_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZASE_Probes")]
        public int LAVAZZASE_Probes { get; set; }

        //LAVAZZASG	int	NULL,
        [DbColumn(Name = "LAVAZZASG")]
        public int LAVAZZASG { get; set; }

        //LAVAZZASG_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZASG_Probes")]
        public int LAVAZZASG_Probes { get; set; }

        //LAVAZZAUAE	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE")]
        public int LAVAZZAUAE { get; set; }

        //LAVAZZAUAE_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAUAE_Probes")]
        public int LAVAZZAUAE_Probes { get; set; }

        //LAVAZZAUK	int	NULL,
        [DbColumn(Name = "LAVAZZAUK")]
        public int LAVAZZAUK { get; set; }

        //LAVAZZAUK_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAUK_Probes")]
        public int LAVAZZAUK_Probes { get; set; }

        //LAVAZZAUS	int	NULL,
        [DbColumn(Name = "LAVAZZAUS")]
        public int LAVAZZAUS { get; set; }

        //LAVAZZAUS_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAUS_Probes")]
        public int LAVAZZAUS_Probes { get; set; }

        //LAVAZZAZA	int	NULL,
        [DbColumn(Name = "LAVAZZAZA")]
        public int LAVAZZAZA { get; set; }

        //LAVAZZAZA_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAZA_Probes")]
        public int LAVAZZAZA_Probes { get; set; }

        //LRSUK	int	NULL,
        [DbColumn(Name = "LRSUK")]
        public int LRSUK { get; set; }

        //LRSUK_Probes	int	NULL,
        [DbColumn(Name = "LRSUK_Probes")]
        public int LRSUK_Probes { get; set; }

        //MARSBR	int	NULL,
        [DbColumn(Name = "MARSBR")]
        public int MARSBR { get; set; }

        //MARSBR_Probes	int	NULL,
        [DbColumn(Name = "MARSBR_Probes")]
        public int MARSBR_Probes { get; set; }

        //MARSIN	int	NULL,
        [DbColumn(Name = "MARSIN")]
        public int MARSIN { get; set; }

        //MARSIN_Probes	int	NULL,
        [DbColumn(Name = "MARSIN_Probes")]
        public int MARSIN_Probes { get; set; }

        //MARSIN_OLD	int	NULL,
        [DbColumn(Name = "MARSIN_OLD")]
        public int MARSIN_OLD { get; set; }

        //MARSIN_OLD_Probes	int	NULL,
        [DbColumn(Name = "MARSIN_OLD_Probes")]
        public int MARSIN_OLD_Probes { get; set; }

        //MARSRU_PROD	int	NULL,
        [DbColumn(Name = "MARSRU_PROD")]
        public int MARSRU_PROD { get; set; }

        //MARSRU_PROD_Probes	int	NULL,
        [DbColumn(Name = "MARSRU_PROD_Probes")]
        public int MARSRU_PROD_Probes { get; set; }

        //MAYORAID	int	NULL,
        [DbColumn(Name = "MAYORAID")]
        public int MAYORAID { get; set; }

        //MAYORAID_Probes	int	NULL,
        [DbColumn(Name = "MAYORAID_Probes")]
        public int MAYORAID_Probes { get; set; }

        //MJNCN	int	NULL,
        [DbColumn(Name = "MJNCN")]
        public int MJNCN { get; set; }

        //MJNCN_Probes	int	NULL,
        [DbColumn(Name = "MJNCN_Probes")]
        public int MJNCN_Probes { get; set; }

        //MOLSONCOOLERHN	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN")]
        public int MOLSONCOOLERHN { get; set; }

        //MOLSONCOOLERHN_Probes	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHN_Probes")]
        public int MOLSONCOOLERHN_Probes { get; set; }

        //MOLSONCOOLERHR	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR")]
        public int MOLSONCOOLERHR { get; set; }

        //MOLSONCOOLERHR_Probes	int	NULL,
        [DbColumn(Name = "MOLSONCOOLERHR_Probes")]
        public int MOLSONCOOLERHR_Probes { get; set; }

        //MOLSONCOORSUK	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK")]
        public int MOLSONCOORSUK { get; set; }

        //MOLSONCOORSUK_Probes	int	NULL,
        [DbColumn(Name = "MOLSONCOORSUK_Probes")]
        public int MOLSONCOORSUK_Probes { get; set; }

        //NESTLEUK	int	NULL,
        [DbColumn(Name = "NESTLEUK")]
        public int NESTLEUK { get; set; }

        //NESTLEUK_Probes	int	NULL,
        [DbColumn(Name = "NESTLEUK_Probes")]
        public int NESTLEUK_Probes { get; set; }

        //NIVEAUK	int	NULL,
        [DbColumn(Name = "NIVEAUK")]
        public int NIVEAUK { get; set; }

        //NIVEAUK_Probes	int	NULL,
        [DbColumn(Name = "NIVEAUK_Probes")]
        public int NIVEAUK_Probes { get; set; }

        //NRF2017_DEMO	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO")]
        public int NRF2017_DEMO { get; set; }

        //NRF2017_DEMO_Probes	int	NULL,
        [DbColumn(Name = "NRF2017_DEMO_Probes")]
        public int NRF2017_DEMO_Probes { get; set; }

        //ONE_AMERICAS_DEMO	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO")]
        public int ONE_AMERICAS_DEMO { get; set; }

        //ONE_AMERICAS_DEMO_Probes	int	NULL,
        [DbColumn(Name = "ONE_AMERICAS_DEMO_Probes")]
        public int ONE_AMERICAS_DEMO_Probes { get; set; }

        //ONE_APAC_DEMO	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO")]
        public int ONE_APAC_DEMO { get; set; }

        //ONE_APAC_DEMO_Probes	int	NULL,
        [DbColumn(Name = "ONE_APAC_DEMO_Probes")]
        public int ONE_APAC_DEMO_Probes { get; set; }

        //PEPSICOBR	int	NULL,
        [DbColumn(Name = "PEPSICOBR")]
        public int PEPSICOBR { get; set; }

        //PEPSICOBR_Probes	int	NULL,
        [DbColumn(Name = "PEPSICOBR_Probes")]
        public int PEPSICOBR_Probes { get; set; }

        //PNGAU	int	NULL,
        [DbColumn(Name = "PNGAU")]
        public int PNGAU { get; set; }

        //PNGAU_Probes	int	NULL,
        [DbColumn(Name = "PNGAU_Probes")]
        public int PNGAU_Probes { get; set; }

        //PNGAU_OLD	int	NULL,
        [DbColumn(Name = "PNGAU_OLD")]
        public int PNGAU_OLD { get; set; }

        //PNGAU_OLD_Probes	int	NULL,
        [DbColumn(Name = "PNGAU_OLD_Probes")]
        public int PNGAU_OLD_Probes { get; set; }

        //PNGCAREUS	int	NULL,
        [DbColumn(Name = "PNGCAREUS")]
        public int PNGCAREUS { get; set; }

        //PNGCAREUS_Probes	int	NULL,
        [DbColumn(Name = "PNGCAREUS_Probes")]
        public int PNGCAREUS_Probes { get; set; }

        //PNGCN_PROD	int	NULL,
        [DbColumn(Name = "PNGCN_PROD")]
        public int PNGCN_PROD { get; set; }

        //PNGCN_PROD_Probes	int	NULL,
        [DbColumn(Name = "PNGCN_PROD_Probes")]
        public int PNGCN_PROD_Probes { get; set; }

        //PNGJP	int	NULL,
        [DbColumn(Name = "PNGJP")]
        public int PNGJP { get; set; }

        //PNGJP_Probes	int	NULL,
        [DbColumn(Name = "PNGJP_Probes")]
        public int PNGJP_Probes { get; set; }

        //PNGJP_OLD	int	NULL,
        [DbColumn(Name = "PNGJP_OLD")]
        public int PNGJP_OLD { get; set; }

        //PNGJP_OLD_Probes	int	NULL,
        [DbColumn(Name = "PNGJP_OLD_Probes")]
        public int PNGJP_OLD_Probes { get; set; }

        //PNGUS	int	NULL,
        [DbColumn(Name = "PNGUS")]
        public int PNGUS { get; set; }

        //PNGUS_Probes	int	NULL,
        [DbColumn(Name = "PNGUS_Probes")]
        public int PNGUS_Probes { get; set; }

        //PNGUSEPISODIC	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC")]
        public int PNGUSEPISODIC { get; set; }

        //PNGUSEPISODIC_Probes	int	NULL,
        [DbColumn(Name = "PNGUSEPISODIC_Probes")]
        public int PNGUSEPISODIC_Probes { get; set; }

        //RBUS	int	NULL,
        [DbColumn(Name = "RBUS")]
        public int RBUS { get; set; }

        //RBUS_Probes	int	NULL,
        [DbColumn(Name = "RBUS_Probes")]
        public int RBUS_Probes { get; set; }

        //RE_XSUITE_DEMO	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO")]
        public int RE_XSUITE_DEMO { get; set; }

        //RE_XSUITE_DEMO_Probes	int	NULL,
        [DbColumn(Name = "RE_XSUITE_DEMO_Probes")]
        public int RE_XSUITE_DEMO_Probes { get; set; }

        //REPNGCN_DEMO	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO")]
        public int REPNGCN_DEMO { get; set; }

        //REPNGCN_DEMO_Probes	int	NULL,
        [DbColumn(Name = "REPNGCN_DEMO_Probes")]
        public int REPNGCN_DEMO_Probes { get; set; }

        //RI_DEMO	int	NULL,
        [DbColumn(Name = "RI_DEMO")]
        public int RI_DEMO { get; set; }

        //RI_DEMO_Probes	int	NULL,
        [DbColumn(Name = "RI_DEMO_Probes")]
        public int RI_DEMO_Probes { get; set; }

        //RI_DIAGEOAU	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU")]
        public int RI_DIAGEOAU { get; set; }

        //RI_DIAGEOAU_Probes	int	NULL,
        [DbColumn(Name = "RI_DIAGEOAU_Probes")]
        public int RI_DIAGEOAU_Probes { get; set; }

        //RIALCBEVUK_PROD	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD")]
        public int RIALCBEVUK_PROD { get; set; }

        //RIALCBEVUK_PROD_Probes	int	NULL,
        [DbColumn(Name = "RIALCBEVUK_PROD_Probes")]
        public int RIALCBEVUK_PROD_Probes { get; set; }

        //RICOFFEEUS	int	NULL,
        [DbColumn(Name = "RICOFFEEUS")]
        public int RICOFFEEUS { get; set; }

        //RICOFFEEUS_Probes	int	NULL,
        [DbColumn(Name = "RICOFFEEUS_Probes")]
        public int RICOFFEEUS_Probes { get; set; }

        //RINIELSENUS	int	NULL,
        [DbColumn(Name = "RINIELSENUS")]
        public int RINIELSENUS { get; set; }

        //RINIELSENUS_Probes	int	NULL,
        [DbColumn(Name = "RINIELSENUS_Probes")]
        public int RINIELSENUS_Probes { get; set; }

        //RIPETCAREUK_PROD	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD")]
        public int RIPETCAREUK_PROD { get; set; }

        //RIPETCAREUK_PROD_Probes	int	NULL,
        [DbColumn(Name = "RIPETCAREUK_PROD_Probes")]
        public int RIPETCAREUK_PROD_Probes { get; set; }

        //RIUS	int	NULL,
        [DbColumn(Name = "RIUS")]
        public int RIUS { get; set; }

        //RIUS_Probes	int	NULL,
        [DbColumn(Name = "RIUS_Probes")]
        public int RIUS_Probes { get; set; }

        //RIUS_DEV	int	NULL,
        [DbColumn(Name = "RIUS_DEV")]
        public int RIUS_DEV { get; set; }

        //RIUS_DEV_Probes	int	NULL,
        [DbColumn(Name = "RIUS_DEV_Probes")]
        public int RIUS_DEV_Probes { get; set; }

        //RNBDE	int	NULL,
        [DbColumn(Name = "RNBDE")]
        public int RNBDE { get; set; }

        //RNBDE_Probes	int	NULL,
        [DbColumn(Name = "RNBDE_Probes")]
        public int RNBDE_Probes { get; set; }

        //SMARTCOOLER_POC2	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2")]
        public int SMARTCOOLER_POC2 { get; set; }

        //SMARTCOOLER_POC2_Probes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_POC2_Probes")]
        public int SMARTCOOLER_POC2_Probes { get; set; }

        //SMARTCOOLER_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN")]
        public int SMARTCOOLER_TRN { get; set; }

        //SMARTCOOLER_TRN_Probes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER_TRN_Probes")]
        public int SMARTCOOLER_TRN_Probes { get; set; }

        //SMARTCOOLER2_TRN	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN")]
        public int SMARTCOOLER2_TRN { get; set; }

        //SMARTCOOLER2_TRN_Probes	int	NULL,
        [DbColumn(Name = "SMARTCOOLER2_TRN_Probes")]
        public int SMARTCOOLER2_TRN_Probes { get; set; }

        //SOLARBR	int	NULL,
        [DbColumn(Name = "SOLARBR")]
        public int SOLARBR { get; set; }

        //SOLARBR_Probes	int	NULL,
        [DbColumn(Name = "SOLARBR_Probes")]
        public int SOLARBR_Probes { get; set; }

        //STATIC_CAMERA_DEMO	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO")]
        public int STATIC_CAMERA_DEMO { get; set; }

        //STATIC_CAMERA_DEMO_Probes	int	NULL,
        [DbColumn(Name = "STATIC_CAMERA_DEMO_Probes")]
        public int STATIC_CAMERA_DEMO_Probes { get; set; }

        //SWIRECN	int	NULL,
        [DbColumn(Name = "SWIRECN")]
        public int SWIRECN { get; set; }

        //SWIRECN_Probes	int	NULL,
        [DbColumn(Name = "SWIRECN_Probes")]
        public int SWIRECN_Probes { get; set; }

        //SWIREREDCN	int	NULL,
        [DbColumn(Name = "SWIREREDCN")]
        public int SWIREREDCN { get; set; }

        //SWIREREDCN_Probes	int	NULL,
        [DbColumn(Name = "SWIREREDCN_Probes")]
        public int SWIREREDCN_Probes { get; set; }

        //TNUVAIL	int	NULL,
        [DbColumn(Name = "TNUVAIL")]
        public int TNUVAIL { get; set; }

        //TNUVAIL_Probes	int	NULL,
        [DbColumn(Name = "TNUVAIL_Probes")]
        public int TNUVAIL_Probes { get; set; }

        //TRAXDEMO_TS_PROD	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD")]
        public int TRAXDEMO_TS_PROD { get; set; }

        //TRAXDEMO_TS_PROD_Probes	int	NULL,
        [DbColumn(Name = "TRAXDEMO_TS_PROD_Probes")]
        public int TRAXDEMO_TS_PROD_Probes { get; set; }

        //TWEAU	int	NULL,
        [DbColumn(Name = "TWEAU")]
        public int TWEAU { get; set; }

        //TWEAU_Probes	int	NULL,
        [DbColumn(Name = "TWEAU_Probes")]
        public int TWEAU_Probes { get; set; }

        //RI_DEMO2	int	NULL,
        [DbColumn(Name = "RI_DEMO2")]
        public int RI_DEMO2 { get; set; }

        //RI_DEMO2_Probes	int	NULL,
        [DbColumn(Name = "RI_DEMO2_Probes")]
        public int RI_DEMO2_Probes { get; set; }

        //COMPASSCCH_SAND	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND")]
        public int COMPASSCCH_SAND { get; set; }

        //COMPASSCCH_SAND_Probes	int	NULL,
        [DbColumn(Name = "COMPASSCCH_SAND_Probes")]
        public int COMPASSCCH_SAND_Probes { get; set; }

        //LAVAZZAIT_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND")]
        public int LAVAZZAIT_SAND { get; set; }

        //LAVAZZAIT_SAND_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAIT_SAND_Probes")]
        public int LAVAZZAIT_SAND_Probes { get; set; }

        //INBEVUS_STG	int	NULL,
        [DbColumn(Name = "INBEVUS_STG")]
        public int INBEVUS_STG { get; set; }

        //INBEVUS_STG_Probes	int	NULL,
        [DbColumn(Name = "INBEVUS_STG_Probes")]
        public int INBEVUS_STG_Probes { get; set; }

        //LAVAZZAFR_SAND	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND")]
        public int LAVAZZAFR_SAND { get; set; }

        //LAVAZZAFR_SAND_Probes	int	NULL,
        [DbColumn(Name = "LAVAZZAFR_SAND_Probes")]
        public int LAVAZZAFR_SAND_Probes { get; set; }

        //INBEVBE_SAND2 int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2")]
        public int INBEVBE_SAND2 { get; set; }

        //INBEVBE_SAND2_Probes	int	NULL,
        [DbColumn(Name = "INBEVBE_SAND2_Probes")]
        public int INBEVBE_SAND2_Probes { get; set; }

        //INBEVLU_SAND2 int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2")]
        public int INBEVLU_SAND2 { get; set; }

        //INBEVLU_SAND2_Probes	int	NULL,
        [DbColumn(Name = "INBEVLU_SAND2_Probes")]
        public int INBEVLU_SAND2_Probes { get; set; }

        //INBEVNL_SAND2	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2")]
        public int INBEVNL_SAND2 { get; set; }

        //INBEVNL_SAND2_Probes	int	NULL,
        [DbColumn(Name = "INBEVNL_SAND2_Probes")]
        public int INBEVNL_SAND2_Probes { get; set; }

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