using NUnit.Framework;

namespace nunit_csharp_samples.Tests;

public class LibraryStatisticsAnalyzerTests
{
    [TestCase("testbook", "123444A", "bobby")]
    public void TestGetBookByTitle(in string n_title, in string n_arti, in string n_auth)
    {
        LibraryManager manager = new LibraryManager();
        Book book = new Book { Title = n_title, Articul = n_arti, Author = n_auth };
        manager.AddBook(book);
        LibraryStatisticsAnalyzer statisticsAnalyzer = new(manager);
        Assert.That(statisticsAnalyzer.GetBookByTitle(n_title) == book);
    }

    [TestCase("testbook", "123444A", "bobby")]
    public void TestGetBookByArticle(in string n_title, in string n_arti, in string n_auth)
    {
        LibraryManager manager = new LibraryManager();
        Book book = new Book { Title = n_title, Articul = n_arti, Author = n_auth };
        manager.AddBook(book);
        LibraryStatisticsAnalyzer statisticsAnalyzer = new(manager);
        Assert.That(statisticsAnalyzer.GetBookByTitle(n_title) == book);
    }

    [Test]
    public void TestGetBooksByAuthor()
    {
        LibraryManager manager = new LibraryManager();
        int book_a = 4, book_b = 3;
        for(int i = 0; i < book_a; i++)
        {
            Book book = new Book { Title = "testbook" + i.ToString(), Articul = "123444A", Author = "bobby" };
            manager.AddBook(book);
        }
        for (int i = 0; i < book_b; i++)
        {
            Book book = new Book { Title = "book" + i.ToString(), Articul = "14sdf321", Author = "noka" };
            manager.AddBook(book);
        }

        LibraryStatisticsAnalyzer statisticsAnalyzer = new(manager);
        Assert.That(statisticsAnalyzer.GetBooksByAuthor("bobby").Count == book_a);
    }
}