USE [InfoClima]
GO
/****** Object:  Table [dbo].[Climates]    Script Date: 9/6/2021 3:02:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Climates](
	[ClimaID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Temperature] [int] NOT NULL,
	[Humidity] [int] NOT NULL,
	[Wind] [int] NOT NULL,
	[City] [varchar](20) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Climates] PRIMARY KEY CLUSTERED 
(
	[ClimaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/6/2021 3:02:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](10) NOT NULL,
	[LastName] [varchar](10) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[Password] [varchar](16) NOT NULL,
	[Token] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [UserName], [Password], [Token]) VALUES (1, N'Pablo', N'Moya', N'pmoya', N'Moneda32', NULL)
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [UserName], [Password], [Token]) VALUES (2, N'Maria', N'Morena', N'mmorena', N'123456', NULL)
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [UserName], [Password], [Token]) VALUES (3, N'Tito', N'Alonzo', N'tito45', N'cach#$12', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
