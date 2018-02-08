``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6820HQ CPU 2.70GHz (Skylake), ProcessorCount=8
Frequency=2648440 Hz, Resolution=377.5808 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host] : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2102.0
  Core   : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                                                             Method |  Job | Runtime |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
 |------------------------------------------------------------------- |----- |-------- |------------:|----------:|----------:|-------:|----------:|
 |                                             FormatStringWithOneArg |  Clr |     Clr | 106.0822 ns | 0.7247 ns | 0.6779 ns | 0.0094 |      40 B |
 |                                            FormatStringWithTwoArgs |  Clr |     Clr | 134.9902 ns | 1.0616 ns | 0.9931 ns | 0.0112 |      48 B |
 |                                          FormatStringWithThreeArgs |  Clr |     Clr | 162.5213 ns | 1.6993 ns | 1.5064 ns | 0.0112 |      48 B |
 |                                           FormatStringWithManyArgs |  Clr |     Clr | 305.8065 ns | 2.9737 ns | 2.7816 ns | 0.0319 |     136 B |
 |                                         FormatStringWithToManyArgs |  Clr |     Clr | 269.4145 ns | 5.0132 ns | 4.6893 ns | 0.0300 |     128 B |
 |                               FormatStringWithOneArgFormattedTwice |  Clr |     Clr | 136.9776 ns | 1.2848 ns | 1.2018 ns | 0.0112 |      48 B |
 |                                       FormatStringWithIntegerAsArg |  Clr |     Clr | 195.5074 ns | 3.7581 ns | 4.1771 ns | 0.0226 |      96 B |
 |                                        FormatStringWithDoubleAsArg |  Clr |     Clr | 636.3814 ns | 4.5731 ns | 4.2777 ns | 0.0238 |     104 B |
 |                                                           Truncate |  Clr |     Clr |  12.5051 ns | 0.1027 ns | 0.0960 ns | 0.0095 |      40 B |
 |                                                 TruncateWithSuffix |  Clr |     Clr |  29.5754 ns | 0.3221 ns | 0.2855 ns | 0.0209 |      88 B |
 |                                        IsNullOrEmptyWithNullString |  Clr |     Clr |   0.0023 ns | 0.0056 ns | 0.0053 ns |      - |       0 B |
 |                                       IsNullOrEmptyWithEmptyString |  Clr |     Clr |   0.0189 ns | 0.0225 ns | 0.0188 ns |      - |       0 B |
 |                                            IsNullOrEmptyWithString |  Clr |     Clr |   0.3825 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |
 |                                   IsNullOrWhiteSpaceWithNullString |  Clr |     Clr |   1.8994 ns | 0.0490 ns | 0.0459 ns |      - |       0 B |
 |                                  IsNullOrWhiteSpaceWithEmptyString |  Clr |     Clr |   1.6028 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
 |                                       IsNullOrWhiteSpaceWithString |  Clr |     Clr |   3.5152 ns | 0.0541 ns | 0.0506 ns |      - |       0 B |
 |  ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparison |  Clr |     Clr | 143.0316 ns | 2.7176 ns | 2.4091 ns |      - |       0 B |
 |   ContainsWithValidCorrectCasedStringAndCaseSensensitiveComparison |  Clr |     Clr | 126.2767 ns | 1.4359 ns | 1.2729 ns |      - |       0 B |
 | ContainsWithValidIncorrectCasedStringAndCaseSensensitiveComparison |  Clr |     Clr | 132.4767 ns | 2.1861 ns | 1.9379 ns |      - |       0 B |
 |                                             FormatStringWithOneArg | Core |    Core | 121.3274 ns | 1.4877 ns | 1.3916 ns | 0.0093 |      40 B |
 |                                            FormatStringWithTwoArgs | Core |    Core | 152.4529 ns | 1.6928 ns | 1.5835 ns | 0.0112 |      48 B |
 |                                          FormatStringWithThreeArgs | Core |    Core | 185.7669 ns | 1.2442 ns | 1.1029 ns | 0.0112 |      48 B |
 |                                           FormatStringWithManyArgs | Core |    Core | 337.9421 ns | 3.2652 ns | 3.0542 ns | 0.0319 |     136 B |
 |                                         FormatStringWithToManyArgs | Core |    Core | 296.2758 ns | 3.0655 ns | 2.8675 ns | 0.0300 |     128 B |
 |                               FormatStringWithOneArgFormattedTwice | Core |    Core | 155.9710 ns | 3.1434 ns | 3.7420 ns | 0.0112 |      48 B |
 |                                       FormatStringWithIntegerAsArg | Core |    Core | 191.0974 ns | 1.6696 ns | 1.5618 ns | 0.0226 |      96 B |
 |                                        FormatStringWithDoubleAsArg | Core |    Core | 766.4520 ns | 5.0430 ns | 4.7172 ns | 0.0238 |     104 B |
 |                                                           Truncate | Core |    Core |  13.5358 ns | 0.1757 ns | 0.1644 ns | 0.0095 |      40 B |
 |                                                 TruncateWithSuffix | Core |    Core |  31.1962 ns | 0.2016 ns | 0.1574 ns | 0.0209 |      88 B |
 |                                        IsNullOrEmptyWithNullString | Core |    Core |   0.0026 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
 |                                       IsNullOrEmptyWithEmptyString | Core |    Core |   0.1120 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
 |                                            IsNullOrEmptyWithString | Core |    Core |   0.0928 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
 |                                   IsNullOrWhiteSpaceWithNullString | Core |    Core |   1.4890 ns | 0.0127 ns | 0.0112 ns |      - |       0 B |
 |                                  IsNullOrWhiteSpaceWithEmptyString | Core |    Core |   2.2946 ns | 0.0510 ns | 0.0477 ns |      - |       0 B |
 |                                       IsNullOrWhiteSpaceWithString | Core |    Core |   5.0216 ns | 0.0393 ns | 0.0368 ns |      - |       0 B |
 |  ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparison | Core |    Core | 129.0601 ns | 1.9881 ns | 1.7624 ns |      - |       0 B |
 |   ContainsWithValidCorrectCasedStringAndCaseSensensitiveComparison | Core |    Core | 116.6350 ns | 1.0295 ns | 0.9127 ns |      - |       0 B |
 | ContainsWithValidIncorrectCasedStringAndCaseSensensitiveComparison | Core |    Core | 123.7082 ns | 0.8269 ns | 0.7331 ns |      - |       0 B |
