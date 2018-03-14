module ListManipulationTests

open Xunit
open Permutations.ListManipulation

[<Theory>]
[<MemberData("putTestData")>]
let ``put`` (a, xs, j, expected: 't list) =
    // Arrange // Act
    let actual = put a xs j

    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory(Skip = "Not implemented")>]
[<MemberData("moveTestData")>]
let ``move`` (xs, i, j, expected: List<int>) =
    // Arrange // Act
    let actual = move xs i j

    // Assert
    Assert.Equal<List<int>>(expected, actual)

[<Theory>]
[<MemberData("removeFirstTestData")>]
let ``removeFirst`` (x, xs, expected: List<int>) =
    // Arrange // Act
    let actual = removeFirst x xs

    // Assert
    Assert.Equal<List<int>>(expected, actual)

let putTestData: obj array seq = 
    seq {
        yield [| "D"; ["A"; "B"; "C"]; 0; ["D"; "A"; "B"; "C"] |]
    }

// deletes the i'th element of xs
// and inserts it after the j'th element of xs.
// [we are assuming that i and j start at one not zero.]
let moveTestData : obj array seq = 
    seq {
        yield [| [0;1;2;3]; 1, 2, [1;2;0;3] |]
    }

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