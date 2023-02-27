import pymysql 

# localhost 자기 자신 = 127.0.0.1
conn = pymysql.connect(host='localhost', user ='root', password = '1234', db = 'homeplus', charset = 'utf8')

cur = conn.cursor()
sql = 'SELECT * FROM indextbl'
cur.execute(sql)

rows = cur.fetchall()
print(rows)
conn.close()