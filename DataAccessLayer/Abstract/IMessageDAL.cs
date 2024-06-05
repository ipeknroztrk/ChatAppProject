using System;
using System.Linq.Expressions;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDAL : IGenericDAL<Message>
    {
        List<Message> GetListWithInclude(Expression<Func<Message, bool>> filter = null);
        List<Message> GetImportantMessagesListWithSender(string email);
        List<Message> GetSentMessagesListWithSender(string email);
        List<Message> GetTrashMessagesListWithSender(string email);
    }
}

