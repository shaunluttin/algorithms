module Permute2Tests

open Xunit
open Permutations.Permute2

[<Theory>]
[<MemberData("mapconsTestData")>]
let ``mapconsTest`` (item, ps, qs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapCons item ps qs

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Theory>]
[<MemberData("mapconsTestData")>]
let ``mapconsRecursiveTest`` (item, ps, qs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapConsRecursive item ps qs

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)


[<Theory>]
[<MemberData("mappermTestData")>]
let ``mappermTest`` (x, y, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapperm x y []

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Theory>]
[<ClassData(typeof<TestData.PermuteLexographic>)>]
let ``permuteTest`` (xs, expected: 't list list) =
    // Arrange // Act
    let actual = permute xs

    // Assert
    Assert.Equal<'t list list>(expected, actual)

[<Theory>]
[<ClassData(typeof<TestData.RPermuteLexographic>)>]
let ``rpermuteTest`` (xs, expected: 't list list) =
    // Arrange // Act
    let actual = permute xs

    // Assert
    Assert.Equal<'t list list>(expected, actual)

[<Theory>]
[<ClassData(typeof<TestData.KPermuteLexographic>)>]
let ``kpermuteTest`` (k, xs, expected: 't list list) =
    // Arrange // Act
    let actual = kpermute k xs

    // Assert
    Assert.Equal<'t list list>(expected, actual)

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
