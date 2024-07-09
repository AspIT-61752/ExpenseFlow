namespace ExpenseFlow.Entity;

public class User
{
    #region Fields

    private int userId;
    private string userName;
    private string passwordHash;
    private string passwordSalt;
    private string email;

    #endregion

    #region Constructors

    public User()
    {
    }

    public User(int userId, string userName, string passwordHash, string passwordSalt, string email)
    {
        this.userId = userId;
        this.userName = userName;
        this.passwordHash = passwordHash;
        this.passwordSalt = passwordSalt;
        this.email = email;
    }

    #endregion

    #region Properties

    public int UserId { get => userId; set => userId = value; }
    public string UserName { get => userName; set => userName = value; }
    public string PasswordHash { get => passwordHash; set => passwordHash = value; }
    public string PasswordSalt { get => passwordSalt; set => passwordSalt = value; }
    public string Email { get => email; set => email = value; }

    #endregion
}
