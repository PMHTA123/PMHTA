USE [QLCH]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tb_KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NamSinh] [date] NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Diem] [int] NULL,
	[Email] [varchar](30) NULL,
 CONSTRAINT [PK_tb_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
--------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tb_HangHoa](
	[MaHang] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](30) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_tb_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-------------------------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tb_HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[NguoiLap] [varchar](10) NULL,
	[KhachHang] [varchar](10) NULL,
 CONSTRAINT [PK_tb_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon_tb_KhachHang] FOREIGN KEY([KhachHang])
REFERENCES [dbo].[tb_KhachHang] ([MaKH])
GO

ALTER TABLE [dbo].[tb_HoaDon] CHECK CONSTRAINT [FK_tb_HoaDon_tb_KhachHang]
GO
---------------------------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NamSinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[MatKhau] [varchar](20) NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
------------------------------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[tb_CTHD](
	[MaHD] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tb_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHD_tb_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[tb_HangHoa] ([MaHang])
GO

ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [FK_tb_CTHD_tb_HangHoa]
GO

ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHD_tb_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tb_HoaDon] ([MaHD])
GO

ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [FK_tb_CTHD_tb_HoaDon]
GO









