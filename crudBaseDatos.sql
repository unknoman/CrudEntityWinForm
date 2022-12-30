create database crudema
USE [crudema]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 30/12/2022 5:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[IDUSUARIO] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [varchar](200) NOT NULL,
	[PASSWORD] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUSUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
