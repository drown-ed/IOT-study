-- employees DB의 employees 테이블에서 테이블 10만개 가져오기

CREATE TABLE indexTBL(
	first_name VARCHAR(14),
    last_name VARCHAR(16),
    hire_date DATE
);

INSERT INTO indexTBL
	SELECT first_name, last_name, hire_date
    FROM employees.employees
    LIMIT 300000;
    
SELECT * FROM indexTBL
	WHERE first_name = 'Mary';
    
CREATE INDEX idx_indexTbl_firstName ON indexTBL(first_name);