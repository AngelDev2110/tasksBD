using tasksBD.Models;

namespace tasksBD.Repository
{
	public interface IRepositoryMembers
	{
		Task<List<Member>> GetAll();
		Task<Member?> Get(int id);
		Task<Member> Add(Member member);
		Task Update(int Id, Member member);
		Task Delete(int Id);
	}
}
