# SwissArmyKnife

SwissArmyKnife is my little utility library. Its as lightweight, reliable & fast as possible, with extensive unit tests and benchmarks.

Supported .NET frameworks:
* .NET 3.5
* .NET 4.0
* .NET 4.5

## Current status

I'm in the process of making things available under the right license and moving them over to this project.

Done: 
* Extension methods
 * `object.IsAnyOf()`
 * `IComparable.IsBetween()`
 * `StringBuilder.AppendFormatLine()`
 * `string.FormatWith()`
 * `string.Truncate()`
 * `Stream.CopyTo()` (Backport to .NET 3.5 because it was introduced in the BCL in .NET 4.0)
 * `Stream.Reset()`
 * Stopwatch.GetValueAndReset()`

Todo:
* Collections & data structures
 * `FixedList<T>`, a fixed capacity list
 * `BinaryTree`
* IO namespace
* Custom types
* Loads more

## Examples

### Extension methods

#### object.IsAnyOf()

```csharp
int value = 0;

/// Replaces this:
/// if (value == 0 || value == 1 || value == 2)
/// {
///     // Do something
/// }
if (value.IsAnyOf(0, 1, 2))
{
    // Do something
}
```

```csharp
string value = "b";
if (value.IsAnyOf("a", "b", "c"))
{
    // Do something
}
```

#### IComparable.IsBetween()
```csharp
int value = 1;

/// Replaces this:
/// if (value > 0 &amp;&amp;  value < 2)
/// {
///     // Do something
/// }
if (value.IsBetween(0, 2))
{
    // Do something
}
```

```csharp
DateTime lower = new DateTime(2015, 01, 01, 0, 0, 1);
DateTime upper = new DateTime(2015, 12, 31, 23, 59, 59);

DateTime upper = new DateTime(2015, 6, 1, 12, 0, 0);

if (value.IsBetween(lower, upper))
{
    // Do something
}
```

#### StringBuilder.AppendFormatLine()
```csharp

StringBuilder sb = new StringBuilder();

sb.AppendFormatLine("{0}: {1}", "test", 1);
```

#### string.FormatWith()

```csharp
string formattedString = "Employee: {0} (status: {1})".FormatWith("Donald Duck", "Fired");
```

```csharp
var employeeName = "{0} {1}";
string formattedString = employeeName.FormatWith("Donald", "Duck");
```

#### string.Truncate()

```csharp
var text = "Lorem ipsum".Truncate(5); // "Lorem"
```

```csharp
var text = "Lorem ipsum";
var truncatedText = text.Truncate(5); // "Lorem"
```

```csharp
var truncatedTextWithSuffix = "Lorem ipsum".Truncate(5, "..."); // "Lorem..."
```

#### Stopwatch.GetValueAndReset()

```csharp

var sw = Stopwatch.StartNew();

// Replaces:
// var elapsed = sw.Elapsed;
// sw.Reset();
var elapsed = sw.GetValueAndReset();
````

## Build it

Since I converted most of the code to C#6 you need at least Visual Studio 2015RC.
