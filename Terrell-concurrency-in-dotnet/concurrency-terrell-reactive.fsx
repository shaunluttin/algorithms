open System;
open System.Timers;
open System.Threading.Tasks;

let squareOfDigits (chars:char list) =
    chars
    // filter event digits
    |> List.filter (fun c -> Char.IsDigit c && int c % 2 = 0)
    // square them
    |> List.map (fun n -> int n * int n)

let isEven x = x % 2 = 0;

let toSeconds (x:ElapsedEventArgs) = 
    x.SignalTime.Second;

// using events
let t2 = new Timer(float 1000)
t2.Elapsed 
    |> Event.map(toSeconds)
    |> Event.filter(isEven)
    |> Event.map(printfn "%O")

t2.Start();
Task.Delay(10000).GetAwaiter().GetResult()
t2.Stop();

// using observables
let t1 = new Timer(float 500);
let disposable = 
    t1.Elapsed 
        |> Observable.map(fun _ -> "t1") 
        |> Observable.subscribe(fun s -> printfn "%s" s)

t1.Start()
Task.Delay(10000).GetAwaiter().GetResult();
disposable.Dispose();