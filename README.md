# Constructopia — AR Object Recognition App

![Unity](https://img.shields.io/badge/Unity-2022.3.20f1-black?style=flat-square&logo=unity)
![C#](https://img.shields.io/badge/C%23-Scripts-purple?style=flat-square&logo=csharp)
![Vuforia](https://img.shields.io/badge/Vuforia-10.22.5-orange?style=flat-square)
![Platform](https://img.shields.io/badge/Platform-Android-green?style=flat-square&logo=android)

> A Unity AR application built with Vuforia Engine that recognises physical image targets and overlays interactive 3D models in the real world — deployed as a standalone Android APK.

---

## Overview

**Constructopia** is an Augmented Reality (AR) mobile application developed in Unity using Vuforia Engine 10.22.5. The app uses Vuforia's image target recognition to detect physical objects or printed markers in the real world and overlay contextual 3D models on top of them via the device camera.

The experience guides users through a three-scene flow — a welcome screen, an interactive AR session, and a closing screen — making it accessible and straightforward for any audience.

---

## How It Works

```
Welcome Screen
     ↓  (tap button)
AR Camera View
  - Points camera at image target (book / bucket / sword / vase)
  - Vuforia recognises the target
  - 3D model overlaid on the physical target in real time
     ↓  (tap button)
Thank You Screen
     ↓  (tap exit)
App closes
```

---

## Image Targets & 3D Models

| Image Target | 3D Model Overlay |
|---|---|
| Book | Books / Druid Tome |
| Bucket | Wood Bucket |
| Sword | Two-Handed Sword (6 colour variants) |
| Vase | Floral Golden Jar |

---

## Scenes

| Scene | Purpose |
|---|---|
| `Welcome.unity` | Landing screen with heading, subheading, and start button |
| `AR Scene.unity` | Live AR camera with Vuforia image target recognition and 3D overlays |
| `Thankyou.unity` | Closing screen after the AR experience |

---

## Custom Scripts

| Script | Class | Purpose |
|---|---|---|
| `SceneLoadAR.cs` | `Control` | Loads the AR Scene (index 1) from the Welcome screen |
| `SceneLoadThankyou.cs` | `ExitAR` | Loads the Thank You screen (index 2) from the AR Scene |
| `Exitbutton.cs` | `QuitGame` | Calls `Application.Quit()` to exit the app |

---

## Tech Stack

| Technology | Usage |
|---|---|
| Unity 2022.3.20f1 LTS | Game engine |
| C# | Scene management scripting |
| Vuforia Engine 10.22.5 | AR image target recognition |
| Universal Render Pipeline (URP) 14.0.10 | Rendering pipeline |
| TextMesh Pro | UI text rendering |
| Android Build Target | Mobile APK deployment |

---

## Project Structure

```
Constructopia/
├── Assets/
│   ├── Scripts/
│   │   ├── SceneLoadAR.cs          # Welcome → AR Scene
│   │   ├── SceneLoadThankyou.cs    # AR Scene → Thank You
│   │   └── Exitbutton.cs           # App exit
│   ├── Scenes/
│   │   ├── Welcome.unity           # Landing screen
│   │   ├── AR Scene.unity          # AR experience
│   │   └── Thankyou.unity          # Closing screen
│   └── 3D Stuff/
│       ├── Books/                  # Book target 3D assets
│       ├── InnerDriveStudios/      # Druid Tome 3D assets
│       ├── MONQO Floral Golden Jar/# Vase target 3D assets
│       ├── Sword Two-Hander/       # Sword target 3D assets (6 variants)
│       └── WoodBucket/             # Bucket target 3D assets
├── Packages/
│   └── manifest.json               # Package dependencies
├── ProjectSettings/                # Unity project & Android build config
└── README.md
```

---

## Getting Started

### Prerequisites
- Unity 2022.3.20f1 LTS (install via Unity Hub)
- Android Build Support module
- Vuforia Engine 10.22.5 package (see note below)
- A Vuforia Developer account and licence key

### Vuforia Setup

> **Note:** The Vuforia Engine `.tgz` package is excluded from this repository due to its file size (134MB). Download it from the [Vuforia Developer Portal](https://developer.vuforia.com/downloads/sdk) and place it at `Packages/com.ptc.vuforia.engine-10.22.5.tgz` before opening the project.

### Running the Project
1. Clone the repository
2. Place the Vuforia `.tgz` in the `Packages/` folder
3. Open the project in Unity Hub (Unity 2022.3.20f1)
4. Add your Vuforia licence key under **Window → Vuforia Configuration**
5. Open `Assets/Scenes/Welcome.unity` as the start scene
6. Press **Play** to test, or build for Android

### Building for Android
1. **File → Build Settings → Android**
2. Add all three scenes in order: Welcome (0), AR Scene (1), Thankyou (2)
3. Connect Android device
4. **Build and Run**

---

## Author

**Wadzanayi K. Bwanya**
GitHub: [@wadzanayikim](https://github.com/wadzanayikim)
