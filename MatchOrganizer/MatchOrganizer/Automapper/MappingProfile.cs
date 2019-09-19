using AutoMapper;
using MatchOrganizer.ViewModels;
using Services.DTO;

namespace MatchOrganizer.Automapper
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region DTOToViewModel
            MapToViewModel();
            #endregion

            #region ViewModelToD
            MapToDTO();
            #endregion


            //CreateMap<Source,Destination>();
            // Additional mappings here...
        }
        private void MapToViewModel()
        {
            CreateMap<TeamDTO, TeamViewModel>();
            CreateMap<TeamDTO, TeamDetailsViewModel>();
            CreateMap<PlayerDTO, PlayerViewModel>();
        }
        private void MapToDTO()
        {
            CreateMap<TeamDetailsViewModel, TeamDTO>();
            CreateMap<TeamViewModel, TeamDTO>();
            CreateMap<PlayerViewModel, PlayerDTO>();
        }
    }
}
