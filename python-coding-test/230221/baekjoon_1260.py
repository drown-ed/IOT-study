from queue import Queue

N, M, Start = map(int, input().split())
A = [[] for _ in range(N+1)]

for _ in range(M):
    s, e = map(int, input().split())
    A[s].append(e)
    A[e].append(s)

for i in range(N+1):
    A[i].sort()

visited = [False] * (N + 1)

def DFS(v):
    print(v, end = ' ')
    visited[v] = True 
    for i in A[v]:
        if not visited[i]:
            DFS(i)

def BFS(v):
    q = Queue()
    q.put(v)
    visited[v] = True 
    while q.empty() != True:
        now = q.get()
        print(now, end = ' ')
        for i in A[now]:
            if not visited[i]:
                visited[i] = True 
                q.put(i)

visited = [False] * (N+1)
DFS(Start)
print()
visited = [False] * (N+1)
BFS(Start)
print() 