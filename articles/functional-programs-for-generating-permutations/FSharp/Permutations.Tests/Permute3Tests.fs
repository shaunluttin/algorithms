module Permute3Tests

open Xunit
open Permutations.Permute3

[<Theory>]
[<MemberData("permuteTestData")>]
let ``permute`` (x, expected: 't list list) =
    // Arrange // Act
    let actual = permute x

    // Assert
    Assert.Equal<'t list list>(expected, actual)

let permuteTestData : obj array seq = 
    seq {
        yield [| List.empty<int>; [ List.empty<int> ] |]
        yield [| [0]; [ [0] ] |]
        yield [| [0;1]; [ [0;1]; [1;0] ] |]
        yield [| 
            ["A";"B";"C"];
            [["A";"B";"C"];["B";"A";"C"];["A";"C";"B"];["C";"A";"B"];["B";"C";"A"];["C";"B";"A"]] 
        |]
    }