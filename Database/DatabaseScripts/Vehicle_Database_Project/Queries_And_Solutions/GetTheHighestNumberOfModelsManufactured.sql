 --Problem 47: Get the highest number of models manufactured

 --The First Solution be built in function max() subqueres
 select   max (NumberofModels) as MaximumNumberOfModels 
 from(
	select  Makes.Make ,  count(*) as NumberofModels
	from MakeModels
	inner join Makes 
	on Makes.MakeID = MakeModels.MakeID
	group by Makes.Make
)R1;


--Second Solution by top and ordering the Data descending
/*
select top 1 Makes.Make ,  count(*) as NumberofModels
from MakeModels
inner join Makes 
on Makes.MakeID = MakeModels.MakeID
group by Makes.Make
order by NumberofModels desc;

*/