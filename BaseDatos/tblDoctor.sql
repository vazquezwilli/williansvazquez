

CREATE TABLE [dbo].[tblDoctor](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorNumber] int  NOT NULL,
	[DoctorName] [nvarchar](250) NOT NULL,
	BirthDate datetime NOT NULL,
	FirstEpisodeDate datetime NOT NULL,
	LastEpisodeDate datetime NOT NULL,



PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


