let d : uint64 = uint64 3
let n : uint64 = uint64 "600851475143"

let factors = 
    Seq.unfold (fun (d, n) -> 
        if d * d > n then None
        else if n % d = uint64 0 then Some(d, (d, n / d))
        else Some(d, (d + uint64 2, n))) (d, n)

let result = Seq.fold (fun acc d -> if acc % d = uint64 0 then acc / d else acc) n factors

printfn "%d" result

open FSharp.Core

assert (result = 6857UL)
