-- use villes_pays;

-- 1 Sélectionner le nom de toutes les villes

SELECT city_name FROM Cities;

-- 2 Sélectionner l’identifiant et le nom de toutes les villes triées par nom de ville et par ordre alphabétique.

SELECT city_id,city_name FROM Cities
ORDER BY city_name;

-- 3 Sélectionner toutes les villes avec le nom du pays associé à chaque ville. Trier la liste par code pays et par ordre alphabétique inverse.

SELECT 
city_name,
Countries.country_name
FROM Cities JOIN Countries ON Cities.country_code = Countries.country_code
ORDER BY Cities.country_code DESC;

-- 4 Sélectionner le code ISO et le nom de tous les pays avec le nombre de villes par pays. Les pays avec le moins de villes apparaissent en 1er.

SELECT
Countries.country_code,
COUNT (Countries.country_code) AS 'number of cities'
FROM Countries JOIN Cities ON Countries.country_code = Cities.country_code
GROUP BY Countries.country_code
ORDER BY 'number of cities' ASC;

-- 5

SELECT
Ci0.city_id AS 'City Id',
Ci0.city_name AS 'City Name',
Countries.country_code AS 'Country Code',
country_name AS 'Country Name',
COUNT (Ci1.country_code) AS 'Number of cities'
FROM Cities AS Ci0 
JOIN Countries ON Ci0.country_code = Countries.country_code
JOIN Cities AS Ci1 ON Countries.country_code = Ci1.country_code 
GROUP BY Ci0.city_id, Ci0.city_name, country_name, Countries.country_code;