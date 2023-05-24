

-- 1. Obtenir la liste des 10 villes les plus peupl�es en 2012

SELECT TOP 10 *
FROM villes_france_free
ORDER BY ville_population_2012 DESC

-- 2. Obtenir la liste des 50 villes ayant la plus faible superficie

SELECT TOP 50 *
FROM villes_france_free
WHERE ville_population_2012 >0
ORDER BY ville_population_2012 ASC

-- 3. Obtenir la liste des d�partements d�outres-mer, c�est-�-dire ceux dont le num�ro de d�partement commencent par �97�

SELECT departement_nom
FROM departement
WHERE departement_code LIKE '97%'

-- 4. Obtenir le nom des 10 villes les plus peupl�es en 2012, ainsi que le nom du d�partement associ�

SELECT TOP 10 ville_nom, departement_nom
FROM villes_france_free JOIN departement ON villes_france_free.ville_departement = departement.departement_code
ORDER BY ville_population_2012 DESC

-- 5. Obtenir la liste du nom de chaque d�partement, associ� � son code et du nombre de commune au sein de ces d�partement, en triant afin d�obtenir en priorit� les d�partements qui poss�dent le plus de communes

SELECT departement_nom, departement_code,
COUNT (villes_france_free.ville_departement) AS 'Nombre de villes'
FROM departement JOIN villes_france_free ON departement.departement_code = villes_france_free.ville_departement
GROUP BY departement_nom, departement_code
ORDER BY 'Nombre de villes' DESC;

-- 6. Obtenir la liste des 10 plus grands d�partements, en termes de superficie

SELECT TOP 10 departement_nom, departement_code,
SUM (ville_surface) AS 'Superficie du d�partement'
FROM departement JOIN villes_france_free ON departement.departement_code = villes_france_free.ville_departement
GROUP BY departement_code, departement_nom
ORDER BY 'Superficie du d�partement' DESC;

-- 7. Compter le nombre de villes dont le nom commence par �Saint�

SELECT COUNT (ville_nom) AS 'Villes commen�ant par saint'
FROM villes_france_free
WHERE ville_nom LIKE 'saint%';

-- 8. Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d�obtenir en premier celles dont le nom est le plus souvent utilis� par plusieurs communes

SELECT V0.ville_nom,
COUNT (V0.ville_nom) AS 'Nombre de ville'
FROM villes_france_free AS V0 --JOIN villes_france_free AS V1 ON V0.ville_nom_simple = V1.ville_nom_simple
GROUP BY V0.ville_nom
HAVING COUNT(V0.ville_nom) > 1
ORDER BY 'Nombre de ville' DESC

-- 9. Obtenir en une seule requ�te SQL la liste des villes dont la superficie est sup�rieur � la superficie moyenne

SELECT ville_nom FROM villes_france_free
WHERE ville_surface > (SELECT AVG(ville_surface) FROM villes_france_free)

-- 10. Obtenir la liste des d�partements qui poss�dent plus de 2 millions d�habitants

SELECT departement_nom, SUM(villes_france_free.ville_population_2012)
FROM departement JOIN villes_france_free ON villes_france_free.ville_departement = departement.departement_code
GROUP BY departement_nom
HAVING SUM(villes_france_free.ville_population_2012) > 2000000

-- 11. Remplacez les tirets par un espace vide, pour toutes les villes commen�ant par �SAINT-� (dans la colonne qui contient les noms en majuscule).

SELECT REPLACE (ville_nom,'-',' ') FROM villes_france_free
WHERE ville_nom LIKE 'SAINT-%'
