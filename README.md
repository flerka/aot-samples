This repository contains sample projects for my [blog post](https://flerka.github.io/personal-blog/2022-06-21-ahead-of-time-compilation/) about ahead-of-time compilation. 

## Repository structure
- *measure-execution* - contains bash script I used to measure application execution time
- *regular-nonquickjit-console-net7* - ReadyToRun turned off, and QuickJIT turned off console sample
- *regular-console-net7* - ReadyToRun is off, and QuickJIT is on console sample
- *r2r-quickloops-console-net7* - ReadyToRun with Quick JIT for loops console sample
- *r2r-console-net7* - ReadyToRun console sample
- *native-aot-console-net7* - Native AOT console sample
- *native-aot-lambda-net7* - Native AOT .NET 7 lambda on provided.al2.
- *r2r-lambda-net6* - ReadyToRun .NET 6 lambda on dotnet6
- *r2r-lambda-net7* - ReadyToRun .NET 7 lambda on provided.al2
- *regular-lambda-net6* - regular .NET 6 Lambda on dotnet6 with ReadyToRun off
- *regular-lambda-net7* - regular .NET 7 lambda on provided.al2 with ReadyToRun off

### Console project structure
- *Program.cs* - my sample code, naive solution for Advent of Code.
- *aot-samples.csproj* - project file with all compilation settings.
- *aot-samples.exe* - result application self-contained executables. 
- *result.txt* - measurements data after 1000 execution.

### Console project execution
I used `dotnet publish -c Release` without additional parameters to publish samples. 

And I used this command on Windows x64 Git bash to run measurements tests:
 ```bash
 for run in {1..1000}; do (./measure-execution ./aot-samples.exe >/dev/null) &>> result.txt; done
```

### Lambda project structure
- *Program.cs* - my sample code, naive solution for Advent of Code.
- *aot-samples.csproj* - project file with all compilation settings.
- *aws-lambda-tools-defaults.json* - lambda settings

### Lambda project execution
- `dotnet lambda deploy-function --function-name FUNCTION_NAME` to deploy lambda
- `dotnet lambda invoke-function FUNCTION_NAME -p "Hello World"` to invoke lambda
- `dotnet lambda delete-function --function-name LAMBDA_NAME` to delete lambda after execution

You can check my [article](https://flerka.github.io/personal-blog/2022-06-21-ahead-of-time-compilation/) for additional details.