namespace SmartServices.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
        IServiceRepository Service { get; }

        void Save();
    }
}
