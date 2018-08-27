module MyProject.Logging

open Fable.Core.JsInterop
open Fable.Core

open Fable.Import
open Fable.Import.Browser
open Fable.Import.JS

open MyProject.Sdk.Logging

type Logger(name:string) =
    interface ILogger with
        member x.Log d =
            console.log(name + ": " + d)

[<Global>]
let LogManager : ILogManager = jsNative

do window?LogManager <-
    { new ILogManager with
        member x.Create name =
            new Logger(name) :> ILogger }

let dummy() = ()    