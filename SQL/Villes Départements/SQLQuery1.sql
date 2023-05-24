

-- 1. Obtenir la liste des 10 villes les plus peuplées en 2012

SELECT TOP 10 *
FROM villes_france_free
ORDER BY ville_population_2012 DESC

-- 2. Obtenir la liste des 50 villes ayant la plus faible superficie

SELECT TOP 50 *
FROM villes_france_free
WHERE ville_population_2012 >0
ORDER BY ville_population_2012 ASC

-- 3. Obtenir la liste des départements d’outres-mer, c’est-à-dire ceux dont le numéro de département commencent par “97”

SELECT departement_nom
FROM departement
WHERE departement_code LIKE '97%'

-- 4. Obtenir le nom des 10 villes les plus peuplées en 2012, ainsi que le nom du département associé

SELECT TOP 10 ville_nom, departement_nom
FROM villes_france_free JOIN departement ON villes_france_free.ville_departement = departement.departement_code
ORDER BY ville_population_2012 DESC

-- 5. Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces département, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes

SELECT departement_nom, departement_code,
COUNT (villes_france_free.ville_departement) AS 'Nombre de villes'
FROM departement JOIN villes_france_free ON departement.departement_code = villes_france_free.ville_departement
GROUP BY departement_nom, departement_code
ORDER BY 'Nombre de villes' DESC;

-- 6. Obtenir la liste des 10 plus grands départements, en termes de superficie

SELECT TOP 10 departement_nom, departement_code,
SUM (ville_surface) AS 'Superficie du département'
FROM departement JOIN villes_france_free ON departement.departement_code = villes_france_free.ville_departement
GROUP BY departement_code, departement_nom
ORDER BY 'Superficie du département' DESC;

-- 7. Compter le nombre de villes dont le nom commence par “Saint”

SELECT COUNT (ville_nom) AS 'Villes commençant par saint'
FROM villes_france_free
WHERE ville_nom LIKE 'saint%';

-- 8. Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d’obtenir en premier celles dont le nom est le plus souvent utilisé par plusieurs communes

SELECT V0.ville_nom,
COUNT (V0.ville_nom) AS 'Nombre de ville'
FROM villes_france_free AS V0 --JOIN villes_france_free AS V1 ON V0.ville_nom_simple = V1.ville_nom_simple
GROUP BY V0.ville_nom
HAVING COUNT(V0.ville_nom) > 1
ORDER BY 'Nombre de ville' DESC

-- 9. Obtenir en une seule requête SQL la liste des villes dont la superficie est supérieur à la superficie moyenne

SELECT ville_nom FROM villes_france_free
WHERE ville_surface > (SELECT AVG(ville_surface) FROM villes_france_free)

-- 10. Obtenir la liste des départements qui possèdent plus de 2 millions d’habitants

SELECT departement_nom, SUM(villes_france_free.ville_population_2012)
FROM departement JOIN villes_france_free ON villes_france_free.ville_departement = departement.departement_code
GROUP BY departement_nom
HAVING SUM(villes_france_free.ville_population_2012) > 2000000

-- 11. Remplacez les tirets par un espace vide, pour toutes les villes commençant par “SAINT-” (dans la colonne qui contient les noms en majuscule).

SELECT REPLACE (ville_nom,'-',' ') FROM villes_france_free
WHERE ville_nom LIKE 'SAINT-%'
