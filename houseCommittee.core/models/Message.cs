using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace houseCommittee.core.models
{
    public class Message
    {
        [Key]
        public string Title { get; set; }//כותרת ההודעה
        public string Body { get; set; }//גוף ההודעה
        public DateTime DateTimeMessage { get; set; }//תאריך שליחת ההודעה
        public string target { get; set; }
    }
}
