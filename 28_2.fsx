// Модульная
let list1 = [ for a in 1 .. 500 do yield (a * 2+1) ]
// list = [3; 5; 7; 9; ...]

printfn "%A" (list1
                |> Seq.map (fun n -> 4*(n-2)*(n-2)+10*(n-1)) 
                |> Seq.fold (fun sum v -> sum + v) 0 
                |> fun sum -> sum + 1)
