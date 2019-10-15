USE [GestionComercio]
GO

/****** Object:  Table [dbo].[Proveedores]    Script Date: 2/21/2019 3:03:38 PM ******/
DROP TABLE [dbo].[Proveedores]
GO

/****** Object:  Table [dbo].[Proveedores]    Script Date: 2/21/2019 3:03:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Proveedores](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[Cuit] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
CREATE PROCEDURE SELECT_TOP_PROVEEDORES(@Count bigint)
as
begin
select top (@Count) *  from Proveedores
end

GO
CREATE PROCEDURE SELECT_ALL_PROVEEDORES
as
begin
select * from Proveedores
end
GO
CREATE PROCEDURE SELECT_BYID_PROVEEDORES(@Id bigint)
as
begin
select *  from Proveedores where Id=@Id
end
go
CREATE PROCEDURE INSERT_PROVEEDOR(@Nombre varchar(200),@Telefono varchar(200), @Cuit varchar(200))
as
begin
insert into Proveedores(Nombre,Telefono,Cuit) values(@Nombre,@Telefono,@Cuit)
end
go