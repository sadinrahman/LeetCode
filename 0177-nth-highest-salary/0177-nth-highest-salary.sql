CREATE FUNCTION getNthHighestSalary(@N INT)
RETURNS INT
AS
BEGIN
    DECLARE @Result INT;

    WITH RankedSalaries AS (
        SELECT Salary, DENSE_RANK() OVER (ORDER BY Salary DESC) AS Rank
        FROM Employee
    )
    SELECT @Result = Salary
    FROM RankedSalaries
    WHERE Rank = @N;

    RETURN @Result;
END;
