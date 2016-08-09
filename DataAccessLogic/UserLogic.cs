using IDataAccessLogic;
using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    public class UserLogic : IUserLogic
    {
        public Login Login(Login input)
        {

            using (var ctx = new NoticeBoardContext())
            {
                var stud = new Login();
                var output = ctx.Credentials.FirstOrDefault(x => x.UserName.Equals(input.UserName)
                    && x.Password.Equals(input.Password));
                return output;
            }
        }
    }
}
