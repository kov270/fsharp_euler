module Euler3

let n:uint64 = uint64 "600851475143"
let d:uint64 = uint64 3

let rec f31 (n:uint64) (d:uint64): uint64  = 
    if d * d >= n then
        n
    elif n % d = uint64 0 then
        f31 (n/d) d
    else
        f31 n (d+ uint64 2)


let tailRec3 = (f31 n d)

let rec f32 n x a = 
    if x = n then
        x::a
    elif n % x = 0 then 
        f32 (n/x) x (x::a)
    else
        f32 n (x+1) a
let factorise n = f32 n 2 []
let factors = factorise 13195

let tailRec3_2 =  factors[0]
