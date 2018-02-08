``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648435 Hz, Resolution=377.5815 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                             Method |  Job | Runtime |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------------------------------------------------------------- |----- |-------- |------------:|----------:|----------:|-------:|----------:|
|                                             FormatStringWithOneArg |  Clr |     Clr |  94.7709 ns | 0.8488 ns | 0.7088 ns | 0.0094 |      40 B |
|                                            FormatStringWithTwoArgs |  Clr |     Clr | 118.9111 ns | 1.3766 ns | 1.2203 ns | 0.0112 |      48 B |
|                                          FormatStringWithThreeArgs |  Clr |     Clr | 142.8781 ns | 1.2875 ns | 1.2043 ns | 0.0112 |      48 B |
|                                           FormatStringWithManyArgs |  Clr |     Clr | 253.0075 ns | 2.8768 ns | 2.6910 ns | 0.0319 |     136 B |
|                                         FormatStringWithToManyArgs |  Clr |     Clr | 228.6740 ns | 0.8759 ns | 0.8194 ns | 0.0303 |     128 B |
|                               FormatStringWithOneArgFormattedTwice |  Clr |     Clr | 120.6834 ns | 0.1814 ns | 0.1311 ns | 0.0113 |      48 B |
|                                       FormatStringWithIntegerAsArg |  Clr |     Clr | 178.1855 ns | 1.2793 ns | 0.9988 ns | 0.0226 |      96 B |
|                                        FormatStringWithDoubleAsArg |  Clr |     Clr | 599.9173 ns | 2.2998 ns | 1.7955 ns | 0.0238 |     104 B |
|                                                           Truncate |  Clr |     Clr |  11.6555 ns | 0.0831 ns | 0.0778 ns | 0.0095 |      40 B |
|                                                 TruncateWithSuffix |  Clr |     Clr |  28.2099 ns | 0.1446 ns | 0.1282 ns | 0.0210 |      88 B |
|                                        IsNullOrEmptyWithNullString |  Clr |     Clr |   0.0000 ns | 0.0000 ns | 0.0000 ns |      - |       0 B |
|                                       IsNullOrEmptyWithEmptyString |  Clr |     Clr |   0.3339 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
|                                            IsNullOrEmptyWithString |  Clr |     Clr |   0.2943 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
|                                   IsNullOrWhiteSpaceWithNullString |  Clr |     Clr |   1.9360 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
|                                  IsNullOrWhiteSpaceWithEmptyString |  Clr |     Clr |   2.2581 ns | 0.0234 ns | 0.0218 ns |      - |       0 B |
|                                       IsNullOrWhiteSpaceWithString |  Clr |     Clr |   3.7491 ns | 0.0228 ns | 0.0190 ns |      - |       0 B |
|  ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparison |  Clr |     Clr | 134.6787 ns | 0.7778 ns | 0.6895 ns |      - |       0 B |
|   ContainsWithValidCorrectCasedStringAndCaseSensensitiveComparison |  Clr |     Clr | 126.5505 ns | 0.7213 ns | 0.6747 ns |      - |       0 B |
| ContainsWithValidIncorrectCasedStringAndCaseSensensitiveComparison |  Clr |     Clr | 143.2701 ns | 0.5889 ns | 0.4918 ns |      - |       0 B |
|                                             FormatStringWithOneArg | Core |    Core | 102.2383 ns | 0.8064 ns | 0.7543 ns | 0.0094 |      40 B |
|                                            FormatStringWithTwoArgs | Core |    Core | 131.1982 ns | 1.0047 ns | 0.9398 ns | 0.0112 |      48 B |
|                                          FormatStringWithThreeArgs | Core |    Core | 160.7692 ns | 1.4407 ns | 1.3476 ns | 0.0112 |      48 B |
|                                           FormatStringWithManyArgs | Core |    Core | 305.4844 ns | 1.4511 ns | 1.2117 ns | 0.0319 |     136 B |
|                                         FormatStringWithToManyArgs | Core |    Core | 264.5064 ns | 2.0504 ns | 1.9180 ns | 0.0300 |     128 B |
|                               FormatStringWithOneArgFormattedTwice | Core |    Core | 131.9638 ns | 0.4999 ns | 0.4174 ns | 0.0112 |      48 B |
|                                       FormatStringWithIntegerAsArg | Core |    Core | 173.0777 ns | 1.1178 ns | 0.9335 ns | 0.0226 |      96 B |
|                                        FormatStringWithDoubleAsArg | Core |    Core | 738.4052 ns | 6.8981 ns | 6.4525 ns | 0.0238 |     104 B |
|                                                           Truncate | Core |    Core |  12.3300 ns | 0.1170 ns | 0.1095 ns | 0.0095 |      40 B |
|                                                 TruncateWithSuffix | Core |    Core |  29.1136 ns | 0.6351 ns | 0.7059 ns | 0.0209 |      88 B |
|                                        IsNullOrEmptyWithNullString | Core |    Core |   0.0237 ns | 0.0430 ns | 0.0402 ns |      - |       0 B |
|                                       IsNullOrEmptyWithEmptyString | Core |    Core |   0.0932 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
|                                            IsNullOrEmptyWithString | Core |    Core |   0.0673 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
|                                   IsNullOrWhiteSpaceWithNullString | Core |    Core |   1.3759 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
|                                  IsNullOrWhiteSpaceWithEmptyString | Core |    Core |   2.4563 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
|                                       IsNullOrWhiteSpaceWithString | Core |    Core |   4.2732 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
|  ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparison | Core |    Core | 116.1518 ns | 0.8168 ns | 0.7640 ns |      - |       0 B |
|   ContainsWithValidCorrectCasedStringAndCaseSensensitiveComparison | Core |    Core | 109.2509 ns | 0.8699 ns | 0.8137 ns |      - |       0 B |
| ContainsWithValidIncorrectCasedStringAndCaseSensensitiveComparison | Core |    Core | 115.3449 ns | 0.5177 ns | 0.4589 ns |      - |       0 B |
