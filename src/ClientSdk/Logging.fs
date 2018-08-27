module MyProject.Sdk.Logging

open Fable.Core

type ILogger =
    abstract Log: string -> unit

type ILogManager =
    abstract Create: string -> ILogger

[<Global>]
let LogManager : ILogManager = jsNative

