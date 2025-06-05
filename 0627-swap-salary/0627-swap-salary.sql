# Write your MySQL query statement below
update Salary Set sex= case
    WHEN sex = 'm' THEN 'f'
    WHEN sex = 'f' THEN 'm'
    ELSE sex
    END;