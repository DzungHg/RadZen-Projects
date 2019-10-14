USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblGN_Product]    Script Date: 10/13/2019 2:54:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblGN_Product](
	[Product_SEQ] [int] IDENTITY(1,1) NOT NULL,
	[Product_ID] [char](5) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	
 CONSTRAINT [pk_tblIC_Product] PRIMARY KEY CLUSTERED 
(
	[Product_SEQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

