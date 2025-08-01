create table users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR (max) NULL,
	password VARCHAR (max) NULL,
	role VARCHAR (max) NUll,
	status VARCHAR (max) NULL,
	data_reg DATETIME NUll
)

drop table users
SELECT * from users
SELECT COUNT(*) FROM users WHERE role = 'Kasir'
alter table users alter column data_reg datetime;
SELECT SUM(total_price) FROM orders WHERE order_date = DateTime.Now.Date
SELECT SUM(total_price) FROM orders WHERE CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)


INSERT INTO users(username,password,role,status,data_reg) VALUES('admin','admin1234','Admin','Aktif','2025-07-24')
INSERT INTO users(username,password,role,status,data_reg) VALUES('admin2','admin1234','Admin','Aktif','2025-07-24')
INSERT INTO users(username,password,role,status,data_reg) VALUES('admin2','admin1234','Kasir','Aktif','2025-07-24')
INSERT INTO users(username,password,role,status,data_reg) VALUES('juned','admin1234','Kasir','Aktif','2025-07-24')

UPDATE users SET username = 'kasir' WHERE id = 3


create table products(
	id INT PRIMARY KEY IDENTITY(1,1),
	product_id VARCHAR (max) NULL,
	product_name VARCHAR (max) NULL,
	product_tipe VARCHAR (max) NULL,
	product_stock INT NULL,
	product_price FLOAT NULL,
	product_status VARCHAR (max) NULL,
	product_image VARCHAR (max) NULL,
	date_insert DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL
)
drop table products
Insert into products(product_id,product_name,product_tipe,product_stock,product_price,product_status,product_image,date_insert,date_update,date_delete) values('Makanan-1','Kebab','Makanan',100,20000,'Tersedia','','2025-07-24',NULL,NULL)
Insert into products(product_id,product_name,product_tipe,product_stock,product_price,product_status,product_image,date_insert,date_update,date_delete) values('Makanan-1','SUsu','Minuman',100,5000,'Tersedia','','2025-07-24',NULL,NULL)
Insert into products(product_id,product_name,product_tipe,product_stock,product_price,product_status,product_image,date_insert,date_update,date_delete) values('Makanan-5','Ayam Goreng','Makanan',0,15000,'Tidak Tersedia','','2025-07-24',NULL,NULL)

SELECT * from products

use kasir
DELETE products WHERE id = 5
DELETE products WHERE id = 6
DELETE products WHERE id = 7

update products set product_id = 'Minuman-1' where id = 2
ALTER TABLE products ALTER COLUMN date_insert DATETIME;
ALTER TABLE products ALTER COLUMN date_update DATETIME;
ALTER TABLE products ALTER COLUMN date_delete DATETIME;
ALTER TABLE products DROP COLUMN date_delete;



create table orders
(
	id INT PRIMARY KEY IDENTITY(1,1),	
	customer_id INT NULL,
	product_id VARCHAR (max) NULL,
	product_name VARCHAR (max) NULL,
	product_tipe VARCHAR (max) NULL,
	product_price FLOAT NULL,
	product_quantity INT NULL,
	total_price FLOAT NULL,
	order_date DATETIME NULL,
	delete_date DATETIME NULL,
)

select * from orders
drop table orders
delete from orders where customer_id = 1


create table customers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	total_price FLOAT NULL,
	pay FLOAT NULL,
	change FLOAT NULL,
	date DATETIME NULL,
)

select * from customers
EXECUTE sp_rename 'customers.amount', 'pay', 'COLUMN'

SELECT * FROM orders WHERE customer_id = 1
drop table customers

select SUM(amount) from customers