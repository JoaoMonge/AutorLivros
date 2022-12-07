var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Author eca = new Author("Eca", "eca@mail.com");
Book livro = new Book("12323235", "Titulo", eca, 12.30);
Book livro2 = new Book("34554677", "Titulo2", eca, 15.60,10);

app.MapGet("/", () => livro2.ToString());

app.Run();

class Author {

    string name;
    string email;

    public Author(string name,string email)
    {
        this.email = email;
        this.name = name;
    }

    public override string ToString()
    {
        return "Author[name=" + Name + ",email=" + Email + "]";
    }

    public string Name { get => name;}
    public string Email { get => email; set => email = value;}
}

class Book
{
    string isbn;
    string name;
    Author author;
    double price;
    int qty;

    public Book(string isbn,string name,Author author,double price)
    {
        this.isbn = isbn;
        this.name = name;
        this.author = author;
        this.price = price;
    }

    public Book(string isbn, string name, Author author, double price,int qty)
    {
        this.isbn = isbn;
        this.name = name;
        this.author = author;
        this.price = price;
        this.qty = qty;
    }

    public override string ToString()
    {
        return "Book[isbn="+Isbn+","+Author.ToString()+",price="+Price+",qty="+Qty+"]";
    }

    public string Isbn { get => isbn;}
    public string Name { get => name;}
    public double Price { get => price; set => price = value; }
    public int Qty { get => qty; set => qty = value; }
    public Author Author { get => author;}
    public string AuthorName { get => Author.Name;}

}
