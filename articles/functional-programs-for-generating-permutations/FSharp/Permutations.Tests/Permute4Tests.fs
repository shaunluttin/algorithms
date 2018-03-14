module Permute4Tests

open Xunit
open Permutations.Permute4

[<Theory(Skip = "Not implemented")>]
[<MemberData("mapPermTestData")>]
let ``mapPerm`` (x, i, j, ps, expected: List<List<int>>) =
    // Arrange // Act
    let actual = mapPerm x i j ps

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Theory(Skip = "Not implemented")>]
[<MemberData("genPermTestData")>]
let ``genPerm`` (x, j, ps, expected: List<List<int>>) =
    // Arrange // Act
    let actual = genPerm x j ps

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)

[<Theory(Skip = "Not implemented")>]
[<MemberData("permuteTestData")>]
let ``permute`` (x, expected: List<List<int>>) =
    // Arrange // Act
    let actual = permute x

    // Assert
    Assert.Equal<List<List<int>>>(expected, actual)
