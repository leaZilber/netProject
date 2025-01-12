using houseCommittee.core.IService;
using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using System.Linq;
namespace houseCommittee.service.servies
{
    public class MessageServies : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        public MessageServies(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        static List<Message> MessagesList = new List<Message>();
        public Message GetMessageByid(string Title)//שליפת הודעה עפ"י כותרת
        {
            //Message m = MessagesList.Where(te => te.Title == Title).FirstOrDefault();
            //if (m == null)
            //    return null;
            //return m;
            return _messageRepository.GetMessageByid(Title);   
        }
        public void AddMessages(Message mes)//הוספת הודעה
        {
            //MessagesList.Add(mes);
            _messageRepository.AddMessage(mes);
        }

        public void DeleteMessages(string title, string target)//מחיקת הודעה
        {
            //MessagesList.RemoveAll(item => item.target == target&&item.Title==title);
            _messageRepository.DeleteMessage(title, target);
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
            _messageRepository.UpDateMessage(newMes,title,target);
        }

        public List<Message> GetAllMessages()
        {
            throw new NotImplementedException();
        }

        public void AddMessage(Message newMessage)
        {
            throw new NotImplementedException();
        }

        public void UpDateMessage(Message newMessage, string title, string target)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(string title, string target)
        {
            throw new NotImplementedException();
        }
    }
}
