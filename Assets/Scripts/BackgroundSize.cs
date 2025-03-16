using UnityEngine;

public class BackgroundSize : MonoBehaviour
{
   
    void Start()
    {
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
    }

    
    void Update()
    {
        
    }
}
