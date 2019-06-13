using UnityEngine;
using UnityEngine.UI;

//TODO: Add more views... (currently only color)

public class MultiView : MonoBehaviour {

    public KinectInputManager kinectInputManager;
    public Image image;

    Texture2D texture;


    void Start() {
        texture = new Texture2D(KinectInputManager.COLOR_WIDTH, KinectInputManager.COLOR_HEIGHT, TextureFormat.BGRA32, false);
        image.material.mainTexture = texture;

    }

    void Update() {
        var rawImage = kinectInputManager.GetColorBuffer();
        texture.LoadRawTextureData(rawImage);
        texture.Apply();
    }

}
