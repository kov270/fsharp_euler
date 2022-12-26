module Lab1

open NUnit.Framework
open Functions

[<SetUp>]
let Setup () = ()

let input3D = uint64 "600851475143"
let result3 = 6857UL

let result28 = 669171001

[<Test>]
let Test1 () =
    let f: uint64 = rec31_c input3D
    assert (f = result3)

[<Test>]
let Test2 () =
    let factRes = resultFactors_c input3D
    assert (factRes = result3)

[<Test>]
let Test3 () =
    let fact = factorise input3D
    assert (fact[0] = result3)


[<Test>]
let TestTailRec () =
    let tail28 = tailRec28 3 1
    assert (tail28 = result28)

[<Test>]
let TestModuleRel () =
    let res1 = module28_1
    assert (res1 = result28)
    let res2 = module28_2
    assert (res2 = result28)
