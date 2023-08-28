
using BLOODBANK2.Models;
using BLOODBANK2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BLOODBANK2.Controllers
{
    // DonorsController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        private readonly DonorService _donorService;
       

        public DonorsController(DonorService donorService)
        {
            _donorService = donorService;
         
        }
      
        [HttpGet("cities")]
        public ActionResult<List<string>> GetCities()
        {
            var cities = _donorService.GetCities();
            return Ok(cities);
        }

        [HttpGet("states")]
        public ActionResult<List<string>> GetStates()
        {
            var states = _donorService.GetStates();
            return Ok(states);
        }

        [HttpGet("bloodtypes")]
        public ActionResult<List<string>> GetBloodTypes()
        {
            var bloodTypes = _donorService.GetBloodTypes();
            return Ok(bloodTypes);
        }

        [HttpGet]
        public async Task<ActionResult<List<Donor>>> GetDonors()
        {
            var donors = await _donorService.GetAllDonorsAsync();
            return Ok(donors);
        }


        [HttpPost]
        public async Task<IActionResult> RegisterDonor([FromBody] Donor donor)
        {
            try
            {
                var registeredDonor = await _donorService.RegisterDonorAsync(donor);
                return Ok(registeredDonor);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error registering donor: {ex.Message}");
            }
        }




        [HttpGet("{id}")]
        public async Task<ActionResult<Donor>> GetDonorById(int id)
        {
            var donor = await _donorService.GetDonorByIdAsync(id);
            if (donor == null)
            {
                return NotFound();
            }
            return Ok(donor);
        }

        //[HttpPost]
        //public async Task<ActionResult> CreateDonor([FromBody] Donor donor)
        //{
        //    var registeredDonor = await _donorService.RegisterDonorAsync(donor);
        //       return Ok(registeredDonor);
        //}


        [HttpGet("search")]
        public async Task<ActionResult<List<Donor>>> SearchDonor(string city, string state, string bloodType)
        {
            try
            {
                var searchResults = await _donorService.SearchDonor(city, state, bloodType);
                return Ok(searchResults);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            try
            {
                var donor = await _donorService.GetDonorByAsync(email,password);
                //var donor1 = await _donorService.GetDonorByPasswordAsync(password);
                if (donor == null)
                {
                    return NotFound();
                }
                return Ok(donor);
            
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Error logging in: {ex.Message}" });
            }
        }

    
    //[HttpPut("{id}")]
    //public async Task<IActionResult> UpdateDonor(int id, Donor donor)
    //{
    //    if (id != donor.Id)
    //    {
    //        return BadRequest();
    //    }

    //    await _donorService.UpdateDonorAsync(donor);
    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //public async Task<IActionResult> DeleteDonors(int id)
    //{
    //    await _donorService.DeleteDonorAsync(id);

    //    return NoContent();
    //}



    [HttpPost("request/{donorId}")]
        public async Task<IActionResult> RequestBlood(int donorId)
        {
            try
            {
                var result = await _donorService.RequestBloodAsync(donorId);
                if (result)
                {
                    return Ok($"Blood donation requested from donor with ID: {donorId}");
                }
                return NotFound($"Donor with ID {donorId} not found or blood request failed.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error requesting blood donation: {ex.Message}");
            }
        }

        [HttpPost("reportdonor/{id}")]
        public async Task<IActionResult> ReportDonor(int id, [FromBody] string reason)
        {
            try
            {
                await _donorService.ReportDonorAsync(id, reason);
                return Ok($"Donor with ID {id} reported for: {reason}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error reporting donor: {ex.Message}");
            }
        }

        //[HttpGet]
        //[Route("profile")]
        //public async Task<IActionResult> GetDonorProfile()
        //{
        //    var donorProfile = await _donorService.GetDonorProfileAsync();
        //    if (donorProfile == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(donorProfile);
        //}

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDonor(int id, Donor updatedDonor)
        {
            if (id != updatedDonor.Id)
            {
                return BadRequest();
            }

            var result = await _donorService.UpdateDonorAsync(updatedDonor);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonor(int id)
        {
            var result = await _donorService.DeleteDonorAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

