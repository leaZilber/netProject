﻿using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;

//using WebApplication1;

namespace houseCommittee.data.repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataContext _message;
        public MessageRepository(DataContext message)
        {
            _message = message;
        }

        public Message GetMessageByid(string code)//שליפת הודעה עפ"י קוד
        {
            Message m = _message.MessageList.Where(te => te.Title == code).FirstOrDefault();
            if (m == null)
                return null;
            return m;
        }
        public List<Message> GetAllMessages()
        {
            return _message.MessageList.ToList();
        }

        public void AddMessage(Message newMessage)
        {
            _message.MessageList.Add(newMessage);
            _message.SaveChanges();
        }

        public void UpDateMessage(Message newMessage, string title, string target)//עדכון פרטי בנין
        {
            foreach (Message item in _message.MessageList)
            {
                if (item.Title == title && item.target == target)
                {
                    _message.MessageList.Add(item);
                }
            }
            _message.SaveChanges();
        }
        public void DeleteMessage(string title, string target)//מחיקת הודעה
        {
            var message = _message.MessageList.FirstOrDefault(item => item.Title == title && item.target == target);
            if (message != null)
            {
                _message.MessageList.Remove(message);
                _message.SaveChanges();

            }
           
        }

        //public void UpDateMessage(Message newMessage, string title)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteMessage(string id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
