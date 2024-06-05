using System;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFMessageDAL : GenericRepository<Message>, IMessageDAL
    {
        private readonly Context _context;

        public EFMessageDAL(Context context) : base(context)
        {
            _context = context;
        }

        public List<Message> GetImportantMessagesListWithSender(string email)
        {
            return _context.Messages
                .Include(x => x.Receiver)
                .Where(x => x.ReRecieverMail == email && x.IsImportant == true)
                .OrderByDescending(x => x.MessageId)
                .ToList();
        }

        public List<Message> GetList()
        {
            using var c = new Context();
            return c.Messages.ToList();
        }

        public List<Message> GetListWithInclude(Expression<Func<Message, bool>> filter = null)
        {
            using (var context = new Context())
            {
                if (filter == null)
                {
                    return context.Messages.Include(m => m.Sender).Include(m => m.Receiver).ToList();
                }//.net core ilişkili tabloalrda listeleme yapabilmek için ınclude kullanmamız lazım
                else
                {
                    return context.Messages.Where(filter).Include(m => m.Sender).Include(m => m.Receiver).ToList();
                }
            }
        }

        public List<Message> GetSentMessagesListWithSender(string email)
        {
            return _context.Messages
                 .Include(x => x.Receiver)
                 .Where(x => x.IsTrash == false && x.Sender.Email == email && x.Status == true)
                 .OrderByDescending(x => x.MessageId)
                 .ToList();
        }

        public List<Message> GetTrashMessagesListWithSender(string email)
        {
            return _context.Messages
                 .Include(x => x.Receiver)
                 .Where(x => x.ReRecieverMail == email && x.IsTrash == true)
                 .OrderByDescending(x => x.MessageId)
                 .ToList();
        }
    }
}

