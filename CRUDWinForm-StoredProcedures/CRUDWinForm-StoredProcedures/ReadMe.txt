create database CRUD_SP_DB;
---------------------------------------------------------------------------------------------------------------------------------------
create table ProductInfo_Tab
(
ProductID int primary key,
ItemName nvarchar(50),
Color nvarchar(50),
status nvarchar(50),
ExpiryDate datetime
); 
--------------------------------------------------------------------------------------------------------------------------------------

USE [CRUD_SP_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_Product_Insert]    Script Date: 3/25/2021 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cagtay bayrak,
-- Create date: 2021-03-25
-- Description:	insert Procedures
-- =============================================
ALTER PROCEDURE [dbo].[SP_Product_Insert]
	-- Add the parameters for the stored procedure here
	 @ProductID int,
	 @ItemName nvarchar(50),
	 @Color nvarchar(50),
	 @status nvarchar(50),
	 @Address nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
  insert into ProductInfo_Tab (ProductID,ItemName,Color,status,Address)
  VALUES
  (@ProductID,@ItemName,@Color,@status,@Address)
END


--------------------------------------------------------------------------------------------------------------------------------------

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cagtay bayrak
-- Create date: 2021-03-25
-- Description:	update Procedures
-- =============================================
CREATE PROCEDURE [dbo].[SP_Product_Update]
	-- Add the parameters for the stored procedure here
	 @ProductID int,
	 @ItemName nvarchar(50),
	 @Color nvarchar(50),
	 @status nvarchar(50),
	 @Address nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
  update ProductInfo_Tab set ItemName=@ItemName,Color=@Color,status=@status,Address=@Address
  where ProductID=@ProductID
END

--------------------------------------------------------------------------------------------------------------------------------------


USE [CRUD_SP_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_Product_View]    Script Date: 3/25/2021 3:35:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cagtay bayrak,
-- Create date: 2021-03-25
-- Description:	View Procedures
-- =============================================

--All Records
ALTER PROCEDURE [dbo].[SP_Product_View]
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
 select * from ProductInfo_Tab
END
--------------------------------------------------------------------------------------------------------------------------------------
USE [CRUD_SP_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_Product_Delete]    Script Date: 3/25/2021 3:43:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cagtay bayrak
-- Create date: 2021-03-25
-- Description:	Delete Procedures
-- =============================================
ALTER PROCEDURE [dbo].[SP_Product_Delete]
	-- Add the parameters for the stored procedure here
	 @ProductID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
  Delete ProductInfo_Tab where ProductID=@ProductID
END


-----------------------------------------------------------------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cagtay bayrak
-- Create date: 2021-03-25
-- Description:	Search Procedures
-- =============================================
create PROCEDURE [dbo].[SP_Product_Search]
	-- Add the parameters for the stored procedure here
	 @ProductID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
  select * from ProductInfo_Tab where ProductID=@ProductID
END
