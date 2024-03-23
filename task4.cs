using System.Text.Json;
namespace Exam3
{
    class task4
    {
        public List<books> BookList = new List<books>();

        public void reader() //redundant refractor at the end ot one function for all if oyu have time
        {

            string BookString = File.ReadAllText("books.json");
            books book = JsonSerializer.Deserialize<books>(BookString);
            BookList.Add(book);
        }
        List<books> ReturnBookByKeyword(string keyword = "the")
        {  List<books> BooksWithKeyword = new List<books>();
            foreach(books book in BookList){
                if( book.title.Contains(keyword)){
                BooksWithKeyword.Add(book);} 
            }
            return BooksWithKeyword;
        }

        String ReturnBookByAuthorContainsLetter(char Keyletter = 't')
        {

        }
        int NumberOfBooksAfterYear(int Year = 1992)
        {

        }
        int NumberOfBooksBeforeYear(int Year = 2004)
        {

        }
        string ISBNAuthorReturn()
        {

        }
        void ListBooksAlphabetically(bool Ascending = true)
        {

        }
        void ListBooksChronologicaly(bool Ascending = true)
        {

        }
        void ListBooksGroupedAuthorLastName()
        {

        }
        void ListBooksGroupedAuthorFirstName()
        {
        }

    }
    class books
    {
        public string title { get; set; }
        public int publication_year { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
    }
}