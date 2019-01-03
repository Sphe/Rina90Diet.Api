using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rina90Diet.Api.Web.Models
{
    [DataContract]
    public partial class CustomerCreateOrUpdate
    {
        public CustomerCreateOrUpdate()
        {           
        }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId")]
        public string CustomerId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [DataMember(Name = "nationality")]
        public string Nationality { get; set; }

        [DataMember(Name = "picture")]
        public string Picture { get; set; }

        [DataMember(Name = "addressLine1")]
        public string AddressLine1 { get; set; }

        [DataMember(Name = "addressLine2")]
        public string AddressLine2 { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "zipCode")]
        public string ZipCode { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "telegramUser")]
        public string TelegramUser { get; set; }        

    }
}
