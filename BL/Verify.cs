using FameDirecBL;
using FameDirector;
namespace BL
{
    public class Verify
    {
        public static bool VerifyUser(string userName)
        {
            List Direc = new List();
            var result = Direc.GetUser(userName);

            return result.userName != null ? true : false;
        }
    }
}
