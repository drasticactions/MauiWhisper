# MauiWhisper - a .NET MAUI Whisper App

![MauiWhisper Logo](https://user-images.githubusercontent.com/898335/258113060-f4f074c9-a8d8-4884-ac78-d734870f2cba.png)

![1444070256569233](https://user-images.githubusercontent.com/898335/167266846-1ad2648f-91c1-4a04-a18d-6dd4d6c7d21c.gif)

MauiWhisper is a [Whisper](https://github.com/ggerganov/whisper.cpp) app written using the .NET MAUI UI Framework. It allows you to transcribe audio and video files into SRT subtitles.

![App Image](https://user-images.githubusercontent.com/898335/258113809-35580839-ce34-4643-8e63-89294dd4c0bf.png)

## Setup

MauiWhisper uses the .NET 8 SDK. You must install .NET 8 and the MAUI Workloads to build and deploy the app. Once installed, it should "just work".

For Windows and Mac, you need to install FFMpeg on your system. For Android and iOS, it uses LibVLCSharp and includes the binaries.

## Libraries

[Whisper.net](https://github.com/sandrohanea/whisper.net)
[Maui.VirtualListView](https://github.com/Redth/Maui.VirtualListView)
[libvlcsharp](https://github.com/videolan/libvlcsharp)
[xabe.ffmpeg](https://ffmpeg.xabe.net/)