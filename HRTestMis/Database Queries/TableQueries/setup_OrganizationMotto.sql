use HRTestMIS
Create table setup_OrganizationMotto(
Id int primary key identity,
Slogan nvarchar(300) not null,
IsActive bit not null,
IsPrimary bit not null,
CreatedBy nvarchar(50) not null,
CreatedOn datetime not null,
UpdatedBy  nvarchar(50), 
UpdatedOn  datetime 
)