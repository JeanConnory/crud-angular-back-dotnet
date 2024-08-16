namespace crud_dotnet.Models;

public class PaginatedList<T>
{
    public List<T> Items { get; set; }

    public int PageIndex { get; set; }

    public int TotalPages { get; set; }

    public int TotalElements { get; set; }

    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;

    public PaginatedList(List<T> items, int pageIndex, int totalPages, int totalElements)
    {
        Items = items;
        PageIndex = pageIndex;
        TotalPages = totalPages;
        TotalElements = totalElements;
    }
}
