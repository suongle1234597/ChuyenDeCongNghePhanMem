USE [CHUNGKHOAN]
GO
/****** Object:  Table [dbo].[LENHDAT]    Script Date: 4/1/2020 12:03:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LENHDAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MACP] [char](7) NULL,
	[NGAYDAT] [datetime] NULL,
	[LOAIGD] [nchar](1) NULL,
	[LOAILENH] [nchar](10) NULL,
	[SOLUONG] [int] NULL,
	[GIADAT] [float] NULL,
	[TRANGTHAILENH] [nvarchar](30) NULL,
 CONSTRAINT [PK_LENHDAT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LENHKHOP]    Script Date: 4/1/2020 12:03:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LENHKHOP](
	[IDKHOP] [int] IDENTITY(1,1) NOT NULL,
	[NGAYKHOP] [datetime] NULL,
	[SOLUONGKHOP] [int] NULL,
	[GIAKHOP] [float] NULL,
	[IDLENHDAT] [int] NOT NULL,
 CONSTRAINT [PK_LENHKHOP] PRIMARY KEY CLUSTERED 
(
	[IDKHOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[LENHDAT] ON 

INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (1, N'ACB    ', CAST(N'2020-04-01 11:46:39.353' AS DateTime), N'M', N'LO        ', 1000, 10000, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (2, N'ACB    ', CAST(N'2020-04-01 11:46:39.353' AS DateTime), N'M', N'LO        ', 1000, 10500, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (3, N'ACB    ', CAST(N'2020-04-01 11:46:39.353' AS DateTime), N'M', N'LO        ', 1000, 11000, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (4, N'MBB    ', CAST(N'2020-04-01 11:46:39.353' AS DateTime), N'M', N'LO        ', 1000, 21000, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (5, N'ACB    ', CAST(N'2020-04-01 11:49:07.520' AS DateTime), N'B', N'LO        ', 700, 9400, NULL)
SET IDENTITY_INSERT [dbo].[LENHDAT] OFF
SET IDENTITY_INSERT [dbo].[LENHKHOP] ON 

INSERT [dbo].[LENHKHOP] ([IDKHOP], [NGAYKHOP], [SOLUONGKHOP], [GIAKHOP], [IDLENHDAT]) VALUES (1, CAST(N'2020-04-01 11:49:07.517' AS DateTime), 1000, 9500, 2)
INSERT [dbo].[LENHKHOP] ([IDKHOP], [NGAYKHOP], [SOLUONGKHOP], [GIAKHOP], [IDLENHDAT]) VALUES (2, CAST(N'2020-04-01 11:49:07.517' AS DateTime), 1000, 9500, 4)
SET IDENTITY_INSERT [dbo].[LENHKHOP] OFF
/****** Object:  StoredProcedure [dbo].[CursorLoaiGD]    Script Date: 4/1/2020 12:03:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CursorLoaiGD]
	@OutCrsr CURSOR VARYING	OUTPUT,
	@macp NVARCHAR(10), @Ngay NVARCHAR(50), @LoaiGD CHAR(1)
AS
	SET DATEFORMAT DMY
	IF (@LoaiGD = 'M')
		SET @OutCrsr = CURSOR KEYSET FOR 
		SELECT ID, NGAYDAT, SOLUONG, GIADAT FROM LENHDAT 
		WHERE MACP = @macp
			AND DAY(NGAYDAT) = DAY(@Ngay) AND MONTH(NGAYDAT) = MONTH(@Ngay) AND YEAR(NGAYDAT) = YEAR(@Ngay)
			AND LOAIGD = @LoaiGD AND SOLUONG > 0
			ORDER BY GIADAT DESC, NGAYDAT --Sắp xếp giá đặt từ cao xuống, Time tu nhanh den cham
	ELSE 
		SET @OutCrsr = CURSOR KEYSET FOR 
		SELECT ID, NGAYDAT, SOLUONG, GIADAT FROM LENHDAT 
		WHERE MACP = @macp
			AND DAY(NGAYDAT) = DAY(@Ngay) AND MONTH(NGAYDAT) = MONTH(@Ngay) AND YEAR(NGAYDAT) = YEAR(@Ngay)
			AND LOAIGD = @LoaiGD AND SOLUONG > 0
			ORDER BY GIADAT, NGAYDAT
	OPEN @OutCrsr 




GO
/****** Object:  StoredProcedure [dbo].[SP_KHOPLENH_LO]    Script Date: 4/1/2020 12:03:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KHOPLENH_LO]
	@macp NVARCHAR(10), @Ngay NVARCHAR(50), @LoaiGD CHAR(1),
	@soluongMB INT, @giadatMB FLOAT 
AS
	SET DATEFORMAT DMY
	DECLARE @CrsrVar CURSOR, @ngaydat NVARCHAR(50), @soluong INT,
	@giadat	FLOAT, @soluongkhop INT, @giakhop FLOAT, @ID INT
	IF(@LoaiGD = 'B')--Nếu bán thì nó sẽ chạy sp và xem thằng mua nào đặt trước với giá cao nhất 
		EXEC CursorLoaiGD @CrsrVar OUTPUT, @macp, @Ngay, 'M'
	ELSE --còn mua thì ngược lại
		EXEC CursorLoaiGD @CrsrVar OUTPUT, @macp, @Ngay, 'B'
	FETCH NEXT FROM @CrsrVar INTO @ID, @ngaydat, @soluong, @giadat
	--select @ID, @ngaydat, @soluong, @giadat cua bang lenhdat tao thanh 1 bang roi dua con tro vao bang do
	WHILE(@@FETCH_STATUS <>-1 AND @soluongMB > 0)
	BEGIN
		IF(@LoaiGD = 'B')--nếu gia dịch là bán
			IF(@giadatMB <= @giadat)--if giá bán <= với giá người mua đặt mua
			BEGIN
				IF (@soluongMB > @soluong)
				BEGIN 
					SET @soluongkhop = @soluong
					SET @giakhop = @giadat
					SET @soluongMB = @soluongMB - @soluong --LUC NAY DA MUA DC @SOLUONG VA CAN THEM @soluongMB = @soluongMB - @soluong
					UPDATE dbo.LENHDAT
						SET SOLUONG = 0
						WHERE CURRENT OF @CrsrVar
				END
				ELSE
				BEGIN
					SET @soluongkhop = @soluongMB
					SET @giakhop = @giadat

					UPDATE dbo.LENHDAT 
						SET SOLUONG = SOLUONG - @soluongMB
						WHERE CURRENT OF @CrsrVar 
					SET @soluongMB = 0--luc nay da ban het so co phieu
				END
				--SELECT @soluongkhop, @giakhop
				--Cập nhật table lệnh khớp
					INSERT INTO LENHKHOP(NGAYKHOP, SOLUONGKHOP, GIAKHOP, IDLENHDAT)
						VALUES (GETDATE(),@soluongkhop, @giakhop, @ID)
			END
			ELSE
				GOTO THOAT
		-- Còn Trường hợp lệnh gởi vào là lệnh mua
		ELSE
			IF(@giadatMB>=@giadat)
			BEGIN
				IF(@soluongMB > @soluong)
				BEGIN
					SET @soluongkhop = @soluong
					SET @giakhop = @giadat
					SET @soluongMB = @soluongMB - @soluong
					UPDATE dbo.LENHDAT 
						SET SOLUONG = 0
						WHERE CURRENT OF @CrsrVar
				END
				ELSE
				BEGIN
					SET @soluongkhop = @soluongMB
					SET @giakhop = @giadat
					UPDATE dbo.LENHDAT
						SET SOLUONG = SOLUONG - @soluongMB
						WHERE CURRENT OF @CrsrVar
						SET @soluongMB = 0
				END
				--SELECT @soluongkhop, @giakhop
				--Update table LENHKHOP
				INSERT INTO LENHKHOP(NGAYKHOP, SOLUONGKHOP, GIAKHOP, IDLENHDAT)
						VALUES (GETDATE(),@soluongkhop, @giakhop, @ID)
				
			END
			ELSE
				GOTO THOAT
		FETCH NEXT FROM @CrsrVar INTO @ID, @ngaydat, @soluong, @giadat
	END
	
	THOAT:
	--Update table LENHDAT nếu số lượng mua bán > 0
	IF(@soluongMB>0)
	BEGIN
		INSERT INTO LENHDAT(MACP, NGAYDAT, LOAIGD, LOAILENH, SOLUONG, GIADAT, TRANGTHAILENH)
			VALUES(@macp, GETDATE(), @LoaiGD, N'LO', @soluongMB, @giadatMB, null)
	END
		SELECT SUM(SOLUONGKHOP) FROM dbo.LENHKHOP
		CLOSE @CrsrVar 
		DEALLOCATE @CrsrVar
		


GO
