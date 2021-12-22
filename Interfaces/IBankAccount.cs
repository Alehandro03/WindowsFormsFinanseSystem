namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public interface IBankAccount
    {
        string Name { get; set; }

        string UserName { get; set; }

        decimal Balance { get; set; }
    }
}
