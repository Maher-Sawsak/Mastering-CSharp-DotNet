 --Problem 17: Get total Makes that Mantufactures DriveTypeName=FWD

 select count(*) as TotalMakesByFWD from(
select  Distinct Makes.Make
from VehicleDetails
 inner join Makes
  on  Makes.MakeID = VehicleDetails.MakeID
 inner join DriveTypes
  on  DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID
where DriveTypeName = N'FWD'
)R1;
