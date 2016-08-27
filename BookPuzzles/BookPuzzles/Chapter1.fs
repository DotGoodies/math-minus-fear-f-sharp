module Chapter1

let puzzle1() = 
    let positives = Seq.initInfinite (fun x -> x + 1)
    let solution = positives |> Seq.tryFind (fun x -> x % 3 = 0 && x % 4 = 0 && x % 5 = 0)
    printfn "Puzzle 1: Number of days: %i" (Option.get solution)

let puzzle2() = 
//TODO - can we render name of the puzzle automatically?
    printfn "Puzzle 2: 0? Because eventually they'll all are good?"

