// ps: the previous permutation
// rs: the first sublist of ps whose head is greater than its predecessor's.
// qs: the first sublist of ps whose head is less than the head of rs.
// a:  the head of rs
module Permutations.Permute5

    let next3 ps qs rs =

        let rec genRev (ps: 't list) qs rs ss =
            match ps with
            | _ when ps = rs -> ss
            | _ when ps = qs -> genRev ps.Tail qs rs (rs.Head::ss)
            | _ -> genRev ps.Tail qs rs (ps.Head::ss)

        genRev ps qs rs (qs.Head::rs.Tail)

    let rec firstLess (ps: 't list) a =
        match ps with
        | _ when ps.Head < a -> ps
        | _ -> firstLess ps.Tail a

    let next2 ps rs = 
        match rs with 
        | [] -> None
        | _ -> 
            let qs = firstLess ps rs.Head
            let permutation = next3 ps qs rs
            Some (permutation)

    let rec firstUp ps  =
        match ps with
        | [ _ ] -> []
        | psHead::psTail when psHead < psTail.Head -> psTail
        | _ -> firstUp ps.Tail

    let nextPerm ps =  
        match ps with 
        | [] -> None
        | _ -> 
            let rs = firstUp ps 
            next2 ps rs 

    let rec permute ps =
        match ps with 
        | None -> []
        | Some prev ->
            let ns = nextPerm prev
            prev::(permute ns)