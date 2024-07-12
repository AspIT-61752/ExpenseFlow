using ExpenseFlow.Context;
using ExpenseFlow.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserRepository repo) : Controller
    {
        private readonly IUserRepository repo = repo;

        [HttpPost]
        public void AddNewUser([FromQuery] User user)
        {
            repo.Add(user);
        }

        [HttpPut]
        public void UpdateUser([FromQuery] User user)
        {
            repo.Update(user);
        }

        [HttpDelete]
        public void DeleteUser([FromQuery] User user)
        {
            repo.Delete(user);
        }

        [HttpDelete]
        [Route(nameof(DeleteUserBy))]
        public void DeleteUserBy([FromQuery] int id)
        {
            repo.DeleteBy(id);
        }

        [HttpGet]
        [Route(nameof(GetAllUsers))]
        public IEnumerable<User> GetAllUsers()
        {
            return repo.GetAll();
        }

        [HttpGet]
        [Route(nameof(GetUserBy))]
        public User GetUserBy([FromQuery] int id)
        {
            return repo.GetBy(id);
        }

        [HttpGet]
        [Route(nameof(UserExists))]
        public bool UserExists([FromQuery] string userName)
        {
            return repo.UserExists(userName);
        }

        [HttpGet]
        [Route(nameof(EmailExists))]
        public bool EmailExists([FromQuery] string email)
        {
            return repo.EmailExists(email);
        }

        [HttpPost]
        [Route(nameof(RegisterUser))]
        public void RegisterUser([FromQuery] string username, [FromQuery] string email, [FromQuery] string password)
        {
            repo.RegisterUser(username, email, password);
        }
    }
}
