-- Problem 16: Get all Makes that manufactures DriveTypeName = FWD


select Distinct Makes.Make
from VehicleDetails
inner join Makes
on  Makes.MakeID = VehicleDetails.MakeID
inner join DriveTypes
on  DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID
where DriveTypeName = N'FWD';

