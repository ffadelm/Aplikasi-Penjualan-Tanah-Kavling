create database kavlingtanah

CREATE TABLE users(
	id_user INT not null identity(1,1) Primary Key,
	nama varchar(50) not null, 
	no_hp varchar(50) not null,
	kontak varchar(100) null,
	biodata varchar(100) null,
	alamat text not null,
)
ALTER TABLE users ADD foto image;

CREATE TABLE login(
	id_login INT not null identity(1,1) Primary Key,
	username VARCHAR(50) NOT NULL,
	password varchar(50) NOT NULL,
	id_user INT,
	FOREIGN KEY (id_user) REFERENCES users(id_user) 
)

CREATE TABLE tanah(
	id_tanah INT not null identity(1,1) Primary Key,
	judul varchar(50) not null,
	status varchar(50) not null,
	luas varchar(50) not null,
	alamat text not null,
	harga varchar(50) not null,
	foto image null,
	id_user INT,
	FOREIGN KEY (id_user) REFERENCES users(id_user) 
)


/*
Testing

select*from tanah
select*from users
select*from login

delete from users

DROP TABLE login
DROP TABLE tanah
DROP TABLE users

INSERT INTO tanah (judul, status, luas, harga, alamat, foto) 
Values ('Kavling Indo', 'Milik Sendiri', '5000', '75000000', 'jl. indo, kec. mdk, kab. lamut, lpg', '')

insert into users (nama, no_hp, alamat) values ('faysal', '08988765554', 'lampung')

insert into login (username, password, id_user) values ('user', 'user', '1')

SELECT tanah.id_tanah,tanah.judul, tanah.alamat, tanah.harga, users.nama, users.no_hp, users.kontak
FROM ((tanah
INNER JOIN users ON tanah.id_user = users.id_user))

SELECT tanah.id_tanah,tanah.judul, tanah.status,tanah.luas, tanah.alamat, tanah.harga,tanah.foto, users.nama, users.no_hp, users.kontak
FROM ((tanah
tanah INNER JOIN users ON tanah.id_user = users.id_user))

update users set nama = 'Tony Stark', no_hp = '098765678726', alamat = 'Malibu, California', biodata = 'Percayakan kepada kami, kami adalah yang terpercaya',
kontak = 'starkIndustries@mail.com' where id_user = 2
*/