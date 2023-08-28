using BLOODBANK2.Context;
using BLOODBANK2.Models;
using BLOODBANK2.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace BLOODBANK2.Services
{
    // DonorService.cs
    public class DonorService:IDonorService
    {
        private readonly ApplicationDbContext _context;

        public DonorService(ApplicationDbContext context)
        {
            _context = context;
            
        }


    

        public async Task<Donor> GetDonorByAsync(string email,string password)
        {

            return await _context.Donors.FirstOrDefaultAsync(d => (d.Email == email && d.Password==password));

        }

    

        public List<string> GetCities()
        {
            return _context.Donors.Select(d => d.City).Distinct().ToList();
        }

        public List<string> GetStates()
        {
            return _context.Donors.Select(d => d.State).Distinct().ToList();
        }

        public List<string> GetBloodTypes()
        {
            return _context.Donors.Select(d => d.Blood).Distinct().ToList();
        }
        public async Task<List<Donor>> GetAllDonorsAsync()
        {
            return await _context.Donors.ToListAsync();
        }

        //public async Task<Donor> GetDonorByIdAsync(int id)
        //{
        //    return await _context.Donors.FindAsync(id);
        //}

      

        // Other methods...
    
    public async Task CreateDonorAsync(Donor donor)
        {
            _context.Donors.Add(donor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Donor>> SearchDonor(string city, string state, string grp)
        {
            var rsearch = await _context.Donors.Where(donor => donor.City == city &&
            donor.State == state && donor.Blood == grp).ToListAsync();

            if (rsearch == null)
            {
                throw new Exception("Not found");
            }
            else
            {
                return rsearch;
            }
        }
     
        public async Task<Donor> RegisterDonorAsync(Donor donor)
        {
            try
            {
                // Add the donor to the database and save changes
                _context.Donors.Add(donor);
                await _context.SaveChangesAsync();
                return donor;
            }
            catch (Exception ex)
            {
                // Handle exception, log, etc.
                throw new Exception($"Error registering donor: {ex.Message}");
            }
        }



        public async Task<bool> RequestBloodAsync(int donorId)
        {
            var donor = await _context.Donors.FindAsync(donorId);
            if (donor == null)
            {
                return false;
            }

            var bloodRequest = new BloodRequest
            {
                DonorId = donorId,
                // Assuming you have recipient data
                RequestDate = DateTime.Now
            };

            _context.BloodRequests.Add(bloodRequest);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task ReportDonorAsync(int donorId, string reason)
        {
            var donor = await _context.Donors.FindAsync(donorId);
            if (donor != null)
            {
               // donor.Reported = true;
                donor.ReportReason = reason;
                _context.Donors.Update(donor);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Donor not found");
            }
        }
        public async Task<Donor> GetDonorByIdAsync(int id)
        {
            return await _context.Donors.FirstOrDefaultAsync(d => d.Id == id);
        }

        //public async Task<Donor> CreateDonorAsync(Donor newDonor)
        //{
        //    _context.Donors.Add(newDonor);
        //    await _context.SaveChangesAsync();
        //    return newDonor;
        //}

        public async Task<bool> UpdateDonorAsync(Donor updatedDonor)
        {
            _context.Entry(updatedDonor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> DeleteDonorAsync(int id)
        {
            var donor = await _context.Donors.FindAsync(id);

            if (donor == null)
            {
                return false;
            }

            _context.Donors.Remove(donor);
            await _context.SaveChangesAsync();
            return true;
        }

        Task<Donor> IDonorService.CreateDonorAsync(Donor newDonor)
        {
            throw new NotImplementedException();
        }
    }
}


