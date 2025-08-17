using UnityEngine;
using UnityEngine.UI;

public class PlayTimeDisplay : MonoBehaviour
{
    public Text playTimeText; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.timeSinceLevelLoad;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        playTimeText.text = string.Format("Play Time: {0:D2}:{1:D2}", minutes, seconds);
    }
}
