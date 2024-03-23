using System.Text.Json;
namespace Exam3
{
    public class task4
    {
        public List<Books> BookList = new List<Books>();
        string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        string Backfabet = "zyxwvutsrqponmlkjihgfedcba";
        public void reader() //redundant refractor at the end ot one function for all if oyu have time
        {
            string BookString = File.ReadAllText("books.json");
            Books book = JsonSerializer.Deserialize<Books>(BookString);
            BookList.Add(book);
        }
        List<Books> ReturnBookByKeyword(string keyword = "the")
        {
            List<Books> BooksWithKeyword = new List<Books>();
            foreach (Books book in BookList)
            {
                if (book.title.Contains(keyword))
                {
                    BooksWithKeyword.Add(book);
                }
            }
            return BooksWithKeyword;
        }

        List<Books> ReturnBookByAuthorContainsLetter(char Keyletter = 't')
        {
            List<Books> BooksWithKeyword = new List<Books>();
            foreach (Books book in BookList)
            {
                if (book.author.ToLower().Contains(Keyletter))
                {
                    BooksWithKeyword.Add(book);
                }
            }
            return BooksWithKeyword;
        }
        int NumberOfBooksAfterYear(int Year = 1992)
        {
            List<Books> BooksWithKeyword = new List<Books>();
            foreach (Books book in BookList)
            {
                if (book.publication_year > Year)
                {
                    BooksWithKeyword.Add(book);
                }
            }
            return BooksWithKeyword.Count;

        }
        int NumberOfBooksBeforeYear(int Year = 2004)
        {
            List<Books> BooksWithKeyword = new List<Books>();
            foreach (Books book in BookList)
            {
                if (book.publication_year < Year)
                {
                    BooksWithKeyword.Add(book);
                }
            }
            return BooksWithKeyword.Count;

        }
        List<string> ISBNAuthorReturn(string authorName)
        {
            List<string> ISBNS = new List<string>();
            foreach (Books book in BookList)
            {
                if (book.author == authorName)
                {
                    ISBNS.Add(book.isbn);
                }
            }
            return ISBNS;
        }
        List<Books> ListBooksAlphabeticallyy(bool Ascending = true, bool Authorsort = false)
        {
            List<Books> Booksalphabetical = new List<Books>();
            if (Ascending)
            {
                foreach (char c in Backfabet)
                {
                    foreach (Books book in BookList)
                    {
                        if (c == book.title.ElementAt(0))
                        {
                            Booksalphabetical.Add(book);
                        }
                    }
                }

            }
            else if (!Ascending)
            {
                foreach (char c in Alphabet)
                {
                    foreach (Books book in BookList)
                    {
                        if (Authorsort)
                        {
                            if (c == book.author.ElementAt(0))
                            {
                                Booksalphabetical.Add(book);
                            }
                        }
                        else if (c == book.title.ElementAt(0))
                        {
                            Booksalphabetical.Add(book);
                        }
                    }
                }

            }
            return Booksalphabetical;
        }
        List<Books> ListBooksChronologicaly(bool Ascending = true)
        {
            List<Books> Chronologically = new List<Books>();
            if (Ascending)
            {
                for (int i = 0; i < 2025; i++)
                {

                    foreach (Books book in BookList)
                    {
                        if (book.publication_year == i)
                        {
                            Chronologically.Add(book);
                        }
                    }
                }
                return Chronologically;

            }
            else if (!Ascending)
            {
                for (int i = 2025; i > 0; i--)
                {
                    foreach (Books book in BookList)
                    {
                        if (book.publication_year == i)
                        {
                            Chronologically.Add(book);
                        }
                    }
                }
                return Chronologically;
            }
            else
            {
                Console.WriteLine("error");
                return Chronologically;
            }

        }
        List<Books[]> ListBooksGroupedAuthorFirstName()
        {
            List<Books> AlphabeticallySortedBooks = ListBooksAlphabeticallyy(false,true);
            List<Books> GroupedBooks = new List<Books>();
            List<Books[]> BookGroupsGrouped = new List <Books[]>();
            string startingname = AlphabeticallySortedBooks[0].authordictionary["FirstName"];
            
            foreach (Books book in AlphabeticallySortedBooks)
            {
                if( book.authordictionary["FirstName"] == startingname){
                    GroupedBooks.Add(book);
                }
                else{
                     startingname = book.authordictionary["FirstName"];
                    BookGroupsGrouped.Add(GroupedBooks.ToArray());
                    GroupedBooks.Clear();
                    GroupedBooks.Add(book);
                }

            }
            return BookGroupsGrouped;
        }
        List<Books[]> ListBooksGroupedAuthorLastName()
        {
             List<Books> AlphabeticallySortedBooks = new List<Books>();
            List<Books> GroupedBooks = new List<Books>();
            List<Books[]> BookGroupsGrouped = new List <Books[]>();
            string startingname = AlphabeticallySortedBooks[0].authordictionary["LastName"];
            
            foreach (Books book in BookList)
            { 
                if( book.authordictionary["LastName"] == startingname){
                    GroupedBooks.Add(book);
                }
                else if( BookGroupsGrouped.Contains(book.authordictionary[])){
                    //my head started spinning so this is a potential error in my code. 
                }
                else{
                     startingname = book.authordictionary["LastName"];
                    BookGroupsGrouped.Add(GroupedBooks.ToArray());
                    GroupedBooks.Clear();
                    GroupedBooks.Add(book);
                }

            }
            return BookGroupsGrouped;
        }
        public void runTask4()
        {
            reader();
            Console.WriteLine($"return book by keyword \n{ReturnBookByKeyword()} \n return book by author contains letter \n{ReturnBookByAuthorContainsLetter()}");
            Console.WriteLine($" return book by year \n {NumberOfBooksAfterYear()}\n return book before year \n{NumberOfBooksBeforeYear()}");
            Console.WriteLine($"isbn author default value = christian \n {ISBNAuthorReturn("Christian")} list books alphabetically \n  {ListBooksAlphabeticallyy()} list books chronologically \n {ListBooksChronologicaly()} grouped by author first name \n {ListBooksGroupedAuthorFirstName()} grouped by lastname \n{ListBooksGroupedAuthorLastName()}");
        }

    }
    public class Books
    {
        public string title { get; set; }
        public int publication_year { get; set; }
        public string author { get; set; }
        public Dictionary<string, string> authordictionary { get; set; }
        public string isbn { get; set; }

        public Books()
        {
            authordictionary = AuthorDictionary(author);
        }
        public Dictionary<string, string> AuthorDictionary(string author)
        {
            string[] authorNames = author.Split(' ');
            Dictionary<string, string> dictionary = new Dictionary<string, string>
             {
                 { "FirstName" ,authorNames[0]},
                  {"LastName" , authorNames[1]}
             };
            return dictionary;

        }


    }
}