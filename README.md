# SimpleAudio
Small Unity library for convenient audio playing from code. Library provides Audio class for playing sounds from scripts, loading audio files and AudioClip extensions.

## How to install
Go to [Releases](https://github.com/quad58/SimpleAudio/releases) and download the archive. Then unpack the archive into your project's assets folder.

## Usage
```csharp
AudioClip audioClip = Audio.LoadSound(path); // Load AudioClip from file
Audio.PlaySound(audioClip); // Basically play sound
Audio.PlaySoundAtPoint(audioClip, position); // Play sound in 3D
Audio.PlaySoundAttached(transform, audioClip); // Play sound attached to some object. Sound object will be set as child.
```
