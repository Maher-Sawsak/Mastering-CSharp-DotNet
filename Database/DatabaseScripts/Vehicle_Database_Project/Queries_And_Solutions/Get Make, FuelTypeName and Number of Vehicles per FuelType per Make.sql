		--  Problem 8: Get Make, FuelTypeName and Number of Vehicles per FuelType per Make
		select Makes.Make , FuelTypes.FuelTypeName ,count(*) as Numbers
		    from VehicleDetails
			inner join Makes
			  on Makes.MakeID = VehicleDetails.MakeID
			inner join FuelTypes
			  on FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID
		    where (VehicleDetails.[Year] between 1950 and 2000)	
		    group by Makes.Make , FuelTypes.FuelTypeName
	     	order by Makes.Make asc;