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

    public class RankController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public RankController(ApplicationContext context)
        {
            _context = context;
        }
    }
}