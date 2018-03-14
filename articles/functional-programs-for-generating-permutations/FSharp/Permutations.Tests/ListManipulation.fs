module ListManipulationTests

open Xunit
open Permutations.ListManipulation

[<Theory>]
[<MemberData("removeFirstTestData")>]
let ``removeFirst`` (item, list, expected: List<int>) =
    // Arrange // Act
    let actual = removeFirst item list

    // Assert
    Assert.Equal<List<int>>(expected, actual)

let removeFirstTestData : obj array seq = 
    seq {
        // not in list
        yield [| 0; [1;2;3;4]; [1;2;3;4] |]
        // in list once
        yield [| 0; [0;1;2;3]; [1;2;3] |]
        yield [| 0; [1;0;2;3]; [1;2;3] |]
        yield [| 0; [1;2;0;3]; [1;2;3] |]
        yield [| 0; [1;2;3;0]; [1;2;3] |]
        // in list multiple times
        yield [| 0; [0;0;0;3]; [0;0;3] |]
    }