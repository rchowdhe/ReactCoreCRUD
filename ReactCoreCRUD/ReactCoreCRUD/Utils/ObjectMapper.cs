using Microsoft.AspNetCore.Http;
using ReactCoreCRUD.Entities;
using System.IO;
using System.Threading.Tasks;

namespace ReactCoreCRUD.Utils
{
    enum FileType
    {
        EMIRATES,
        PASSPORT,
        DRIVINGL
    }

    public class ObjectMapper
    {
        private readonly string HOST_PATH;
        private const string EMIRATES_FOLDER = "Emirates_Files";
        private const string PASSPORT_FOLDER = "Passport_Files";
        private const string DRIVINGL_FOLDER = "Driving_Files";

        public ObjectMapper(string hostPath)
        {
            HOST_PATH = hostPath;
        }
        public UserDetails ConvertToObject(UserDetails source)
        {
            UserDetails target = new UserDetails
            {
                UserDetailsId = source.UserDetailsId,
                LocationId = source.LocationId,
                EmployeeType = source.EmployeeType,
                ContractEndate = source.ContractEndate,
                ContractStartdate = source.ContractStartdate,
                Designation = source.Designation,
                DrivingLicence = source.DrivingLicence,
                DrivingLicenceExpiryDate = source.DrivingLicenceExpiryDate,
                DrivingLicenceFilePath = source.DrivingLicenceFile != null ? GetFileLocalPath(source.DrivingLicenceFile, FileType.DRIVINGL, source.DrivingLicence).Result : source.DrivingLicenceFilePath,
                Email = source.Email,
                EmiratesID = source.EmiratesID,
                EmiratesIDExpiryDate = source.EmiratesIDExpiryDate,
                EmiratesIDFilePath = source.EmiratesIDFile != null ? GetFileLocalPath(source.EmiratesIDFile, FileType.EMIRATES, source.EmiratesID).Result : source.EmiratesIDFilePath,
                MobileNo = source.MobileNo,
                Name = source.Name,
                Nationality = source.Nationality,
                PassportExpiryDate = source.PassportExpiryDate,
                PassportNo = source.PassportNo,
                PassportFilePath = source.PassportNoFile != null ? GetFileLocalPath(source.PassportNoFile, FileType.PASSPORT, source.PassportNo).Result : source.PassportFilePath,
                Section = source.Section,
                PersonPhotoPath = ""
            };
            return target;
        }
        private async Task<string> GetFileLocalPath(IFormFile document, FileType fileType, string filePrefix)
        {
            string initialpath = "";
            switch (fileType)
            {
                case FileType.EMIRATES:
                    initialpath = Path.Combine(HOST_PATH, "Documents", EMIRATES_FOLDER);
                    if (!Directory.Exists(initialpath))
                    {
                        Directory.CreateDirectory(initialpath);
                    }
                    break;
                case FileType.PASSPORT:
                    initialpath = Path.Combine(HOST_PATH, "Documents", PASSPORT_FOLDER);
                    if (!Directory.Exists(initialpath))
                    {
                        Directory.CreateDirectory(initialpath);
                    }
                    break;
                case FileType.DRIVINGL:
                    initialpath = Path.Combine(HOST_PATH, "Documents", DRIVINGL_FOLDER);
                    if (!Directory.Exists(initialpath))
                    {
                        Directory.CreateDirectory(initialpath);
                    }
                    break;
            }
            FileInfo fi = new FileInfo(document.FileName);
            string completePath = Path.Combine(initialpath, string.Format("{0}{1}", filePrefix, fi.Extension));
            using (Stream fileStream = new FileStream(completePath, FileMode.Create))
            {
                await document.CopyToAsync(fileStream);
            }
            return completePath;
        }
    }
}
