using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Linq;
using System.Linq;
using System.ComponentModel;

namespace LINQtoObject
{
    public enum sorting_method
    {
      Title,
      Price,
      PublicationDate,
      Subject
    }

    public enum sorting_way
    {
       ASC,
       DESC 
    }
    static public class SampleData
    {
        static public Publisher[] Publishers =
        {
      new Publisher {Name="FunBooks"},
      new Publisher {Name="Joe Publishing"},
      new Publisher {Name="I Publisher"}
    };

        static public Author[] Authors =
        {
      new Author {FirstName="Johnny", LastName="Good"},
      new Author {FirstName="Graziella", LastName="Simplegame"},
      new Author {FirstName="Octavio", LastName="Prince"},
      new Author {FirstName="Jeremy", LastName="Legrand"}
        };

        static public Subject[] Subjects =
        {
      new Subject {Name="Software development"},
      new Subject {Name="Novel"},
      new Subject {Name="Science fiction"}
    };

        static public Book[] Books =
        {
      new Book {
        Title="Funny Stories",
        Publisher=Publishers[0],
        Authors=new[]{Authors[0], Authors[1]},
        PageCount=101,
        Price=25.55M,
        PublicationDate=new DateTime(2004, 11, 10),
        Isbn="0-000-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="LINQ rules",
        Publisher=Publishers[1],
        Authors=new[]{Authors[2]},
        PageCount=300,
        Price=12M,
        PublicationDate=new DateTime(2007, 9, 2),
        Isbn="0-111-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="C# on Rails",
        Publisher=Publishers[1],
        Authors=new[]{Authors[2]},
        PageCount=256,
        Price=35.5M,
        PublicationDate=new DateTime(2007, 4, 1),
        Isbn="0-222-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="The Incredibles",
        Publisher=Publishers[1],
        Authors=new[]{Authors[3]},
        PageCount=1205,
        Price=35.5M,
        PublicationDate=new DateTime(2006, 5, 5),
        Isbn="0-333-77777-2",
        Subject=Subjects[2]
      },
      new Book {
        Title="Bonjour mon Amour",
        Publisher=Publishers[0],
        Authors=new[]{Authors[1], Authors[0]},
        PageCount=50,
        Price=29M,
        PublicationDate=new DateTime(1973, 2, 18),
        Isbn="2-444-77777-2",
        Subject=Subjects[1]
      }
    };

        public static ArrayList GetBooks()
        {
            return new ArrayList(Books);
        }



        public static IEnumerable<Book> FindBooksSorted(string publisher_name , sorting_method sorting_method , sorting_way sorting_way)  // can take func deleg instead of sorting method so no much cases
        {
            string[] publisher_names = new string[Publishers.Length];
            
            for(int i = 0; i<Publishers.Length; i++)
            {
                publisher_names[i] = Publishers[i].Name; 
            }

            IEnumerable<Book> books = null;

            if (publisher_names.Contains(publisher_name))
            {

                if (sorting_way == sorting_way.ASC)
                {
                    switch (sorting_method)
                    {
                        case sorting_method.Price:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                              .OrderBy(b => b.Price);
                            break;

                        case sorting_method.PublicationDate:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                            .OrderBy(b => b.PublicationDate);
                            break;

                        case sorting_method.Subject:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                            .OrderBy(b => b.Subject);
                            break;

                        case sorting_method.Title:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                            .OrderBy(b => b.Title);
                            break;

                        default: break;
                    }
                    return books;
                }


                else
                {
                    switch (sorting_method)
                    {
                        case sorting_method.Price:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                              .OrderByDescending(b => b.Price);
                            break;

                        case sorting_method.PublicationDate:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                            .OrderByDescending(b => b.PublicationDate);
                            break;

                        case sorting_method.Subject:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                            .OrderByDescending(b => b.Subject);
                            break;

                        case sorting_method.Title:
                            books = Books.Where(b => b.Publisher.Name == publisher_name)
                            .OrderByDescending(b => b.Title);
                            break;

                        default: break;
                    }
                    return books;
                }
            }

            else
            {
                Console.WriteLine("invalid publisher name");
                return books;
            }
        }
    }
}