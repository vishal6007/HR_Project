﻿using AutoMapper;
using Domain.DTO.DTOModels;
using System.Collections.Generic;
using Domain.DTO.DTOModels.SetupDTO;
using BaseOfTalents.Domain.Entities;
using BaseOfTalents.Domain.Entities.Enum.Setup;
using BaseOfTalents.WebUI.Models;
using Domain.Entities;
using DAL.DTO;
using Domain.Entities.Enum.Setup;
using DAL.DTO.SetupDTO;

namespace WebApi
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<CandidateSocial, CandidateSocialDTO>();
                x.CreateMap<CandidateSocialDTO, CandidateSocial>();

                x.CreateMap<Comment, CommentDTO>();
                x.CreateMap<CommentDTO, Comment>();


                x.CreateMap<Photo, PhotoDTO>();
                x.CreateMap<PhotoDTO, Photo>();

                x.CreateMap<Country, CountryDTO>();
                x.CreateMap<CountryDTO, Country>();

                x.CreateMap<Department, DepartmentDTO>();
                x.CreateMap<DepartmentDTO, Department>();

                x.CreateMap<DepartmentGroup, DepartmentGroupDTO>();
                x.CreateMap<DepartmentGroupDTO, DepartmentGroup>();

                x.CreateMap<EventType, EventTypeDTO>();
                x.CreateMap<EventTypeDTO, EventType>();

                x.CreateMap<Event, EventDTO>();
                x.CreateMap<EventDTO, Event>();

                x.CreateMap<Industry, IndustryDTO>();
                x.CreateMap<IndustryDTO, Industry>();

                x.CreateMap<Language, LanguageDTO>();
                x.CreateMap<LanguageDTO, Language>();

                x.CreateMap<PhoneNumber, PhoneNumberDTO>();
                x.CreateMap<PhoneNumberDTO, PhoneNumber>();

                x.CreateMap<Level, LevelDTO>();
                x.CreateMap<LevelDTO, Level>();

                x.CreateMap<City, CityDTO>();
                x.CreateMap<CityDTO, City>();

                x.CreateMap<Skill, SkillDTO>();
                x.CreateMap<SkillDTO, Skill>();

                x.CreateMap<SocialNetwork, SocialNetworkDTO>();
                x.CreateMap<SocialNetworkDTO, SocialNetwork>();

                x.CreateMap<Stage, StageDTO>();
                x.CreateMap<StageDTO, Stage>();

                x.CreateMap<Tag, TagDTO>();
                x.CreateMap<TagDTO, Tag>();

                x.CreateMap<File, FileDTO>();
                x.CreateMap<FileDTO, File>();

                x.CreateMap<Note, NoteDTO>();
                x.CreateMap<NoteDTO, Note>();

                x.CreateMap<Currency, CurrencyDTO>();
                x.CreateMap<CurrencyDTO, Currency>();

                x.CreateMap<CandidateSource, CandidateSourceDTO>();
                x.CreateMap<CandidateSourceDTO, CandidateSource>();

                x.CreateMap<LanguageSkill, LanguageSkillDTO>();
                x.CreateMap<LanguageSkillDTO, LanguageSkill>();

                x.CreateMap<VacancyStage, VacancyStageDTO>();
                x.CreateMap<VacancyStageDTO, VacancyStage>();

                x.CreateMap<VacancyStageInfo, VacancyStageInfoDTO>();
                x.CreateMap<VacancyStageInfoDTO, VacancyStageInfo>();

                x.CreateMap<Currency, int>()
                     .ConstructUsing(source => (source.SourceValue as Currency).Id);

                x.CreateMap<Vacancy, int>()
                    .ConstructUsing(source => (source.SourceValue as Vacancy).Id);

                x.CreateMap<Skill, int>()
                     .ConstructUsing(source => (source.SourceValue as Skill).Id);

                x.CreateMap<Permission, int>()
                    .ConstructUsing(source => (source.SourceValue as Permission).Id);

                x.CreateMap<Role, int>()
                        .ConstructUsing(source => (source.SourceValue as Role).Id);

                x.CreateMap<Tag, int>()
                     .ConstructUsing(source => (source.SourceValue as Tag).Id);

                x.CreateMap<Level, int>()
                     .ConstructUsing(source => (source.SourceValue as Level).Id);

                x.CreateMap<Department, int>()
                    .ConstructUsing(source => (source.SourceValue as Department).Id);

                x.CreateMap<City, int>()
                    .ConstructUsing(source => (source.SourceValue as City).Id);

                x.CreateMap<Role, RoleDTO>()
                        .ForMember(dest => dest.PermissionIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Permission>, IEnumerable<int>>(src.Permissions)));

                x.CreateMap<Permission, PermissionDTO>()
                        .ForMember(dest => dest.RoleIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Role>, IEnumerable<int>>(src.Roles)));

                x.CreateMap<User, UserDTO>()
                   .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => Mapper.Map<PhotoDTO>(src.Photo)))
                   .ForMember(dest => dest.PhoneNumbers, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<PhoneNumberDTO>>(src.PhoneNumbers)));

                x.CreateMap<Candidate, CandidateDTO>()
                    .ForMember(dest => dest.VacanciesProgress, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<VacancyStageInfo>, IEnumerable<VacancyStageInfoDTO>>(src.VacanciesProgress)))
                    .ForMember(dest => dest.SocialNetworks, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<CandidateSocial>, IEnumerable<CandidateSocialDTO>>(src.SocialNetworks)))
                    .ForMember(dest => dest.LanguageSkills, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<LanguageSkill>, IEnumerable<LanguageSkillDTO>>(src.LanguageSkills)))
                    .ForMember(dest => dest.TagIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Tag>, IEnumerable<int>>(src.Tags)))
                    .ForMember(dest => dest.SkillIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Skill>, IEnumerable<int>>(src.Skills)))
                    .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDTO>>(src.Comments)))
                    .ForMember(dest => dest.Events, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Event>, IEnumerable<EventDTO>>(src.Events)))
                    .ForMember(dest => dest.RelocationPlaces, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<RelocationPlace>, IEnumerable<RelocationPlaceDTO>>(src.RelocationPlaces)))
                    .ForMember(dest => dest.Files, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<File>, IEnumerable<FileDTO>>(src.Files)));

                x.CreateMap<Vacancy, VacancyDTO>()
                    .ForMember(dest => dest.CandidatesProgress, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<VacancyStageInfo>, IEnumerable<VacancyStageInfoDTO>>(src.CandidatesProgress)))
                    .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDTO>>(src.Comments)))
                    .ForMember(dest => dest.LevelIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Level>, IEnumerable<int>>(src.Levels)))
                    .ForMember(dest => dest.CityIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<City>, IEnumerable<int>>(src.Cities)))
                    .ForMember(dest => dest.TagIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Tag>, IEnumerable<int>>(src.Tags)))
                    .ForMember(dest => dest.RequiredSkillIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Skill>, IEnumerable<int>>(src.RequiredSkills)))
                    .ForMember(dest => dest.ChildVacanciesIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<Vacancy>, IEnumerable<int>>(src.ChildVacancies)))
                    .ForMember(dest => dest.Files, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<File>, IEnumerable<FileDTO>>(src.Files)));

                x.CreateMap<RelocationPlace, RelocationPlaceDTO>()
                   .ForMember(dest => dest.LocationIds, opt => opt.MapFrom(src => Mapper.Map<IEnumerable<City>, IEnumerable<int>>(src.Cities)));

                x.CreateMap<VacancyDTO, VacancySearchModel>()
                   .ForMember(dest => dest.State, opt => opt.MapFrom(src => (int)src.State));
            });
        }
    }
}
