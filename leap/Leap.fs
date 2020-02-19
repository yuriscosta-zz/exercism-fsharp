module Leap

let leapYear (year: int): bool =
    let divisableByFour = year % 4 = 0
    let divisableByHundred = year % 100 = 0
    let divisableByFourHundred = year % 400 = 0

    divisableByFourHundred || (divisableByFour <> divisableByHundred)