using Api.Challenge.Books.Data;
using Api.Challenge.Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Challenge.Books.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookStoreController : ControllerBase
{
    private readonly BookStoreContext _context;
    
    public BookStoreController(BookStoreContext context)
    {
        _context = context;
    }
    
    // GET: api/BookStore
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }
    
    // GET: api/BookStore/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        
        if (book == null)
        {
            return NotFound();
        }
        
        return book;
    }
    
    // PUT: api/BookStore/{id}
    [HttpPut("{id:int}")]
    public async Task<IActionResult> PutBook(int id, Book book)
    {
        if (id != book.Id)
        {
            return BadRequest();
        }
        
        _context.Entry(book).State = EntityState.Modified;
        
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BookExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        
        return NoContent();
    }
    
    // POST: api/BookStore
    [HttpPost]
    public async Task<ActionResult<Book>> PostBook(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        
        return CreatedAtAction("GetBook", new { id = book.Id }, book);
    }
    
    // DELETE: api/BookStore/{id}
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        
        if (book == null)
        {
            return NotFound();
        }
        
        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        
        return NoContent();
    }
    
    private bool BookExists(int id)
    {
        return _context.Books.Any(e => e.Id == id);
    }
}