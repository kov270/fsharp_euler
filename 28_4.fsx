module Euler28

// while
let f = 
    let mutable ans = 1
    let mutable i = 3
    while i <= 1001 do
        ans <- (ans+i*i*4-6*i+6)
        i <- i+2
    ans

printfn "%A" (f)
