let mutable n:uint64 = uint64 "600851475143"
let mutable d:uint64 = uint64 3

while d * d < n do
    if n % d = uint64 0 then n <- n / d else d <- d + uint64 2

printfn "%d" n
