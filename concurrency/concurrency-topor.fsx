

let put a q xs = 
    xs |> Seq.fold 
        (fun acc x -> match x with 
                        | x when x = q -> a::x::acc
                        | _ -> x::acc) []

["A";"B";"C"] |> put "0" "A"