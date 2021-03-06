USE [CrudOperation]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 4/5/2021 12:26:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDetails](
	[UserDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[LocationId] [int] NOT NULL,
	[EmployeeType] [int] NULL,
	[Name] [varchar](500) NOT NULL,
	[MobileNo] [varchar](250) NULL,
	[Email] [varchar](500) NULL,
	[Section] [varchar](250) NULL,
	[Nationality] [varchar](250) NULL,
	[Designation] [varchar](250) NULL,
	[EmiratesID] [varchar](250) NULL,
	[EmiratesIDExpiryDate] [date] NULL,
	[EmiratesIDFilePath] [varchar](max) NULL,
	[PassportNo] [varchar](250) NULL,
	[PassportExpiryDate] [date] NULL,
	[PassportFilePath] [varchar](max) NULL,
	[DrivingLicence] [varchar](250) NULL,
	[DrivingLicenceExpiryDate] [date] NULL,
	[DrivingLicenceFilePath] [varchar](250) NULL,
	[ContractStartdate] [date] NULL,
	[ContractEndate] [date] NULL,
	[PersonPhotoPath] [varchar](max) NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[UserDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON 

INSERT [dbo].[UserDetails] ([UserDetailsId], [LocationId], [EmployeeType], [Name], [MobileNo], [Email], [Section], [Nationality], [Designation], [EmiratesID], [EmiratesIDExpiryDate], [EmiratesIDFilePath], [PassportNo], [PassportExpiryDate], [PassportFilePath], [DrivingLicence], [DrivingLicenceExpiryDate], [DrivingLicenceFilePath], [ContractStartdate], [ContractEndate], [PersonPhotoPath]) VALUES (1, 4, 2, N'Rajiv Chowdhery', N'+918882557290', N'rcraaj18@gmail.com', N'Test', N'Indian', N'Consultant', N'786806555487', CAST(N'2025-11-20' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Emirates_Files\786806555487.jpg', N'R-25678-43', CAST(N'2028-07-24' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Passport_Files\R-25678-43.jpg', N'UP-16-BN-778080', CAST(N'2025-05-20' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Driving_Files\UP-16-BN-778080.jpg', CAST(N'2020-02-04' AS Date), CAST(N'2022-12-30' AS Date), N'')
INSERT [dbo].[UserDetails] ([UserDetailsId], [LocationId], [EmployeeType], [Name], [MobileNo], [Email], [Section], [Nationality], [Designation], [EmiratesID], [EmiratesIDExpiryDate], [EmiratesIDFilePath], [PassportNo], [PassportExpiryDate], [PassportFilePath], [DrivingLicence], [DrivingLicenceExpiryDate], [DrivingLicenceFilePath], [ContractStartdate], [ContractEndate], [PersonPhotoPath]) VALUES (2, 5, 1, N'John Smith', N'+9187984578943', N'Joshn.s@gmail.com', N'Test', N'American', N'Consultant', N'456706555487', CAST(N'2025-11-20' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Emirates_Files\456706555487.jpg', N'R-25678-43', CAST(N'2028-07-24' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Passport_Files\R-25678-43.jpg', N'UP-16-BN-778080', CAST(N'2023-05-20' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Driving_Files\UP-16-BN-778080.jpg', CAST(N'2020-02-04' AS Date), CAST(N'2022-12-30' AS Date), N'')
INSERT [dbo].[UserDetails] ([UserDetailsId], [LocationId], [EmployeeType], [Name], [MobileNo], [Email], [Section], [Nationality], [Designation], [EmiratesID], [EmiratesIDExpiryDate], [EmiratesIDFilePath], [PassportNo], [PassportExpiryDate], [PassportFilePath], [DrivingLicence], [DrivingLicenceExpiryDate], [DrivingLicenceFilePath], [ContractStartdate], [ContractEndate], [PersonPhotoPath]) VALUES (3, 3, 3, N'Robert', N'+916787982456', N'robert@gmail.com', N'Test', N'Indian', N'Consultant', N'786806555487', CAST(N'2025-11-20' AS Date), N'C:DEVELOPMENTTrainingReactCoreCRUDReactCoreCRUDDocumentsEmirates_FilesScreenshot.jpg', N'R-25678-43', CAST(N'2028-07-24' AS Date), N'C:DEVELOPMENTTrainingReactCoreCRUDReactCoreCRUDDocumentsPassport_FilesTestFile.jpg', N'UP-16-BN-778080', CAST(N'2025-05-20' AS Date), N'C:DEVELOPMENTTrainingReactCoreCRUDReactCoreCRUDDocumentsDriving_FilesScreenshot.jpg', CAST(N'2020-02-04' AS Date), CAST(N'2022-12-30' AS Date), N'')
INSERT [dbo].[UserDetails] ([UserDetailsId], [LocationId], [EmployeeType], [Name], [MobileNo], [Email], [Section], [Nationality], [Designation], [EmiratesID], [EmiratesIDExpiryDate], [EmiratesIDFilePath], [PassportNo], [PassportExpiryDate], [PassportFilePath], [DrivingLicence], [DrivingLicenceExpiryDate], [DrivingLicenceFilePath], [ContractStartdate], [ContractEndate], [PersonPhotoPath]) VALUES (4, 4, 1, N'Trinity', N'+910987675434', N'trinity@gmail.com', N'Test', N'Indian', N'Consultant', N'786806555487', CAST(N'2025-11-20' AS Date), N'C:DEVELOPMENTTrainingReactCoreCRUDReactCoreCRUDDocumentsEmirates_FilesScreenshot.jpg', N'R-25678-43', CAST(N'2028-07-24' AS Date), N'C:\DEVELOPMENT\Training\ReactCoreCRUD\ReactCoreCRUD\Documents\Passport_Files\R-25678-43.jpg', N'UP-16-BN-778080', CAST(N'2024-05-20' AS Date), N'C:DEVELOPMENTTrainingReactCoreCRUDReactCoreCRUDDocumentsDriving_FilesScreenshot.jpg', CAST(N'2020-02-04' AS Date), CAST(N'2022-12-30' AS Date), N'')
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
