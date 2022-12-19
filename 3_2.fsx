let rec f n x a = 
    if x = n then
        x::a
    elif n % x = 0 then 
        f (n/x) x (x::a)
    else
        f n (x+1) a
let factorise n = f n 2 []
let factors = factorise 13195

printfn "%A" factors[0]
