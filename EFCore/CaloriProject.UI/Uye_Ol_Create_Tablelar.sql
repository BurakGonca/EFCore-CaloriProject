create table users
(
	id int primary key identity(1,1),
	Cinsiyet nvarchar(10) not null,
	Ad nvarchar(50) not null,
	Soyad nvarchar(50) not null,
	DogumTarihi date not null,
	Kilo smallint not null,
	Boy smallint not null,
	Email nvarchar(50) not null,
	Sifre nvarchar(50) not null,
	SifreTekrar nvarchar(10) not null 

)