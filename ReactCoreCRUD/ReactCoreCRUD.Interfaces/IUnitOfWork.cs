namespace ReactCoreCRUD.Interfaces
{
    public interface IUnitOfWork
    {
        IUserDetailsRepository UserDetails { get; }
    }
}
