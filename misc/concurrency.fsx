// nuget install FSharp.Collections.ParallelSeq
#r "./FSharp.Collections.ParallelSeq.1.1.0/lib/netstandard2.0/FSharp.Collections.ParallelSeq.dll"
open FSharp.Collections.ParallelSeq

let list = [1..4] 

list |> Seq.reduce(*)
list |> PSeq.reduce(*)

list |> Seq.reduce(+)
list |> PSeq.reduce(+)