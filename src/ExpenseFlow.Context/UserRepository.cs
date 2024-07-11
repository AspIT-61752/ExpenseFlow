using ExpenseFlow.Entity;

namespace ExpenseFlow.Context
{
    public class UserRepository(ExpenseFlowDbContext expenseFlowContext) : Repository<User>(expenseFlowContext), IUserRepository
    {
        public bool EmailExists(string email)
        {
            if (p_context.Users.FirstOrDefault(u => u.Email == email) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserExists(string userName)
        {
            if (p_context.Users.FirstOrDefault(u => u.UserName == userName) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
