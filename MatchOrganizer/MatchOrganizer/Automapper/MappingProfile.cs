using AutoMapper;
using MatchOrganizer.ViewModels;
using MatchOrganizer.ViewModels.Matches;
using MatchOrganizer.ViewModels.TeamMenagment;
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
            CreateMap<TeamDTO, CreateTeamViewModel>();
            CreateMap<TeamDTO, IndexTeamViewModel>();
            CreateMap<TeamDTO, DetailsTeamViewModel>();


            CreateMap<PlayerDTO, PlayerViewModel>();
            CreateMap<MatchDTO, MatchViewModel>();
            CreateMap<MatchDTO, IndexMatchViewModel>();
            CreateMap<TeamDTO, TeamListItemViewModel>();

        }
        private void MapToDTO()
        {

            CreateMap<CreateTeamViewModel, TeamDTO>();
            CreateMap<DetailsTeamViewModel, TeamDTO>();
            CreateMap<IndexTeamViewModel, TeamDTO>();
            CreateMap<MatchDTO, CreateMatchViewModel>();

            CreateMap<PlayerViewModel, PlayerDTO>();
            CreateMap<MatchViewModel, MatchDTO>();
            CreateMap<CreateMatchViewModel, MatchDTO>();
            CreateMap<IndexMatchViewModel, MatchDTO>();
            CreateMap<TeamListItemViewModel, TeamDTO>();

        }
    }
}
