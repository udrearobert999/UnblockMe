USE [UnblockMe]
GO

UPDATE [dbo].[Cars]
   SET [license_plate] = <license_plate, nvarchar(20),>
      ,[brand] = <brand, nvarchar(20),>
      ,[color] = <color, nvarchar(20),>
      ,[blocks_car] = <blocks_car, nvarchar(20),>
      ,[is_blocked_by_car] = <is_blocked_by_car, nvarchar(20),>
      ,[owner_id] = <owner_id, uniqueidentifier,>
 WHERE <Search Conditions,,>
GO


