using Microsoft.EntityFrameworkCore;
using tasksBD.Models;

namespace tasksBD.Repository
{
    public class RepositoryTasks : IRepositoryTasks
    {
        private readonly TasksManagement _context;
        public RepositoryTasks(TasksManagement context)
        {
            _context = context;
        }
        public async Task<MemberTask> Add(MemberTask memberTask)
        {
            await _context.Tasks.AddAsync(memberTask);
            await _context.SaveChangesAsync();
            return memberTask;
        }
        public async Task Delete(int id)
        {
            var memberTask = await _context.Tasks.FindAsync(id);
            if (memberTask != null)
            {
                _context.Tasks.Remove(memberTask);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<MemberTask?> Get(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }
        public async Task<List<MemberTask>> GetAll()
        {
            return await _context.Tasks.ToListAsync();
        }
        public async Task Update(int id, MemberTask memberTask)
        {
            var currentTask = await _context.Tasks.FindAsync(id);
            if (currentTask != null)
            {
                currentTask.Title = memberTask.Title;
                currentTask.Description = memberTask.Description;
                currentTask.TaskState = memberTask.TaskState;
                await _context.SaveChangesAsync();
            }
        }
        public async Task changeResponsible(int id, MemberTask memberTask)
        {
            var currentTask = await _context.Tasks.FindAsync(id);
            if (currentTask != null)
            {
                currentTask.MemberId = memberTask.MemberId;
            }
        }
    }
}
