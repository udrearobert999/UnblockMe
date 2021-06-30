USE [UnblockMe]
GO

INSERT INTO [dbo].[Cars]
           ([license_plate]
           ,[brand]
           ,[color]
           ,[blocks_car]
           ,[is_blocked_by_car]
           ,[owner_id])
     VALUES
           (<license_plate, nvarchar(20),>
           ,<brand, nvarchar(20),>
           ,<color, nvarchar(20),>
           ,<blocks_car, nvarchar(20),>
           ,<is_blocked_by_car, nvarchar(20),>
           ,<owner_id, uniqueidentifier,>)
GO


