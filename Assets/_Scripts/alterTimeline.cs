using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class alterTimeline : MonoBehaviour
{
    private PlayableDirector director;

    [SerializeField] private Button PlayButton;
    [SerializeField] private Button PauseButton;
    [SerializeField] private Button StopButton;
    [SerializeField] private Button SkipButton;
    [SerializeField] private Button RewindButton;

    void Start()
    {
        director = GetComponent<PlayableDirector>();

        PlayButton.onClick.AddListener(playAnimation);
        PauseButton.onClick.AddListener(pauseAnimation);
        StopButton.onClick.AddListener(stopAnimation);
        SkipButton.onClick.AddListener(skipAnimation);
        RewindButton.onClick.AddListener(rewindAnimation);

    }

    void playAnimation()
    {
        director.Play();
    }

    void pauseAnimation()
    {
        director.Pause();
    }

    void stopAnimation()
    {
        director.Stop();
    }

    void skipAnimation()
    {
        director.time = director.time + 0.5;
    }

    void rewindAnimation()
    {
        director.time = director.time - 0.5;
    }
}
