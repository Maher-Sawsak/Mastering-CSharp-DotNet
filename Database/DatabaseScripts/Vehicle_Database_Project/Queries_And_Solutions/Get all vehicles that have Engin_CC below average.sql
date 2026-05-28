--Problem 36: Get all vehicles that have Engin_CC below average


  Select VehicleDetails.Vehicle_Display_Name
  from VehicleDetails
  where VehicleDetails.Engine_CC < (select Avg (VehicleDetails.Engine_CC) from VehicleDetails);
