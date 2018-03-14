module ListManipulationTests

open Xunit
open Permutations.ListManipulation

[<Theory(Skip = "Not implemented")>]
[<MemberData("putTestData")>]
let ``put`` (a, x, j, expected: List<int>) =
    // Arrange // Act
    let actual = put a x j

    // Assert
    Assert.Equal<List<int>>(expected, actual)

[<Theory(Skip = "Not implemented")>]
[<MemberData("moveTestData")>]
let ``move`` (x, i, j, expected: List<int>) =
    // Arrange // Act
    let actual = move x i j

    // Assert
    Assert.Equal<List<int>>(expected, actual)

[<Theory>]
[<MemberData("removeFirstTestData")>]
let ``removeFirst`` (x, xs, expected: List<int>) =
    // Arrange // Act
    let actual = removeFirst x xs

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