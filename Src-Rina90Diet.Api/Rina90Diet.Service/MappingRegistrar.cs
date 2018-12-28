using AutoMapper;
using Rina90Diet.Api.Web.Models;
using System;
using Newtonsoft.Json;
using Rina90Diet.Data.FullDomain;
using Rina90Diet.Dto;
using Rina90Diet.Service.Json;
using Rina90Diet.Model.FullDomain;
using System.Reflection;

namespace Rina90Diet.Service
{
    public class MappingRegistrar
    {
        public static MapperConfiguration CreateMapperConfig()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
            };

            settings.Converters.Insert(0, new PrimitiveJsonConverter());

            var config = new MapperConfiguration(
                cfg => {

                    cfg.CreateMap<Genericattribute, GenericAttributeDto>();

                    //!!!!!! People

                    cfg.CreateMap<CustomerCreateOrUpdate, People>()
                        .ForMember(opt => opt.Email, x => x.MapFrom(x2 => x2.Email))
                        .ForMember(opt => opt.Firstname, x => x.MapFrom(x2 => x2.FirstName))
                        .ForMember(opt => opt.Title, x => x.MapFrom(x2 => x2.Title))
                        .ForMember(opt => opt.Middlename, x => x.MapFrom(x2 => x2.MiddleName))
                        .ForMember(opt => opt.Lastname, x => x.MapFrom(x2 => x2.LastName))

                        .ForMember(opt => opt.Dateofbirth, x => x.MapFrom(x2 => x2.DateOfBirth))
                        .ForMember(opt => opt.Nationality, x => x.MapFrom(x2 => x2.Nationality))
                        .ForMember(opt => opt.Addressline1, x => x.MapFrom(x2 => x2.AddressLine1))
                        .ForMember(opt => opt.Addressline2, x => x.MapFrom(x2 => x2.AddressLine2))
                        .ForMember(opt => opt.City, x => x.MapFrom(x2 => x2.City))
                        .ForMember(opt => opt.Zipcode, x => x.MapFrom(x2 => x2.ZipCode))
                        .ForMember(opt => opt.Country, x => x.MapFrom(x2 => x2.Country))
                        .ForMember(opt => opt.Phonenumber, x => x.MapFrom(x2 => x2.PhoneNumber))
                        .ForMember(opt => opt.Telegramuser, x => x.MapFrom(x2 => x2.TelegramUser));

                    cfg.CreateMap<People, CustomerCreateOrUpdate>()
                        .ForMember(opt => opt.Email, x => x.MapFrom(x2 => x2.Email))
                        .ForMember(opt => opt.FirstName, x => x.MapFrom(x2 => x2.Firstname))
                        .ForMember(opt => opt.Title, x => x.MapFrom(x2 => x2.Title))
                        .ForMember(opt => opt.MiddleName, x => x.MapFrom(x2 => x2.Middlename))
                        .ForMember(opt => opt.LastName, x => x.MapFrom(x2 => x2.Lastname))

                        .ForMember(opt => opt.DateOfBirth, x => x.MapFrom(x2 => x2.Dateofbirth))
                        .ForMember(opt => opt.Nationality, x => x.MapFrom(x2 => x2.Nationality))
                        .ForMember(opt => opt.AddressLine1, x => x.MapFrom(x2 => x2.Addressline1))
                        .ForMember(opt => opt.AddressLine2, x => x.MapFrom(x2 => x2.Addressline2))
                        .ForMember(opt => opt.City, x => x.MapFrom(x2 => x2.City))
                        .ForMember(opt => opt.ZipCode, x => x.MapFrom(x2 => x2.Zipcode))
                        .ForMember(opt => opt.Country, x => x.MapFrom(x2 => x2.Country))
                        .ForMember(opt => opt.PhoneNumber, x => x.MapFrom(x2 => x2.Phonenumber))
                        .ForMember(opt => opt.TelegramUser, x => x.MapFrom(x2 => x2.Telegramuser));

                    //!!!!!! User
                    cfg.CreateMap<User, CustomerCreateOrUpdate>()
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.Userid))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email));

                    cfg.CreateMap<CustomerCreateOrUpdate, User>()
                        .ForMember(d => d.Userid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.Username, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Password, opt => opt.MapFrom(f => string.Empty));

                    cfg.CreateMap<User, CustomerProfile>()
                    .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.Userid))
                    .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email))
                    .ForMember(d => d.FirstName, opt => opt.MapFrom(f => f.People != null ? f.People.Firstname : null))
                    .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.People != null ? f.People.Middlename : null))
                    .ForMember(d => d.Title, opt => opt.MapFrom(f => f.People != null ? f.People.Title : null))
                    .ForMember(d => d.LastName, opt => opt.MapFrom(f => f.People != null ? f.People.Lastname : null))
                    .ForMember(d => d.Nationality, opt => opt.MapFrom(f => f.People != null ? f.People.Nationality : null))

                    .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.People != null ? f.People.Middlename : null))
                    .ForMember(d => d.AddressLine1, opt => opt.MapFrom(f => f.People != null ? f.People.Addressline1 : null))
                    .ForMember(d => d.AddressLine2, opt => opt.MapFrom(f => f.People != null ? f.People.Addressline2 : null))
                    .ForMember(d => d.City, opt => opt.MapFrom(f => f.People != null ? f.People.City : null))
                    .ForMember(d => d.Country, opt => opt.MapFrom(f => f.People != null ? f.People.Country : null))
                    .ForMember(d => d.DateOfBirth, opt => opt.MapFrom(f => f.People != null ? f.People.Dateofbirth : null))
                    .ForMember(d => d.ZipCode, opt => opt.MapFrom(f => f.People != null ? f.People.Zipcode : null))
                    .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(f => f.People != null ? f.People.Phonenumber : null))
                    .ForMember(d => d.TelegramUser, opt => opt.MapFrom(f => f.People != null ? f.People.Telegramuser : null))

                    .ForMember(d => d.KycStatus, opt => opt.MapFrom(f => f.Userverificationstatus != null ? f.Userverificationstatus.Name : null))
                    ;

                    cfg.CreateMap<CustomerCreateOrUpdate, User>()
                        .ForMember(d => d.Userid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.Username, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Password, opt => opt.MapFrom(f => string.Empty));

                    //!!!!!! CustomerProfile 
                    cfg.CreateMap<CustomerProfile, CustomerCreateOrUpdate>()
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.CustomerId))
                        .ForMember(d => d.FirstName, opt => opt.MapFrom(f => f.FirstName))
                        .ForMember(d => d.LastName, opt => opt.MapFrom(f => f.LastName))
                        .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.MiddleName))
                        .ForMember(d => d.Nationality, opt => opt.MapFrom(f => f.Nationality))
                        .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(f => f.PhoneNumber))
                        .ForMember(d => d.Picture, opt => opt.MapFrom(f => f.Picture))
                        .ForMember(d => d.TelegramUser, opt => opt.MapFrom(f => f.TelegramUser))
                        .ForMember(d => d.ZipCode, opt => opt.MapFrom(f => f.ZipCode))
                        .ForMember(d => d.Country, opt => opt.MapFrom(f => f.Country))
                        .ForMember(d => d.AddressLine1, opt => opt.MapFrom(f => f.AddressLine1))
                        .ForMember(d => d.AddressLine2, opt => opt.MapFrom(f => f.AddressLine2))
                        .ForMember(d => d.City, opt => opt.MapFrom(f => f.City))
                        .ForMember(d => d.Title, opt => opt.MapFrom(f => f.Title))
                        .ForMember(d => d.DateOfBirth, opt => opt.MapFrom(f => f.DateOfBirth))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email));

                    cfg.CreateMap<CustomerCreateOrUpdate, CustomerProfile>()
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.FirstName, opt => opt.MapFrom(f => f.FirstName))
                        .ForMember(d => d.LastName, opt => opt.MapFrom(f => f.LastName))
                        .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.MiddleName))
                        .ForMember(d => d.Nationality, opt => opt.MapFrom(f => f.Nationality))
                        .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(f => f.PhoneNumber))
                        .ForMember(d => d.Picture, opt => opt.MapFrom(f => f.Picture))
                        .ForMember(d => d.TelegramUser, opt => opt.MapFrom(f => f.TelegramUser))
                        .ForMember(d => d.ZipCode, opt => opt.MapFrom(f => f.ZipCode))
                        .ForMember(d => d.Country, opt => opt.MapFrom(f => f.Country))
                        .ForMember(d => d.AddressLine1, opt => opt.MapFrom(f => f.AddressLine1))
                        .ForMember(d => d.AddressLine2, opt => opt.MapFrom(f => f.AddressLine2))
                        .ForMember(d => d.City, opt => opt.MapFrom(f => f.City))
                        .ForMember(d => d.Title, opt => opt.MapFrom(f => f.Title))
                        .ForMember(d => d.DateOfBirth, opt => opt.MapFrom(f => f.DateOfBirth))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email));
                        

                    cfg.CreateMap<CultureDto, Culture>();

                    cfg.CreateMap<Culture, CultureDto>();

                    //

                    cfg.CreateMap<PageDto, Page>();

                    cfg.CreateMap<Page, PageDto>();

                    //

                    cfg.CreateMap<ArticleDto, Article>();

                    cfg.CreateMap<Article, ArticleDto>();

                    //

                    cfg.CreateMap<ContentblockDto, Contentblock>();

                    cfg.CreateMap<Contentblock, ContentblockDto>();

                    //

                    cfg.CreateMap<UserGenericAttributeDto, Usergenericattributemap>();

                    cfg.CreateMap<Usergenericattributemap, UserGenericAttributeDto>();

                    cfg.CreateMap<UserVerificationStatusDto, Userverificationstatus>();

                    cfg.CreateMap<Userverificationstatus, UserVerificationStatusDto>();

                    cfg.CreateMap<UserBlockchainAdressDto, Userblockchainaddress>();

                    cfg.CreateMap<Userblockchainaddress, UserBlockchainAdressDto>();

                    //cfg.CreateMap<ContentBlockImageMapDto, Contentblockimagemap>();

                    //cfg.CreateMap<Contentblockimagemap, ContentBlockImageMapDto>();

                });

            return config;
        }

    }
}
