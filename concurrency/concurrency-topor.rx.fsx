#time

// nuget install FSharp.Collections.ParallelSeq
#r "./FSharp.Collections.ParallelSeq.1.1.0/lib/netstandard2.0/FSharp.Collections.ParallelSeq.dll"
open FSharp.Collections.ParallelSeq
open System.Collections.ObjectModel

let put a q xs =
    ([], xs)
        ||> Seq.fold (fun acc x ->
            if x = q then a::x::acc
            else x::acc)
        |> List.rev

let putAtEach a xs =
    let result = ([a::xs], xs) ||> Seq.fold (fun acc x -> (put a x xs)::acc)
    new ObservableCollection<'t>(result)

putAtEach 0 [1] |> Observable.scan(fun acc item -> acc)