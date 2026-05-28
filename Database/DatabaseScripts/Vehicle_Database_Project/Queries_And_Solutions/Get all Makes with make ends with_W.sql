-- Problem 15: Get all Makes with make ends with 'W'

SELECT Makes.Make 
from Makes
where Makes.Make Like '%W';