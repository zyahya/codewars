https://www.codewars.com/kata/57a77726bb9944d000000b06

This solution has an enhancement, where I can directly do the division without using the floor method. Where doing calculation with int and decimals by default will lose the precision.

```cs
var freeMangoes = Math.Floor((double)quantity / 3);

return (quantity - (int)freeMangoes) * price;
```

If your division result has precisions, and you return it as int value or any other data type that doesn't support decimal numbers, you will lose them.

```cs
return (quantity - (quantity / 3)) * price;
```
