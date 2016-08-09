using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUserLogic
{
    public interface ILogic
    {
        Login Login(Login input);
    }
}
