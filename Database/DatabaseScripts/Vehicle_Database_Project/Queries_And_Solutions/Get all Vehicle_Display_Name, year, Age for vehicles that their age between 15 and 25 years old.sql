--Problem 32: Get all Vehicle_Display_Name, year, Age for vehicles that their age between 15 and 25 years old


select * from (
select VehicleDetails.Vehicle_Display_Name , VehicleDetails.[Year] , Age = Year(Getdate()) - VehicleDetails.[Year]
from VehicleDetails
)R1
where Age between 15 and 25;