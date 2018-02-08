``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6820HQ CPU 2.70GHz (Skylake), ProcessorCount=8
Frequency=2648440 Hz, Resolution=377.5808 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host] : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2102.0
  Core   : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 | Method |  Job | Runtime |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
 |------- |----- |-------- |---------:|---------:|---------:|-------:|----------:|
 |    Add |  Clr |     Clr | 425.1 ns | 2.969 ns | 2.777 ns | 0.0529 |     224 B |
 |   Test |  Clr |     Clr | 426.6 ns | 3.035 ns | 2.839 ns | 0.0529 |     224 B |
 |    Add | Core |    Core | 359.3 ns | 2.711 ns | 2.536 ns | 0.0548 |     232 B |
 |   Test | Core |    Core | 362.3 ns | 3.324 ns | 3.110 ns | 0.0548 |     232 B |
