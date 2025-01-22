namespace freelance.Services
{
    public interface IFreelanceRepository
    {
        Task GetId(Guid id);
        Task GetEmail(string email);
    }
}