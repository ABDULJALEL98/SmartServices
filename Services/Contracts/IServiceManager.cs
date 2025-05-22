namespace SmartServices.Services.Contracts
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IServiceService ServiceService { get; }


    }
}
