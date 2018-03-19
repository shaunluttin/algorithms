module Permute5Tests

open Xunit
open Permutations.Permute5

[<Theory>]
[<MemberData("genRevTestData")>]
let ``genRev`` () =
    // Arrange // Act 
    
    // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("next3TestData")>]
let ``next3`` =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("firstLessTestData")>]
let ``firstLess`` =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("mapConsTestData")>]
let ``next2`` =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("firstUpTestData")>]
let ``firstUp`` =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("nextPermTestData")>]
let ``nextPerm`` =
    // Arrange // Act // Assert
    Assert.Equal(true, false)
