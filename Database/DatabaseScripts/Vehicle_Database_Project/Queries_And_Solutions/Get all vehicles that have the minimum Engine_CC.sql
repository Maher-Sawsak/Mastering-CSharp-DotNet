
--  Problem 34: Get all vehicles that have the minimum Engine_CC

--VIN(Very Important Note ) : The WHERE clause operates on a row-by-row basis and cannot see the entire table to calculate the MIN. 
--To work around this, we use a -------subquery---- inside parentheses () to perform the calculation beforehand,
--which then returns a ready-to-use number for the WHERE clause to compare against.

Select VehicleDetails.Vehicle_Display_Name
from VehicleDetails
where  VehicleDetails.Engine_CC = (select Min(VehicleDetails.Engine_CC) from VehicleDetails);
