module TestData

type ClassDataBase (generator: obj array seq) = 
    interface obj array seq with 
        member this.GetEnumerator () = generator.GetEnumerator()
        member this.GetEnumerator () = 
            generator.GetEnumerator() :> System.Collections.IEnumerator


type PermuteLexographic () = 
    inherit ClassDataBase(seq 
        {                                                                                         
            yield [| 
                ["A";"B"]; 
                [["A";"B"]; ["B";"A"]] 
            |]
            yield [| List.empty<int>; [ List.empty<int> ] |]
            yield [| [0]; [[0]] |]
            yield [| [0;1]; [[0;1];[1;0]] |]
            yield [| [0;1;2]; [[0;1;2]; [0;2;1]; [1;0;2]; [1;2;0]; [2;0;1]; [2;1;0]] |]
        })
                                                                                                 


type PermuteReverseLexographic () = 
    inherit ClassDataBase(seq 
        {
            yield [| 
                ["A";"B";"C"];
                [["A";"B";"C"];["B";"A";"C"];["A";"C";"B"];["C";"A";"B"];["B";"C";"A"];["C";"B";"A"]] 
            |]
            yield [| List.empty<int>; [ List.empty<int> ] |]
            yield [| [0]; [ [0] ] |]
            yield [| [0;1]; [ [0;1]; [1;0] ] |]
        })