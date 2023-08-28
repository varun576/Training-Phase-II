using BLOODBANK2.Models;
using System.Threading.Tasks;


namespace BLOODBANK2.Services
{
    public interface IRecipientService
    {
        Task AddRecipientAsync(Recipient recipient);
        Task<Recipient> GetRecipientByIdAsync(int recipientId);
        Task ReportDonorAsync(int recipientId, int donorId, string reason);
        Task RequestBloodFromDonorAsync(int recipientId, int donorId);
        // Other methods for recipient-related functionality
    }
}
