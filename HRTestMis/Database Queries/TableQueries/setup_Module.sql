Create table Setup_Module(
Id int primary key identity,
Name nvarchar(50) not null,
IsActive bit not null,
CreatedBy nvarchar(50) not null,
CreatedOn datetime not null,
UpdatedBy  nvarchar(50), 
UpdatedOn  datetime 
)
