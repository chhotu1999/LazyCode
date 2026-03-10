namespace MeroPasal.Model.Shared;
 public class MvParamReqOption<T>
{
    public string? SearchText { get; set; }
    public string? Operator { get; set; }
    public required int Offset { get; set; }
    public required int PageSize { get; set; }
    public string? SortBy { get; set; }
    public string? SortOrder { get; set; }
    public required T Filter { get; set; }
    /*
         Filter Eg: 
            "Filter": {
                        "CategoryIdList": [0],
                        "UserId": 1
                      },
     */
}

public class MvGridConfig<T>
{
    public required List<T> Data { get; set; }
    public required int TotalRows { get; set; }
}

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
    public object? Errors { get; set; }
}

