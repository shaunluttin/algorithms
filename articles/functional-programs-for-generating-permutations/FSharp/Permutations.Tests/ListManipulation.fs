module ListManipulationTests

open Xunit
open Permutations.ListManipulation

[<Theory>]
[<MemberData("putTestData")>]
let ``put`` (a, j, xs, expected: 't list) =
    // Arrange // Act
    let actual = put a j xs 

    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory>]
[<MemberData("moveTestData")>]
let ``move`` (i, j, xs, expected: 't list) =
    // Arrange // Act
    let actual = move i j xs

    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory>]
[<MemberData("removeFirstTestData")>]
let ``removeFirst`` (x, xs, expected: List<int>) =
    // Arrange // Act
    let actual = removeFirst x xs

    // Assert
    Assert.Equal<List<int>>(expected, actual)

// inserts x into xs at the j'th index.
let putTestData: obj array seq = 
    seq {
        yield [| "D"; 0; ["A";"B"]; ["D";"A";"B"] |]
        yield [| "D"; 1; ["A";"B"]; ["A";"D";"B"] |]
        yield [| "D"; 2; ["A";"B"]; ["A";"B";"D"] |]
    }

// deletes the current i'th element of xs
// and inserts it after the current j'th element of xs.
// [we are assuming that i and j start at one not zero.]
let moveTestData : obj array seq = 
    seq {
        yield [| 1; 2; ["A";"B";"C"]; ["B";"A";"C"] |]
        yield [| 1; 3; ["A";"B";"C"]; ["B";"C";"A";] |]
        yield [| 2; 3; ["A";"B";"C"]; ["A";"C";"B";] |]
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