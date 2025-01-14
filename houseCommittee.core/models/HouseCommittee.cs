using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace houseCommittee.core.models
{
    public class HouseCommittee
    {
        public string FamilyHouseCommittee { get; set; }//שם משפחה
        public string FirstHouseCommittee { get; set; }//שם פרטי
        public string MailHouseCommittee { get; set; }//מייל וועד הבית
        [Key]
        public string PhoneHouseCommittee { get; set; }//טלפון וועד הבית
    }
}
