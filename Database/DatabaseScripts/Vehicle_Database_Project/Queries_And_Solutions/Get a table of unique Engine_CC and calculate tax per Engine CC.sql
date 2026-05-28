--Problem 42: Get a table of unique Engine_CC and calculate tax per Engine CC
-- Get a table of unique Engine_CC and calculate tax per Engine CC as follows:
	-- 0 to 1000    Tax = 100
	-- 1001 to 2000 Tax = 200
	-- 2001 to 4000 Tax = 300
	-- 4001 to 6000 Tax = 400
	-- 6001 to 8000 Tax = 500
	-- Above 8000   Tax = 600
	-- Otherwise    Tax = 0


	/*
Performance Note:
This query is highly optimized and offers better performance.
Reason: The subquery extracts the unique engine capacities (DISTINCT Engine_CC) first.
As a result, the CASE statement to calculate the Tax is only evaluated on a small set of unique values, 
rather than computing it for every single row in the entire table before filtering. 
This approach significantly reduces CPU usage and improves execution time, especially for large tables.
*/
select Engine_CC , 
(case

when (Engine_CC between 0 and 1000) then 100
when (Engine_CC between 1001 and 2000) then 200
when (Engine_CC between 2001 and 4000) then 300
when (Engine_CC between 4001 and 6000) then 400
when (Engine_CC between 6001 and 8000) then 500
when (Engine_CC > 8000 ) then 600
Else  0
End)
as Tax
from
(
select  distinct VehicleDetails.Engine_CC  from VehicleDetails
)R1
order by Engine_CC;


/*
--its bad practice cuz will bring all data and apply the case statment for all

select  distinct VehicleDetails.Engine_CC , 

(case



when (VehicleDetails.Engine_CC between 0 and 1000) then 100

when (VehicleDetails.Engine_CC between 1001 and 2000) then 200

when (VehicleDetails.Engine_CC between 2001 and 4000) then 300

when (VehicleDetails.Engine_CC between 4001 and 6000) then 400

when (VehicleDetails.Engine_CC between 6001 and 8000) then 500

when (VehicleDetails.Engine_CC > 8000 ) then 600

Else  0

End)

as Tax

from VehicleDetails

order by VehicleDetails.Engine_CC;
*/