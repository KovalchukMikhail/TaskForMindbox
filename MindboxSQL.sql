-- Создание и Установка базы данных
DROP DATABASE IF EXISTS test;
CREATE DATABASE test;
USE test;

-- Создание таблиц  
CREATE TABLE categorys (
	id INT NOT NULL IDENTITY (1 , 1) PRIMARY KEY,
	name VARCHAR(50)
);

CREATE TABLE products (
	id BIGINT NOT NULL IDENTITY (1 , 1) PRIMARY KEY,
	name VARCHAR(50)
);

CREATE TABLE products_with_categorys (
	id BIGINT NOT NULL IDENTITY (1 , 1) PRIMARY KEY,
	id_product BIGINT NOT NULL,
	id_category INT,
	FOREIGN KEY (id_product) REFERENCES products(id),
	FOREIGN KEY (id_category) REFERENCES categorys(id)
);

-- Заполнение таблиц данными
INSERT INTO categorys VALUES 
('Мясо'),
('Молочное'),
('Выпечка');

INSERT INTO products VALUES 
('Говядина'),
('Свинина'),
('Творог'),
('Молоко'),
('Пирог с мясом'),
('Конфеты');

INSERT INTO products_with_categorys (id_product, id_category) VALUES (1, 1);
INSERT INTO products_with_categorys (id_product, id_category) VALUES (2, 1);
INSERT INTO products_with_categorys (id_product, id_category) VALUES (3, 2);
INSERT INTO products_with_categorys (id_product, id_category) VALUES (4, 2);
INSERT INTO products_with_categorys (id_product, id_category) VALUES (5, 1);
INSERT INTO products_with_categorys (id_product, id_category) VALUES (5, 3);
INSERT INTO products_with_categorys (id_product) VALUES (6);

-- Решение задачи
SELECT products.name AS product, categorys.name AS category
FROM products
LEFT JOIN products_with_categorys ON products.id = products_with_categorys.id_product
LEFT JOIN categorys ON categorys.id = products_with_categorys.id_category
ORDER BY product;