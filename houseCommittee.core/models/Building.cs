using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace houseCommittee.core.models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        public string NameStreet { get; set; }//שם רחוב
        public string NameCity { get; set; }//שם עיר
        public int NumBuilding { get; set; }// מספר בנין
        public int NumTenants { get; set; }// מספר דיירים
        public int MonthlyPayment { get; set; }
        public List<Tenant> Tenant { get; set; }
    }
}
