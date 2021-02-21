open System

let rec input s  = 
    printf "%s: " s
    try
        Console.ReadLine() |> int
    with
        | _ -> printfn "Некорректный ввод!"; input s


[<EntryPoint>]
let main argv =
    let startInt = 
        input "Введите начало диапазона"

    let endInt = 
        input "Введите конец диапазона"

    let evens = 
        EvenNumbers.getFrom [startInt..endInt]        

    let evensCount =
        Seq.length evens 

    printfn "Кол-во четных элементов: %i" evensCount
    for even in evens do
        printfn "%i" even
    
    printfn "\r\nГотово"
    Console.ReadKey() |> ignore
    0

