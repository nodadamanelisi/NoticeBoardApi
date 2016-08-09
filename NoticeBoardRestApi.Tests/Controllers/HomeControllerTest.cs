using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using User;
using NoticeBoardDtos.Input;

namespace NoticeBoardRestApi.Tests.Controllers
{
    [TestClass()]
    public class HomeControllerTest
    {
        UserLogic user;
        Login loginInput;
        [TestInitialize()]
        public void BeforeEach()
        {
            user = new UserLogic();
            loginInput = new Login { UserId = 1, Password = "secret", UserName = "username" };
        }
        [TestMethod]
        public void ShouldLogin()
        {
             var output = user.Login(loginInput);
             Assert.IsNotNull(output);
        }
    }
}
