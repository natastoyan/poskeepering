using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Orgs
    {
        public Orgs()
        {
            Books = new HashSet<Books>();
        }

        public string Corgcode { get; set; }
        public string Corgname { get; set; }
        public string Corgtypecode { get; set; }
        public string Crequisites { get; set; }
        public decimal? Npriority { get; set; }
        public string Csalescredit { get; set; }
        public decimal? Bnetting { get; set; }
        public decimal? Binternal { get; set; }
        public decimal? Bmmdepart { get; set; }
        public decimal? Bnoresident { get; set; }
        public string Cmicexcode { get; set; }
        public string Cinn { get; set; }
        public string Cbic { get; set; }
        public string Crusname { get; set; }
        public decimal? Bnoocp { get; set; }
        public decimal? Bisbank { get; set; }
        public string Corggroup { get; set; }
        public decimal? Bisrazvit { get; set; }
        public string Creutercode { get; set; }
        public string Csummitcode { get; set; }
        public string Cathenacode { get; set; }
        public decimal? Bdepopayments { get; set; }
        public string Cgridname { get; set; }
        public decimal? Ngridid { get; set; }
        public string Cgridtown { get; set; }
        public decimal? Icrsexportallow { get; set; }
        public decimal? Ncountryid { get; set; }
        public decimal? Naccountmanagerid { get; set; }
        public decimal? Nsegmentationid { get; set; }
        public decimal? Nsalesmanagerid { get; set; }
        public decimal? Nportionfm { get; set; }
        public decimal? Nathenaclassified { get; set; }
        public string Cvtmgroup { get; set; }
        public decimal? Bprincipalorbroker { get; set; }
        public decimal? Bprefunding { get; set; }
        public decimal? Ncombps { get; set; }
        public string Cprefsettcurr { get; set; }
        public string Cingcode { get; set; }
        public string Cbrokagreementfm { get; set; }
        public string Cbrokagreementeq { get; set; }
        public bool? Bcrsexpfx { get; set; }
        public bool? Bcrsexpmm { get; set; }
        public bool? Bcrsexpss { get; set; }
        public bool? Bcrsexprg { get; set; }
        public bool? Bcrsexpeq { get; set; }
        public bool? Bcrsexper { get; set; }
        public string Cmicexfxcontr { get; set; }
        public bool? Inettingtype { get; set; }
        public string Cmailnotification { get; set; }
        public decimal? Dtimenotification { get; set; }
        public string Ccpclient { get; set; }
        public string Cquikclientcode { get; set; }
        public bool? Bloroclient { get; set; }
        public string Cbloombergcode { get; set; }
        public decimal? Nacckey { get; set; }
        public string Ctradingvenue { get; set; }
        public string Cnamerus { get; set; }
        public string Cinvestorcode { get; set; }
        public decimal? Nmmbase { get; set; }
        public string Ccpclientrub { get; set; }
        public string Cparentcode { get; set; }
        public bool? Brubnetting { get; set; }
        public bool? Bactive { get; set; }
        public string Ccddstatus { get; set; }
        public string Cfatcastatus { get; set; }
        public string Codd { get; set; }
        public string Ccpack { get; set; }
        public string Сssdstatus { get; set; }
        public string Сfatcastatus { get; set; }
        public string Сodd { get; set; }
        public string Сcpack { get; set; }
        public string Сcddstatus { get; set; }
        public int? Id { get; set; }

        public virtual Orgstype CorgtypecodeNavigation { get; set; }
        public virtual ICollection<Books> Books { get; set; }
    }
}
