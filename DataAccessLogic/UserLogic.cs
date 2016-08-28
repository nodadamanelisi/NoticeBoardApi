using IDataAccessLogic;
using Logger;
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
            Login results = null;
            //Not sure if this is the best solution, still need to do figure out how to do this on the config file rather than on the code like this.
            MyConfiguration conf = new MyConfiguration();
            try
            {
                using (var ctx = new NoticeBoardContext())
                {
                    Log4Net.Log(this.ToString());
                    results = ctx.Login.FirstOrDefault(x => x.UserName.Equals(input.UserName)
                     && x.Password.Equals(input.Password));
                }
            }
            catch (Exception ex)
            {
                Log4Net.Log(this.ToString());
            }
            return results;
        }
    }
}
