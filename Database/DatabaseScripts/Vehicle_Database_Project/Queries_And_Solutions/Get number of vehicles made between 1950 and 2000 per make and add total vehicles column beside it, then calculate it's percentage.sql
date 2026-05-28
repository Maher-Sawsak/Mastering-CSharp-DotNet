
--Problem 7: Get number of vehicles made between 1950 and 2000 per make and add total vehicles column beside it, then calculate it's percentage

select * , cast(NumberOfVehicles as float) / cast(TotalVehicales as float) as Percentagee from
(
SELECT 
    Makes.Make,  COUNT(*) AS NumberOfVehicles,(SELECT COUNT(*) FROM VehicleDetails) AS TotalVehicales
	
FROM VehicleDetails
INNER JOIN Makes ON Makes.MakeID = VehicleDetails.MakeID
WHERE VehicleDetails.[Year] BETWEEN 1950 AND 2000
GROUP BY Makes.Make
)R1

order by NumberOfVehicles desc;