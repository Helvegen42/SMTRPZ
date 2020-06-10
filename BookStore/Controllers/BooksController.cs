using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.RequestModels;
using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        readonly IBooksService service;

        public BooksController(IBooksService service) => this.service = service;

        [HttpPost]
        [Route("/books/add")]
        public async Task<IActionResult> AddBooks([FromBody] AddBooksRequest request)
        {
            var books = new BooksDTO { Name = request.Name, Theme = request.Theme};

            await service.AddBooksAsync(books);

            return Ok("Havaet normal`no");
        }

        [HttpGet]
        [Route("/books/get/{id}")]
        public async Task<IActionResult> GetBooks(int id)
        {
            var books = await service.GetBooksByIdAsync(id);

            return Ok(books);
        }
    }
}