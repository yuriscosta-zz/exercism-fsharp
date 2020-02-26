module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    let rec loop input accumulator =
        match input with
        | [] -> accumulator |> List.rev
        | head :: tail -> 
            ((func head) :: accumulator) |> loop tail
    loop input []