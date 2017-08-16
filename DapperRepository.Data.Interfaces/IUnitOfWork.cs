namespace DapperRepository.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IContext Context { get; }
    }
}
