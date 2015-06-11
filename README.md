# SwissArmyKnife

SwissArmyKnife is my little utility library. Its target framework is 4.0, the only dependency is System (mscorlib), it doesn't cause warnings and it's fully CLS compliant.

## Current status

I'm in the process of making things available under the right license and moving them over to this project.

Done: 
* Extension methods
 * `object.IsAnyOf()`
 * `IComparable.IsBetween()`
 * `StringBuilder.AppendFormatLine()`
 * `string.FormatWith()`

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
/// if (value > 0 &&  value < 2)
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

#### StringBuilder.AppendFormatLine()

```csharp

StringBuilder sb = new StringBuilder();

sb.AppendFormatLine("{0}: {1}", "test", 1);
```

#### string.FormatWith()

```csharp
string formattedString = "Employee: {0} (status: {1})".FormatWith("Donald Duck", "Fired");
```

## Project structures

### src\SwissArmyKnife

The main project.

### src\SwissArmyKnife.Tests

The unit tests, using (NUnit)[http://www.nunit.org].

### src\SwissArmyKnife.Benchmarks

Benchmarks, using the awesome (Minibench.skeet)[https://github.com/akamsteeg/minibench.skeet].

## Build it

Since I converted most of the code to C#6 you need at least Visual Studio 2015RC.
