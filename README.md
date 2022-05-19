# Unity-echo3D-demo-ConvertProjectToEcho
Convert an existing Unity project by integrating echo3D. Compose music by clicking different instruments and go to band practice.

## Version
[Unity 2021.2.7f1](https://unity3d.com/get-unity/download/archive)

## Register
Don't have an echo3D API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
* Clone this [repo](https://github.com/echo3Dco/Unity-echo3D-demo-ConvertProjectToEcho)
* [Import the Unity SDK](https://docs.echo3d.co/unity/installation)
* [Add the assets](https://docs.echo3d.co/quickstart/add-a-3d-model) to the echo3D cloud from the Unity 'Models' folder
* In Unity, open 'MusicScene'
* Drag the 'echo3D' script onto the Drum, Piano and Guitar
* Add the API key and entry ID for each object in the Inspector
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/169384936-a779f128-be0c-4d69-b411-fff1e8824e33.png)
![InspectorAPIkey](https://user-images.githubusercontent.com/99516371/169384627-bc2e2d5b-b3da-45cc-9b5e-37639ea88056.png)

* In the Hierarchy, uncheck the box for the Sprite Renderer for Drum, Piano and Guitar
* Press Play in Unity to see where the 3 assets show up in the scene so you can modify the metadata in the console
* Adjust the metadata in the echo3D console as follows:
  <br>Drum: scale: .1/ xAngle: 90/ zAngle: 180
  <br>Piano: scale: .1/ xAngle: 90/ zAngle: 180/ x: -7/ z: .4
  <br>Guitar: scale: .1/ xAngle: 90/ zAngle: 180/ x: -14/ z: .4

## Run
Simply press the _Play_ button in Unity and click on each instrument to play and stop music.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
* [Guitar audio](https://www.bensound.com/royalty-free-music/track/acoustic-breeze)
* [Drum audio](https://www.bensound.com/royalty-free-music/track/downtown)
* [Piano audio](https://www.bensound.com/royalty-free-music/track/once-again)
* [Frame graphic](https://www.canva.com/design/play?locale=en&layoutQuery=square+frame&analyticsCorrelationId=f7ba0eb9-bdd8-41e5-8578-e99b67b21209)
* [Instruments graphic](https://www.freepik.com/free-vector/colored-flat-musical-icons-isolated-black-background_10600517.htm#query=instruments&position=49&from_view=search)
* ['Squealer' rock and roll font](https://www.dafont.com/squealer.font)

## Screenshots
[Youtube Video of playthrough](https://youtu.be/hWzq6cAvhu0)<br><br>
![Thumbnail](https://user-images.githubusercontent.com/99516371/169385347-c4db177a-24ae-46ef-a92a-035fec97b157.png)




