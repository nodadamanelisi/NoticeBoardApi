using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    public class NoticeBoardContext : DbContext 
    {
        public NoticeBoardContext()
            : base("NoticeBoard")
        {

        }
        public DbSet<Login> Credentials { get; set; }
    }
}
