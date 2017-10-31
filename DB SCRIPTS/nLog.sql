SET ANSI_NULLS ON
  SET QUOTED_IDENTIFIER ON
  CREATE TABLE [dbo].[Log] (
      [Id] [int] IDENTITY(1,1) NOT NULL,
      [Application] [nvarchar](50) NOT NULL,
      [Logged] [datetime] NOT NULL,
      [Level] [nvarchar](50) NOT NULL,
      [Message] [nvarchar](max) NOT NULL,
      [Logger] [nvarchar](250) NULL,
      [Callsite] [nvarchar](max) NULL,
      [Exception] [nvarchar](max) NULL,
    CONSTRAINT [PK_dbo.Log] PRIMARY KEY CLUSTERED ([Id] ASC)
      WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
  ) ON [PRIMARY]
  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertLog]
	@Application [nvarchar](50), 
	@Logged datetime, 
	@Level nvarchar (50), 
	@Message nvarchar (max),
	@Logger nvarchar(250), 
	@Callsite nvarchar (max), 
	@Exception nvarchar (max)
AS
BEGIN
insert into dbo.Log 
	(
		Application, 
		Logged, 
		Level, 
		Message,
        Logger, 
		CallSite,	
		Exception
	)
    values 
	(
        @Application, 
		@Logged, 
		@Level, 
		@Message,
        @Logger, 
		@Callsite, 
		@Exception
        )
END
GO
