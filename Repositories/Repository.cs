using UniContext;

namespace Repositories;
public class Repository : IRepository
{
    private readonly UniDbContext _uniDbContext;
    public Repository(UniDbContext uniDbContext)
    {
        _uniDbContext = uniDbContext;
    }

    public void h()
    {
        
    }


}

