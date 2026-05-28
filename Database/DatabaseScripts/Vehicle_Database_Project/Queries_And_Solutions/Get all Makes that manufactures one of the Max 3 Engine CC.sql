--Problem 41: Get all Makes that manufactures one of the Max 3 Engine CC


 select distinct Makes.Make
 from VehicleDetails
inner join Makes 
on  Makes.MakeID = VehicleDetails.MakeID
 where	VehicleDetails.Engine_CC in
(

		select distinct top 3 VehicleDetails.Engine_CC
		from VehicleDetails
		order by VehicleDetails.Engine_CC desc

)
order by Makes.Make;