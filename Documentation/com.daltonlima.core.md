# DaltonLima Core Package

This is a custom Unity Package.

Currently we have a `Singleton` implementation that uses generic. It's amazingly easy to use and remove a lot of that same boilerplate.

## How to install

### Unity 2019.3+

1. Open `Windows` -> `Package Manager`
2. Enable Preview Packages (Found in `Advanced` dropdown)
3. Click on the `+` icon at top-left corner -> `Add package from git URL...`

### Unity 2018.3+

Add this entry to your `Packages\Manifest.json`

```json
  "dependencies": {
    "com.daltonlima.core": "https://github.com/daltonbr/com.daltonlima.core.git",
    ..."com.unity.2d.sprite": "1.0.0",
```

## How to use

After importing the package, just inherit it like this

```csharp
using DaltonLima.Core;

public class MySingletonClass : Singleton<MySingletonClass>
{
    ...
}
```
