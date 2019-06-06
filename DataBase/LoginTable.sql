USE [Book]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 6/6/2019 6:18:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
	[login_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[admin] [bit] NOT NULL
) ON [PRIMARY]
GO

