
### Permutation-related Terminology

* multiset: a set which may contain duplicate items; multiset equality depends on element order.
* permutation: order matters
* combination: order does matter

Names of permutation types: 

1. permutations of length N from a set of length N (set contains no duplicates; order does not matter)
2. permutations of length K <= N from a set of length N
3. permutations of length N from a multiset of length N (multiset contains duplicates; order matters)
4. permutation orders: lexographic; reverse lexographic

### FSharp List related Symbols

    elem :: list   // append a single element to the front of a list
    listA @ listB  // concatenate two lists

### NuGet restore without internet connetion: 

First list the local sources: 

    dotnet nuget locals all --list

Then use one or more of them:

    dotnet restore --source C:\Users\bigfo\.nuget\packages\
    dotnet build --no-restore

## Introduction

* algorithms will use linear linked lists not arrays
* function definitions will be mutually recursive
* affinity with Lisp and Backus function programming systems
* all operations are constructive
* fields of list nodes cannot be altered (immutable) 

### Generally

hd x 
    return the first element of a list

tl x 
    return the list without the first element

cons a x 
    create a new list with (a) in front of (x), such that hd will be (a) and tl will be (x)

## In the Article

list(x) 
    create a new list with a single element (x)

|x|
    return the length of list (x)

x - a
    the result of deleting the first occurance of (a) from (x)

x|y
    the result of concantenating two lists (x) and (y)

