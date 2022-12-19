s = 2
ans = 1
i = 1
while i < 1001*1001:
    for _ in range(4):
        i += s
        ans += i
        # print((i,s,ans))
    s += 2

print(ans)