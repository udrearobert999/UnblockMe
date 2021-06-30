USE [UnblockMe]
GO

INSERT INTO [dbo].[Users]
           ([id]
           ,[first_name]
           ,[last_name]
           ,[email]
           ,[passowrd]
           ,[phone_number])
     VALUES
           (<id, uniqueidentifier,>
           ,<first_name, nvarchar(50),>
           ,<last_name, nvarchar(50),>
           ,<email, nvarchar(50),>
           ,<passowrd, nvarchar(20),>
           ,<phone_number, varchar(20),>)
GO


