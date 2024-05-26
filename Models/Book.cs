namespace Api.Challenge.Books.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public List<string> Genres { get; set; }
    public int Quantity { get; set; }
}