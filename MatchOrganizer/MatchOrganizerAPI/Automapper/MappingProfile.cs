using AutoMapper;
using Database.Entities;
using MatchOrganizerAPI.Model;
using Services.DTO;

namespace MatchOrganizerAPI.Automapper

{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region DTOToModel
            MapToModel();
            #endregion

            #region ModelToDTO
            MapToDTO();
            #endregion


            //CreateMap<Source,Destination>();
            // Additional mappings here...
        }
        private void MapToModel()
        {
            CreateMap<TeamDTO, TeamModel>();
            CreateMap<PlayerDTO, PlayerModel>();
            CreateMap<MatchDTO, MatchModel>();

        }
        private void MapToDTO()
        {
            CreateMap<TeamModel, TeamDTO>();
            CreateMap<PlayerModel, PlayerDTO>();
            CreateMap<MatchModel, MatchDTO>();
        }
    }
}
