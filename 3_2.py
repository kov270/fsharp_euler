a = []

def fc(n):
    global a
    for i in range(0, n + 1):
        a.append(i)
    
    a[1] = 0
    i = 2
    while i <= n:
        # print(a)
        if a[i] != 0:
            j = i + i
            while j <= n:
                a[j] = 0
                j = j + i
        i += 1

    a = set(a)
    a.remove(0)
    # a = list(a)
    # a.append(0)
    # a.append(1)
    print(a)
    return f(n)
    


def f(n):
    n=int(n)
    if n == 1:
        return ()
    if n == 0:
        return (0,)
    
    ans = []
    for i in a:
        if n%i == 0:
            ans.append(i)

    # print(n)
    return ans

# print(fc(600851475143))
# print(fc(13195))
# print(fc(50))

print(f(13195))
