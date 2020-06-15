using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();
            Console.WriteLine($"There are {authors.Count()} total authors");
            Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");

            //================= 1 =================
            Console.WriteLine("1. How many books are collaborations (have more than one author)?");
            var booksCollaborations = authors
                                 .SelectMany(author => author.Books)
                                 .GroupBy(book => book.ID) 
                                 .Where(duplicate => duplicate.Count() > 1)                                 
                                 .ToList();

            Console.WriteLine($"- {booksCollaborations.Count()} books.");

            //================= 2 =================                                   
            Console.WriteLine("2. Which book has the most authors (and how many)?");
            var bookMostAuthors = booksCollaborations
                                                .OrderByDescending(duplicateNo => duplicateNo.Count())
                                                .FirstOrDefault();
            var bookTitle = bookMostAuthors                                            
                                            .FirstOrDefault();

            var collaborationAuthorsNo = bookMostAuthors.Count();     
            
            Console.WriteLine($"- {bookTitle.Title} has {collaborationAuthorsNo} authors.");

            //================= 3 =================
            Console.WriteLine("3. What author wrote most collaborations?");
                                   
            var collaborationList = authors
                                    .SelectMany(book => book.Books)
                                    .Where(book => (booksCollaborations
                                    .Select(a => a.Key))                                                  
                                    .Any(b => b == book.ID))
                                    .ToList();

           var collaborationsNo = authors
                               .Select(author => author.Books
                               .Where(books => collaborationList
                               .Any(book => book.ID == books.ID))
                               .Count())
                               .Max();          
            
            var authorMostCollaborations = authors                
                                   .Where(author => author.Books
                                   .Where(books => collaborationList
                                   .Any(book => book.ID == books.ID))
                                   .Count() == collaborationsNo)
                                   .FirstOrDefault();
                        
            Console.WriteLine($"Author: {authorMostCollaborations.Name} Collaborations: {collaborationsNo}");

            Console.ReadLine();


           

        }
    }
}
