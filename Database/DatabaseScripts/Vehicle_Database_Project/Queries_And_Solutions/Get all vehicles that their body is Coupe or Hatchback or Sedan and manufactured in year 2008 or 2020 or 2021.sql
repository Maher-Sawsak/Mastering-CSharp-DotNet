
 -- Problem 28: Get all vehicles that their body is 'Coupe' or 'Hatchback' or 'Sedan' and manufactured in year 2008 or 2020 or 2021
 Select   BodyName , VehicleDetails.* 
 From VehicleDetails
 inner join Bodies
 On Bodies.BodyID = VehicleDetails.BodyID
 Where ((Bodies.BodyName in('Coupe' , 'Hatchback' , 'Sedan')) AND (VehicleDetails.[Year] in(2008,2020,2021)))
 Order By BodyName;

