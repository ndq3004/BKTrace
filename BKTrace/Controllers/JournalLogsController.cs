using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKTrace.Context;
using BKTrace.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BKTrace.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class JournalLogsController : ControllerBase
    {
        private readonly AppDbContext _context;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<JournalLogsController> _logger;

        public JournalLogsController(ILogger<JournalLogsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<JournalLog> Get()
        {
            return _context.journalLogs.ToList();
        }
    }
}
