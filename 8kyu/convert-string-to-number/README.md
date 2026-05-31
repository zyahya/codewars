https://www.codewars.com/kata/544675c6f971f7399a000e79/train/csharp

The difference between `Convert.ToInt32()` and `int.Parse()`, is about how they handle the `NULL` inputs.

`int.Parse()` throws `ArgumentNullException` while `Convert.Int32()` returns `0`.
