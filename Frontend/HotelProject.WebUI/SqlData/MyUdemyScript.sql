USE [ApiDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abouts]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abouts](
	[AboutID] [int] IDENTITY(1,1) NOT NULL,
	[Title1] [nvarchar](max) NULL,
	[Title2] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[RoomCount] [int] NOT NULL,
	[StaffCount] [int] NOT NULL,
	[CustomerCount] [int] NOT NULL,
 CONSTRAINT [PK_Abouts] PRIMARY KEY CLUSTERED 
(
	[AboutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Gender] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[WorkLocationID] [int] NOT NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [int] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Checkin] [datetime2](7) NOT NULL,
	[CheckOut] [datetime2](7) NOT NULL,
	[AdultCount] [nvarchar](max) NULL,
	[ChildCount] [nvarchar](max) NULL,
	[RoomCount] [nvarchar](max) NULL,
	[SpecialRequest] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[Category] [nvarchar](max) NULL,
	[MessageCategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guests]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[GuestID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
 CONSTRAINT [PK_Guests] PRIMARY KEY CLUSTERED 
(
	[GuestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageCategories]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageCategories](
	[MessageCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[MessageCategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_MessageCategories] PRIMARY KEY CLUSTERED 
(
	[MessageCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [nvarchar](max) NULL,
	[RoomCoverImage] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
	[BedCount] [nvarchar](max) NULL,
	[BatCount] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SendMessages]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SendMessages](
	[SendMessageID] [int] IDENTITY(1,1) NOT NULL,
	[ReceiverName] [nvarchar](max) NULL,
	[ReceiverMail] [nvarchar](max) NULL,
	[SenderName] [nvarchar](max) NULL,
	[SenderMail] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SendMessages] PRIMARY KEY CLUSTERED 
(
	[SendMessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceIcon] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SocialMedia1] [nvarchar](max) NULL,
	[SocialMedia2] [nvarchar](max) NULL,
	[SocialMedia3] [nvarchar](max) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscribes]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscribes](
	[SubscribeID] [int] IDENTITY(1,1) NOT NULL,
	[Mail] [nvarchar](max) NULL,
 CONSTRAINT [PK_Subscribes] PRIMARY KEY CLUSTERED 
(
	[SubscribeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testimonials]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testimonials](
	[TestimonialID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Testimonials] PRIMARY KEY CLUSTERED 
(
	[TestimonialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkLocations]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkLocations](
	[WorkLocationID] [int] IDENTITY(1,1) NOT NULL,
	[WorkLocationName] [nvarchar](max) NULL,
	[WorkLocationCity] [nvarchar](max) NULL,
 CONSTRAINT [PK_WorkLocations] PRIMARY KEY CLUSTERED 
(
	[WorkLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250227101404_mig1', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250228141559_mig_add_identity', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250303124443_migg_add_about', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250304132910_add_mig_booking', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250307110119_mig_add_guest', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250307122104_mig_add_contact', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250310104254_mig_add_SendMessage', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250311132813_migg_MessageCategory', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250313093134_migg_add_imageurl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250313103739_migg_add_worklocation', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250313103949_migg_add_worklocation2', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250313141139_migg_add_countryAndGender', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250317084538_migg_add_booking_city_country', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([AboutID], [Title1], [Title2], [Content], [RoomCount], [StaffCount], [CustomerCount]) VALUES (1, N'Hakkımzıda', N'Hotelier`a Hoş Geldiniz', N'Tatilin tadını doyasıya çıkarın , uzman ekibimiz hizmetinizde..', 3, 4, 6)
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetRoles] ON 

INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (2, N'Member', N'MEMBER', N'e02d9d3f-7cf5-48fd-bd91-92e2d6dcc494')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (5, N'Admin', N'ADMIN', N'e166a954-a5f4-4b75-bd2f-6ba5618fd24d')
SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2, 2)
GO
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [City], [Gender], [Country], [ImageUrl], [UserName], [WorkLocationID], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (2, N'emre', N'binici', N'Bursa', N'Erkek', N'Türkiye', N'/adminweb/images/avatar/1.jpg', N'emre1', 1, N'EMRE1', N'emre@gmail.com', N'EMRE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIBn03eLp4dhO9PnznqHw6KgTpHAg+AJRu0Wg9n7SZxfaWMQDkoa5XsY7DswWzb5Aw==', N'MMNXPS67B7MGPMXOJKLJEUQE2775U4CW', N'5b7899b1-16d4-4ae9-9833-3d786e2004e1', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [City], [Gender], [Country], [ImageUrl], [UserName], [WorkLocationID], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (3, N'Deneme', N'Deniz', NULL, NULL, NULL, NULL, N'Deneme', 1, N'DENEME', N'deneme@gmail.com', N'DENEME@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFVAHS9o4V3ZRPSjCfOEBJ0Pg9lSnNXznkYI9wA7y8FSApPlY9gKM8HOy1qFchZWhQ==', N'T5KKTH3463NZLI2UQYIYVK74ET7JYFKV', N'c644a303-6f4a-48fe-a714-cbdec7bd506a', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (1, N'emre binici', N'emre@gmail.com', CAST(N'2025-04-03T17:37:00.0000000' AS DateTime2), CAST(N'2025-04-07T17:37:00.0000000' AS DateTime2), N'2', N'1', N'2', N'Manzarası Güzel Olsun.', NULL, N'İptal Edildi', N'Bursa', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (2, N'Yunus Binici', N'yunus@gmail.com', CAST(N'2025-07-05T11:52:00.0000000' AS DateTime2), CAST(N'2025-08-03T00:00:00.0000000' AS DateTime2), N'1', N'1', N'2', N'Manzarası Güzel Olsun', NULL, N'Onay Bekleniyor', N'Bursa', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (3, N'Zehra Çınar', N'zehra@gmail.com', CAST(N'2025-07-05T11:52:00.0000000' AS DateTime2), CAST(N'2025-08-03T00:00:00.0000000' AS DateTime2), N'2', N'2', N'1', N'1.Katta Olsun', NULL, N'Onay Bekleniyor', N'İzmir', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (4, N'Ali Kaya', N'ali@gmail.com', CAST(N'2025-07-05T11:52:00.0000000' AS DateTime2), CAST(N'2025-08-03T00:00:00.0000000' AS DateTime2), N'1', N'1', N'1', N'Deniz Manzaralı Olsun', NULL, N'Onaylandı', N'İstanbul', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (5, N'Fatma Çınar', N'fatma@gmail.com', CAST(N'2025-07-05T11:52:00.0000000' AS DateTime2), CAST(N'2025-08-03T00:00:00.0000000' AS DateTime2), N'1', N'1', N'1', N'Sahile Yakın olsun', NULL, N'Onaylandı', N'İzmir', N'Türkiye')
SET IDENTITY_INSERT [dbo].[Bookings] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ContactID], [Name], [Mail], [Subject], [Date], [Category], [MessageCategoryID]) VALUES (1, N'emre', N'binici', N'Her Şey Harikaydı.', CAST(N'2025-03-13T12:07:17.1216408' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (1, N'Ahmet ', N'Çınar', N'Adana')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (2, N'Merve', N'Yılmaz', N'Bursa')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (3, N'Ender', N'Öztürk', N'Ankara')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (4, N'Kerem', N'Meşeli', N'Trabzon')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (5, N'Cemil', N'Narin', N'İstanbul')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (12, N'Emre', N'BİNİCİ', N'Bursa')
SET IDENTITY_INSERT [dbo].[Guests] OFF
GO
SET IDENTITY_INSERT [dbo].[MessageCategories] ON 

INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (1, N'Teşekkür')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (2, N'Şikayet')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (3, N'Öneri')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (4, N'Talep')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (5, N'İş Görüşmesi')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (6, N'Diğer(Belirtiniz)')
SET IDENTITY_INSERT [dbo].[MessageCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomCoverImage], [Price], [BedCount], [BatCount], [Description]) VALUES (2, N'100', N'/hotel/img/room-1.jpg', 1700, N'2', N'2', N'Deniz Manzaralı Aile Odası.')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomCoverImage], [Price], [BedCount], [BatCount], [Description]) VALUES (3, N'101', N'/hotel/img/room-2.jpg', 1600, N'3', N'3', N'Doğadan Vazgeçemem Diyenlere.')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomCoverImage], [Price], [BedCount], [BatCount], [Description]) VALUES (4, N'102', N'/hotel/img/room-3.jpg', 1700, N'4', N'4', N'Rahatına Düşkünler için .')
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO
SET IDENTITY_INSERT [dbo].[SendMessages] ON 

INSERT [dbo].[SendMessages] ([SendMessageID], [ReceiverName], [ReceiverMail], [SenderName], [SenderMail], [Title], [Content], [Date]) VALUES (2, N'Emre', N'emre@gmail.com', N'admin', N'Admin@gmail.com', N'Maç', N'Akşam 8-9 Maça Gelir Misin?', CAST(N'2025-03-10T14:58:00.3972099' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SendMessages] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [Title], [Description]) VALUES (3, N'fa fa-hotel fa-2x text-primary', N'Odalar & Daireler', N'Uzman kadromuz ile hizmeti doruklara çıkarıyoruz. Konforun tadını çıkarın. ')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [Title], [Description]) VALUES (5, N'fa fa-utensils fa-2x text-primary', N'Yemek & Restorant', N'Dünya mutfağına sahip , yurt dışında eğitim almış şeflerimiz ile hizmet veriyoruz')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [Title], [Description]) VALUES (6, N'fa fa-spa fa-2x text-primary', N'Spa & Fitness', N'Alanında uzman kişiler ile masaj keyfini farklı bir noktaya çıkardık.')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [Title], [Description]) VALUES (7, N'fa fa-swimmer fa-2x text-primary', N'Spor & Eğlence', N'Hem spor hem eğlenceyi bir araya getirdik , üstelik bu himeti her gün veriyoruz.')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [Title], [Description]) VALUES (8, N'fa fa-glass-cheers fa-2x text-primary', N'Event & Partiler', N'Özel geceler ile eğlenceyi dorukluyoruz, süpriz etkinlikler ve partiler sizi bekliyor.')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [Title], [Description]) VALUES (9, N'fa fa-dumbbell fa-2x text-primary', N'Gym & Yoga', N'Ödüllü hocalarımız ile her sabah Gym etkinliği sizi bekliyor , sağlığınız önceliğimizdir.')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffID], [Name], [Title], [SocialMedia1], [SocialMedia2], [SocialMedia3]) VALUES (1, N'Ali Kaya', N'Direktör', N'/hotel/img/team-1.jpg', N'fab fa-facebook-f', N'fab fa-twitter')
INSERT [dbo].[Staff] ([StaffID], [Name], [Title], [SocialMedia1], [SocialMedia2], [SocialMedia3]) VALUES (14, N'Mehmet Çınar', N'Ceo', N'/hotel/img/team-2.jpg', N'fab fa-facebook-f', N'fab fa-twitter')
INSERT [dbo].[Staff] ([StaffID], [Name], [Title], [SocialMedia1], [SocialMedia2], [SocialMedia3]) VALUES (15, N'Selman Uzun', N'İşletme Müdürü', N'/hotel/img/team-3.jpg', N'fab fa-facebook-f', N'fab fa-twitter')
INSERT [dbo].[Staff] ([StaffID], [Name], [Title], [SocialMedia1], [SocialMedia2], [SocialMedia3]) VALUES (16, N'Veli Yılmaz', N'Muhasebe Uzmanı', N'/hotel/img/team-4.jpg', N'fab fa-facebook-f', N'fab fa-twitter')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscribes] ON 

INSERT [dbo].[Subscribes] ([SubscribeID], [Mail]) VALUES (2, N'emre@gmail.com')
INSERT [dbo].[Subscribes] ([SubscribeID], [Mail]) VALUES (3, N'veli@gmail.com')
INSERT [dbo].[Subscribes] ([SubscribeID], [Mail]) VALUES (4, N'ayşe@gmail.com')
SET IDENTITY_INSERT [dbo].[Subscribes] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [Title], [Description], [Image]) VALUES (2, N'Ayşe Yılmaz', N'Genel Kordinatör', N'Ailemle birlikte harika bir hafta sonu geçirdim, etkisinden hala çıkamadım.', N'/hotel/img/testimonial-1.jpg')
INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [Title], [Description], [Image]) VALUES (3, N'Mesut Yılmaz', N'IT Manager', N'Daha önce hiç bu kadar eğlendiğimi hatırlamıyorum .', N'/hotel/img/testimonial-2.jpg')
INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [Title], [Description], [Image]) VALUES (4, N'Emre Seri', N'Developer', N'Denizin mansarası içimi huzurla doldurdu , hizmet kusursuzdu.', N'/hotel/img/testimonial-3.jpg')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkLocations] ON 

INSERT [dbo].[WorkLocations] ([WorkLocationID], [WorkLocationName], [WorkLocationCity]) VALUES (1, N'Kadıköy Hotelier', N'İstanbul')
INSERT [dbo].[WorkLocations] ([WorkLocationID], [WorkLocationName], [WorkLocationCity]) VALUES (2, N'Bostancı Hotelier Plaza', N'İstanbul')
INSERT [dbo].[WorkLocations] ([WorkLocationID], [WorkLocationName], [WorkLocationCity]) VALUES (3, N'Datça Butik Hotelier', N'Muğla')
INSERT [dbo].[WorkLocations] ([WorkLocationID], [WorkLocationName], [WorkLocationCity]) VALUES (4, N'Adrasan Butik Hotelier', N'Antalya')
SET IDENTITY_INSERT [dbo].[WorkLocations] OFF
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12.06.2025 22:48:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUsers_WorkLocationID]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_WorkLocationID] ON [dbo].[AspNetUsers]
(
	[WorkLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12.06.2025 22:48:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Contacts_MessageCategoryID]    Script Date: 12.06.2025 22:48:09 ******/
CREATE NONCLUSTERED INDEX [IX_Contacts_MessageCategoryID] ON [dbo].[Contacts]
(
	[MessageCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  CONSTRAINT [DF__AspNetUse__WorkL__3A4CA8FD]  DEFAULT ((0)) FOR [WorkLocationID]
GO
ALTER TABLE [dbo].[Contacts] ADD  DEFAULT ((0)) FOR [MessageCategoryID]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_WorkLocations_WorkLocationID] FOREIGN KEY([WorkLocationID])
REFERENCES [dbo].[WorkLocations] ([WorkLocationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_WorkLocations_WorkLocationID]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_MessageCategories_MessageCategoryID] FOREIGN KEY([MessageCategoryID])
REFERENCES [dbo].[MessageCategories] ([MessageCategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_MessageCategories_MessageCategoryID]
GO
/****** Object:  Trigger [dbo].[CustomerDecrease]    Script Date: 12.06.2025 22:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[CustomerDecrease]
on [dbo].[Guests]
after delete
as
begin
declare @customerCount int;
set @customerCount=(select Count(*) from Guests )
update Abouts set CustomerCount=@customerCount
end
GO
ALTER TABLE [dbo].[Guests] ENABLE TRIGGER [CustomerDecrease]
GO
/****** Object:  Trigger [dbo].[Customerincrease]    Script Date: 12.06.2025 22:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Customerincrease]
on [dbo].[Guests]
after insert
as
begin
declare @customerCount int;
set @customerCount=(select count(*) from Guests)
update Abouts set CustomerCount=@customerCount
end	
GO
ALTER TABLE [dbo].[Guests] ENABLE TRIGGER [Customerincrease]
GO
/****** Object:  Trigger [dbo].[RoomDecrease]    Script Date: 12.06.2025 22:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[RoomDecrease] 
on [dbo].[Rooms]
after delete
as
begin
declare @RoomCount int;
set @RoomCount =(select count(*) from Rooms)
Update Abouts set RoomCount=@RoomCount
end
GO
ALTER TABLE [dbo].[Rooms] ENABLE TRIGGER [RoomDecrease]
GO
/****** Object:  Trigger [dbo].[Roomincrease]    Script Date: 12.06.2025 22:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Roomincrease] 
on [dbo].[Rooms]
after Insert
as
begin
declare  @roomCount int;
set @roomCount=(Select Count(*) From Rooms);
Update Abouts set RoomCount=@roomCount
end
GO
ALTER TABLE [dbo].[Rooms] ENABLE TRIGGER [Roomincrease]
GO
/****** Object:  Trigger [dbo].[StaffDecrease]    Script Date: 12.06.2025 22:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[StaffDecrease]
on [dbo].[Staff]
after delete
as
begin
declare @staffCount int
set @staffCount=(select count(*) from Staff)
update Abouts set StaffCount=@staffCount
end
GO
ALTER TABLE [dbo].[Staff] ENABLE TRIGGER [StaffDecrease]
GO
/****** Object:  Trigger [dbo].[Staffincrease]    Script Date: 12.06.2025 22:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Staffincrease]
on [dbo].[Staff]
after insert
as
begin
declare @staffCount int;
set @staffCount=(select count(*) from Staff)
update Abouts set StaffCount=@staffCount
end
GO
ALTER TABLE [dbo].[Staff] ENABLE TRIGGER [Staffincrease]
GO
