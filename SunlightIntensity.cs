using UnityEngine;
using UnityEngine.UI;

public class SunlightIntensity : MonoBehaviour{
    // We will use a slider UI to change the sunlight
    public Light sunlight; // Sunlight object
    public Slider slider; // Slider object
    
    // Update is called once per frame
    void Update(){
        // All we do here is set the intensity equal to the value of the slider (from 0-1, including decimals)
        sunlight.intensity = slider.value;
    }
}