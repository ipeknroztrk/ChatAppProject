using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public List<Message> GetListAll(Expression<Func<Message, bool>> filter = null)
        {
            return _messageDAL.GetList(filter);
        }

        public void TAdd(Message entity)
        {
            _messageDAL.Insert(entity);
        }

        public void TDelete(int id)
        {
            _messageDAL.Delete(id);
        }

        public List<Message> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            return _messageDAL.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDAL.GetList();
        }

        public List<Message> GetList(Expression<Func<Message, bool>> filter = null)
        {
            return _messageDAL.GetListWithInclude(filter);
        }

        public void TUpdate(Message entity)
        {
            _messageDAL.Update(entity);
        }

        public List<Message> TGetImportantMessagesListWithSender(string email)
        {
            return _messageDAL.GetImportantMessagesListWithSender(email);
        }

        public List<Message> TGetTrashMessagesListWithSender(string email)
        {
            return _messageDAL.GetTrashMessagesListWithSender(email);
        }

        public List<Message> TGetSentMessagesListWithSender(string email)
        {
            return _messageDAL.GetSentMessagesListWithSender(email);
        }
    }
}
