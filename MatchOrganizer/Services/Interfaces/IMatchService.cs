using Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMatchService : IServiceTemplate<MatchDTO>
    {
        Task<List<MatchDetailsDTO>> GetAllWithDetails();
        Task<MatchDetailsDTO> GetWithDetails(int matchId);
        Task<MatchDTO> GetByUniqueIdentifiers(int hostTeamId, int guestTeamId, DateTime startTime);
    }
}
