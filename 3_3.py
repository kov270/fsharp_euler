d, n = 3, 600851475143
while (d * d < n):
    if n % d == 0: n //= d
    else: d += 2
print(n)
