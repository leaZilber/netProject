using System;
using System.Collections.Generic;
using System.Text;

namespace houseCommittee.core.models
{
    public class Tenant
    {
        public string FamilyName { get; set; }//שם משפחה
        public string FirstName { get; set; }//שם פרטי
        public int ApartmentNumber { get; set; }// מספר דירה
        public int AmounPayments { get; set; }//כמות תשלומים
        public string MailTenant { get; set; }//מייל הדייר
        public string PhoneTenant { get; set; }//טלפון הדייר
        public string CodeTenant { get; set; }
    }
}
