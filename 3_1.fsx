let n:uint64 = uint64 "600851475143"
let d:uint64 = uint64 3

let rec f31 (n:uint64) (d:uint64): uint64  = 
    if d * d >= n then
        n
    elif n % d = uint64 0 then
        f31 (n/d) d
    else
        f31 n (d+ uint64 2)


printfn "%A" (f31 n d)
