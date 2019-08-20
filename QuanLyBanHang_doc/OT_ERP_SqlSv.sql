CREATE DATABASE OT_ERP
-----------------------------------------------------
-----------------------------------------------------
---------------------------------------------USE QLBH
-- KHACHANG
CREATE TABLE tblSO_Customer(
	Customer_SEQ int identity (1, 1) not null,
	Customer_ID	char(10) not null,	
	LastName	nvarchar(50),
	FirstName	nvarchar(50),
	CustomerAdressBook_FK int,
	CreditLimit money,
	LastRevisedCreditLimitDate datetime,
	PaymentTerm_FK int,
	PaymentType_FK int,
	DiscountPercent int,
	Current_MTD_Sales money,
	Current_MTD_Returns money,
	YTD_GrossSales money,
	YTD_Returns money,
	YTD_COGS money,
	LYR_GrossSales money,
	LYR_COGS money,
	LastAmountSales money,
	SalesPersonAdressBook_FK,
	Commission double,
	Salesperson_MTD_Goal money,
	SalesPerson_YTD_Goal money,
	ChargeInterest bit,
	Statement bit,
	Aging30DayAmout money,
	Aging60DayAmout money,
	Aging90DayAmout money,
	Notes ntext,
	LastUpdatedDate datetime,
	LastUdpatedBy int,
	Inactive bit,
	
	constraint pk_Customer_CustSEO primary key(Customer_SEQ)
)
---------------------------------------------
-- Bang do dim PaymentType va PaymentTerms

CREATE TABLE tblGN_PaymentTerms(
	PaymentTerm_SEQ int identity (1, 1) not null,
	PaymentTermText	nvarchar(50) not null,	
	PaymentTerm_ID	char(20) not null,
	
	constraint pk_paymentterm_PMTSEQ primary key(PaymentTerm_SEQ)
)
CREATE TABLE tblGN_PaymentType(
	PaymentType_SEQ int identity (1, 1) not null,
	PaymentTypeText	nvarchar(50) not null,	
	PaymentType_ID	char(20) not null,
	
	constraint pk_paymtype_PMTSEQ primary key(PaymentType_SEQ)
)

---------------------------------------------
-- Bang do tim Addressbook

CREATE TABLE tblGN_AddressBook(
	AddressBook_SEQ int identity (1, 1) not null,
	AddressBook_ID	char(10) not null,
	AddressBookType_FK int,
	LastName	nvarchar(50),
	FirstName	nvarchar(50),
	Gender	nvarchar(50),
	DOB nvarchar(50),
	Origin nvarchar(50),
	IDNumber char(20),
	TaxIDNumber char (10),
	OrganizationName	nvarchar(100),
	JobPosition nvarchar(50),	
	constraint pk_addbook_AddBookSEQ primary key(AddressBook_SEQ)
)
---------------------------------------------
-- bang SaleOrder va tap tin chi tiet tblSO_OrderDetail
CREATE TABLE tblSO_SalesOrder(
	SO_SEQ int identity (1, 1) not null,
	SO_ID	char(15) not null,
	SODate datetime,
	CreatedBy_FK int,
	SOStatus_FK int,
	Customer_FK int,
	CustomerPONumber nvarchar(15),
	CustomerPODate datetime,
	BillTo_FK int,
	ShipTo_FK int,
	Attention nvarchar(100),
	ShipVia_FK int,
	ActualShipDate datetime,
	ExpectedShipDate datetime,
	Shipper_FK int,
	PaymentTerm_FK int,
	PaymentType_FK int,
	SalesPersion_FK int,
	Commission money,
	Pick_No int,
	Ship_No int,
	TaxYN bit,
	TaxtRate double,
	Subtotal money,
	Taxt_Amount money,
	Discount_Amt money,
	Freight money,
	Total_Order AS Subtotal + Taxt_Amount - Discount_Amt + Freight,
	Description ntext,
	ChangeLong ntext,
	Notes ntext,
	LastUpdatedDate datetime,
	LastUpdatedBy_FK int,
	Inactive bit,
	Sequence int,
	
	constraint pk_salesorder_SOSEQ primary key(SO_SEQ)
		
)
---------------------------------------------
-- Tao bang do tim tlblGN_ShipVia va tblSO_OrderStatus
CREATE TABLE tblGN_ShipVia(
	ShipVia_SEQ int identity (1, 1) not null,
	ShipVia_ID	nchar(25) not null,
	Description nvarchar(50),
	
	constraint pk_shipvia_ShipViaSEQ primary key (ShipVia_SEQ)
)
 CREATE TABLE tblSO_OrderStatus(
	SOStatus_SEQ int identity (1, 1) not null,
	SOStatus_ID	nchar(20) not null,
	SOStatusText nvarchar(50),
	Description nvarchar(255),
	
	constraint pk_orderstatus_SOSSEQ primary key (SOStatus_SEQ)
)
---------------------------------------------
-- Tao bang do tim tblSO_OrderDetail
CREATE TABLE tblSO_OrderDetail(
	SODetail_SEQ int identity (1, 1) not null,
	SODetailStatus_FK	int,
	SO_FK int,
	Inventory_FK int,
	UnitPrice money,
	QtyOnHand int,
	QtyOrdered int,
	QtyOrderedNow int,
	QtyBackOrdered int,
	QtyPicked int,
	SubTotal AS QtyOrderedNow * UnitPrice,
	DiscountPercent double,
	Discount As QtyOrderedNow * UnitPrice * DiscountPercent,
	TaxRate double,
	Tax AS QtyOrderedNow * UnitPrice * TaxRate,
	
	constraint pk_orderdetail_ODTSEQ primary key (SODetail_SEQ)
)
CREATE TABLE tblSO_OrderDetailStatus(
	SODetailStatus_SEQ int identity (1, 1) not null,
	SODetailStatus_ID int,
	SODetailStatusText nvarchar(50),
	Description nvarchar(255),
	
	constraint pk_orderDetailstatus_ODTSSEQ primary key (SODetailStatus_SEQ)
)

-- Khoa ngoai cho bang HOADON

-----------------------------------------------------
-----------------------------------------------------
