let put a q xs =
    ([], xs)
        ||> Seq.fold (fun acc x ->
            if x = q then a::x::acc
            else x::acc)
        |> List.rev

let putAtEveryPossible a xs =
    ([a::xs], xs)
        ||> Seq.fold (fun acc x ->
            (put a x xs)::acc)

#time

putAtEveryPossible 0 [1..10]
