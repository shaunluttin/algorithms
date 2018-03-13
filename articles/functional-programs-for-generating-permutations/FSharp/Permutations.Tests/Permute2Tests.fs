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

[<Theory>]
[<MemberData("mapconsTestData")>]
let ``mapcons`` (item, ps, qs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapcons item ps qs

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Theory>]
[<MemberData("mappermTestData")>]
let ``mapperm`` (x, y, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapperm x y

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Theory>]
[<MemberData("permuteTestData")>]
let ``permute`` (x, expected: List<List<int>>) =
    // Arrange // Act
    let actual = permute x

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

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
        yield [| 0; [ [1] ]; [ [1;0] ]; [ [0;1]; [1;0] ] |]
    }

let mappermTestData : obj array seq = 
    seq {
        yield [| List.empty<int>; List.empty<int>; List.empty<List<int>> |]
        yield [| [0]; [0]; [[0]] |]
        yield [| [0;1]; [0;1]; [[0;1];[1;0]] |]
    }

let permuteTestData : obj array seq = 
    seq {
        yield [| List.empty<int>; [ List.empty<int> ] |]
        yield [| [0]; [ [0] ] |]
    }