This repository contains sample projects for my [blog post](https://flerka.github.io/personal-blog/2022-06-21-ahead-of-time-compilation/) about ahead-of-time compilation. 

## Repository structure
- *measure-execution* - contains bash script I used to measure application execution time.
- *regular-nonquickjit-net7* folder - ReadyToRun turned off, and QuickJIT turned off sample.
- *regular-net7* folder - ReadyToRun is off, and QuickJIT is on sample.
- *r2r-quickloops-net7* folder - ReadyToRun with Quick JIT for loops sample.
- *r2r-net7* folder - ReadyToRun sample.
- *native-aot-net7* folder - Native AOT turned on sample.

## Sample projects structure
- *src/Program.cs* - my sample code, naive solution for Advent of Code.
- *src/aot-samples.csproj* - project file with all compilation settings.
- *aot-samples.exe* - result application self-contained executables. I used `dotnet publish -c Release` without additional parameters.
- *result.txt* - measurements data after 1000 execution. I used `for run in {1..1000}; do (./measure-execution ./aot-samples.exe >/dev/null) &>> result.txt; done` on Windows x64 Git bash.

You can check my [article](https://flerka.github.io/personal-blog/2022-06-21-ahead-of-time-compilation/) for additional details.