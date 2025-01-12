using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using System.Linq;
namespace houseCommittee.servies
{
    public class MessageServies
    {
        private readonly IMessageService _messageService;
        public MessageServies(IMessageService messageService)
        {
            _messageService = messageService;
        }
        static List<Message> MessagesList = new List<Message>();
        public Message GetMessageByid(string Title)//שליפת הודעה עפ"י כותרת
        {
            //Message m = MessagesList.Where(te => te.Title == Title).FirstOrDefault();
            //if (m == null)
            //    return null;
            //return m;
            return _messageService.GetMessageByid(Title);   
        }
        public void AddMessages(Message mes)//הוספת הודעה
        {
            //MessagesList.Add(mes);
            _messageService.AddMessage(mes);
        }

        public void DeleteMessages(string title, string target)//מחיקת הודעה
        {
            //MessagesList.RemoveAll(item => item.target == target&&item.Title==title);
            _messageService.DeleteMessage(title, target);
        }
        public void UpDateMessage(string target,string title, Message newMes)//עדכון פרטי הודעה
        {
            //foreach (Message item in MessagesList)
            //{
            //    if (item.Title==title && item.target==target)
            //    {
            //        MessagesList.Add(newMes);
            //    }
            //}
            _messageService.UpDateMessage(newMes,title,target);
        }
    }
}
