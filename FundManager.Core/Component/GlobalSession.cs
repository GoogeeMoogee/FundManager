using FundManager.Core.Model;
using Newtonsoft.Json;

namespace FundManager.Core.Component
{
    public static class GlobalSession
    {
        public const string DesktopSessionKey = "DesktopSessionKey";

        public static void StartDesktopSession(UserModel user)
        {
            var session = CacheHelper.Instance;

            if (session.Contains(DesktopSessionKey)) return;

            session.AddWithoutExpiration(DesktopSessionKey, JsonConvert.SerializeObject(user));
        }

        public static void EndDesktopSession()
        {
            var session = CacheHelper.Instance;

            if (session.Contains(DesktopSessionKey))
            {
                session.Delete(DesktopSessionKey);
            }
        }

        public static UserModel GetDesktopCurrentUser()
        {
            var session = CacheHelper.Instance;
            var strModel = session.Get(DesktopSessionKey) as string;
            var userModel = JsonConvert.DeserializeObject<UserModel>(strModel);
            return userModel;
        }
    }
}
