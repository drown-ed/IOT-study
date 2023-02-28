-- 사용 데이터베이스 변경
USE homeplus;

SELECT * FROM homeplus.indextbl;

SELECT first_name, last_name from indextbl;

USE sqldb;

SELECT userID, name, birthYear, height FROM usertbl WHERE name = '김경호';

SELECT * FROM usertbl WHERE birthYear >= 1970 and height >= 182; 

SELECT * FROM usertbl WHERE height BETWEEN 180 AND 183; 

SELECT * FROM usertbl WHERE addr = '경남' OR addr = '경북' OR addr = '전남'; 
SELECT * FROM usertbl WHERE addr IN ('경남', '경북', '전남');

SELECT * FROM usertbl WHERE name LIKE '김%'; 
SELECT * FROM usertbl WHERE name LIKE '%김'; 
SELECT * FROM usertbl WHERE name LIKE '%김%'; 
SELECT * FROM usertbl WHERE name LIKE '김__';

SELECT name, height FROM usertbl WHERE height > 177;

SELECT u.userID, u.name, u.birthYear
	from (
			SELECT userID, name, birthYear, addr
            FROM usertbl
            ) AS u
		WHERE u.birthYear > 1969; 
        
SELECT u.userID, u.name, (2023 - u.birthYear)
	from (
			SELECT userID, name, birthYear, addr
            FROM usertbl
            ) AS u
		WHERE u.birthYear > 1969; 
        
SELECT b.userID, 
		(SELECT name FROM usertbl WHERE userID = b.userID) AS '이름',
        b.prodName, b.price * b.amount AS '판매액' 
        FROM buytbl AS b;