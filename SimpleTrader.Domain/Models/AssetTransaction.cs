using System;

namespace SimpleTrader.Domain.Models
{
    public class AssetTransaction : DomainObject
    {
        public Account Acc { get; set; }
        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }
        public int Shares { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}