module Permute2Tests

open Xunit
open Permutations.Permute2

[<Theory>]
[<MemberData("mapConsTestData")>]
let ``mapConsTest`` (item, ps, qs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapCons item ps qs

    // Assert
    Assert.Equal<'t list list>(expected, actual)

[<Theory>]
[<MemberData("mapConsTestData")>]
let ``mapConsRecursiveTest`` (item, ps, qs, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapConsRecursive item ps qs

    // Assert
    Assert.Equal<'t list list>(expected, actual)


[<Theory>]
[<MemberData("mapPermTestData")>]
let ``mapPermTest`` (x, y, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapPerm x y []

    // Assert
    Assert.Equal<'t list list>(expected, actual)

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

let mapConsTestData : obj array seq =
    seq {
        yield [| 0; List.empty<List<int>>; List.empty<List<int>>; List.empty<List<int>> |]
        yield [| 0; [ List.empty<int> ]; List.empty<List<int>>; [ [0] ] |]
        yield [| 0; [ [1] ]; List.empty<List<int>>; [ [0;1] ] |]
        yield [| 0; [ [1]; [2] ]; List.empty<List<int>>; [ [0;1]; [0;2] ] |]
        yield [| 0; [ [1;2]; [2;3] ]; List.empty<List<int>>; [ [0;1;2]; [0;2;3] ] |]
        yield [| 0; [ [1] ]; [ [1;0] ]; [ [0;1]; [1;0] ] |]
    }

let mapPermTestData : obj array seq =
    seq {
        yield [| List.empty<int>; List.empty<int>; List.empty<List<int>> |]
        yield [| [0]; [0]; [[0]] |]
        yield [| [0;1]; [0;1]; [[0;1];[1;0]] |]
    }
