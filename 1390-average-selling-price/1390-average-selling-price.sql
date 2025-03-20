# Write your MySQL query statement below
select p.product_id,
ROUND(IFNULL(SUM(p.price * u.units) / SUM(u.units), 0), 2) AS average_price
from Prices p left join UnitsSold u
ON p.product_id = u.product_id
AND u.purchase_date BETWEEN p.start_date AND p.end_date
GROUP BY 
    p.product_id;