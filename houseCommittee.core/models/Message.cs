using System;
using System.Collections.Generic;
using System.Text;

namespace houseCommittee.core.models
{
    public class Message
    {
        public string Title { get; set; }//כותרת ההודעה
        public string Body { get; set; }//גוף ההודעה
        public DateTime DateTimeMessage { get; set; }//תאריך שליחת ההודעה
        public string target { get; set; }
    }
}
