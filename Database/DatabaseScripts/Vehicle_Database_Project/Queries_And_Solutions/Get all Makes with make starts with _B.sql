--  Problem 14: Get all Makes with make starts with 'B'

--Write a query to get all Makes with make starts with 'B'.


select Makes.Make  from Makes
where Makes.Make Like 'B%';