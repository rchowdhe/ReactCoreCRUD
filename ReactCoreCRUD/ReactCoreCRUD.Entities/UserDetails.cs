using System;
using Microsoft.AspNetCore.Http;
using Dapper.Contrib.Extensions;

namespace ReactCoreCRUD.Entities
{
    public class UserDetails
    {
        private int _id;
        [Computed]
        public int id { get; set; }

        [Computed]
        public int UserDetailsId
        {
            get { return _id; }
            set
            {
                _id = value;
                id = value;
            }
        }
        public int LocationId { get; set; }
        public int EmployeeType { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Section { get; set; }
        public string Nationality { get; set; }
        public string Designation { get; set; }
        public string EmiratesID { get; set; }
        public DateTime EmiratesIDExpiryDate { get; set; }
        public string EmiratesIDFilePath { get; set; }
        public string PassportNo { get; set; }
        public DateTime PassportExpiryDate { get; set; }
        public string PassportFilePath { get; set; }
        public string DrivingLicence { get; set; }
        public DateTime DrivingLicenceExpiryDate { get; set; }
        public string DrivingLicenceFilePath { get; set; }
        [Computed]
        public IFormFile EmiratesIDFile { get; set; }
        [Computed]
        public IFormFile PassportNoFile { get; set; }
        [Computed]
        public IFormFile DrivingLicenceFile { get; set; }
        [Computed]
        public IFormFile PersonPhoto { get; set; }
        public string PersonPhotoPath { get; set; }
        public DateTime ContractStartdate { get; set; }
        public DateTime ContractEndate { get; set; }
    }
}
