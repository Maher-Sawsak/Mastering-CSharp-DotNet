 -- Problem 40: Get all vehicles that has one of the Max 3 Engine CC
 
-- Note: You use this same method if you have a table of students and their grades, and you need to find the top 10.

--The "top 10" might actually be 15 students because some grades can be repeated (ties).

--Therefore, you must first find the top 10 highest grades, and then find all the students who got any of those grades.

 select * 
 from VehicleDetails
 where	VehicleDetails.Engine_CC in (

 select distinct top 3 VehicleDetails.Engine_CC
from VehicleDetails
order by Engine_CC desc
);