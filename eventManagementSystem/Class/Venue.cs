using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem
{
    public class Venue
    {
        public string venueName {  get; set; }
        public string venueDisplayName { get; set; }
        public string venueDescription { get; set; }
        public string venueAddress { get; set; }
        public string venueEmail { get; set; }
        public string venueContactNumber { get; set; }
        public string companyName { get; set; }
        public string companyAddress { get; set; }
        public string companyContactNumber { get; set; }
        public string companyBRN { get; set; }
        public string companyTIN { get; set; }


        public Venue(string VenueName, string VenueDisplayName, string VenueDiscription, string VenueAddress, string venueEmail, string VenueContactNumber,string CompanyName,string CompanyAddress,string CompanyContactNumber,string CompanyBRN, string CompanyTIN)
        {
            this.venueName = VenueName;
            this.venueDisplayName = VenueDisplayName;
            this.venueDescription = VenueDiscription;
            this.venueAddress = VenueAddress;
            this.venueEmail = venueEmail;
            this.venueContactNumber = VenueContactNumber;
            this.companyName = CompanyName;
            this.companyAddress = CompanyAddress;
            this.companyContactNumber = CompanyContactNumber;
            this.companyBRN = CompanyBRN;
            this.companyTIN = CompanyTIN;
        }

    }
}
