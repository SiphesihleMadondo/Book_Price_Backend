using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Book_Price_Backend.Data;
using Microsoft.EntityFrameworkCore;

namespace Book_Price_Backend.Contollers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookPricesController : Controller
    {
       private readonly BookPriceContext _book;
        // GET: BookPricesController

        public BookPricesController(BookPriceContext _book)
        {
            this._book = _book;
        }
        [HttpGet]
        [Route("AllClients")]
        public async Task<IActionResult> getResulust()
        {
            return Ok(await _book.BookPrices.ToListAsync());
        }

        [HttpGet]
        [Route("Partners")]
        public async Task<IActionResult> ClientsPerPartner()
        {
            var item = await _book.Partners.ToListAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("ClientsPartner/{PartnerName}")]
        public async Task<IActionResult> ClientsPerPartner([FromRoute] string PartnerName)
        {
            var currentYear = DateTime.Now.Year;
            var item = await _book.BookPrices
                .Where(xp => xp.Partner == PartnerName && xp.StatementDate.Value.Year == currentYear) //getting the current year and comparing with statement date
                .ToListAsync();
            return Ok(item);
        }
       
    }
}
