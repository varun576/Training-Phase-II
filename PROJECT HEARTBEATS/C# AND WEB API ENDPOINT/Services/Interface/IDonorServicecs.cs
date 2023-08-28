using BLOODBANK2.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
namespace BLOODBANK2.Services.Interface
{


  
        public interface IDonorService
        {
      
        Task<Donor> CreateDonorAsync(Donor newDonor);
        Task<bool> UpdateDonorAsync(Donor updatedDonor);
        Task<bool> DeleteDonorAsync(int id);
        Task<List<Donor>> GetAllDonorsAsync();
        Task<Donor> GetDonorByIdAsync(int id);
       




    }
    }


