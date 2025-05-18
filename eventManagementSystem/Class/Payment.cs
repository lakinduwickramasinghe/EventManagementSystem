using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.admin
{
    public class Payment
    {
        public string cardType { get; set; }
        public string cardNumber { get; set; }
        public string cvn { get; set; }
        public int amount { get; set; }

        public Payment(string CardType, string CardNumber, string Cvn, int Amount)
        {
            this.cardType = CardType;
            this.cardNumber = CardNumber;
            this.cvn = Cvn;
            this.amount = Amount;
        }
    }
}
