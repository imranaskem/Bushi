#Bushi

A C# helper library for [FiveRingsDB](https://alsciende.github.io/fiveringsdb/)

## Basic Usage

All resources are accessible through the top-level BushiQuery class:

`var query = new BushiQuery();`

This will cache results in the above object for one hour. That can be changed via the BushiQueryOptions class.

```
var options = new BushiQueryOptions();
options.SetCacheTime(TimeSpan.FromMinutes(10))

var query = new BushiQuery(options);
```

