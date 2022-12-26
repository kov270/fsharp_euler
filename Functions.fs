module Functions

// Euler 3
let rec rec31 (n: uint64) (d: uint64) : uint64 =
    if d * d >= n then n
    elif n % d = uint64 0 then rec31 (n / d) d
    else rec31 n (d + uint64 2)

let rec31c (n: uint64) : uint64 =
    rec31 n 3UL

let rec private f32 (n: uint64) x a =
    if x = n then x :: a
    elif n % x = uint64 0 then f32 (n / x) x (x :: a)
    else f32 n (x + uint64 1) a

let factorise (n: uint64) = f32 n (uint64 2) []


let private factors d n =
    Seq.unfold
        (fun (d, n) ->
            if d * d > n then None
            else if n % d = uint64 0 then Some(d, (d, n / d))
            else Some(d, (d + uint64 2, n)))
        (d, n)

let resultFactors d n =
    Seq.fold (fun acc d -> if acc % d = uint64 0 then acc / d else acc) n (factors d n)


let resultFactorsc n = 
    resultFactors 3UL n


// Euler 28

// Рекурсия хвостовая
let rec tailRec28 i a =
    if i > 1001 then
        a
    else
        // sum i^2, i^2-i+1, i^2-2i+2, i^2-3i+3
        tailRec28 (i + 2) (a + i * i * 4 - 6 * i + 6)

let module28 lt =
    lt
    |> Seq.map (fun n -> 4 * (n - 2) * (n - 2) + 10 * (n - 1))
    // like Seq.fold ( + ) 0 but linter
    |> Seq.sum
    |> fun sum -> sum + 1


let module281 =
    module28 [ for a in 1 .. 500 do yield (a * 2+1) ]

let module282 =
    module28 ([ 1 .. 500] |> Seq.map (fun n -> n* 2+1))
