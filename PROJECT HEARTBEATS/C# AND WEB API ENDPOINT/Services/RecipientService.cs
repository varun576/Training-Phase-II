using BLOODBANK2.Context;
using BLOODBANK2.Models;
using BLOODBANK2.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BLOODBANK2.Services
{
    // RecipientService.cs
    public class RecipientService:IRecipientService
    {
        private readonly ApplicationDbContext _context;

        public RecipientService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Recipient> GetRecipientByIdAsync(int recipientId)
        {
            return await _context.Recipients.FirstOrDefaultAsync(r => r.Id == recipientId);
        }

        public async Task RequestBloodFromDonorAsync(int recipientId, int donorId)
        {
            var bloodRequest = new BloodRequest
            {
               
                DonorId = donorId,
                RequestDate = DateTime.UtcNow
            };

            _context.BloodRequests.Add(bloodRequest);
            await _context.SaveChangesAsync();
        }

        public async Task ReportDonorAsync(int recipientId, int donorId, string reason)
        {
            var report = new Report
            {
                RecipientId = recipientId,
                DonorId = donorId,
                Reason = reason,
                ReportDate = DateTime.UtcNow
            };

            _context.Reports.Add(report);
            await _context.SaveChangesAsync();
        }

        public async Task AddRecipientAsync(Recipient recipient)
        {
            _context.Recipients.Add(recipient);
            await _context.SaveChangesAsync();
        }
    }

    }
