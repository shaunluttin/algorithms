module Permute2Tests

open Xunit
open Permutations.Permute2

[<Theory>]
[<MemberData("removeFirstTestData")>]
let ``removeFirst`` (item, list, expected: List<int>) =
    // Arrange // Act
    let actual = removeFirst list item

    // Assert
    Assert.Equal<List<int>>(expected, actual)

[<Theory(Skip = "Test data returned null")>]
[<MemberData("mapconsTestData")>]
let ``mapcons`` (item, ps, qs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapcons item ps qs

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Fact(Skip = "Not implemented yet")>]
let ``mapperm`` () =
    // Arrange // Act
    let actual = mapperm 
                    List<int>.Empty 
                    List<int>.Empty

    // Assert
    Assert.True(false)

[<Fact(Skip = "Not implemented yet")>]
let ``permute`` () =
    // Arrange // Act
    let actual = permute List<int>.Empty

    // Assert
    Assert.True(false)

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

let mapconsTestData : obj array seq = 
    seq {
        yield [| 0; List.empty<List<int>>; List.empty<List<int>>; List.empty<List<int>> |]
        yield [| 0; [ List.empty<int> ]; List.empty<List<int>>; [ [0] ] |]
        yield [| 0; [ [1] ]; List.empty<List<int>>; [ [0;1] ] |]
        yield [| 0; [ [1]; [2] ]; List.empty<List<int>>; [ [0;1]; [0;2] ] |]
        yield [| 0; [ [1;2]; [2;3] ]; List.empty<List<int>>; [ [0;1;2]; [0;2;3] ] |]
    }