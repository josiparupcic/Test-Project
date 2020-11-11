select Abrv from VehicleMake

SELECT a.Name FROM VehicleModel a
INNER JOIN MakeFK b ON a.Id = b.ModelId
WHERE b.MakeId = 4;


select b.Abrv, a."Name" from VehicleModel a
inner join VehicleMake b ON a.MakeId = b.Id
where b.Id = 4;