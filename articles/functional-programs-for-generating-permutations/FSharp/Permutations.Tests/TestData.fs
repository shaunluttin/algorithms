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
            yield [|
                List.empty<string>;
                [ List.empty<string> ]
            |]
            yield [|
                ["A"];
                [["A"]]
            |]
            yield [|
                ["A";"B"];
                [["A";"B"];["B";"A"]]
            |]
            yield [|
                ["A";"B";"C"];
                [["A";"B";"C"]; ["A";"C";"B"]; ["B";"A";"C"]; ["B";"C";"A"]; ["C";"A";"B"]; ["C";"B";"A"]]
            |]
        })

type PermuteReverseLexographic () =
    inherit ClassDataBase(seq
        {
            yield [|
                ["A";"B";"C"];
                [["A";"B";"C"];["B";"A";"C"];["A";"C";"B"];["C";"A";"B"];["B";"C";"A"];["C";"B";"A"]]
            |]
            yield [|
                List.empty<int>;
                [ List.empty<int> ]
            |]
            yield [|
                ["A"];
                [["A"]]
            |]
            yield [|
                ["A";"B"]; [ ["A";"B"]; ["B";"A"] ]
            |]
        })

type KPermuteLexographic () =
    inherit ClassDataBase(seq
        {
            yield [|
                0;
                ["A";"B";"C"];
                [List.empty<string>]
            |]
            yield [|
                1;
                ["A";"B";"C"];
                [["A"];["B"];["C"]]
            |]
            yield [|
                2;
                ["A";"B";"C"];
                [["A";"B"];["A";"C"];["B";"A"];["B";"C"];["C";"A"];["C";"B"]]
            |]
        })

type RPermuteLexographic () =
    inherit ClassDataBase(seq
        {
            yield [|
                ["A";"A";"B";"B"];
                [
                    ["A";"A";"B";"B"];
                    ["A";"B";"A";"B"];
                    ["A";"B";"B";"A"];
                    ["B";"A";"A";"B"];
                    ["B";"A";"B";"A"];
                    ["B";"B";"A";"A"]
                ]
            |]
        })
