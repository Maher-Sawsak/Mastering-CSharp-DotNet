--	Problem 50: Get all Fuel Types , each time the result should be showed in random order
--this is work good it give each row a GUID so if u have millions of row will be slow for performence there is onther way below.
select * from FuelTypes
order by NewId();

--here this TableSample  work butt just for the huge data or let me say large data 
--cuz if u have a small rows or records sometimes will give you nothing its something dealing or related to the arctitcher (Data Pages) in the disk.
SELECT * FROM VehicleDetails TABLESAMPLE (10 PERCENT);