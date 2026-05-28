--Problem 45: Get Number of Models Per Make


--the best practise here and also for the performance
SELECT        Makes.Make, COUNT(*) AS NumberOfModels
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc

--the second soltion its bad practise cuz the table is have the current data and we can use the model table is better noe redundance
select  Makes.Make ,  count(DISTINCT VehicleDetails.ModelID) AS NumberOfModels
from VehicleDetails
inner join Makes
on  Makes.MakeID = VehicleDetails.MakeID
group by Makes.Make
Order By NumberOfModels Desc
 


