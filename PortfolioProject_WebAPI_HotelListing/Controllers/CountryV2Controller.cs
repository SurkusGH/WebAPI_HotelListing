﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject_WebAPI_HotelListing.DataAccess;
using System.Threading.Tasks;

namespace PortfolioProject_WebAPI_HotelListing.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(_context.Countries);
        }
    }
}
