``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648435 Hz, Resolution=377.5815 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                       Method |  Job | Runtime |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
|----------------------------- |----- |-------- |----------:|----------:|----------:|-------:|----------:|
|    AppendFormattedLineOneArg |  Clr |     Clr |  72.86 ns | 0.8472 ns | 0.7510 ns | 0.0247 |     104 B |
|   AppendFormattedLineTwoArgs |  Clr |     Clr |  96.78 ns | 0.5211 ns | 0.4875 ns | 0.0247 |     104 B |
| AppendFormattedLineThreeArgs |  Clr |     Clr | 118.93 ns | 1.2362 ns | 1.0958 ns | 0.0246 |     104 B |
|  AppendFormattedLineManyArgs |  Clr |     Clr | 244.11 ns | 1.8233 ns | 1.6163 ns | 0.0644 |     272 B |
|    AppendFormattedLineOneArg | Core |    Core |  78.08 ns | 0.5896 ns | 0.5515 ns | 0.0247 |     104 B |
|   AppendFormattedLineTwoArgs | Core |    Core | 109.46 ns | 0.8088 ns | 0.7565 ns | 0.0247 |     104 B |
| AppendFormattedLineThreeArgs | Core |    Core | 140.35 ns | 0.5868 ns | 0.5202 ns | 0.0246 |     104 B |
|  AppendFormattedLineManyArgs | Core |    Core | 278.80 ns | 3.0235 ns | 2.5247 ns | 0.0644 |     272 B |
