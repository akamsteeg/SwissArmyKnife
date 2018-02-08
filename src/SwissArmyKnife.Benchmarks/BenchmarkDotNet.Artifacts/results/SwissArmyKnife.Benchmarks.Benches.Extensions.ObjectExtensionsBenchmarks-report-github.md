``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648435 Hz, Resolution=377.5815 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                       Method |  Job | Runtime |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
|----------------------------- |----- |-------- |----------:|----------:|----------:|----------:|-------:|----------:|
|     StringIsAnyOfSingleValue |  Clr |     Clr |  4.374 ns | 0.0504 ns | 0.0421 ns |  4.376 ns |      - |       0 B |
|       StringIsAnyOfTwoValues |  Clr |     Clr |  4.717 ns | 0.0524 ns | 0.0465 ns |  4.721 ns |      - |       0 B |
|     StringIsAnyOfThreeValues |  Clr |     Clr |  4.853 ns | 0.0391 ns | 0.0346 ns |  4.848 ns |      - |       0 B |
|      StringIsAnyOfFourValues |  Clr |     Clr |  5.369 ns | 0.0832 ns | 0.0778 ns |  5.368 ns |      - |       0 B |
|      StringIsAnyOfManyValues |  Clr |     Clr | 23.498 ns | 0.5420 ns | 1.4836 ns | 22.740 ns | 0.0152 |      64 B |
| StringIsAnyOfManyValuesFails |  Clr |     Clr | 35.719 ns | 0.3483 ns | 0.3087 ns | 35.677 ns | 0.0152 |      64 B |
|        IntIsAnyOfSingleValue |  Clr |     Clr |  5.835 ns | 0.0549 ns | 0.0513 ns |  5.839 ns | 0.0057 |      24 B |
|          IntIsAnyOfTwoValues |  Clr |     Clr |  5.321 ns | 0.0799 ns | 0.0709 ns |  5.323 ns | 0.0057 |      24 B |
|        IntIsAnyOfThreeValues |  Clr |     Clr |  5.979 ns | 0.0670 ns | 0.0627 ns |  5.967 ns | 0.0057 |      24 B |
|         IntIsAnyOfFourValues |  Clr |     Clr |  6.269 ns | 0.0518 ns | 0.0485 ns |  6.271 ns | 0.0057 |      24 B |
|         IntIsAnyOfManyValues |  Clr |     Clr | 11.071 ns | 0.0696 ns | 0.0617 ns | 11.064 ns | 0.0172 |      72 B |
|     IntIsAnyOfTwoValuesFails |  Clr |     Clr | 31.992 ns | 0.1616 ns | 0.1432 ns | 31.995 ns | 0.0401 |     168 B |
|     StringIsAnyOfSingleValue | Core |    Core |  3.535 ns | 0.0320 ns | 0.0300 ns |  3.545 ns |      - |       0 B |
|       StringIsAnyOfTwoValues | Core |    Core |  3.618 ns | 0.0434 ns | 0.0362 ns |  3.608 ns |      - |       0 B |
|     StringIsAnyOfThreeValues | Core |    Core |  3.620 ns | 0.0472 ns | 0.0419 ns |  3.611 ns |      - |       0 B |
|      StringIsAnyOfFourValues | Core |    Core |  3.900 ns | 0.0485 ns | 0.0454 ns |  3.904 ns |      - |       0 B |
|      StringIsAnyOfManyValues | Core |    Core | 22.324 ns | 0.1320 ns | 0.1170 ns | 22.327 ns | 0.0152 |      64 B |
| StringIsAnyOfManyValuesFails | Core |    Core | 38.919 ns | 0.3160 ns | 0.2956 ns | 38.961 ns | 0.0152 |      64 B |
|        IntIsAnyOfSingleValue | Core |    Core |  6.189 ns | 0.0484 ns | 0.0429 ns |  6.184 ns | 0.0057 |      24 B |
|          IntIsAnyOfTwoValues | Core |    Core |  5.831 ns | 0.0532 ns | 0.0498 ns |  5.836 ns | 0.0057 |      24 B |
|        IntIsAnyOfThreeValues | Core |    Core |  6.127 ns | 0.0357 ns | 0.0317 ns |  6.130 ns | 0.0057 |      24 B |
|         IntIsAnyOfFourValues | Core |    Core |  5.469 ns | 0.0260 ns | 0.0231 ns |  5.466 ns | 0.0057 |      24 B |
|         IntIsAnyOfManyValues | Core |    Core | 11.718 ns | 0.1107 ns | 0.1035 ns | 11.679 ns | 0.0172 |      72 B |
|     IntIsAnyOfTwoValuesFails | Core |    Core | 32.323 ns | 0.2848 ns | 0.2664 ns | 32.373 ns | 0.0401 |     168 B |
