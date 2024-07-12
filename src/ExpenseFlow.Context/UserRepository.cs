using ExpenseFlow.Entity;
using BCrypt.Net;
using System.Security.Cryptography;
using System.Text;

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

        public void RegisterUser(string username, string email, string password)
        {
            User user = new User();

            // The username and email should be unique, and we check it on the client side before sending the request
            // But we should also check it on the server side
            
            if (UserExists(username))
            {
                throw new Exception("User already exists");
            }

            if (EmailExists(email))
            {
                throw new Exception("Email already exists");
            }

            // Hash the password before saving it to the database
            const int saltSize = 16;
            //byte[] passwordSalt;

            // I used the RandomNumberGenerator class to generate a random salt. RNGCryptoServiceProvider is obsolete.
            //RandomNumberGenerator rng = RandomNumberGenerator.Create();
            //rng.GetBytes(passwordSalt = new byte[saltSize]);

            string passwordSalt = BCrypt.Net.BCrypt.GenerateSalt(saltSize);
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, passwordSalt);

            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hmacsha512?view=net-8.0
            //byte[] passwordHash;
            //using (var hmac = new HMACSHA512(passwordSalt))
            //{
            //    passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            //}

            user.UserName = username;
            user.Email = email;

            user.PasswordSalt = passwordSalt;
            user.PasswordHash = hashedPassword;

            //try
            //{
            //    user.PasswordSalt = System.Text.Encoding.UTF8.GetString(passwordSalt);
            //}
            //catch (ArgumentException ex)
            //{
            //    throw new Exception("Error converting password salt to string", ex);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("An error occurred: " + ex.Message);
            //}

            //try
            //{
            //    user.PasswordHash = System.Text.Encoding.UTF8.GetString(passwordHash);
            //}
            //catch (ArgumentException ex)
            //{
            //    throw new Exception("Error converting password hash to string", ex);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("An error occurred: " + ex.Message);
            //}

            // Add the user to the database
            p_context.Users.Add(user);
            p_context.SaveChanges();
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
