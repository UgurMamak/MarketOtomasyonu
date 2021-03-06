USE [master]
GO
/****** Object:  Database [DbMarket]    Script Date: 12.01.2020 12:37:37 ******/
CREATE DATABASE [DbMarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbMarket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DbMarket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbMarket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DbMarket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DbMarket] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbMarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbMarket] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbMarket] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbMarket] SET  MULTI_USER 
GO
ALTER DATABASE [DbMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbMarket] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DbMarket] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbMarket] SET QUERY_STORE = OFF
GO
USE [DbMarket]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [DbMarket]
GO
/****** Object:  Table [dbo].[TblIslemler]    Script Date: 12.01.2020 12:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblIslemler](
	[IslemId] [int] IDENTITY(1,1) NOT NULL,
	[KulId] [tinyint] NULL,
	[IslemTarih] [datetime] NULL,
	[UrunId] [int] NULL,
	[Adet] [int] NULL,
 CONSTRAINT [PK_TblIslemler] PRIMARY KEY CLUSTERED 
(
	[IslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKullanici]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKullanici](
	[KulId] [tinyint] IDENTITY(1,1) NOT NULL,
	[KulAd] [nvarchar](20) NULL,
	[Parola] [nvarchar](20) NULL,
	[KullanıcıTip] [nvarchar](20) NULL,
 CONSTRAINT [PK_TblKullanici] PRIMARY KEY CLUSTERED 
(
	[KulId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUrunler]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUrunler](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[Barkod] [nvarchar](15) NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_TblUrunler] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUrunler2]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUrunler2](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[Barkod] [nvarchar](15) NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[GelisFiyat] [money] NULL,
	[SatisFiyat] [money] NULL,
	[Stok] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblIslemler] ON 

INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (7, 1, CAST(N'2020-01-10T12:00:03.410' AS DateTime), 1, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (8, 1, CAST(N'2020-01-10T12:00:03.457' AS DateTime), 2, 10)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (9, 1, CAST(N'2020-01-11T12:00:03.470' AS DateTime), 10, 5)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (10, 1, CAST(N'2020-01-11T12:06:30.347' AS DateTime), 2, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (11, 1, CAST(N'2020-01-11T12:06:30.440' AS DateTime), 10, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (12, 1, CAST(N'2020-01-11T12:06:30.457' AS DateTime), 1, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (13, 1, CAST(N'2020-01-11T12:06:56.600' AS DateTime), 2, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (14, 1, CAST(N'2020-01-11T12:06:56.630' AS DateTime), 10, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (15, 1, CAST(N'2020-01-11T12:06:56.647' AS DateTime), 1, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (16, 1, CAST(N'2020-01-11T12:06:56.647' AS DateTime), 2, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (17, 1, CAST(N'2020-01-11T12:06:56.677' AS DateTime), 1, 10)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (18, 1, CAST(N'2020-01-11T12:06:56.677' AS DateTime), 10, 5)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (19, 1, CAST(N'2020-01-11T12:12:42.543' AS DateTime), 1, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (20, 1, CAST(N'2020-01-11T12:12:42.573' AS DateTime), 2, 6)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (21, 1, CAST(N'2020-01-11T12:12:42.590' AS DateTime), 10, 6)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (22, 1, CAST(N'2020-01-11T12:12:42.607' AS DateTime), 2, 6)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (23, 1, CAST(N'2020-01-11T12:16:47.343' AS DateTime), 1, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (24, 1, CAST(N'2020-01-11T12:16:47.390' AS DateTime), 2, 6)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (25, 1, CAST(N'2020-01-11T12:16:47.407' AS DateTime), 10, 6)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (26, 1, CAST(N'2020-01-11T12:16:47.423' AS DateTime), 2, 6)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (27, 1, CAST(N'2020-01-11T12:16:47.453' AS DateTime), 1, 20)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (28, 1, CAST(N'2020-01-11T12:16:47.517' AS DateTime), 10, 25)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (29, 1, CAST(N'2020-01-11T12:31:48.390' AS DateTime), 2, 1)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (30, 1, CAST(N'2020-01-11T12:31:48.467' AS DateTime), 1, 81)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (31, 1, CAST(N'2020-01-11T17:36:36.487' AS DateTime), 10, 5)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (32, 1, CAST(N'2020-01-11T17:36:36.507' AS DateTime), 13, 10)
INSERT [dbo].[TblIslemler] ([IslemId], [KulId], [IslemTarih], [UrunId], [Adet]) VALUES (33, 1, CAST(N'2020-01-11T17:36:36.517' AS DateTime), 1, 8)
SET IDENTITY_INSERT [dbo].[TblIslemler] OFF
SET IDENTITY_INSERT [dbo].[TblKullanici] ON 

INSERT [dbo].[TblKullanici] ([KulId], [KulAd], [Parola], [KullanıcıTip]) VALUES (1, N'ugur', N'1632', N'yönetici')
INSERT [dbo].[TblKullanici] ([KulId], [KulAd], [Parola], [KullanıcıTip]) VALUES (2, N'mehmet', N'1234', N'kullanıcı')
SET IDENTITY_INSERT [dbo].[TblKullanici] OFF
SET IDENTITY_INSERT [dbo].[TblUrunler] ON 

INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (4, N'8690504065395', N'Laviva', 1.6000)
INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (5, N'8690504130697', N'Frambuazlı Dido', 2.0000)
INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (6, N'8690504135913', N'Ülker Çikolatalı Gofret', 1.0000)
INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (7, N'8690526087252', N'Eti Canga', 2.0000)
INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (8, N'8690504149989', N'Caramio Bitter', 1.5000)
INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (9, N'8690504027508', N'Ülker Çokonat', 1.7500)
INSERT [dbo].[TblUrunler] ([UrunId], [Barkod], [UrunAdi], [Fiyat]) VALUES (1002, N'8690533094762', N'Form Kirazlı', 1.0000)
SET IDENTITY_INSERT [dbo].[TblUrunler] OFF
SET IDENTITY_INSERT [dbo].[TblUrunler2] ON 

INSERT [dbo].[TblUrunler2] ([UrunId], [Barkod], [UrunAdi], [GelisFiyat], [SatisFiyat], [Stok]) VALUES (1, N'8690504065395', N'Laviva', 1.5000, 1.7500, 172)
INSERT [dbo].[TblUrunler2] ([UrunId], [Barkod], [UrunAdi], [GelisFiyat], [SatisFiyat], [Stok]) VALUES (2, N'8690504130697', N'Frambuazlı Dido', 1.5000, 1.7500, 1030)
INSERT [dbo].[TblUrunler2] ([UrunId], [Barkod], [UrunAdi], [GelisFiyat], [SatisFiyat], [Stok]) VALUES (10, N'8690504130685', N'Eti Burçak Sütlü Çik', 2.7500, 3.0000, 445)
INSERT [dbo].[TblUrunler2] ([UrunId], [Barkod], [UrunAdi], [GelisFiyat], [SatisFiyat], [Stok]) VALUES (13, N'8690533094762', N'Form Kirazlı', 0.7500, 1.0000, 120)
INSERT [dbo].[TblUrunler2] ([UrunId], [Barkod], [UrunAdi], [GelisFiyat], [SatisFiyat], [Stok]) VALUES (11, N'8690504027508', N'Ülker çokonat', 2.0000, 2.2500, 0)
INSERT [dbo].[TblUrunler2] ([UrunId], [Barkod], [UrunAdi], [GelisFiyat], [SatisFiyat], [Stok]) VALUES (15, N'8690526087252', N'Eti Canga', 1.7500, 2.0000, 100)
SET IDENTITY_INSERT [dbo].[TblUrunler2] OFF
/****** Object:  StoredProcedure [dbo].[PrcGiris]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcGiris](@KulAdi varchar(10),@Parola varchar(10)) as begin
--Select COUNT(*) from TblCalisan where KulAdi=@KulAdi and Parola=@Parola
select COUNT(*),KullanıcıTip,KulAd,KulId from TblKullanici where KulAd=@KulAdi and Parola=@Parola
group by KullanıcıTip,KulAd,KulId
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblIslemler_Insert]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblIslemler_Insert]
(@KulId tinyint,
@islemtarih datetime,
@urunid int,
@barkod nvarchar(15),
@adet int

) as begin 

update TblUrunler2 set Stok=Stok-@adet where Barkod=@barkod
insert into TblIslemler values(@KulId,@islemtarih,@urunid,@adet)

end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblIslemler_Select]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblIslemler_Select]
as begin 
select islem.IslemId, kul.KulAd, islem.IslemTarih,urun.UrunAdi,urun.GelisFiyat,urun.SatisFiyat,islem.adet
from TblIslemler islem join TblUrunler2 urun on islem.UrunId=urun.UrunId join TblKullanici kul on kul.KulId=islem.KulId
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunler_Select]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrcTblUrunler_Select] as begin
Select * from TblUrunler2
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunler2_Delete]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrcTblUrunler2_Delete](@barkod nvarchar(15)) as begin
delete from TblUrunler2 where Barkod=@barkod
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunler2_Insert]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblUrunler2_Insert](
@Barkod nvarchar(15), 
@UrunAdi nvarchar(50),
@GelisFiyat money,
@SatisFiyat money,
@Stok int
) 
as begin
insert into TblUrunler2 values(@Barkod,@UrunAdi,@GelisFiyat,@SatisFiyat,@Stok)
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunler2_Update]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblUrunler2_Update] (
@Barkod nvarchar(15), 
@UrunAdi nvarchar(50),
@GelisFiyat money,
@SatisFiyat money,
@Stok int
) 
as begin
update TblUrunler2 
set UrunAdi=@UrunAdi, GelisFiyat=@GelisFiyat, SatisFiyat=@SatisFiyat, Stok=Stok+@Stok 
where Barkod=@Barkod
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunler2_Update2]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrcTblUrunler2_Update2] (
@Barkod nvarchar(15), 
@UrunAdi nvarchar(50),
@GelisFiyat money,
@SatisFiyat money,
@Stok int
) 
as begin
update TblUrunler2 
set UrunAdi=@UrunAdi, GelisFiyat=@GelisFiyat, SatisFiyat=@SatisFiyat, Stok=@Stok 
where Barkod=@Barkod
end
GO
/****** Object:  StoredProcedure [dbo].[PrcUrunEkle]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcUrunEkle](
@Barkod nvarchar(15),
@UrunAdi nvarchar(50),
@Fiyat money) as begin
insert into TblUrunler values(@Barkod,@UrunAdi,@Fiyat)
end
GO
/****** Object:  StoredProcedure [dbo].[PrcUrunListele]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcUrunListele] as begin
Select * from TblUrunler
end
GO
/****** Object:  StoredProcedure [dbo].[PrcUrunSil]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrcUrunSil] (@Barkod varchar(20)) as begin
delete from TblUrunler where Barkod=@Barkod
end
GO
/****** Object:  StoredProcedure [dbo].[UrunUpdate]    Script Date: 12.01.2020 12:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UrunUpdate] (@Barkod nvarchar(15), @UrunAdi nvarchar(50),@Fiyat money) 
as begin
update TblUrunler set UrunAdi=@UrunAdi, Fiyat=@Fiyat where Barkod=@Barkod
end
GO
USE [master]
GO
ALTER DATABASE [DbMarket] SET  READ_WRITE 
GO
