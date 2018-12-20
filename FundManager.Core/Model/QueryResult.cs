namespace FundManager.Core.Model
{
    public class QueryResult<T>
    {
        public bool IsSuccessfult { get; set; }
        public int? RowAffected { get; set; }
        public T Result { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class QueryResult
    {
        public bool IsSuccessfult { get; set; }
        public int? RowAffected { get; set; }
        public string ErrorMessage { get; set; }
    }
}
