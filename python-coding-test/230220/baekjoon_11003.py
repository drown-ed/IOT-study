from collections import deque
# from pythonds.basic.deque import Deque 

N, L = map(int, input().split()) # 12 3
mydeque = deque()
now = list(map(int, input().split())) # 1 5 2 3 6 2 3 7 3 5 2 6

for i in range(N):
    while mydeque and mydeque[-1][0] > now[i]:
        mydeque.pop()
    mydeque.append((now[i], i))
    if mydeque[0][1] <= i - L:  # 범위를 벗어난 값 덱에서 제거
        mydeque.popleft()
    print(mydeque[0][0], end = ' ')