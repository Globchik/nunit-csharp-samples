using System.Collections.Generic;

public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }
    
    /// <summary>
    /// Gets books by author.
    /// </summary>
    /// <param name="author">Book author.</param>
    /// <returns>Book list.</returns>
    public List<Book> GetBooksByAuthor(string author)
    {
        List<Book> answ = new();
        foreach (Book i in _manager.Books)
            if (i.Author == author)
                answ.Add(i);
        return answ;
    }
    
    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book.</returns>
    public Book? GetBookByTitle(string title)
    {
        foreach (Book i in _manager.Books)
            if (i.Title == title)
                return i;
        return null;
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book.</returns>
    public Book? GetBookByArticul(string articul)
    {
        foreach (Book i in _manager.Books)
            if (i.Articul == articul)
                return i;
        return null;
    }
}