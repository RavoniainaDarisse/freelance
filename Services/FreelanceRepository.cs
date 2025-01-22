
using freelance.Data;

namespace freelance.Services
{
    public class FreelanceRepository : IFreelanceRepository
    {
        private readonly MyDbContext dbContext;

        public FreelanceRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task GetEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task GetId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}