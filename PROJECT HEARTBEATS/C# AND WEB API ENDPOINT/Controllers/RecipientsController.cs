using BLOODBANK2.Models;
using BLOODBANK2.Services;
using BLOODBANK2.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BLOODBANK2.Controllers
{
    // RecipientsController.cs
   
        [ApiController]
        [Route("api/recipients")]
    public class RecipientsController : ControllerBase
    {
       
       
            private readonly IRecipientService _recipientService; // Replace IRecipientService with the actual service interface
            private readonly IDonorService _donorService; // Replace IDonorService with the actual service interface

            public RecipientsController(IRecipientService recipientService, IDonorService donorService)
            {
                _recipientService = recipientService;
                _donorService = donorService;
            }

        [HttpPost]
        public async Task<ActionResult> AddRecipient([FromBody] Recipient recipient)
        {
            await _recipientService.AddRecipientAsync(recipient);
            return Ok();
        }


        [HttpGet("{recipientId}")]
        public async Task<ActionResult<Recipient>> GetRecipientById(int recipientId)
        {
            var recipient = await _recipientService.GetRecipientByIdAsync(recipientId);

            if (recipient == null)
            {
                return NotFound();
            }

            return Ok(recipient);
        }

        [HttpPost("{recipientId}/request-blood/{donorId}")]
            public async Task<ActionResult> RequestBloodFromDonor(int recipientId, int donorId)
            {
                var recipient = await _recipientService.GetRecipientByIdAsync(recipientId);
                var donor = await _donorService.GetDonorByIdAsync(donorId);

                if (recipient == null || donor == null)
                {
                    return NotFound();
                }

                await _recipientService.RequestBloodFromDonorAsync(recipientId, donorId);

                return Ok();
            }

        [HttpPost("{recipientId}/report-donor/{donorId}")]
        public async Task<ActionResult> ReportDonor(int recipientId, int donorId, [FromBody] string reason)
        {
            var recipient = await _recipientService.GetRecipientByIdAsync(recipientId);
            var donor = await _donorService.GetDonorByIdAsync(donorId);

            if (recipient == null || donor == null)
            {
                return NotFound();
            }

            await _recipientService.ReportDonorAsync(recipientId, donorId, reason);

            return Ok();
        }
    }
    }

    
