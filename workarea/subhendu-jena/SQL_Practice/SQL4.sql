SELECT * FROM EMPLOYEE;
SELECT * FROM DEPT;

SELECT EmpDeptId, AVG(EmpSalary) AS Average FROM EMPLOYEE GROUP BY EmpDeptId;
SELECT EmpDeptId, COUNT(EmpName) AS Cnt FROM EMPLOYEE GROUP BY EmpDeptId;
SELECT MAX(EmpSalary) AS Highest FROM EMPLOYEE;
SELECT MIN(EmpSalary) AS Highest FROM EMPLOYEE;
SELECT EmpDeptId,SUM(EmpSalary) AS "Total Salary" FROM EMPLOYEE Group by EmpDeptId;