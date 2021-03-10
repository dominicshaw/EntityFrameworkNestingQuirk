using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Appraiser.Data;
using Appraiser.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNestingQuirk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppraisalsController : ControllerBase
    {
        private readonly ILogger<AppraisalsController> _logger;
        private readonly AppraiserContext _context;

        public AppraisalsController(ILogger<AppraisalsController> logger, AppraiserContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Appraisal>> GetAppraisal(int id)
        {
            try
            {
                var (found, model) = await Get(id);

                if (!found) return NotFound();

                return model;
            }
            finally
            {
                _logger.LogInformation("Got weather");
            }
        }

        private async Task<(bool Found, Appraisal Appraisal)> Get(int id)
        {
            var staff = await _context.Staff.FindAsync(3);

            _logger.LogInformation("Got Staff Object   : Staff {id} has manager set to {managerId} - running query for appraisal", staff.Id, staff.ManagerId);

            var appraisal =
                await _context.Appraisals
                    .Include(ap => ap.Staff).ThenInclude(s => s.Manager)
                    .Include(ap => ap.Staff).ThenInclude(s => s.SecondaryManager)
                    .Where(ap => ap.Id == id)
                    .SingleOrDefaultAsync();

            _logger.LogInformation("Appraisal Query Run: Staff {id} has manager set to {managerId} - run completed", staff.Id, staff.ManagerId);

            if (appraisal != null)
                return (true, appraisal);

            return (false, null);
        }
    }
}
