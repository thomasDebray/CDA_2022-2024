-- use cars

-- 1 Sélectionner le nom et le numéro d’immatriculation de toutes les voitures triées par immatriculation (ordre croissant).

SELECT car_name,car_registration
FROM cars
ORDER BY car_registration ASC;

-- 2 Sélectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et prénom du propriétaire. Trier la liste par nom de marque (ordre croissant) puis par nom de propriétaire (ordre croissant).

SELECT brand_name, owner_lastname, owner_firstname
FROM cars 
JOIN brands ON cars.brand_id = brands.brand_id
JOIN owners ON cars.car_owner_id = owners.owner_id
ORDER BY brand_name ASC, owner_lastname ASC;

-- 3 Sélectionner le nom de toutes les marques incluant le nombre de voitures de chaque marque.

SELECT brand_name,
COUNT (car_id) AS 'Number of car'
FROM cars
JOIN brands on cars.brand_id = brands.brand_id
GROUP BY brand_name;

-- 4 Sélectionner le nom de toutes les marques incluant le nombre de propriétaires de chaque marque.

SELECT brand_name,
COUNT (DISTINCT car_owner_id) AS 'Number of owner'
FROM cars
JOIN brands ON cars.brand_id = brands.brand_id
GROUP BY brand_name;

-- 5 Sélectionner les prénoms des propriétaires dont le prénom commence par la lettre A.

SELECT owner_firstname FROM owners WHERE owner_firstname LIKE 'A%';

-- 6 Sélectionner le noms et prénom des propriétaires dont le prénom contient plus de 5 lettres.

SELECT owner_firstname, owner_lastname 
FROM owners
WHERE owner_lastname LIKE '______%';-- LEN(owner_lastname) > 5

-- 7 Sélectionner les noms et prénoms des propriétaires possédant plus d’une voiture avec le nombre de voitures possédées par propriétaire. Trier la liste par nombre de voitures possédées. Les propriétaires possédant le plus de voitures apparaissent en 1er.

SELECT owner_lastname, owner_firstname,
COUNT (car_owner_id) AS Number_of_car
FROM cars 
JOIN owners ON cars.car_owner_id = owners.owner_id
WHERE Number_of_car > 1
GROUP BY owner_lastname, owner_firstname;

SELECT * 
FROM cars
JOIN owners ON cars.car_owner_id = owners.owner_id;