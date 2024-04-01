using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWork.Models;

namespace WebApiWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            PanelContext context = new PanelContext();
            List<AdminUser> adminUser = context.AdminUsers.ToList();
            return Ok(adminUser);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            PanelContext context = new PanelContext();
            AdminUser adminUser = context.AdminUsers.FirstOrDefault(u => u.Id == id);

            if (adminUser == null)
            {
                return NotFound("Kullanıcı bulunamadı!");
            }

            return Ok(adminUser);
        }

        [HttpPost]
        public IActionResult Create(AdminUser user)
        {
            PanelContext context = new PanelContext();
            context.AdminUsers.Add(user);
            context.SaveChanges();

            return Ok("Kayıt başarılı");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            PanelContext context = new PanelContext();
            AdminUser adminUser = context.AdminUsers.FirstOrDefault(x => x.Id == id);

            if (adminUser == null)
            {
                return NotFound("Kullanıcı bulunamadı!");

            }
            context.AdminUsers.Remove(adminUser);
            context.SaveChanges();
            return Ok("Silme işlemi başarılı");
        }

        [HttpPut]
        public IActionResult Update(AdminUser user)
        {
            PanelContext context = new PanelContext();
            AdminUser adminUser = context.AdminUsers.FirstOrDefault(x => x.Id == user.Id);

            adminUser.UserName = user.UserName;
            adminUser.SurName = user.SurName;
            adminUser.AddDate = user.AddDate;
            adminUser.IsDeleted = user.IsDeleted;
            adminUser.Email = user.Email;
            context.SaveChanges();

            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
