using UnityEngine;
using UnityEngine.EventSystems;

public class ImageHoverSound : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public SteveAudioScript audioScript;
    public ImageChangeScript imageChangeScript;
    public AudioClip[] hoverClips;

    public void OnPointerEnter(PointerEventData eventData)
    {
        int currentIndex = imageChangeScript.currentIndex;

        if (currentIndex >= 0 && currentIndex < hoverClips.Length)
        {
            audioScript.audioSource.clip = hoverClips[currentIndex];
            audioScript.audioSource.loop = false;
            audioScript.audioSource.Play();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (audioScript.audioSource.isPlaying)
        {
            audioScript.audioSource.Stop();
        }
    }
}
