using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Message
	{
        [Key]
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public AppUser Sender { get; set; }
        //Mesajı gönderen kullanıcıyı temsil eden bir AppUser nesnesi.
        public int ReceiverId { get; set; }
        public AppUser Receiver { get; set; }
        // Mesajı alan kullanıcıyı temsil eden bir AppUser nesnesi.
        public string Subject { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public string ReRecieverMail { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Status { get; set; }
        public bool IsRead { get; set; }
        public bool IsImportant { get; set; }
        public bool IsTrash { get; set; } 
       
        public Priority.PriorityLevel Priority { get; set; } 
       

    }
}

