USE [UnblockMe]
GO

UPDATE [dbo].[Users]
   SET [id] = <id, uniqueidentifier,>
      ,[first_name] = <first_name, nvarchar(50),>
      ,[last_name] = <last_name, nvarchar(50),>
      ,[email] = <email, nvarchar(50),>
      ,[passowrd] = <passowrd, nvarchar(20),>
      ,[phone_number] = <phone_number, varchar(20),>
 WHERE <Search Conditions,,>
GO


