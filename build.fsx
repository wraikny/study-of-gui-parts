#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.Core.Target
nuget Fake.IO.Zip //"
#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.IO
open Fake.Core.TargetOperators
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators

Target.initEnvironment ()

Target.create "Zip" (fun _ ->
  !! "works/**"
  ++ "README.md"
  ++ "LICENSE"
  |> Zip.zip "." "wraikny-StudyOfGUIParts.zip"
)

Target.runOrDefault "Zip"
