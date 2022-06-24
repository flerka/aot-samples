This repository contains sample projects for my [blog post](https://flerka.github.io/personal-blog/2022-06-21-ahead-of-time-compilation/) about ahead-of-time compilation. 

## Repository structure
- *measure-execution* - contains bash script I used to measure application execution time.
- *regular-nonquickjit-net7* - ReadyToRun turned off, and QuickJIT turned off sample.
- *regular-net7* - ReadyToRun is off, and QuickJIT is on sample.
- *r2r-quickloops-net7* - ReadyToRun with Quick JIT for loops sample.
- *r2r-net7* - ReadyToRun sample.
- *native-aot-net7* - Native AOT turned on sample.

## Sample projects structure
- *src/Program.cs* - my sample code, naive solution for Advent of Code.
- *src/aot-samples.csproj* - project file with all compilation settings.
- *aot-samples.exe* - result application self-contained executables. 
- *result.txt* - measurements data after 1000 execution.

I used `dotnet publish -c Release` without additional parameters to publish samples. 

And I used this command on Windows x64 Git bash to run measurements tests:
 ```bash
 for run in {1..1000}; do (./measure-execution ./aot-samples.exe >/dev/null) &>> result.txt; done
```

You can check my [article](https://flerka.github.io/personal-blog/2022-06-21-ahead-of-time-compilation/) for additional details.