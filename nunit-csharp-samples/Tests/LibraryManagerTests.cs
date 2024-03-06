using NUnit.Framework;

namespace nunit_csharp_samples.Tests;

[TestFixture]
public class LibraryManagerTests
{
    [TestCase("testbook", "123444A", "bobby")]
    public void TestAddBook(in string n_title, in string n_arti, in string n_auth)
    {
        LibraryManager manager = new LibraryManager();
        Book book = new Book { Title = n_title, Articul= n_arti, Author= n_auth };
        manager.AddBook(book);
        Assert.That(manager.Books[0].Title == n_title && manager.Books[0].Articul == n_arti && manager.Books[0].Author == n_auth);
    }


    [TestCase("testbook", "123444A", "bobby")]
    public void TestRemoveBook(in string n_title, in string n_arti, in string n_auth)
    {
        LibraryManager manager = new LibraryManager();
        Book book = new Book { Title = n_title, Articul = n_arti, Author = n_auth };
        manager.AddBook(book);
        manager.RemoveBook(book);
        Assert.That(manager.Books.Count == 0);
    }
}