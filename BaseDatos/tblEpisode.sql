USE [Examen]
GO

/****** Object:  Table [dbo].[ArticuloTienda]    Script Date: 6/2/2025 9:53:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEpisode](
	[EpisodeId] [int] IDENTITY(1,1) NOT NULL,
	[SeriesNumber] [int] NOT NULL,
	[EpisodeNumber] [int] NOT NULL,
	[EpisodeType] [int] NOT NULL,
	Title varchar(200) NOT NULL,
	EpisodeDate datetime not null,
	AuthorId int not null,
	DoctorId int not null,
	Notes varchar(400)
PRIMARY KEY CLUSTERED 
(
	[EpisodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblEpisode]  WITH CHECK ADD FOREIGN KEY(AuthorId)
REFERENCES [dbo].[tblAuthor] ([AuthorId])
GO

ALTER TABLE [dbo].[tblEpisode]  WITH CHECK ADD FOREIGN KEY(DoctorId)
REFERENCES [dbo].[tblDoctor] (DoctorId)
GO
 
GO


