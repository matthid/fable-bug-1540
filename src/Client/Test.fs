module MyProject.Test

open MyProject.Sdk.Logging

let l = LogManager.Create "test"

do l.Log("Test")

let doSomething() =
    l.Log("doSomething")