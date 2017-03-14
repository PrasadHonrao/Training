let square x = x * x // function declaration
printfn "Square of 4 is %d" (square 4) // function call
printfn "Square of 3 + 1 is %d" (square 3 + 1) // same as square(3) + 1
printfn "Square of 4 is %d" (square (3 + 1))

let linear x = x * 2
printfn "Linear %d" (linear 2) // output functin result

let quadratic y = y ** 2.
printfn "Quadratic %f" (quadratic 10.0)

let Foo name  = printfn "Hellllllloooooooooooo %s" name
Foo "Prasad"

let distance x y = x - y |> abs
let mutable dist = distance 10 20 // declared as mutable to override during second example
printfn "Distance is %d" dist

dist <- distance 10 20 + 1
printfn "Distance 10 20 + 1 is %d" dist

//[for x in 1.0 .. 10.0 -> (x, linear)] |> printfn "%d"