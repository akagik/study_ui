using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Sample5 : MonoBehaviour
{
    [SerializeField] PlayableDirector playableDirector;
    [SerializeField] PlayableAsset fadein;
    [SerializeField] PlayableAsset fadeout;

    public bool canUIControl {
        get {
            return playableDirector.state != PlayState.Playing;
        }
    }

    void Start() {
        FadeIn();
    }

    public void FadeIn() {
        playableDirector.Play(fadein);
    }

    public void FadeOut() {
        if (!canUIControl) {
            return;
        }
        playableDirector.Play(fadeout);
        Invoke("FadeIn", 2f);
    }

}
