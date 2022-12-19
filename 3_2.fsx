let rec f32 n x a = 
    if x = n then
        x::a
    elif n % x = 0 then 
        f32 (n/x) x (x::a)
    else
        f32 n (x+1) a
let factorise n = f32 n 2 []
let factors = factorise 13195

printfn "%A" factors[0]
