using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public Sprite unmutedSprite; // Assign unmuted sprite in the inspector
    public Sprite mutedSprite; // Assign muted sprite in the inspector
    private bool isMuted = false;

    void Start()
    {
        UpdateButtonSprite();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        UpdateButtonSprite();
        UpdateAudio();
    }

    private void UpdateButtonSprite()
    {
        GetComponent<Image>().sprite = isMuted ? mutedSprite : unmutedSprite;
    }

    private void UpdateAudio()
    {
        AudioListener.volume = isMuted ? 0 : 1;
    }
}
