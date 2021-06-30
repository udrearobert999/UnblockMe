USE [UnblockMe]
GO

/****** Object:  Table [dbo].[Cars]    Script Date: 6/30/2021 2:36:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cars](
	[license_plate] [nvarchar](20) NOT NULL,
	[brand] [nvarchar](20) NOT NULL,
	[color] [nvarchar](20) NOT NULL,
	[blocks_car] [nvarchar](20) NULL,
	[is_blocked_by_car] [nvarchar](20) NULL,
	[owner_id] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[license_plate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_ref_to_Users] FOREIGN KEY([owner_id])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_ref_to_Users]
GO

ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [CK_Colision_Cars_Constraint] CHECK  (([license_plate]<>[blocks_car] AND [blocks_car]<>[is_blocked_by_car] AND [license_plate]<>[is_blocked_by_car]))
GO

ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [CK_Colision_Cars_Constraint]
GO


