// inserts a in to xs immediately after q
let put a q xs = 
    xs |> Seq.fold 
        (fun acc x -> 
            match x with 
                | x when x = q -> acc@[x;a]
                | _ -> acc@[x]) []

// puts a at each possible position of xs
let insert a xs =             
    xs |> Seq.fold (fun acc x -> (put a x xs)::acc) [a::xs] 
 
insert "0" ["A";"B";"C"] 
