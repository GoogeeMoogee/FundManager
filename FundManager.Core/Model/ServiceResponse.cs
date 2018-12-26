namespace FundManager.Core.Model
{
    public class ServiceResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }

    public class ServiceResponse
    {
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
    }
}
