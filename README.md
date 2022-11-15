# Sky360 Simulation Projects

## Overview

This repository contains Unity 3D projects providing a basic simulation system,
capable of creating video content to test the tracker.

Environment, virtual camera and target objects are fully customizable using the
basic elements of Unity games, GameObjects and behaviors.

In the future, evaluation of tracker performance may be enabled using ground
truth trajectory information recorded by the simulated object behaviors.

### Requirements

Local Unity 3D installation is required to run the provided simulation scenes.

See the following URI for installation details:
https://unity3d.com/get-unity/download

Since Unity uses Mono and C# internally, the Visual Studio .NET developer tools
may be optionally installed to enable debugging.

### Recording

Simulation data is produced using the Unity Recorder package.

https://docs.unity3d.com/Packages/com.unity.recorder@3.0/manual/index.html

Initially, MP4 video creation is enabled for optical tracking simulation.
