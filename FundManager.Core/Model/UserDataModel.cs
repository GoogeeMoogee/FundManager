namespace FundManager.Core.Model
{
    public class SecretDataModel : UserModel
    {
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
