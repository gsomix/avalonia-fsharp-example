open System
open Avalonia

open AvaloniaFsharpExample

let buildAvaloniaApp() =
    AppBuilder.Configure<App>().UsePlatformDetect()

[<EntryPoint>]
let main argv =
    buildAvaloniaApp().StartWithClassicDesktopLifetime(argv)
