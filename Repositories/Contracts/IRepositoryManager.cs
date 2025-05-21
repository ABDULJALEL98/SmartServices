namespace SmartServices.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }

        void Save();
    }
}
