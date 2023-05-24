-- use cars

INSERT INTO owners
(owner_lastname,owner_firstname)
VALUES
('Petit','Annie'),
('Marsfall','Bénédicte'),
('Doe','John'),
('Bouchra','Amine'),
('Jones','Steeven');

INSERT INTO brands
(brand_name)
VALUES
('Chevrolet'),
('Audi'),
('Toyota'),
('AMC'),
('Peugeot');

INSERT INTO cars
(car_id,car_name,car_registration,car_owner_id,brand_id)
VALUES
(12,'Chevelle Concours','AA-123-AA',1,1),
(16,'A6 Break','BB-274-BB',5,2),
(19,'Monte Carlo','CC-546-FV',4,1),
(21,'Corolla','CA-789-BA',2,3),
(23,'Hornet','DE-228-KS',5,4),
(26,'3008','CF-614-PM',5,5),
(27,'504','CG-274-ZG',4,5),
(28,'100 LS','FV-313-FT',5,2),
(30,'Q8','ER-355-GX',3,2);