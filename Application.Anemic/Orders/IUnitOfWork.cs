namespace Application.Anemic.Orders
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken token);
    }
}
