using Microsoft.EntityFrameworkCore;
using tasksBD.Models;

namespace tasksBD.Repository
{
	public class RepositoryMembers : IRepositoryMembers
	{
		private readonly TasksManagement _context;
		public RepositoryMembers(TasksManagement context)
		{
			_context = context;
		}
		public async Task<Member> Add(Member member)
		{
			await _context.Members.AddAsync(member);
			await _context.SaveChangesAsync();
			return member;
		}
		public async Task Delete(int id)
		{
			var member = await _context.Members.FindAsync(id);
			if (member != null)
			{
				_context.Members.Remove(member);
				await _context.SaveChangesAsync();
			}
		}
		public async Task<Member?> Get(int id)
		{
			return await _context.Members.FindAsync(id);
		}
		public async Task<List<Member>> GetAll()
		{
			return await _context.Members.ToListAsync();
		}
		public async Task Update(int id, Member member)
		{
			var currentMember = await _context.Members.FindAsync(id);
			if (currentMember != null)
			{
				currentMember.Name = member.Name;
				currentMember.Email = member.Email;
				await _context.SaveChangesAsync();
			}
		}
	}
}
