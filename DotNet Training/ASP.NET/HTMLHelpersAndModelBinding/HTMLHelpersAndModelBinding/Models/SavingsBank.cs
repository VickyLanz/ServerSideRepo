using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpersAndModelBinding.Models
{
    public class SavingsBank
    {
        public double PrincipalAmount { get; set; }
        public float TimeInYears { get; set; }
        public float InterestRate { get; set; }
    }
}