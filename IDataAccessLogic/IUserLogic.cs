using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccessLogic
{
    public interface IUserLogic
    {
        Login Login(Login input);
    }
}
