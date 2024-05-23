using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class FPS : MonoBehaviour
{
    public int avgFrameRate;
    public TMP_Text FPSC;
 
    public void Update ()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        FPSC.text = avgFrameRate.ToString() + " FPS";
    }
}