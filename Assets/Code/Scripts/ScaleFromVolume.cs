using UnityEngine;

public class ScaleFromVolume : MonoBehaviour
{
    public Vector3 minScale;
    public Vector3 maxScale;
    public GetMicVolumeScript micVolume;

    public float volumeSensibility = 2;
    public float volumeThreshold = 0.1f;

    void Update()
    {
        float volume = micVolume.GetMicrophoneVolume() * volumeSensibility;

        if(volume < volumeThreshold)
            volume = 0;

        transform.localScale = Vector3.Lerp(minScale, maxScale, volume);
    }
}
