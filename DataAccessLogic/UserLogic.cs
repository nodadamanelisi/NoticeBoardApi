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
            //Not sure if this is the best solution, still need to do figure out how to do this on the config file rather than on the code like this.
            MyConfiguration conf = new MyConfiguration();

            using (var ctx = new NoticeBoardContext())
            {
                var output = ctx.Credentials.FirstOrDefault(x => x.UserName.Equals(input.UserName)
                    && x.Password.Equals(input.Password));
                return output;
            }
        }
    }
}
