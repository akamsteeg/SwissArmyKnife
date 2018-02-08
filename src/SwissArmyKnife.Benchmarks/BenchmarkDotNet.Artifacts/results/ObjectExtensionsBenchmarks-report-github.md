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
 |     StringIsAnyOfSingleValue |  Clr |     Clr |  3.531 ns | 0.0320 ns | 0.0250 ns |      - |       0 B |
 |       StringIsAnyOfTwoValues |  Clr |     Clr |  4.592 ns | 0.1246 ns | 0.1040 ns |      - |       0 B |
 |     StringIsAnyOfThreeValues |  Clr |     Clr |  5.902 ns | 0.1211 ns | 0.1073 ns |      - |       0 B |
 |      StringIsAnyOfFourValues |  Clr |     Clr |  5.461 ns | 0.0817 ns | 0.0764 ns |      - |       0 B |
 |      StringIsAnyOfManyValues |  Clr |     Clr | 23.851 ns | 0.1783 ns | 0.1668 ns | 0.0152 |      64 B |
 | StringIsAnyOfManyValuesFails |  Clr |     Clr | 35.983 ns | 0.3693 ns | 0.3273 ns | 0.0152 |      64 B |
 |        IntIsAnyOfSingleValue |  Clr |     Clr |  5.666 ns | 0.0883 ns | 0.0826 ns | 0.0057 |      24 B |
 |          IntIsAnyOfTwoValues |  Clr |     Clr |  5.246 ns | 0.0573 ns | 0.0508 ns | 0.0057 |      24 B |
 |        IntIsAnyOfThreeValues |  Clr |     Clr |  5.104 ns | 0.0782 ns | 0.0693 ns | 0.0057 |      24 B |
 |         IntIsAnyOfFourValues |  Clr |     Clr |  6.544 ns | 0.1358 ns | 0.1204 ns | 0.0057 |      24 B |
 |         IntIsAnyOfManyValues |  Clr |     Clr | 11.939 ns | 0.0927 ns | 0.0867 ns | 0.0172 |      72 B |
 |     IntIsAnyOfTwoValuesFails |  Clr |     Clr | 29.858 ns | 0.2595 ns | 0.2428 ns | 0.0401 |     168 B |
 |     StringIsAnyOfSingleValue | Core |    Core |  3.518 ns | 0.0481 ns | 0.0450 ns |      - |       0 B |
 |       StringIsAnyOfTwoValues | Core |    Core |  3.113 ns | 0.0387 ns | 0.0362 ns |      - |       0 B |
 |     StringIsAnyOfThreeValues | Core |    Core |  4.403 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
 |      StringIsAnyOfFourValues | Core |    Core |  3.726 ns | 0.0517 ns | 0.0484 ns |      - |       0 B |
 |      StringIsAnyOfManyValues | Core |    Core | 22.673 ns | 0.1514 ns | 0.1416 ns | 0.0152 |      64 B |
 | StringIsAnyOfManyValuesFails | Core |    Core | 43.607 ns | 0.3509 ns | 0.3283 ns | 0.0152 |      64 B |
 |        IntIsAnyOfSingleValue | Core |    Core |  5.219 ns | 0.0369 ns | 0.0345 ns | 0.0057 |      24 B |
 |          IntIsAnyOfTwoValues | Core |    Core |  5.784 ns | 0.0462 ns | 0.0432 ns | 0.0057 |      24 B |
 |        IntIsAnyOfThreeValues | Core |    Core |  5.925 ns | 0.0629 ns | 0.0558 ns | 0.0057 |      24 B |
 |         IntIsAnyOfFourValues | Core |    Core |  6.249 ns | 0.0713 ns | 0.0595 ns | 0.0057 |      24 B |
 |         IntIsAnyOfManyValues | Core |    Core | 12.375 ns | 0.0516 ns | 0.0482 ns | 0.0172 |      72 B |
 |     IntIsAnyOfTwoValuesFails | Core |    Core | 31.788 ns | 0.2067 ns | 0.1832 ns | 0.0401 |     168 B |
