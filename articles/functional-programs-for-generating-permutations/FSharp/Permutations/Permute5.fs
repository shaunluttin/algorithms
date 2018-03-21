// ps: the previous permutation
// rs: the first sublist of ps whose head is greater than its predecessor's.
// qs: the first sublist of ps whose head is less than the head of rs.
// a:  the head of rs
module Permutations.Permute5

// 4. "...exchange the hd's of q and r,and reverse the elements of p up to but excluding q"
// (Topor, 1982)
let next3 ps qs rs =

    let rec genRev (ps: 't list) qs rs ss =
        match ps with
        | _ when ps = rs -> ss
        | _ when ps = qs -> genRev ps.Tail qs rs (rs.Head::ss)
        | _ -> genRev ps.Tail qs rs (ps.Head::ss)

    genRev ps qs rs (qs.Head::rs.Tail)

// 3. "...find the first sublist q of p whose head is less than a" (Topor, 1982)
let rec firstLess (ps: 't list) a =
    match ps with
    | _ when ps.Head < a -> ps
    | _ -> firstLess ps.Tail a
    | _ -> failwith "Invalid argument"

// 2. "If there is no such sublist, then the elements are in reverse order and we
// return NONE since there is no successor." (Topor, 1982)
let next2 ps rs = 
    match rs with 
    | [] -> None
    | _ -> 
        let qs = firstLess ps rs.Head
        let permutation = next3 ps qs rs
        Some (permutation)

// 1. "...find the first sublist r of p whose hd, a, is greater than its predecessor." 
// (Topor, 1982)
let rec firstUp ps  =
    match ps with
    | [ _ ] -> []
    | head::tail when head < tail.Head -> tail
    | _::tail -> firstUp tail
    | _ -> failwith "Invalid argument"

let nextPerm ps =  
    match ps with 
    | [] -> None
    | _ -> 
        let rs = firstUp ps 
        next2 ps rs 

let rec permute5 ps =
    match ps with 
    | None -> []
    | _ -> 
        let ns = nextPerm ps.Value 
        ps.Value::(permute5 ns)