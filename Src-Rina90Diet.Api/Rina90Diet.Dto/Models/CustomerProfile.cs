using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Rina90Diet.Dto;

namespace Rina90Diet.Api.Web.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CustomerProfile
    {
        public CustomerProfile()
        { }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId")]
        public string CustomerId { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title")]
        public string Title { get; set; }

        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        [DataMember(Name="email")]
        public string Email { get; set; }
        
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

        [DataMember(Name = "kycStatus")]
        public string KycStatus { get; set; }

        [DataMember(Name="active")]
        public bool? Active { get; set; }

        [DataMember(Name = "documents")]
        public List<AttachedDocumentDto> Documents { get; set; }


    }
}
