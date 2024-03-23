using System.Text.Json;
namespace Exam3
{
    class task4
    {
        public List<Books> BookList = new List<Books>();

        public void reader() //redundant refractor at the end ot one function for all if oyu have time
        {
            string BookString = File.ReadAllText("books.json");
            Books book = JsonSerializer.Deserialize<Books>(BookString);
            BookList.Add(book);
        }
        List<Books> ReturnBookByKeyword(string keyword = "the")
        {  List<Books> BooksWithKeyword = new List<Books>();
            foreach(Books book in BookList){
                if( book.title.Contains(keyword)){
                BooksWithKeyword.Add(book);} 
            }
            return BooksWithKeyword;
        }

        List<Books> ReturnBookByAuthorContainsLetter(char Keyletter = 't')
        {    List<Books> BooksWithKeyword = new List<Books>();
            foreach(Books book in BookList){
                if( book.author.ToLower().Contains(Keyletter)){
                BooksWithKeyword.Add(book);} 
            }
             return BooksWithKeyword;
        }
        int NumberOfBooksAfterYear(int Year = 1992)
        {List<Books> BooksWithKeyword = new List<Books>();
            foreach(Books book in BookList){
                if( book.publication_year > Year){
                BooksWithKeyword.Add(book);} 
            }
             return BooksWithKeyword.Count;

        }
        int NumberOfBooksBeforeYear(int Year = 2004)
        {List<Books> BooksWithKeyword = new List<Books>();
            foreach(Books book in BookList){
                if( book.publication_year < Year){
                BooksWithKeyword.Add(book);} 
            }
             return BooksWithKeyword.Count;

        }
        List<string> ISBNAuthorReturn(string authorName)
        {   List<string> ISBNS = new List<string>();
            foreach(Books book in BookList){
                if( book.author == authorName){
                ISBNS.Add(book.isbn);} 
            }
            return ISBNS;
        }
          void ListBooksAlphabeticallyy(bool Ascending = true)
        {
            if(Ascending){

            }
            else if(!Ascending){
                
            }

        }
        List<Books> ListBooksChronologicaly(bool Ascending = true)
        {
            List<Books> Chronologically = new List<Books>();
            if(Ascending){ 
                for (int i = 0; i < 2025; i++){    
                   
                foreach (Books book in BookList){
                    if (book.publication_year == i){
                        Chronologically.Add(book);
                    }
                }  }
                return Chronologically;

            }
            else if(!Ascending){
                for (int i = 2025; i > 0; i--){    
                foreach (Books book in BookList){
                    if (book.publication_year == i){
                        Chronologically.Add(book);
                    }
                } 
                 }
                return Chronologically;
            }
            else{
                Console.WriteLine("error");
                return Chronologically;
            }

        }
      
        void ListBooksGroupedAuthorLastName()
        {
            foreach( Books book in BookList){
                
              
                 for (int i = 0; i < NamesList.Length; i++)
                {
                }

            }

        }
        void ListBooksGroupedAuthorFirstName()
        {
        }

    }
    class Books
    {
        public string title { get; set; }
        public int publication_year { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
    }
}