using ReactCoreCRUD.Interfaces;

namespace ReactCoreCRUD.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IUserDetailsRepository userRepository)
        {
            UserDetails = userRepository;
        }
        public IUserDetailsRepository UserDetails { get; }
    }
}
