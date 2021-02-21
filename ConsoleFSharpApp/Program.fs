open System

[<EntryPoint>]
let main argv =  
    let startInt = 
        printf "Введите начало диапазона: "     
        Console.ReadLine() |> int        

    let endInt = 
        printf "Введите конец диапазона: "
        Console.ReadLine() |> int    

    let evenSeq = 
        EvenNumbers.getFrom [startInt..endInt] 

    for i in evenSeq do
        printfn "%i" i
    
    printfn "\r\nГотово"
    Console.ReadKey() |> ignore
    0

