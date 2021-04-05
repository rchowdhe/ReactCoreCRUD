namespace ReactCoreCRUD.Repository.Queries
{
    public class CommandText : ICommandText
    {
        public string GetAllUsers => "SELECT * FROM UserDetails";
        public string GetUserById => "SELECT * FROM UserDetails WHERE UserDetailsId= @Id";
        public string InsertUser => @"INSERT INTO [dbo].[UserDetails] ([LocationId], [EmployeeType], [Name], [MobileNo], [Email], [Section], [Nationality], [Designation],[EmiratesID],
                                                        [EmiratesIDExpiryDate],[EmiratesIDFilePath],[PassportNo],[PassportExpiryDate],[PassportFilePath],[DrivingLicence],
                                                        [DrivingLicenceExpiryDate], [DrivingLicenceFilePath], [ContractStartdate], [ContractEndate], [PersonPhotoPath])
                                                VALUES (@LocationId, @EmployeeType, @Name, @MobileNo, @Email, @Section, @Nationality, @Designation, @EmiratesID, @EmiratesIDExpiryDate, 
                                                        @EmiratesIDFilePath, @PassportNo, @PassportExpiryDate, @PassportFilePath, @DrivingLicence, @DrivingLicenceExpiryDate,
                                                        @DrivingLicenceFilePath, @ContractStartdate, @ContractEndate, @PersonPhotoPath)";
        public string UpdateUser => @"UPDATE [dbo].[UserDetails] SET [LocationId] = @LocationId,[EmployeeType] = @EmployeeType,[Name] = @Name,[MobileNo] = @MobileNo
                                                    ,[Email] = @Email,[Section] = @Section,[Nationality] = @Nationality,[Designation] = @Designation,[EmiratesID] = @EmiratesID
                                                    ,[EmiratesIDExpiryDate] = @EmiratesIDExpiryDate,[EmiratesIDFilePath] = @EmiratesIDFilePath,[PassportNo] = @PassportNo
                                                    ,[PassportExpiryDate] = @PassportExpiryDate,[PassportFilePath] = @PassportFilePath,[DrivingLicence] = @DrivingLicence
                                                    ,[DrivingLicenceExpiryDate] = @DrivingLicenceExpiryDate,[DrivingLicenceFilePath] = @DrivingLicenceFilePath
                                                    ,[ContractStartdate] = @ContractStartdate,[ContractEndate] = @ContractEndate,[PersonPhotoPath] = @PersonPhotoPath 
                                            WHERE UserDetailsId =@Id";
        public string DeleteUser => "DELETE FROM [UserDetails] WHERE UserDetailsId= @Id";
        public string GetUserById_SP => "GetProductId";
    }
}

