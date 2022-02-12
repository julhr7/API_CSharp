USE [Prueba]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_upd]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_productos_upd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_productos_upd]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_sel_pag]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_productos_sel_pag]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_productos_sel_pag]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_sel]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_productos_sel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_productos_sel]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_ins]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_productos_ins]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_productos_ins]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_fnd]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_productos_fnd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_productos_fnd]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_del]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_productos_del]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[usp_productos_del]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Tproductos_precioProducto]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Tproducto] DROP CONSTRAINT [DF_Tproductos_precioProducto]
END
GO
/****** Object:  Table [dbo].[Tproducto]    Script Date: 2/11/2022 6:13:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tproducto]') AND type in (N'U'))
DROP TABLE [dbo].[Tproducto]
GO
/****** Object:  Table [dbo].[Tproducto]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tproducto](
	[codProducto] [int] IDENTITY(1,1) NOT NULL,
	[nomProducto] [varchar](50) NOT NULL,
	[precioProducto] [decimal](12, 2) NULL,
	[fechRegistroProducto] [date] NOT NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[codProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tproducto] ON 
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (2, N'Mouse', CAST(3.00 AS Decimal(12, 2)), CAST(N'2022-01-20' AS Date))
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (3, N'TEclado', CAST(15.50 AS Decimal(12, 2)), CAST(N'2022-02-05' AS Date))
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (4, N'laptop', CAST(15.50 AS Decimal(12, 2)), CAST(N'2022-02-05' AS Date))
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (5, N'pantalla', CAST(15.50 AS Decimal(12, 2)), CAST(N'2022-02-05' AS Date))
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (6, N'cargador', CAST(100.00 AS Decimal(12, 2)), CAST(N'2022-02-05' AS Date))
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (7, N'MEMORIA', CAST(200.00 AS Decimal(12, 2)), CAST(N'2022-02-05' AS Date))
GO
INSERT [dbo].[Tproducto] ([codProducto], [nomProducto], [precioProducto], [fechRegistroProducto]) VALUES (8, N'TARJETA DE RED', CAST(400.00 AS Decimal(12, 2)), CAST(N'2022-02-01' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Tproducto] OFF
GO
ALTER TABLE [dbo].[Tproducto] ADD  CONSTRAINT [DF_Tproductos_precioProducto]  DEFAULT ((0)) FOR [precioProducto]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_del]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_productos_del]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_fnd]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_productos_fnd]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_ins]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_productos_ins]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_sel]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_productos_sel]
GO
/****** Object:  StoredProcedure [dbo].[usp_productos_sel_pag]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_productos_sel_pag]
		IF @PageSize < 1  OR @PageNumber < 1 RETURN

		SELECT @RecordCnt = COUNT(*) FROM dbo.Tproducto

			SET @PageCount = 0
		ELSE IF @RecordCnt % @PageSize = 0
			SET @PageCount = @RecordCnt / @PageSize	

GO
/****** Object:  StoredProcedure [dbo].[usp_productos_upd]    Script Date: 2/11/2022 6:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_productos_upd]
GO