USE [DBfirstDemo]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 09-09-2019 20:47:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts](
	[PostID] [int] NOT NULL,
	[DatePublished] [smalldatetime] NOT NULL,
	[Title] [varchar](200) NOT NULL,
	[Body] [varchar](300) NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

