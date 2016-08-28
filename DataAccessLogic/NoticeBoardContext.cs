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
            : base("Data Source=MANELISI\\MANELISI;Integrated Security=True;Pooling=False")
        {

        }
        public DbSet<Login> Login { get; set; }
    }
}
