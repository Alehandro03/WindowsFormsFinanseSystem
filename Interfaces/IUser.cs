namespace WindowsFormsFinanseSystem.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        string Login { get; set; }
        bool CheckPassword(string login, string password);
    }
}
