using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Flap")]
    [SerializeField] AudioClip flappingClip;
    [SerializeField][Range(0f, 1f)] float flappingVolume;

    [Header("Score")]
    [SerializeField] AudioClip scoreClip;
    [SerializeField][Range(0f, 1f)] float scoreVolume;

    [Header("Hit")]
    [SerializeField] AudioClip hitClip;
    [SerializeField][Range(0f, 1f)] float hitVolume;

    public void PlayFlappingClip()
    {
        if (flappingClip != null)
        {
            AudioSource.PlayClipAtPoint(flappingClip, Camera.main.transform.position, flappingVolume);
        }
    }

    public void PlayScoreClip()
    {
        if (scoreClip != null)
        {
            AudioSource.PlayClipAtPoint(scoreClip, Camera.main.transform.position, scoreVolume);
        }
    }

    public void PlayHitClip()
    {
        if (hitClip != null)
        {
            AudioSource.PlayClipAtPoint(hitClip, Camera.main.transform.position, hitVolume);
        }
    }
}
