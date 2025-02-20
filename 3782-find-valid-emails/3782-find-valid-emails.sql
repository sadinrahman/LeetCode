# Write your MySQL query statement below
select * from Users
 WHERE email REGEXP '^[A-Za-z0-9]+@[A-Za-z0-9.-]+\\.com$' 
  order by user_id;