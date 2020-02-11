using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public interface IIdeaRepository
    {
        Task<Idea> AddIdea(Idea idea);
        Task<List<Idea>> GetIdeas();
    }
}
