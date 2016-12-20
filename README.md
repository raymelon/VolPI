# VolPI: Volume Percent Indicator [![Tweet](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/intent/tweet?text=Check out VolPI! The Volume Percentage Indicator. Your volume percentage etched on your system tray. @github https://github.com/raymelon/VolPI)![](https://reposs.herokuapp.com/?path=raymelon/VolPI) [![Build status](https://ci.appveyor.com/api/projects/status/asu6ofasst2t1ce4?svg=true)](https://ci.appveyor.com/project/raymelon/volpi)

Your volume percentage etched on your tray.
>
From
![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/default_hover.jpg)
to...
![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/volpi_v1_hover.jpg)

>See [VolPI/screenshots](https://github.com/raymelon/VolPI/tree/master/screenshots) for more.

## How To's

- To mute/unmute, double click the tray icon.

  ![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/volpi_v1_muted.jpg)
  ![alt tag](https://github.com/raymelon/VolPI/blob/master/screenshots/v1/volpi_v1_unmuted.jpg)

- To open the Windows' volume slider `sndvol.exe -f`, single click the tray icon.
- To show the tray menu, right click the tray icon.

## Audio Libraries
This project uses [AudioSwitcher](https://github.com/xenolightning/AudioSwitcher) and [NAudio](https://github.com/naudio/NAudio).

Integrate these libraries on your projects too! [![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg)]()
```
PM> Install-Package AudioSwitcher.AudioApi.CoreAudio
PM> Install-Package NAudio
```

## Licenses [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) ![License: MIT](https://img.shields.io/badge/License-MS--PL-8A2BE2.svg) [![License: CC BY-NC 4.0](https://img.shields.io/badge/License-CC%20BY--NC%204.0-lightgrey.svg)](http://creativecommons.org/licenses/by-nc/4.0/) <a rel="license" href="http://creativecommons.org/licenses/by-nc/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc/4.0/88x31.png" /></a>
This app's code is licensed under [MIT License](https://github.com/raymelon/VolPI/blob/master/LICENSE)
while its icon files [VolPI.ico](https://github.com/raymelon/VolPI/blob/master/VolPI/VolPI.ico) and
[VolPI icon.png](https://github.com/raymelon/VolPI/blob/master/VolPI/VolPI%20icon.png) are licensed under
[Creative Commons Attribution-NonCommercial 4.0 International License](https://creativecommons.org/licenses/by-nc/4.0/).
AudioSwitcher and NAudio are licensed under [Microsoft Public License (MS-PL)](https://opensource.org/licenses/MS-PL).
