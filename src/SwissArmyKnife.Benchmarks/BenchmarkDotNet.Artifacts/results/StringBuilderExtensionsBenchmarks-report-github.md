``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6820HQ CPU 2.70GHz (Skylake), ProcessorCount=8
Frequency=2648440 Hz, Resolution=377.5808 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host] : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2102.0
  Core   : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                       Method |  Job | Runtime |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
 |----------------------------- |----- |-------- |----------:|----------:|----------:|-------:|----------:|
 |    AppendFormattedLineOneArg |  Clr |     Clr |  83.32 ns | 0.5578 ns | 0.4945 ns | 0.0247 |     104 B |
 |   AppendFormattedLineTwoArgs |  Clr |     Clr | 117.71 ns | 2.3734 ns | 2.2201 ns | 0.0246 |     104 B |
 | AppendFormattedLineThreeArgs |  Clr |     Clr | 138.34 ns | 1.1950 ns | 1.0594 ns | 0.0246 |     104 B |
 |  AppendFormattedLineManyArgs |  Clr |     Clr | 279.15 ns | 1.3056 ns | 1.1574 ns | 0.0644 |     272 B |
 |    AppendFormattedLineOneArg | Core |    Core |  90.31 ns | 0.8362 ns | 0.7412 ns | 0.0247 |     104 B |
 |   AppendFormattedLineTwoArgs | Core |    Core | 121.57 ns | 0.9251 ns | 0.8654 ns | 0.0246 |     104 B |
 | AppendFormattedLineThreeArgs | Core |    Core | 153.72 ns | 1.3533 ns | 1.2659 ns | 0.0246 |     104 B |
 |  AppendFormattedLineManyArgs | Core |    Core | 298.24 ns | 1.3672 ns | 1.2120 ns | 0.0644 |     272 B |
