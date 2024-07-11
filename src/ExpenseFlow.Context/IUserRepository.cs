using ExpenseFlow.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseFlow.Context
{
    public interface IUserRepository : IRepository<User>
    {
        bool UserExists(string userName);
        bool EmailExists(string email);
    }
}
