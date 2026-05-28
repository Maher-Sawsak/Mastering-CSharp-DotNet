-- Problem 5 : Get All Makes that have manufactured more than 12000 Vehicles in years 1950 to 2000
--First Solution
select Makes.Make ,count(*) NumberOfVehicles
from VehicleDetails  
Inner join Makes
ON Makes.MakeID = VehicleDetails.MakeID
where Year between 1950 and 2000
group by Make 
having count(*)> 12000
order by NumberOfVehicles desc;	




--Second Solution :
--another solution but this timw without having 
--so the question now solve same probleam but u can't use having this time.

select * from (
select Makes.Make ,count(*) NumberOfVehicles
from VehicleDetails  
Inner join Makes
ON Makes.MakeID = VehicleDetails.MakeID
where Year between 1950 and 2000
group by Make 
) Result1
where NumberOfVehicles > 12000
order by NumberOfVehicles desc;
--here it will give me the same result to the previous one but i didn''t use having in the second query.