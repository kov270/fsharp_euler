let rec f32 (n:uint64) (x:uint64) a = 
    if x = n then
        x::a
    elif n % x = 0UL then 
        f32 (n/x) x (x::a)
    else
        f32 n (x+1UL) a
let factorise (n:uint64) = f32 n 2UL []
let factors:uint64 list = factorise  (uint64 "600851475143")

printfn "%A" factors.[0]
