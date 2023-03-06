USE bookrentalshop;

-- 1번 문제
SELECT CONCAT(LEFT(Names, 1), ',' , RIGHT(Names, 2)) AS '회원명',
		REPLACE(Addr,'부산시 ','') AS '주소',
        Mobile AS '폰번호',
        UPPER(Email) AS '이메일'
  FROM membertbl
  ORDER BY Email DESC;

-- 2번 문제
SELECT d.Names AS '장르',
	   b.Author AS '작가',
       b.Names AS '책제목'
  FROM bookstbl as b
  JOIN divtbl as d
	ON b.Division = d.Division
ORDER BY d.Names, b.Author;

-- 3번 문제
INSERT INTO divtbl (Division, Names) VALUE ('I002', '네트워크');

-- 4번 문제
UPDATE membertbl
	SET Levels = 'D', Mobile = '010-9839-9999'
	WHERE Names = '성명건';

-- 5번 문제
SELECT * FROM (
	SELECT b.Division
			, sum(b.Price) AS '총합'
			FROM bookstbl AS b
			GROUP BY b.Division
		) AS bb
	GROUP BY ROLLUP(bb.총합);
	

SELECT COALESCE((SELECT Names
		FROM divtbl AS d
		WHERE d.Division=bb.Division), '합계') AS '장르'
	, CONCAT(FORMAT(bb.총합, '###,###'), '원') AS '장르별 총합계'
	FROM (
		SELECT
			b.Division
			, sum(b.Price) AS '총합'
			FROM bookstbl AS b
			GROUP BY b.Division WITH ROLLUP
		) AS bb
        ORDER BY 1;
	