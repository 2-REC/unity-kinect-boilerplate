# UNITY KINECT BOILERPLATE

## INTRODUCTION

Boilerplate project for using the Kinect V2 (aka Kinect ONE) in Unity.<br>


## SETUP

The project "UnityKinect" can be used as a base for a new project, or its assets can be used in another Unity project in order to include Kinect handling.<br>
The required assets are in the "Kinect" directory of the assets.<br>
The remaining assets are provided as examples, and can be reused or adapted.<br>

The "Kinect for Unity" package must be imported in the project in order to use the Kinect.<br>

If preferred, and if want to use the latest version of the package, it can be downloaded from the Microsoft website.<br>
MS have ended the development of the Kinect, so the provided package should be the final one.<br>


### IMPORT THE 'KINECT FOR UNITY' PACKAGE

- (OPTIONAL) Download the "Kinect for Unity" package<br>
    From:<br>
    https://developer.microsoft.com/en-us/windows/kinect<br>
    ! - It is mentionned that it is a package for Unity Pro, but it works fine with the free Unity version.<br>

- Import the "Kinect for Unity" package into the Unity project<br>
    - "Assets" -> "Import Package" -> "Custom Package..."<br>
    - Navigate to the "Dependencies" directory or to the download location if the package was downloaded separately (previous step).<br>
    - Select the package:<br>
        "Kinect.2.0.1410.19000.unitypackage" (or different version if downloaded separately)<br>
    - Import the full package:<br>
        => Both "Plugins" and "Standard Assets"<br>

- Move the imported assets to the "Kinect" folder<br>
    - "Plugins" folder<br>
    - "Standard Assets" folder<br>
    ! - MAKE SURE TO ONLY MOVE THE ASSETS RELATED TO KINECT! (the ones imported previously)<br>
    ! - If the Unity project already had "Plugins" or "Standard Assets" directories, make sure to only move the Kinect related assets (those imported from the pacakge).<br>

The last step is not required, but helps keeping a cleaner assets folder.<br>
(The project's ".gitignore" also requires this folders hierarchy)<br>


## USE

The main script of the project is "KinectInputManager".<br>
It allows to specify which frames to acquire from the Kinect, and provides methods to access their data.<br>

The different frame types are:<br>
- Colour frames: RGB video stream<br>
- Depth frames: Depth data obtained from the IR sensor<br>
- Body framss: The tracked humand bodies composed of joints<br>
- Body Index frames: Data indicating for the each element of the depth data if it belongs to a tracked human body<br>

Each type can be acquired or not, depending on its respective setting:<br>
- useColorInput<br>
- useDepthInput<br>
- useBodyInput<br>
- useBodyIndexInput<br>

The different types of data can be obtained through the following methods:<br>

    ```cs
    public byte[] GetColorBuffer();
    //public Texture2D GetColorTexture(); //code can be uncommented if desired
    public ushort[] GetDepthBuffer();
    public DepthSpacePoint[] GetDepthCoordinates(); // mapping of colour frames to depth frames
    public Body[] GetBodyData();
    public byte[] GetBodyIndexBuffer();
    ```cs


### EXAMPLES

There are 2 provided examples:<br>
- "BodyFrames": Acquires the Body frames of the Kinect to display a detected human body.<br>
- "MultiFrames": Acquires the colour, depth and body index frames of the Kinect. Currently only the colour frames are displayed.<br>
