﻿open System

// Define a new function to print a name.
// It is defined above the main function
let printGreeting name =
    printfn "Hello %s from F#!" name

[<EntryPoint>]
let main argv =
    printGreeting "Yuri"
    0 // return an integer exit code
