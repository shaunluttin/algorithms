module Permute5Tests

open Xunit
open Permutations.Permute5

[<Theory>]
[<MemberData("next3TestData")>]
let ``next3Test`` (ps, qs, rs, expected: 't list) =
    // Arrange // Act
    let actual = next3 ps qs rs

    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory>]
[<MemberData("firstLessTestData")>]
let ``firstLessTest`` (ps: 't list, a: 't, expected: 't list) =
    // Arrange // Act
    let actual = firstLess ps a

    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory>]
[<MemberData("next2TestData")>]
let ``next2Test`` (ps, rs, expected: 't list option) =
    // Arrange // Act
    let actual = next2 ps rs

    // Assert
    Assert.Equal<'t list option>(expected, actual)

[<Theory>]
[<MemberData("firstUpTestData")>]
let ``firstUpTest`` (ps: 't list, expected: 't list) =
    // Arrange // Act
    let actual = firstUp ps

    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory>]
[<MemberData("nextPermTestData")>]
let ``nextPermTest`` (ps, expected: 't list option) =
    // Arrange // Act
    let actual = nextPerm ps

   // Assert
    Assert.Equal<'t list option>(expected, actual)

[<Theory>]
[<ClassData(typeof<TestData.PermuteReverseLexographic>)>]
let ``permuteTest`` (ps, expected: 't list list) =
    // Arrange // Act
    let actual = permute (Some(ps))

   // Assert
    Assert.Equal<'t list list>(expected, actual)

let next3TestData : obj array seq =
    seq {
        yield [|
            ["A";"B";"C"];
            ["A";"B";"C"];
            ["B";"C"];
            ["B";"A";"C"];
        |]
        yield [|
            ["B";"A";"C"];
            ["B";"A";"C"];
            ["C"];
            ["A";"C";"B"];
        |]
        yield [|
            ["H";"F";"E";"D";"G";"C";"A";"B"];
            ["F";"E";"D";"G";"C";"A";"B"];
            ["G";"C";"A";"B"];
            ["D";"E";"G";"H";"F";"C";"A";"B"];
        |]
    }

let firstLessTestData : obj array seq =
    seq {
        yield [| ["A";"B";"C"]; "B"; ["A";"B";"C"] |]
        yield [| ["B";"A";"C"]; "C"; ["B";"A";"C"] |]
        yield [| ["C";"B";"A"]; "B"; ["A"] |]
    }

let next2TestData : obj array seq = 
    seq {
        yield [| ["A"]; List.empty<string>; None |]
        // 
        yield [|
            ["A";"B";"C"]; // first
            ["B";"C"]; 
            Some(["B";"A";"C"]); 
        |]
        yield [|
            ["B";"A";"C"]; // second
            ["C"]; 
            Some(["A";"C";"B"]);
        |]
        yield [|
            ["B";"C";"A"]; // fifth
            ["C";"A"]; 
            Some(["C";"B";"A"]); 
        |]
        yield [|
            ["C";"B";"A"]; // sixth
            List.empty<string>
            None
        |]
    }

let firstUpTestData : obj array seq =
    seq {
        yield [| ["A"]; List.empty<string> |] 
        // 
        yield [| ["A";"B";"C"]; ["B";"C"] |] // first
        yield [| ["B";"A";"C"]; ["C"] |] // second
        yield [| ["A";"C";"B"]; ["C";"B"] |] // third
        yield [| ["C";"A";"B"]; ["B"] |] // fourth
        yield [| ["B";"C";"A"]; ["C";"A"] |] // fifth
        yield [| ["C";"B";"A"]; List.empty<string> |] // sixth
    }

let nextPermTestData : obj array seq = 
    seq {
        yield [| ["A"]; None |]
        // 
        yield [| ["A";"B"]; Some(["B";"A"]) |]
        yield [| ["B";"A"]; None |]
        // 
        yield [| ["A";"B";"C"]; Some(["B";"A";"C"]) |] // first
        yield [| ["B";"A";"C"]; Some(["A";"C";"B"]) |] // second
        yield [| ["A";"C";"B"]; Some(["C";"A";"B"]) |] // third
        yield [| ["C";"A";"B"]; Some(["B";"C";"A"]) |] // fourth
        yield [| ["B";"C";"A"]; Some(["C";"B";"A"]) |] // fifth
        yield [| ["C";"B";"A"]; None |] // sixth
    }