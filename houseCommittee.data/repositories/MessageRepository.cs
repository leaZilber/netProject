﻿using houseCommittee.core.models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.data;
//using WebApplication1;

namespace houseCommittee.data.repositories
{
    public class MessageRepository
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
            return _message.MessageList;
        }

        public void AddMessage(Message newMessage)
        {
            _message.MessageList.Add(newMessage);
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
        }
        public void DeleteMessage(string title, string target)//מחיקת הודעה
        {
            _message.MessageList.RemoveAll(item => item.Title == title && item.target == target);
        }
    }
}
