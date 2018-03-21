#load "../Permute5.fs";
open Permutations.Permute5
let rec processPermutations action perm = 
    action perm
    match nextPerm perm with
    | Some next -> processPermutations action next
    | None -> ()

[0..4] |> processPermutations (printfn "%A")