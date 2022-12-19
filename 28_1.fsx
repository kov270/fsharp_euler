// Рекурсия хвостовая
let rec f i  a = 
    if i > 1001 then
        a
    else
        // sum i^2, i^2-i+1, i^2-2i+2, i^2-3i+3
        f (i+2) (a+i*i*4-6*i+6) 

printfn "%A" (f 3 1)
