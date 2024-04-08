
# Control Settings for Unity

This is control setting for unity. Used for in-game controller and mouse settings.

## Table of Contents

1. [Installation](#installation)
2. [Getting Started](#getting-started)
3. [Use case](#How-to-use)


## Installation


### Install via Git URL
You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/com.studio23.ss2.settings.control#upm
```

## Getting Started

### Initialization

Create An Empty GameObject and attach the ControlSettingsConfiguration MonoBehaviour to it. And assign the input action asset you want to modify.



## Use case

### How To Use

You have to initialize ControlSettingsConfiguration once from any other script.

Use your preferred class from where you initialized the ControlSettingsConfiguration or use button on click event to invoke 
ControlSettingsConfiguration class's various function of this package.

```csharp
using studio23.ss2.Settings.Video.Core;

public class YourControllerSettingsController : MonoBehaviour
{
    private void ToggleXAxis()
    {
        ControlSettingsConfiguration.ToggleXAxis();
    }
}
```

That's it! You now have the basic information you need to use the **Studio23.SS2.settings.control** library in your Unity project. Explore the library's features and customize it according to your game's needs.