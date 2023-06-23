drop table if exists products;
drop table if exists customers;
drop table if exists orders;

create table products(
	id int not null identity, 
	name varchar(100) not null,
	description text null,
	price numeric(10,2) default 0.0,
	quantity int default 0,
	created_at smalldatetime not null default current_timestamp,
	modified_at smalldatetime default null,
	primary key (id)
);
create table customers(
	id int not null identity,
	full_name varchar(100) not null,
	document varchar(14) unique not null,
	is_legal_person bit default 0,
	created_at smalldatetime not null default current_timestamp,
	modified_at smalldatetime default null,
	primary key (id)
);
create table orders(
	id int not null identity,	
	order_number char(14) not null,
	customer_id int,
	product_id int,
	product_quantity int not null,
	product_total decimal(10,2) not null,
	created_at smalldatetime not null default current_timestamp,
	modified_at smalldatetime default null,

	primary key(id),
	constraint pk_customer_id 
		foreign key (customer_id) 
			references customers(id) 
				on delete set null
					on update cascade,

	constraint pk_product_id 
		foreign key (product_id) 
			references products(id) 
				on delete set null
					on update cascade
);

insert into products (name, description, price, quantity) 
values 
	('Garrafa Térmica Azul', null, 30.0, 150),
	('Garrafa Térmica Rosa', null, 30.0, 150),
	('Garrafa Térmica Lilás', null, 30.0, 150),
	('Garrafa Térmica Laranja', 'uma garrafa', 30.0, 150),
	('Garrafa Térmica Vermelho', 'Lorem ipsers liders', 30.0, 150),
	('Garrafa Térmica Branca', null, 30.0, 150),
	('Copos plásticos', null, 5.0, 90),
	('Pratos plásticos', null, 6.0, 90);
insert into customers (full_name, document)
values
	('Mercedes Bens', '39483713005'),
	('Roberto Almeida', '15516527066'),
	('Daniela Lima', '37981179009'),
	('Daniel Silva', '97848368076');
insert into customers (full_name, document, is_legal_person)
values
	('WPC Sistemas', '63301787000141', 1),
	('Felix e Navarro Imobiliaria', '67146778000184', 1),
	('Larissa Pretes 26109553000170', '26109553000170', 1),
	('Rosana Araujo 35769832000151', '35769832000151', 1);
