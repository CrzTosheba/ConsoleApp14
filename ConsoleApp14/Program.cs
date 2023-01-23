using ConsoleApp14;
using AppContext = ConsoleApp14.AppContext;

internal class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppContext())
        {
            var user1 = new User { Name = "Arthur", Email = "asd@asd.ru" };
            var user2 = new User { Name = "klim", Email = "aaasdsd@asd.ru" };
            var user3 = new User { Name = "Toto", Email = "dsfd@sdf.com" };
            var book1 = new Book { Title = "Instr", Year = "1985" };
            var book2 = new Book { Title = "IDDQD", Year = "1993" };
            var book3 = new Book { Title = "HESOYAM", Year = "2004" };

            db.Users.Add(user1);
            db.Users.Add(user2);
            db.Users.Add(user3);
            db.Books.Add(book1);
            db.Books.Add(book2);
            db.Books.Add(book3);
            db.SaveChanges();
        }
    }
}