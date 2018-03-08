open Permutations

[<EntryPoint>]
let main argv =

    printfn "[0].Head %A" [0].Head
    printfn "[0].Tail %A" [0].Tail

    printfn "[0;1;2].Head %A" [0;1;2].Head
    printfn "[0;1;2].Tail %A" [0;1;2].Tail

    Permute1.permute1 [1;2;3] |> List.iter (printf "%A ")

    let list = [1;2;3;4;5]
    let result = Permute2.removeFirst list 3
    printfn "%A" result

    printfn "%A" (0 :: list)

    0 // return an integer exit code