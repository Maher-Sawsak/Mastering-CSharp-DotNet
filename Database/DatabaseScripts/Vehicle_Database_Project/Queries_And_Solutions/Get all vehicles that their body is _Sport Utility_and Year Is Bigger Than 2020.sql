--Problem 26: Get all vehicles that their body is 'Sport Utility' and Year > 2020


 select   BodyName , VehicleDetails.* 
 from VehicleDetails
 inner join Bodies
 on Bodies.BodyID = VehicleDetails.BodyID
 where (Bodies.BodyName = 'Sport Utility' and VehicleDetails.[Year] >2020);