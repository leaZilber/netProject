﻿using houseCommittee.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace houseCommittee.core.repositoriesI
{
    public interface IMessageRepository
    {

        public Message GetMessageByid(string code);//שליפת הודעה עפ"י קוד

        public List<Message> GetAllMessages();

        public void AddMessage(Message newMessage);

        public void UpDateMessage(Message newMessage, string title);//עדכון פרטי בנין

        public void DeleteMessage(string id);//מחיקת הודעה
    }
}