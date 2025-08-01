create table users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR (max) NULL,
	password VARCHAR (max) NULL,
	role VARCHAR (max) NUll,
	status VARCHAR (max) NULL,
	data_reg DATE NUll
)

drop table users
SELECT * from users


INSERT INTO users(username,password,role,status,data_reg) VALUES('admin','admin1234','Admin','Aktif','2025-07-24')