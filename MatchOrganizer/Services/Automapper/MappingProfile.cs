using AutoMapper;
using Database.Entities;
using Services.DTO;

namespace Services.AutoMapper
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region EntityToDTO
            MapToDTO();
            #endregion

            #region DTOToEntity
            MapToEntity();
            #endregion


            //CreateMap<Source,Destination>();
            // Additional mappings here...
        }
        private void MapToDTO()
        {
            CreateMap<Player, PlayerDTO>();
            CreateMap<PlayerStatistics, PlayerStatisticsDTO>();
            CreateMap<Team, TeamDTO>();
            CreateMap<Match, MatchDTO>();
            CreateMap<Status, StatusDTO>();
        }
        private void MapToEntity()
        {
            CreateMap<PlayerDTO, Player>();
            CreateMap<PlayerStatisticsDTO, PlayerStatistics>();
            CreateMap<MatchDTO, Match>();
            CreateMap<TeamDTO, Team>();
            CreateMap<StatusDTO, Status>();
        }
    }
}
