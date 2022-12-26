module Program

open Functions

[<EntryPoint>]
let main argv =
    let f: uint64 = rec31_c (uint64 "600851475143")
    printfn "%A" f

    let factors = factorise (uint64 "600851475143")
    printfn "%A" factors[0]

    let factRes = resultFactors (uint64 3) (uint64 "600851475143")
    printfn "%A" factRes

    printfn "Хвостовая рекурсия 28"
    let tail28 = tailRec28 3 1
    printfn "%A" tail28

    printfn "Map-module реализация 28"
    let tail28 = module28_1
    printfn "%A" tail28

    printfn "map генерация последовательности"
    let tail282 = module28_2
    printfn "%A" tail282

    0
