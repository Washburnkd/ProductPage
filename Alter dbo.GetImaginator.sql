USE [pinitgodb]
GO

/****** Object: SqlProcedure [dbo].[GetImaginator] Script Date: 12/6/2020 9:42:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[GetImaginator]
	@Offer int
AS
Begin
SELECT * from [50 Upload]
	SELECT * from [10 Offer] o

join [40 Xform] f on o.OID=f.OID
join [50 Upload] u on u.[UID]=f.[UID]
where o.OID=@Offer

SELECT * from [10 Offer] o
join [20 selection] s on o.OID=s.OID
where o.OID=@Offer

End
