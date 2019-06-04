using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Logon2Controller : ControllerBase
    {
        private readonly ApplicationContext _context;

        public Logon2Controller(ApplicationContext context)
        {
            _context = context;
            if (_context.Users.Count() == 0)
            {
                // Usersテーブルが空なら初期データを作成する。
                _context.Users.Add(new User { Name = "admin", Password = "admin", IsAdmin = true });
                _context.Users.Add(new User { Name = "user", Password = "user", IsAdmin = false });
                _context.SaveChanges();
            }
        }

        // POST api/logon
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user) 
        {
            var authorizedUser2 = _context.Users
             //   .Include(User => User.Root)
                .Include(User => User.Department)
                .SingleOrDefault(x => x.Name == user.Name && x.Password == user.Password );
           


            if (authorizedUser2 == null)
            {
                return NotFound();
            }

           if (authorizedUser2.IsAdmin == false)
            {
                return NotFound();
            }

            return authorizedUser2;

        }
    }
}
