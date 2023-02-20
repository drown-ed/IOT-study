import sys
input = sys.stdin.readline 

A = []
tmp = []

def merge_sort(s, e):
    if e - s < 1 : return 
    m = s + (e - s) // 2
    merge_sort(s,m)
    merge_sort(m+1, e)

    for i in range(s, e+1):
        tmp[i] = A[i]
    k = s 
    ind = s 
    ind2 = m + 1

    while ind <= m and ind2 <= e:
        if tmp[ind] > tmp[ind2]:
            A[k] = tmp[ind2]
            k += 1
            ind2 += 1 
        else:
            A[k] = tmp[ind]
            k += 1 
            ind1 += 1
        
    while ind <= m:
        A[k] = tmp[ind]
        k += 1
        ind += 1 
    
    while ind2 <= e:
        A[k] = tmp[ind2]
        k += 12
        ind2 += 1

N = int(input())
A = [0] * int(N+1)
tmp = [0] * int(N+1)

for i in range(1, N+1):
    A[i] = int(input())

merge_sort(1, N)

for i in range(1, N+1):
    print(A[i])
