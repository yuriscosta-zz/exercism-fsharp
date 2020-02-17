module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int =
    let isMultiple x = List.exists (fun y -> y <> 0 && x % y = 0) numbers

    [ 1 .. upperBound - 1 ]
    |> List.filter isMultiple
    |> List.sum