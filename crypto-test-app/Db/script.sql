USE [crypto]
GO
/****** Object:  Table [dbo].[coin_community]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_community](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[facebook_likes] [nvarchar](50) NULL,
	[twitter_followers] [nvarchar](50) NULL,
	[reddit_average_posts_48h] [nvarchar](50) NULL,
	[reddit_average_comments_48h] [nvarchar](50) NULL,
	[reddit_subscribers] [nvarchar](50) NULL,
	[reddit_accounts_active_48h] [nvarchar](50) NULL,
	[telegram_channel_user_count] [nvarchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_community] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detaillinks]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detaillinks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[twitter_screen_name] [nvarchar](50) NULL,
	[facebook_username] [nvarchar](50) NULL,
	[bitcointalk_thread_identifier] [nvarchar](50) NULL,
	[telegram_channel_identifier] [nvarchar](50) NULL,
	[subreddit_url] [nvarchar](255) NULL,
	[created_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detaillinks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_14dprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_14dprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_14dprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_1hprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_1hprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_1hprice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_1yprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_1yprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_1yprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_200dprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_200dprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_200dprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_24hprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_24hprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_24hprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_30dprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_30dprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_30dprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_60dprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_60dprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_60dprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_7dprices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_7dprices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_7dprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarket_prices]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarket_prices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[try] [decimal](18, 3) NULL,
	[eur] [decimal](18, 3) NULL,
	[usd] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmeta_prices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailmarkets]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailmarkets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[price_change_percentage_24h] [decimal](18, 3) NULL,
	[price_change_percentage_7d] [decimal](18, 3) NULL,
	[price_change_percentage_14d] [decimal](18, 3) NULL,
	[price_change_percentage_30d] [decimal](18, 3) NULL,
	[price_change_percentage_60d] [decimal](18, 3) NULL,
	[price_change_percentage_200d] [decimal](18, 3) NULL,
	[price_change_percentage_1y] [decimal](18, 3) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailmetas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_details]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[coin_name] [nvarchar](50) NULL,
	[coin_symbol] [nvarchar](50) NULL,
	[asset_platform_id] [nvarchar](50) NULL,
	[block_time_in_minutes] [int] NULL,
	[hashing_algorithm] [nvarchar](50) NULL,
	[categories] [nvarchar](50) NULL,
	[localization] [nvarchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[image_thumb] [nvarchar](255) NULL,
	[image_small] [nvarchar](255) NULL,
	[image_large] [nvarchar](255) NULL,
	[country_origin] [nvarchar](50) NULL,
	[genesis_date] [date] NULL,
	[sentiment_votes_up_percentage] [decimal](18, 0) NULL,
	[sentiment_votes_down_percentage] [decimal](18, 0) NULL,
	[market_cap_rank] [decimal](18, 0) NULL,
	[coingecko_rank] [decimal](18, 0) NULL,
	[coingecko_score] [decimal](18, 0) NULL,
	[developer_score] [decimal](18, 0) NULL,
	[community_score] [decimal](18, 0) NULL,
	[liquidity_score] [decimal](18, 0) NULL,
	[public_interest_score] [decimal](18, 0) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_coin_details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coin_detailurls]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coin_detailurls](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NULL,
	[type] [int] NULL,
	[url] [nvarchar](255) NULL,
	[created_date] [datetime] NULL,
 CONSTRAINT [PK_coin_detailurls] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coins]    Script Date: 26.12.2019 15:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coin_id] [nvarchar](50) NOT NULL,
	[coin_name] [nvarchar](50) NOT NULL,
	[coin_symbol] [nvarchar](50) NOT NULL,
	[is_listed] [bit] NULL,
 CONSTRAINT [PK_coins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
