# Write your MySQL query statement below
select email as Email From Person group by email 
Having Count(email)>1 