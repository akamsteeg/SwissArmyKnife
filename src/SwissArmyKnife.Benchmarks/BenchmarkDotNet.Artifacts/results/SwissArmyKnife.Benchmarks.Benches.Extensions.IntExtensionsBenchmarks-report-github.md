``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648435 Hz, Resolution=377.5815 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                  Method |  Job | Runtime |     Mean |     Error |    StdDev | Allocated |
|------------------------ |----- |-------- |---------:|----------:|----------:|----------:|
| MilliSeconds_Succesfull |  Clr |     Clr | 4.377 ns | 0.0429 ns | 0.0402 ns |       0 B |
|      Seconds_Succesfull |  Clr |     Clr | 4.421 ns | 0.0379 ns | 0.0317 ns |       0 B |
|      Minutes_Succesfull |  Clr |     Clr | 4.402 ns | 0.0329 ns | 0.0307 ns |       0 B |
|        Hours_Succesfull |  Clr |     Clr | 4.390 ns | 0.0459 ns | 0.0407 ns |       0 B |
|         Days_Succesfull |  Clr |     Clr | 4.362 ns | 0.0257 ns | 0.0241 ns |       0 B |
| MilliSeconds_Succesfull | Core |    Core | 3.891 ns | 0.0298 ns | 0.0264 ns |       0 B |
|      Seconds_Succesfull | Core |    Core | 3.857 ns | 0.0316 ns | 0.0280 ns |       0 B |
|      Minutes_Succesfull | Core |    Core | 3.834 ns | 0.0188 ns | 0.0167 ns |       0 B |
|        Hours_Succesfull | Core |    Core | 3.871 ns | 0.0453 ns | 0.0378 ns |       0 B |
|         Days_Succesfull | Core |    Core | 3.865 ns | 0.0805 ns | 0.0753 ns |       0 B |
