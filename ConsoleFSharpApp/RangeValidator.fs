module RangeValidator

let rec input s  = 
    printf "%s: " s
    try
        System.Console.ReadLine() |> int
    with
        | _ -> printfn "Некорректный ввод!"
               input s

let rec getValidRange head tail =
    try
        if tail <= head then
            raise (System.ArgumentException())            
        else            
            MyRange.create head tail
                               
    with
        | _ -> printfn "Конец диапазона не может быть меньше или равен началу!" 
               input "Введите конец диапазона" 
               |> getValidRange head 

let createRange = 
    let head = input "Введите начало диапазона"
    let tail = input "Введите конец диапазона"    
    getValidRange head tail
 

