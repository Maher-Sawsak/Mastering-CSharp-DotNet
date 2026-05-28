 --Problem 44: Get Total Number Of Doors Manufactured by (Ford)

 --First Soltuin
 --its more readable than the second but the secont is better for the performence.
 select Makes.Make , sum(VehicleDetails.NumDoors) as NumberOfDoor
 from VehicleDetails
 inner join Makes
 on Makes.MakeID = VehicleDetails.MakeID
 group by Makes.Make
 having Makes.Make = 'Ford'

 

 --The Second Way To SOLVE This question.
 --BEtter for the performence
 select sum(R1.NumDoors) as TotalNumberOfDoorsByFord from(
Select  Makes.Make ,  VehicleDetails.*
From VehicleDetails 
inner join Makes
on  Makes.MakeID = VehicleDetails.MakeID 
where Makes.Make = 'Ford')R1
