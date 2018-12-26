using System.Collections.Generic;

namespace FundManager.Desktop.Model
{
    public class ValidationModel
    {
        public bool IsValid { get; set; }
        public IList<string> ErrorMessages { get; set; }

        public ValidationModel()
        {
            ErrorMessages = new List<string>();
        }
    }
}
