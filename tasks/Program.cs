using LINQtoObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("1st task\n");

            //var query = SampleData.Books
            //    .Select(b => new { b.Title, b.Isbn });

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item}\n");
            //}



           // Console.WriteLine("2nd task\n");

           // IEnumerable<Book> books = SampleData.Books
           //     .Where(b => b.Price > 25).Take(3);

           // foreach (Book book in books)
           // {
           //     Console.WriteLine(book);
           // }


           // Console.WriteLine("3rd task");

           // var book_with_publisher = SampleData.Books
           //     .Select(b => new { b.Title, b.Publisher });

           // foreach (var book in book_with_publisher)
           // { Console.WriteLine(book); }


           // Console.WriteLine("4th task");

           // int num = SampleData.Books
           //   .Where(b => b.Price > 20)
           //   .Count();
           // Console.WriteLine($"num of books which cost more than 20 is : {num}");


           // //Console.WriteLine("5th task");

           // var ordered_books = SampleData.Books
           //     .OrderBy(b => b.Subject.Name)
           //     .ThenByDescending(b => b.Price)
           //     .Select(b => new { b.Title, b.Price, b.Subject });         // all of them >> functions >> return ienumerable "when iterate on it get func result one by one "theses func are defered exec >> yield return or return another func >> yield return""

           // //foreach (var book in ordered_books) 
           // //{
           // //    Console.WriteLine(book);
           // //}



           // Console.WriteLine("6th task");

           // var sub_with_related_books = from s in SampleData.Subjects
           //                              join b in SampleData.Books
           //                              on s.Name equals b.Subject.Name
           //                              select new { s.Name, b.Title };

           // foreach (var item in sub_with_related_books)
           // {
           //     Console.WriteLine(item);
           // }

           // Console.WriteLine("6th task 2nd way");

           // var sub_with_related_books2 = SampleData.Books
           // .Select(b => new { b.Subject.Name, b.Title });

           // foreach (var item in sub_with_related_books2)
           // {
           //     Console.WriteLine(item);
           // }


           // Console.WriteLine("6th task 3rd way");

           // IEnumerable<IGrouping<string, Book>> sub_with_related_books3 =
           //     SampleData.Books.GroupBy(b => b.Subject.Name);

           // int i = 1;
           // foreach (IGrouping<string, Book> books_key_group in sub_with_related_books3)
           // {
           //     Console.WriteLine($"\ngroup num {i}");
           //     i++;
           //     Console.Write(books_key_group.Key + " >> ");

           //     foreach (Book book in books_key_group)
           //     {
           //         Console.Write(" " + book.Title + " ");
           //     }
           // }


           // Console.WriteLine("7th task");

           // var books = SampleData.GetBooks().Cast<Book>()
           //     .ToList().Select(b => new { b.Title, b.Price });

           // foreach (var book in books)
           // {
           //     Console.WriteLine(book);
           // }



           // console.writeline("9th task");

           // var grouped_books = sampledata.books          // return ienmumerable<igrouping<anon , book>>
           //     .groupby(b => new { publisher = b.publisher.name, sub = b.subject.name });

           // int i = 1;
           // foreach (var grouped_book in grouped_books)
           // {
           //     console.writeline($"\ngroup num {i}");
           //     i++;
           //     console.write(grouped_book.key);

           //     foreach (var book in grouped_book)
           //     {
           //         console.write(" " + book.title + " ");
           //     }
           // }



           // Console.WriteLine("Bonus task");

           //IEnumerable<Book> books = SampleData.FindBooksSorted("Joe Publishing", sorting_method.Price, sorting_way.DESC);   // couldnt make publisher name enum due to spaces + many switch and if ?????? send type of orderby so >> no all these switches
           
           // foreach(Book book in books) 
           // {
           //     Console.WriteLine(book.Title);
           // }

        }
    }
}
