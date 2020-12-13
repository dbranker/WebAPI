using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoLibrary.Models
{
    public class CompanyEntryStaging
    {
        public int CompanyID { get; set; }
        public string EntryDate { get; set; }
        public string atmcash { get; set; }
        public string blackjack { get; set; }
        public string creditcardsales { get; set; }
        public string houseaccount { get; set; }
        public bool isdateformatted { get; set; }
        public string netcashin { get; set; }
        public string netslotcash { get; set; }
        public string nettotalcashout { get; set; }
        public string pettycash { get; set; }
        public string revelpos { get; set; }
        public string slotvouchers { get; set; }
        public string threecardpoker { get; set; }
        public string vouchersreentered { get; set; }
        public string acbatm { get; set; }
        public string wagespaid { get; set; }
        public string cubatm { get; set; }
        public string cubcc { get; set; }
        public string acbcc { get; set; }
    }
}
