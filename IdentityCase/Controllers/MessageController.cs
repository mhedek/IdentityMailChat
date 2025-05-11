using IdentityCase.Context;
using IdentityCase.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCase.Controllers
{
    public class MessageController : Controller
    {
        private readonly CaseContext _context;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(CaseContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult InboxMessageDetails(int id)
        {
            var values = _context.Messages.FirstOrDefault(x => x.MessageId == id);
            return View(values);
        }
        public IActionResult SendboxMessageDetails(int id)
        {
            var values = _context.Messages.FirstOrDefault(x => x.MessageId == id);
            return View(values);
        }
        public async Task<IActionResult> Profile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //Giriş yapan kullanıcının bilgilerini getiriyor
            ViewBag.v1 = values.Name + " " + values.Surname;
            ViewBag.v2 = values.Email;

            var receivedMessageCount = _context.Messages.Count(m => m.ReceiverEmail == values.Email);
            var sentMessageCount = _context.Messages.Count(m => m.SenderEmail == values.Email);

            ViewBag.ReceivedMessages = receivedMessageCount;
            ViewBag.SentMessages = sentMessageCount;

            return View();
        }
        public async Task<IActionResult> Inbox()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _context.Messages.Where(x => x.ReceiverEmail == values.Email).ToList();

            return View(messageList);
        }
        public async Task<IActionResult> Sendbox()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string email = values.Email;
            var sendmessageList = _context.Messages.Where(x => x.SenderEmail == email).ToList();
            return View(sendmessageList);
        }
        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string x = values.Email;

            message.SenderEmail = x;
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            _context.Messages.Add(message);
            _context.SaveChanges();

            TempData["alert"] = "Mesaj basariyla gonderildi!";
            return RedirectToAction("Sendbox");
        }
    }
}
