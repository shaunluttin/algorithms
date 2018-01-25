
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

