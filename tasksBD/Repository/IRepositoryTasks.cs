using tasksBD.Models;

namespace tasksBD.Repository
{
    public interface IRepositoryTasks
    {
        Task<List<MemberTask>> GetAll();
        Task<MemberTask?> Get(int id);
        Task<MemberTask> Add(MemberTask memberTask);
        Task Update(int Id, MemberTask memberTask);
        Task changeResponsible(int id, MemberTask member);
        Task Delete(int Id);
    }
}
