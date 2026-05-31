https://www.codewars.com/kata/54edbc7200b811e956000556/train/csharp

Other possible solutions:

```cs
// Old syntax but most compatible
return sheeps.Count(s => s);
```

```cs
MemoryExtensions.Count(sheeps.AsSpan(), true);
```
