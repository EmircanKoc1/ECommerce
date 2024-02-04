namespace CoreLayer.Model
{
    public class ApiResponseModel<T>
    {
        public bool IsFailed { get; set; }
        public Dictionary<string, string[]> Errors { get; set; }
        public T Result { get; set; }

    }
}
