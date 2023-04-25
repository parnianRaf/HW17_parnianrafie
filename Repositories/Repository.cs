using AppCore.Entities;
using UniContext;

namespace Repositories;
public class Repository : IRepository
{
    private readonly UniDbContext _uniDbContext;
    public Repository(UniDbContext uniDbContext)
    {
        _uniDbContext = uniDbContext;
    }

    public List<Teacher> h()
    {
        List<Teacher> students=_uniDbContext.Teacher.ToList();
        return students;
    }


}

