using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoLibrary.Models
{
    public class CompanyEntry
    {
        public int CompanyID { get; set; }
        public DateTime EntryDate { get; set; }
        public double atmcash { get; set; }
        public double blackjack { get; set; }
        public double creditcardsales { get; set; }
        public double houseaccount { get; set; }
        public bool isdateformatted { get; set; }
        public double netcashin { get; set; }
        public double netslotcash { get; set; }
        public double nettotalcashout { get; set; }
        public double pettycash { get; set; }
        public double revelpos { get; set; }
        public double slotvouchers { get; set; }
        public double threecardpoker { get; set; }
        public double vouchersreentered { get; set; }
        public double acbatm { get; set; }
        public double wagespaid { get; set; }
        public double cubatm { get; set; }
        public double cubcc { get; set; }
        public double acbcc { get; set; }
    }
}
