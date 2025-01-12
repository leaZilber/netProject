using System;
using System.Collections.Generic;
using System.Text;

namespace houseCommittee.core.models
{
    public class Building
    {
        public string NameStreet { get; set; }//שם רחוב
        public string NameCity { get; set; }//שם רחוב
        public int NumBuilding { get; set; }// מספר בנין
        public int NumTenants { get; set; }// מספר דיירים
        public int MonthlyPayment { get; set; }
        public List<Tenant> Tenant { get; set; }
    }
}
