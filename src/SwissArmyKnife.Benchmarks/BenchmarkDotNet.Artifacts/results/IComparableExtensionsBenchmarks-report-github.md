``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6820HQ CPU 2.70GHz (Skylake), ProcessorCount=8
Frequency=2648440 Hz, Resolution=377.5808 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host] : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2102.0
  Core   : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |          Method |  Job | Runtime |        Mean |     Error |    StdDev | Allocated |
 |---------------- |----- |-------- |------------:|----------:|----------:|----------:|
 | StringIsBetween |  Clr |     Clr | 163.8310 ns | 3.6923 ns | 4.8011 ns |       0 B |
 |    IntIsBetween |  Clr |     Clr |   0.0028 ns | 0.0055 ns | 0.0052 ns |       0 B |
 | DoubleIsBetween |  Clr |     Clr |   6.0952 ns | 0.1283 ns | 0.1200 ns |       0 B |
 | StringIsBetween | Core |    Core |  82.6995 ns | 0.7633 ns | 0.7140 ns |       0 B |
 |    IntIsBetween | Core |    Core |   0.0057 ns | 0.0088 ns | 0.0083 ns |       0 B |
 | DoubleIsBetween | Core |    Core |   5.3396 ns | 0.0650 ns | 0.0608 ns |       0 B |
