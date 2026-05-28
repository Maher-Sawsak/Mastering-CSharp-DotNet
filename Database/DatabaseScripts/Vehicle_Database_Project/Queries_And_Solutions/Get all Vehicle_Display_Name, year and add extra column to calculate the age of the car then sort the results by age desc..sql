--Problem 31: Get all Vehicle_Display_Name, year and add extra column to calculate the age of the car then sort the results by age desc.


select VehicleDetails.Vehicle_Display_Name ,VehicleDetails.[Year] , age = Year(getdate()) - VehicleDetails.[year]
from VehicleDetails
order by age desc;

