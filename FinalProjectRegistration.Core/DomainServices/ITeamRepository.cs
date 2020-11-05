using System.Collections.Generic;
using FinalProjectRegistration.Core.Entity;

namespace FinalProjectRegistration.Core.DomainServices
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetAll(); 
        Team GetById(int id);
        void Add(Team t);
        void Update(Team t);
        void Remove(Team t);
    }
}