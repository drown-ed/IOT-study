SELECT *
	FROM memberTBL;

CREATE VIEW uv_memberTBL
	AS
    SELECT memberName, memberAddress
		FROM membertbl;
        
SELECT *
	FROM uv_memberTBL;