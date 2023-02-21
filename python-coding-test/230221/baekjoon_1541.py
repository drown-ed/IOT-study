answer = 0 
A = list(map(str, input().split('-')))

def mySum(i):
    result = 0
    temp = str(i).split('+')

    for k in temp:
        result += int(k)

    return result 

for s in range(len(A)):
    temp = mySum(A[s])

    if s == 0:
        answer += temp
    else:
        answer -= temp 

print(answer)