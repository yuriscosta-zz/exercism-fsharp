module QueenAttack

let create (position: int * int) =
    let row, column = position
    row >= 0 && row <= 7 && column >= 0 && column <= 7

let canAttack (queen1: int * int) (queen2: int * int) =
    let row1, column1 = queen1
    let row2, column2 = queen2
    row1 = row2  
    || column1 = column2 
    || abs (row1 - row2) = abs (column1 - column2)