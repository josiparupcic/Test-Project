SELECT * FROM VehicleMake

select * from VehicleModel

SELECT a.Name FROM VehicleModel a
INNER JOIN MakeFK b ON a.Id = ModelId
WHERE b.MakeId = 3;

select * from VehicleModel