open System
open Avalonia

open AvaloniaFsharpExample

[<EntryPoint>]
let main argv =
    AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .Start<MainWindow>()
    0
