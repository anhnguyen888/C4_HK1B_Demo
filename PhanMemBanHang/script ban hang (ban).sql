USE [master]
GO
/****** Object:  Database [C4_QuanLyBanHang]    Script Date: 11/12/2024 2:09:20 CH ******/
CREATE DATABASE [C4_QuanLyBanHang]
 
GO
USE [C4_QuanLyBanHang]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 11/12/2024 2:09:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[BanID] [int] IDENTITY(1,1) NOT NULL,
	[TenBan] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[BanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/12/2024 2:09:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ChiTietID] [int] IDENTITY(1,1) NOT NULL,
	[HoaDonID] [int] NULL,
	[MonAnID] [int] NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
	[ThanhTien]  AS ([SoLuong]*[DonGia]) PERSISTED,
PRIMARY KEY CLUSTERED 
(
	[ChiTietID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 11/12/2024 2:09:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[DanhMucID] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DanhMucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/12/2024 2:09:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[HoaDonID] [int] IDENTITY(1,1) NOT NULL,
	[BanID] [int] NULL,
	[NgayLap] [datetime] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 11/12/2024 2:09:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MonAnID] [int] IDENTITY(1,1) NOT NULL,
	[DanhMucID] [int] NULL,
	[TenMon] [nvarchar](100) NOT NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MonAnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ban] ON 
GO
INSERT [dbo].[Ban] ([BanID], [TenBan], [TrangThai]) VALUES (1, N'Bàn 1', 0)
GO
INSERT [dbo].[Ban] ([BanID], [TenBan], [TrangThai]) VALUES (2, N'Bàn 2', 1)
GO
INSERT [dbo].[Ban] ([BanID], [TenBan], [TrangThai]) VALUES (3, N'Bàn 3', 1)
GO
INSERT [dbo].[Ban] ([BanID], [TenBan], [TrangThai]) VALUES (4, N'Bàn 4', 0)
GO
SET IDENTITY_INSERT [dbo].[Ban] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 
GO
INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc]) VALUES (1, N'Món chính')
GO
INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc]) VALUES (2, N'Tráng miệng')
GO
INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc]) VALUES (3, N'Đồ uống')
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON 
GO
INSERT [dbo].[MonAn] ([MonAnID], [DanhMucID], [TenMon], [DonGia]) VALUES (1, 1, N'Bánh mì thịt', CAST(30000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MonAn] ([MonAnID], [DanhMucID], [TenMon], [DonGia]) VALUES (2, 1, N'Cơm gà', CAST(50000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MonAn] ([MonAnID], [DanhMucID], [TenMon], [DonGia]) VALUES (3, 2, N'Kem tươi', CAST(15000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MonAn] ([MonAnID], [DanhMucID], [TenMon], [DonGia]) VALUES (4, 2, N'Bánh flan', CAST(20000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MonAn] ([MonAnID], [DanhMucID], [TenMon], [DonGia]) VALUES (5, 3, N'Trà sữa', CAST(35000.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[MonAn] OFF
GO
ALTER TABLE [dbo].[Ban] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([HoaDonID])
REFERENCES [dbo].[HoaDon] ([HoaDonID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MonAnID])
REFERENCES [dbo].[MonAn] ([MonAnID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([BanID])
REFERENCES [dbo].[Ban] ([BanID])
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DanhMuc] ([DanhMucID])
GO
USE [master]
GO
ALTER DATABASE [C4_QuanLyBanHang] SET  READ_WRITE 
GO
