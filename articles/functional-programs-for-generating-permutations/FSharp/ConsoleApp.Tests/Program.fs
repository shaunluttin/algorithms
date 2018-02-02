open System
open FSharp.ConsoleApp

[<EntryPoint>]
let main argv =

    printfn "[0].Head %A" [0].Head
    printfn "[0].Tail %A" [0].Tail

    printfn "[0;1;2].Head %A" [0;1;2].Head
    printfn "[0;1;2].Tail %A" [0;1;2].Tail

    0 // return an integer exit code