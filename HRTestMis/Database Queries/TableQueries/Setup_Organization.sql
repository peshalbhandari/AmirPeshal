Create table Setup_Organization(
Id int primary key identity,
Name nvarchar(200) not null,
ShortHandName nvarchar(10),
[Address] nvarchar(200) not null,
Phone1 nvarchar(20) not null,
Phone2 nvarchar(20) ,
Fax nvarchar(20) ,
SiteUrl nvarchar(50) ,
CreatedBy nvarchar(50) not null,
CreatedOn datetime not null,
UpdatedBy  nvarchar(50), 
UpdatedOn  datetime 
)
