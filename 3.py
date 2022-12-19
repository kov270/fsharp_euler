def f(n):
    n=int(n)
    if n == 1:
        return ()
    if n == 0:
        return (0,)
    for i in range(int(n**0.5),n):
        ja = 0
        jb = n
        while jb - ja > 1:
            j = (ja + jb)//2
            if i**2 - j**2 >= n:
                ja = j
            else:
                jb = j

        # for j in range(0,n):
        for j in range(ja,jb+1):
            if i**2 - j**2 == n:
                if i-j == 1:
                    # print(i+j)
                    return (i+j,)
                return f(i-j)+f(i+j)
    
    # print(n)
    return (n,)

m = list(f(600851475143))
m.sort()
print(m)
# print(f(13195))
# print(f(25))
