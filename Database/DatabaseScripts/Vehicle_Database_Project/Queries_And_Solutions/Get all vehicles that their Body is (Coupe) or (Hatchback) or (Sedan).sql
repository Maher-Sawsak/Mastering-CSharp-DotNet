

-- Problem 27: Get all vehicles that their Body is 'Coupe' or 'Hatchback' or 'Sedan'
 Select   BodyName , VehicleDetails.* 
 From VehicleDetails
 inner join Bodies
 On Bodies.BodyID = VehicleDetails.BodyID
 Where Bodies.BodyName in('Coupe' , 'Hatchback' , 'Sedan')
 Order By BodyName;

