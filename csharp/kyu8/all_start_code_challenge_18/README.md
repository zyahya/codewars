Although this solution already passes all tests locally:

```cs
return str.Count(letter);
```

But codewars raises this error:

> src/Solution.cs(8,16): error CS1929: 'string' does not contain a definition for 'Count' and the best extension method overload 'MemoryExtensions.Count<char>(Span<char>, char)' requires a receiver of type 'System.Span<char>'

And I didn't skipped this error message without satisfying the error message:

```cs
return MemoryExtensions.Count(str, letter);
```
