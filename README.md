# Volπ: Volume Percent Indicator 
### Your volume percentage etched on your tray.
>
From
![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/default_hover.jpg)
to...
![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/volpi_v1_hover.jpg)

>See [VolPI/screenshots](https://github.com/raymelon/VolPI/tree/master/screenshots) for more.

[![Build status](https://ci.appveyor.com/api/projects/status/asu6ofasst2t1ce4)](https://ci.appveyor.com/project/raymelon/volpi) 
[![Tweet](https://img.shields.io/twitter/url/http/shields.io.svg?style=flat-square)](https://twitter.com/intent/tweet?text=Check out VolPI! The Volume Percentage Indicator. Your volume percentage etched on your system tray. @github https://github.com/raymelon/VolPI)
![](https://reposs.herokuapp.com/?path=raymelon/VolPI&color=red)
[![os (Windows 7+)](https://img.shields.io/badge/os-Windows%207%2B-green.svg?style=flat-square)](https://www.microsoft.com/en-us/software-download/windows7)
[![.NET (4.0+)](https://img.shields.io/badge/.NET%20Framework-4.0%2B-orange.svg?style=flat-square)](https://www.microsoft.com/net)

## How To's

- To mute/unmute, double click the tray icon.

  ![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/volpi_v1_muted.jpg)
  ![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/volpi_v1_unmuted.jpg)

- To open the Windows' volume slider `sndvol.exe -f`, single click the tray icon.
- To show the tray menu, right click the tray icon.

## Download
 - [VolPI_v1.0.1.zip](https://github.com/raymelon/VolPI/releases/download/v1.0.1/VolPI_v1.0.1.zip)
 
 > - Once finished, extract the `zip` file. 
 > - Open `VolPI.exe` and place it anywhere on your tray. 
 > - Don't forget to add `VolPI.exe` to startup.
 > - Enjoy!

## Audio Libraries
This project uses [AudioSwitcher](https://github.com/xenolightning/AudioSwitcher) and [NAudio](https://github.com/naudio/NAudio).

Integrate these libraries on your projects too! [![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg?style=flat-square)]()
```
PM> Install-Package AudioSwitcher.AudioApi.CoreAudio
PM> Install-Package NAudio
```

## Licenses [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://opensource.org/licenses/MIT) ![License: MS-PL](https://img.shields.io/badge/License-MS--PL-8A2BE2.svg?style=flat-square) [![License: CC BY-NC 4.0](https://img.shields.io/badge/License-CC%20BY--NC%204.0-lightgrey.svg?style=flat-square)](http://creativecommons.org/licenses/by-nc/4.0/) <a rel="license" href="http://creativecommons.org/licenses/by-nc/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc/4.0/88x31.png" /></a>
This app's code is licensed under [MIT License](https://github.com/raymelon/VolPI/blob/master/LICENSE)
while its icon files [VolPI.ico](https://github.com/raymelon/VolPI/blob/master/VolPI/VolPI.ico) and
[VolPI icon.png](https://github.com/raymelon/VolPI/blob/master/VolPI/VolPI%20icon.png) are licensed under
[Creative Commons Attribution-NonCommercial 4.0 International License](https://creativecommons.org/licenses/by-nc/4.0/).
AudioSwitcher and NAudio are licensed under [Microsoft Public License (MS-PL)](https://opensource.org/licenses/MS-PL).
