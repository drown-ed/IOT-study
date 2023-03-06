SELECT *
	FROM membertbl;
    
SELECT *
	FROM bookstbl;

-- 서브 쿼리 성능이 떨어짐 --
SELECT b.Author AS '저자',
	   b.Division AS '장르',
       (SELECT Names FROM divtbl WHERE Division = b.Division),
       b.Names AS '제목',
       b.ISBN AS 'ISBN',
       b.Price AS '가격'
	FROM bookstbl AS b
    order by 3 ASC; /* (저자-1)(장르-2)(제목-3)(ISBN-4)(가격-5) */ 

-- 조인 / 서브 쿼리 대신 조인 사용이 합리적 -- 
SELECT b.Author AS '저자',
	   b.Division AS '장르',
       d.Names AS '장르', 
       b.Names AS '제목',
       b.ISBN AS 'ISBN',
       b.Price AS '가격'
	FROM bookstbl AS b
    INNER JOIN divtbl AS d
		ON b.Division = d.Division
    order by b.Names;

-- 서브 쿼리 / 장르로 그룹핑 
SELECT (SELECT Names FROM divtbl WHERE Division = bb.Division) AS '장르', bb.총합
	FROM (
	SELECT b.Division,
		   SUM(b.Price) AS '총합'
		FROM bookstbl AS b
		GROUP BY b.Division
	) AS bb;
    
SELECT m.Names,
	   m.Addr,
       m.Mobile,
       r.rentalDate,
       r.returnDate,
       b.Names,
       d.Names,
       b.Price
	FROM membertbl AS m
	INNER JOIN rentaltbl AS r
		ON m.memberIdx = r.memberIdx
	INNER JOIN bookstbl AS b
		ON r.bookIdx = b.bookIdx
	INNER JOIN divtbl AS d
		ON b.Division = d.Division;
        
SELECT bb.Author, 
		d.Names As '장르', bb.출판권수, bb.합계금액
	FROM (
		SELECT b.Author,
			   b.Division,
               COUNT(b.Author) AS '출판권수',
               SUM(b.Price) AS '합계금액'
		 FROM bookstbl AS b
         GROUP BY b.Author, b.Division
        HAVING COUNT(b.Author) >= 2
        ) AS bb
	INNER JOIN divtbl AS d
		ON bb.Division = d.Division;