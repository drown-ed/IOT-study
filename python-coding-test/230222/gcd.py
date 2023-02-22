
def gcd(a, b):
    if b == 0:
        return a 
    else:
        gcd(b, a%b)

a, b = map(int, input().split())
result = gcd(a, b)
print(result)