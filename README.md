# ChillFrames
[![Download count](https://img.shields.io/endpoint?url=https://vz32sgcoal.execute-api.us-east-1.amazonaws.com/ChillFrames)](https://github.com/MidoriKami/ChillFrames)

Chill Frames is a XivLauncher/Dalamud plugin.

This is a very simple utility plugin that allows you to conditionally enable a framerate limiter ingame.

## Why is this useful?

This plugin allows you set a frame limiter for the parts of the game that aren't that important to have constantly running at a high framerate.
When your framerate isn't limited your GPU is using maximum power, generating maximum heat, for minimal visual impact.

For those that game on a mobile laptop this will also allow you to save significant battery as well.

## How does it work?

This plugin hooks into the games renderer and delays frame rendering to generate the user specified framerate.

The delay happens *after* the games default logic, and will only act to reduce framerates.

This means if you have the games settings to reduce the framerate when afk, that setting will still apply and will take priority over the delay Chill Frames causes.

## Configuration Window

Currently Chill Frames has the following configuration options, if any of these conditions are met, then the framerate will no longer be limited until the condition is no longer met.

| Condition               | Description                                                      |
|-------------------------|------------------------------------------------------------------|
| Disable during combat   | The framerate will not be limited anytime you are in combat      |
| Disable during duty     | The framerate will not be limited anytime you are bound by duty  |
| Disable during cutscene | The framerate will not be limited during any cinematic cutscenes |

![image](https://user-images.githubusercontent.com/9083275/159103546-7c3bc8f6-192f-4853-9f10-f0b7583b72f7.png)







