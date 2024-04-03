using System.Net;

namespace CoreLayer.Model
{
    public record ApiResponseModel<T>
    {
        public bool IsFailed { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public Dictionary<string, string[]> Errors { get; set; } = new();
        public T Data { get; set; }

        public int PageNumber {  get; set; }   
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
    }
}
