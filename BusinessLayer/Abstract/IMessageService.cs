using System;
using System.Linq.Expressions;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IMessageService:IGenericService<Message>
	{
        List<Message> GetList(Expression<Func<Message, bool>> filter = null);
        List<Message> TGetImportantMessagesListWithSender(string email);
        List<Message> TGetTrashMessagesListWithSender(string email);
        List<Message> TGetSentMessagesListWithSender(string email);
    }
}

