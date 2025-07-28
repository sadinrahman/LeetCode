# Write your MySQL query statement below
SELECT u.name,COALESCE(SUM(r.distance), 0) AS travelled_distance
FROM Users u left JOIN Rides r ON u.id = r.user_id
GROUP BY u.id, u.name ORDER BY travelled_distance DESC,name ASC;
