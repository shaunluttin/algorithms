#time

// nuget install FSharp.Collections.ParallelSeq
#r "./FSharp.Collections.ParallelSeq.1.1.0/lib/netstandard2.0/FSharp.Collections.ParallelSeq.dll"
open FSharp.Collections.ParallelSeq

let put a q xs =
    ([], xs)
        ||> Seq.fold (fun acc x ->
            if x = q then a::x::acc
            else x::acc)
        |> List.rev

let putAtEach a xs =
    ([a::xs], xs)
        ||> Seq.fold (fun acc x ->
            (put a x xs)::acc)

let rec permute (xs:'t list) = 
    if xs.Length = 1 then [xs]
    else permute xs.Tail |> Seq.fold (fun acc ps -> (putAtEach xs.Head ps)@acc) []

permute ["A";"B";"C"] |> ignore
