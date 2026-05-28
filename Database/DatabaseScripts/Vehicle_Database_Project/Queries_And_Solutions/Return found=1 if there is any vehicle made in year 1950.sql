
--Problem 29: Return found=1 if there is any vehicle made in year 1950
--My solution here is the best practice that i know until now and its so good for performance cuz used top 1 *.
select found=1 
where exists(

select top 1 * from VehicleDetails where VehicleDetails.[Year] = 1950
)

