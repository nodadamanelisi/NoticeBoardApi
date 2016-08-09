using ExtensionMethods;
using IUserLogic;
using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class UserLogic : ILogic
    {
        public Login Login(Login input)
        {
               return (!Validations.IsAnyNullOrEmpty(input)) ? 
                   (new DataAccessLogic.UserLogic().Login(input)):
                   null;
        }
    }
}
