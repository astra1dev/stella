<p align="center">
  <img width=256 height=256 src="https://github.com/user-attachments/assets/3b87425e-efc8-40c0-87ac-b38d7faba2da">
</p>

<p align="center">

  <a href="https://www.gnu.org/licenses/gpl-3.0.html">
    <img src="https://img.shields.io/badge/license-GPL-brightgreen.svg?style=plastic&logo=GNU&label=License">
  </a>

  <a href="../../actions/workflows/dotnet.yml">
    <img src="https://github.com/astra1dev/stella/actions/workflows/dotnet.yml/badge.svg?event=push">
  </a>

  <a href="../../releases">
    <img src="https://img.shields.io/github/downloads/astra1dev/stella/total.svg?style=plastic">
  </a>

  <a href="../../releases/latest">
    <img src="https://img.shields.io/github/downloads/astra1dev/stella/latest/total?style=plastic">
  </a>

</p>

<p align="center">
<b>utility menu for the game "Star Birds"</b>
</p>

# 🎮 Game Info

> Star Birds is a relaxing asteroid base-building and resource management game. 
> Discover and mine countless asteroids, create production networks and guide your colony of spacefaring birds to new interstellar horizons!

- Steam Link: https://store.steampowered.com/app/2719750/Star_Birds/
- Steam Link (demo): https://store.steampowered.com/app/3576710/Star_Birds_Demo/
- Save game files are stored in: `%APPDATA%\..\LocalLow\Toukana Interactive\Star Birds Demo\GameFiles\`

This project is (right now) only available for the demo version. The full game is going to release sometime in 2025.

# 🎉 Features
- 🎬 Skip all cutscenes immediately
- 🔎 Zoom in and out infinitely
- 🪙 Set the amount of credits and tech points you have

Planned:
- Influence the randomness / seed somehow
- Manage multiple save files / quickly edit progress
- See redeemable codes

Feel free to request new features by opening an issue.

Preview:
<img src="https://github.com/user-attachments/assets/f81832be-9029-4c1d-baae-0c9e2b119726">

# 🔥 Releases
The table below lists the most recent stella release for each Star Birds version. Release notes can be found below each new [release](../../releases).

| Star Birds Version  |           stella Version            |
|:-------------------:|:-----------------------------------:|
| Demo Patch `0.0.28` | [v1.0.0](../../releases/tag/v1.0.0) |

# 💾 Installation
## 🪟 Windows
- Download the latest `stella.zip` file from the [releases page](../../releases/latest).
- Extract the contents of the zip file into the game folder. You can find it by right-clicking on the game in your Steam library -> `Manage` -> `Browse local files`.
- Launch the game via Steam. The first launch will take some time, so be patient. Once the game has launched, press `F1` to open the menu.

## 🐧 Linux
- Make sure you are running Star Birds under Proton (or Wine). On Steam you can check this by right-clicking Star Birds in your library → `Properties` → `Compatibility` → `Force the use of a specific Steam Play compatibility tool`. Test different Proton versions if you're having issues launching the game.
- Check out [this guide](https://docs.bepinex.dev/articles/advanced/proton_wine.html) to get BepInEx (the framework stella is built upon) working. Alternatively, if you are using Proton with Steam, you can specify the DLL override in the launch options (right-click Star Birds in your library → `Properties` → `General` → `Launch Options`): `WINEDLLOVERRIDES="winhttp.dll=n,b" %command%` Then follow the steps for Windows.

<hr>

<b>👾 If you are already using other mods or already have BepInEx installed:</b>
- You should see a folder called `BepInEx` inside your Star Birds folder.
- Download `stella_v*.dll` from the [latest release](../../releases/latest), put it into `BepInEx/plugins` and launch Star Birds.

<b>👷‍♂️ If you don't want to download the pre-compiled DLL, you can build stella from source by following these steps:</b>
- Make sure you have the [Microsoft .NET SDK](https://dotnet.microsoft.com/en-us/download) and [git](https://git-scm.com/downloads) installed.
- Download the necessary files with `git clone https://github.com/astra1dev/stella`
- Run the command `dotnet build` from the stella folder (where `stella.csproj` is located)
- The compiled DLL will be located here: `src/bin/Debug/net6.0/stella.dll`. Put it into `BepInEx/plugins` and launch Star Birds.

# 👨‍💻 Contributing
- For bug reports and feature requests, [open a new issue](/issues/new)
- If you want to add a new feature or edit / improve existing code, fork this repo and create a pull request with your changes.  ([how?](https://docs.github.com/en/get-started/exploring-projects-on-github/contributing-to-a-project))

# ⚠️ Disclaimer
This project is fan-made and not affiliated with Star Birds, Toukana Interactive, or kurzgesagt - in a nutshell. 
