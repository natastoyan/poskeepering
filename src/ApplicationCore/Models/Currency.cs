using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Currency : BaseStrIdModel
    {
        public Currency()
        {
            Capital = new HashSet<Capital>();
            Counterlimits = new HashSet<Counterlimits>();
            CurraccOld = new HashSet<CurraccOld>();
            Currlimits = new HashSet<Currlimits>();
            CurrpairCcurrcode1Navigation = new HashSet<Currpair>();
            CurrpairCcurrcode2Navigation = new HashSet<Currpair>();
            CurrweightsCcurrcode1Navigation = new HashSet<Currweights>();
            CurrweightsCcurrcode2Navigation = new HashSet<Currweights>();
            DepoCcurrcodeNavigation = new HashSet<Depo>();
            DepoCsalescreditcurrNavigation = new HashSet<Depo>();
            EquitingdealsCsalescreditcurrNavigation = new HashSet<Equitingdeals>();
            EquitingdealsCsettlcurrcodeNavigation = new HashSet<Equitingdeals>();
            EquitingdealsCtradecurrcodeNavigation = new HashSet<Equitingdeals>();
            ForexCcurrcodebNavigation = new HashSet<Forex>();
            ForexCcurrcodesNavigation = new HashSet<Forex>();
            ForexCsalescreditcurrNavigation = new HashSet<Forex>();
            FvsTestAutoinsertFk1Navigation = new HashSet<FvsTestAutoinsert>();
            FvsTestAutoinsertFkNavigation = new HashSet<FvsTestAutoinsert>();
            Limitweightrisk = new HashSet<Limitweightrisk>();
            Netting = new HashSet<Netting>();
            Ourbankcapital = new HashSet<Ourbankcapital>();
            RatesCcurrcode1Navigation = new HashSet<Rates>();
            RatesCcurrcode2Navigation = new HashSet<Rates>();
            Recres = new HashSet<Recres>();
            Remains = new HashSet<Remains>();
            RepoOld = new HashSet<RepoOld>();
            Securities = new HashSet<Securities>();
            SwapCcurrcodebNavigation = new HashSet<Swap>();
            SwapCcurrcodesNavigation = new HashSet<Swap>();
            SwapCfixcurrcodeNavigation = new HashSet<Swap>();
            Trans = new HashSet<Trans>();
        }

        //public string Ccurrcode { get; set; }
        public string Id { get; set; }
        public string Ccurrname { get; set; }
        public decimal? Iorder { get; set; }
        public decimal? Iocporder { get; set; }
        public decimal? Neurrate { get; set; }
        public decimal? Beurgroup { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Nisocode { get; set; }
        public decimal? Batheneadvance { get; set; }
        public decimal? Nrecontype { get; set; }

        public virtual ICollection<Capital> Capital { get; set; }
        public virtual ICollection<Counterlimits> Counterlimits { get; set; }
        public virtual ICollection<CurraccOld> CurraccOld { get; set; }
        public virtual ICollection<Currlimits> Currlimits { get; set; }
        public virtual ICollection<Currpair> CurrpairCcurrcode1Navigation { get; set; }
        public virtual ICollection<Currpair> CurrpairCcurrcode2Navigation { get; set; }
        public virtual ICollection<Currweights> CurrweightsCcurrcode1Navigation { get; set; }
        public virtual ICollection<Currweights> CurrweightsCcurrcode2Navigation { get; set; }
        public virtual ICollection<Depo> DepoCcurrcodeNavigation { get; set; }
        public virtual ICollection<Depo> DepoCsalescreditcurrNavigation { get; set; }
        public virtual ICollection<Equitingdeals> EquitingdealsCsalescreditcurrNavigation { get; set; }
        public virtual ICollection<Equitingdeals> EquitingdealsCsettlcurrcodeNavigation { get; set; }
        public virtual ICollection<Equitingdeals> EquitingdealsCtradecurrcodeNavigation { get; set; }
        public virtual ICollection<Forex> ForexCcurrcodebNavigation { get; set; }
        public virtual ICollection<Forex> ForexCcurrcodesNavigation { get; set; }
        public virtual ICollection<Forex> ForexCsalescreditcurrNavigation { get; set; }
        public virtual ICollection<FvsTestAutoinsert> FvsTestAutoinsertFk1Navigation { get; set; }
        public virtual ICollection<FvsTestAutoinsert> FvsTestAutoinsertFkNavigation { get; set; }
        public virtual ICollection<Limitweightrisk> Limitweightrisk { get; set; }
        public virtual ICollection<Netting> Netting { get; set; }
        public virtual ICollection<Ourbankcapital> Ourbankcapital { get; set; }
        public virtual ICollection<Rates> RatesCcurrcode1Navigation { get; set; }
        public virtual ICollection<Rates> RatesCcurrcode2Navigation { get; set; }
        public virtual ICollection<Recres> Recres { get; set; }
        public virtual ICollection<Remains> Remains { get; set; }
        public virtual ICollection<RepoOld> RepoOld { get; set; }
        public virtual ICollection<Securities> Securities { get; set; }
        public virtual ICollection<Swap> SwapCcurrcodebNavigation { get; set; }
        public virtual ICollection<Swap> SwapCcurrcodesNavigation { get; set; }
        public virtual ICollection<Swap> SwapCfixcurrcodeNavigation { get; set; }
        public virtual ICollection<Trans> Trans { get; set; }
    }
}
