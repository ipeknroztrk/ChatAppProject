using System;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatAppProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;
        Context context = new Context();

        public MessageController(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await GetCurrentUserAsync();
            if (user == null) return RedirectToAction("Login", "Account");

            var messages = _messageService.GetList(m => m.ReceiverId == user.Id &&m.IsTrash==false).ToList();

            if (messages == null || !messages.Any())
            {
                // Eğer mesaj yoksa boş bir liste gönderelim
                messages = new List<Message>();
            }

            return View(messages);
        }
        internal async Task<AppUser> GetCurrentUserAsync()
        {
            // Eğer kullanıcı oturum açmamışsa veya kimlik bilgisi yoksa
            if (User?.Identity?.Name == null)
            {
                ModelState.AddModelError("", "Kullanıcı oturum açmamış veya kimlik bilgisi yok");
                return null;
            }

            // Oturum açmış kullanıcının kimliğini alıyoruz
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            // Eğer kullanıcı bulunamamışsa
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı");
                return null;
            }

            // Kullanıcının isim ve soyisim bilgilerini dolduruyoruz
            user.Name = User.Identity.Name; // veya ilgili kullanıcı veritabanından alınabilir
            user.Surname = ""; // veya ilgili kullanıcı veritabanından alınabilir

         
            return user;
        }


        [HttpGet]
        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewMessage(Message message)
        {
            // Mesaj doğrulama işlemi yapılıyor
            var validator = new NewMessageValıdator();
            var validationResult = validator.Validate(message);

            // Eğer doğrulama başarılıysa
            if (validationResult.IsValid)
            {
                // Oturum açmış kullanıcıyı alıyoruz
                var user = await GetCurrentUserAsync();
              

                // Alıcıyı e-posta adresi üzerinden buluyoruz
                var receiver = _userManager.Users.FirstOrDefault(x => x.Email == message.ReRecieverMail);
                if (receiver == null)
                {
                    ModelState.AddModelError("", "Alıcı bulunamadı.");
                    return View(message);
                }

                // Mesajın diğer alanlarını dolduruyoruz
                message.SenderId = user.Id;
                message.ReceiverId = receiver.Id;
                message.SendDate = DateTime.Now;
                message.Status = true;
                message.IsRead = false;
                message.IsImportant = false;
                message.IsTrash = false;
                message.ReRecieverMail = user.Email;
                message.ImageUrl = user.Image;

                // Öncelik seviyesini enum'a dönüştürme
                message.Priority = (Priority.PriorityLevel)Enum.Parse(typeof(Priority.PriorityLevel), Request.Form["Priority"]);

                // Mesajı veri tabanına ekliyoruz
                _messageService.TAdd(message);

                // Gelen kutusuna yönlendiriyoruz
                return RedirectToAction("Inbox");
            }

            // Eğer doğrulama başarısızsa, formu tekrar gösteriyoruz
            return View(message);
        }

        public async Task<IActionResult> SendBox(int p)
        {
            var user = await GetCurrentUserAsync();
            p = user.Id;
            var messages = _messageService.TGetSentMessagesListWithSender(user.Email);
            return View(messages);
        }

        public IActionResult DeleteReceivedMessages(int id)
        {
            var values = context.Messages.Where(x => x.MessageId == id).FirstOrDefault();
            values.IsTrash = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetails(int id)
        {
            var value = _messageService.TGetById(id);
            return View(value);
        }
        public IActionResult DeleteMessage(int id)
        {
            _messageService.TDelete(id);
            return RedirectToAction("TrashMessages");
        }
        public async Task<IActionResult> TrashMessages()
        {
            var user = await GetCurrentUserAsync();
            if (user == null) return RedirectToAction("Login", "Account");

            // Çöp kutusu mesajları için filtreleme
            var trashMessages = _messageService.GetList(m => m.ReceiverId == user.Id && m.IsTrash == true).ToList();

            if (trashMessages == null || !trashMessages.Any())
            {
                // Çöp kutusunda mesaj yoksa boş bir liste gönderelim
                trashMessages = new List<Message>();
            }

            return View(trashMessages);
        }

        public async Task<IActionResult> ImportantMessages(int id)
        {
            var user = await GetCurrentUserAsync();
            if (user == null) return RedirectToAction("Login", "Account");

            
            var ımportantmessage = _messageService.GetList(m => m.ReceiverId == user.Id && m.IsImportant == true).ToList();

            if (ımportantmessage == null || !ımportantmessage.Any())
            {
                // Çöp kutusunda mesaj yoksa boş bir liste gönderelim
                ımportantmessage = new List<Message>();
            }

            return View(ımportantmessage);
        }

        public IActionResult MakeImportant(int id)
        {
            var values = context.Messages.Where(x => x.MessageId == id).FirstOrDefault();
            values.IsImportant = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

    }
}
