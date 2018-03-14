module Permute4Tests

open Xunit
open Permutations.Permute4

[<Theory>]
[<MemberData("permuteTestData")>]
let ``permute`` (xs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = permute xs

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

// TODO Share this test data among the other tests.
// We have two types of expectations: lexographic and reversed-lexographic.
let permuteTestData : obj array seq = 
    seq {
        yield [| List.empty<int>; [ List.empty<int> ] |]
        // yield [| [0]; [ [0] ] |]
        // yield [| [0;1]; [ [0;1]; [1;0] ] |]
        // yield [| 
        //     ["A";"B";"C"];
        //     [["A";"B";"C"];["B";"A";"C"];["A";"C";"B"];["C";"A";"B"];["B";"C";"A"];["C";"B";"A"]] 
        // |]
    }