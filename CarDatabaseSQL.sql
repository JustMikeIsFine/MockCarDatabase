USE [Car_Rental_Service]
GO

Create Table [dbo].[Reservation](
	[R_ID] int,
	[date_start] Date,
	[date_stop] Date,
	[B_Pickup_ID] int,
	[B_Return_ID] int,
	[E_ID] int,
	[Car_ID] int,
	[C_ID] int,
	Primary Key (R_ID)
);

Create Table [dbo].[Branch](
	B_ID int,
	street_No int,
	street_name varchar(20),
	city varchar(20),
	province varchar(20),
	postal_code varchar(10),
	Primary Key (B_ID)
);

Create Table [dbo].[Employees](
	E_ID int,
	f_name varchar(20),
	l_name varchar(20),
	salary int,
	DL_No int,
	Primary Key (E_ID)
);

Create Table [dbo].[Cars](
	Car_ID int,
	year int, 
	make varchar(20), 
	model varchar(20), 
	date_of_purchase Date, 
	mileage int, 
	condition varchar(20), 
	transmission varchar(20), 
	T_ID varchar(20),
	Primary Key (Car_ID)
);

Create Table [dbo].[Type](
	T_ID varchar(20),
	day_price int,
	week_price int,
	month_price int,
	Primary Key (T_ID)
);

Create Table [dbo].[Customer](
	C_ID int,
	f_name varchar(20),
	l_name varchar(20),
	date_of_birth Date,
	DL_No bigint,
	insur_provider varchar(20),
	insur_policy_No bigint,
	Primary Key (C_ID)
);

Create Table [dbo].[Phone](
	C_ID int,
	Phone_No varchar(20)
);

Create Table [dbo].[Login](
	U_ID varchar(20) not null,
	P_ID varchar(20) not null,
	Primary Key (U_ID, P_ID)
);

/** Append FKs **/

Alter Table [dbo].[Cars] add Foreign Key (T_ID) References Type(T_ID);
Alter Table [dbo].[Reservation] add 
	Foreign Key (B_Pickup_ID) References Branch(B_ID),
	Foreign Key (B_Return_ID) References Branch(B_ID),
	Foreign Key (E_ID) References Employee(E_ID),
	Foreign Key (Car_ID) References Cars(Car_ID),
	Foreign Key (C_ID) References Customer(C_ID);
	
