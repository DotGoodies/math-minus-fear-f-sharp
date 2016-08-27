// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "Chapter 1:"
    //TODO - can we introduce automatic indent for each chapter?
    Chapter1.puzzle1()
    Chapter1.puzzle2()

    System.Console.WriteLine "Done. Press enter.."
    System.Console.ReadLine() |> ignore


    0 // return an integer exit code
