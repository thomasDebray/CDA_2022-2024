-- use villes_pays

DROP TABLE IF EXISTS Cities;
DROP TABLE IF EXISTS Countries;

CREATE TABLE Countries
(
	country_code CHAR(2),
	country_name VARCHAR(100) NOT NULL
	PRIMARY KEY (country_code)
);

CREATE TABLE Cities
(
	city_id INT IDENTITY,
	city_name VARCHAR(100) NOT NULL,
	country_code CHAR(2) NOT NULL
	PRIMARY KEY (city_id)
	FOREIGN KEY (country_code) REFERENCES Countries(country_code)
);