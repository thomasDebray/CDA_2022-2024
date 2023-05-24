-- use villes_pays

INSERT INTO Countries
(country_code, country_name)
VALUES
('FR','France'),
('US','United States'),
('RU','Russian Federation');

-- SELECT country_code,country_name FROM Countries;

INSERT INTO Cities
(city_name, country_code)
VALUES
('Paris','FR'),
('Lyon','FR'),
('Toulouse','FR'),
('Marseille','FR'),
('Mulhouse','FR'),
('Boston','US'),
('Los Angeles','US'),
('Washington','US'),
('New York','US'),
('Moscou','RU'),
('Saint-Pétersbourg','RU');

-- SELECT * FROM Cities;