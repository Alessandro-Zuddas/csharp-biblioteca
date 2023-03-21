
var user = new User("Zuddas", "Alessandro", "ale@email.com", "123abc456", 1222334444);
var books = new List<Book>();
var dvds = new List<Dvd>();

Book libro1 = new Book("ISBN123", "Il Signore degli Anelli", "1954", "Fantasy", "S1", "J.R.R. Tolkien", 1178);
Book libro2 = new Book("ISBN456", "Harry Potter e la Pietra Filosofale", "1997", "Fantasy", "S2", "J.K. Rowling", 223);
Book libro3 = new Book("ISBN789", "1984", "1949", "Fiction", "S3", "George Orwell", 328);
Book libro4 = new Book("ISBN012", "Il Nome della Rosa", "1980", "Fiction", "S4", "Umberto Eco", 512);
Book libro5 = new Book("ISBN345", "Cronache del ghiaccio e del fuoco", "1996", "Fantasy", "S5", "George R.R. Martin", 694);

Dvd dvd1 = new Dvd("DVD001", "Pirati dei Caraibi: La Maledizione della Prima Luna", "2003", "Avventura", "S1", "Gore Verbinski", "143");
Dvd dvd2 = new Dvd("DVD002", "The Shawshank Redemption", "1994", "Drammatico", "S2", "Frank Darabont", "142");
Dvd dvd3 = new Dvd("DVD003", "Inception", "2010", "Fantascienza", "S3", "Christopher Nolan", "148");
Dvd dvd4 = new Dvd("DVD004", "Il Padrino", "1972", "Drammatico", "S4", "Francis Ford Coppola", "175");
Dvd dvd5 = new Dvd("DVD005", "La La Land", "2016", "Musicale", "S5", "Damien Chazelle", "128");

books.Add(libro1);
books.Add(libro2);
books.Add(libro3);
books.Add(libro4);
books.Add(libro5);

dvds.Add(dvd1);
dvds.Add(dvd2);
dvds.Add(dvd3);
dvds.Add(dvd4);
dvds.Add(dvd5);

while (true)
{
    Console.WriteLine("Vuoi cercare per titolo o per codice documento?");
    var userInput = Console.ReadLine();

    string userTitle = "";
    string userCode = "";

    if (userInput == "titolo")
    {
        Console.WriteLine("Inserisci il titolo");
        userTitle = Console.ReadLine();
    }
    else if(userInput == "codice")
    {
        Console.WriteLine("Inserisci il codice");
        userCode = Console.ReadLine();
    }

    switch (userInput)
    {
        case "titolo":

            Console.WriteLine("Articoli trovati: ");
            Console.WriteLine();

            foreach (var book in books)
            {
                if (book.getDocTitle().ToLower() == userTitle)
                {
                    Console.WriteLine();
                    Console.WriteLine(book);
                    Console.WriteLine();
                    break;
                }
            }

            foreach (var dvd in dvds)
            {
                if (dvd.getDocTitle().ToLower() == userTitle)
                {
                    Console.WriteLine();
                    Console.WriteLine(dvd);
                    Console.WriteLine();
                    break;
                }
            }

            break;

        case "codice":

            Console.WriteLine("Articoli trovati: ");
            Console.WriteLine();

            foreach (var book in books)
            {

                if (book.getDocCode().ToLower() == userCode)
                {
                    Console.WriteLine();
                    Console.WriteLine(book);
                    Console.WriteLine();
                    break;
                }
            }

            foreach (var dvd in dvds)
            {

                if (dvd.getDocCode().ToLower() == userCode)
                {
                    Console.WriteLine();
                    Console.WriteLine(dvd);
                    Console.WriteLine();
                    break;
                }
            }

            break;
    }
};