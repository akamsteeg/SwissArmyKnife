``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648435 Hz, Resolution=377.5815 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
| Method |  Job | Runtime |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|------- |----- |-------- |---------:|---------:|---------:|-------:|----------:|
|    Add |  Clr |     Clr | 390.3 ns | 2.088 ns | 1.953 ns | 0.0529 |     224 B |
|   Test |  Clr |     Clr | 390.4 ns | 2.136 ns | 1.998 ns | 0.0529 |     224 B |
|    Add | Core |    Core | 342.6 ns | 1.742 ns | 1.455 ns | 0.0548 |     232 B |
|   Test | Core |    Core | 343.1 ns | 1.972 ns | 1.845 ns | 0.0548 |     232 B |
