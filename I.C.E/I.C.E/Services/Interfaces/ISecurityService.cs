using I.C.E.Models.Security;
using System.Collections.Generic;

namespace I.C.E.Services.Interfaces
{
    public interface ISecurityService
    {
        //IList<MenuItem> GetAllowedAccessItems();
        IList<MenuItem> GetAllowedAccessItems();
        bool LogIn(string userName, string password);
        void LogOut();
    }
}
