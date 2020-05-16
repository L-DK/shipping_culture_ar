using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject videoPlayer;
    public GameObject playBtn;
    VideoPlayer v;
    void Start()
    {
        v = videoPlayer.GetComponent<VideoPlayer>();


    }

    public void play()
    {

        v.Play();
        playBtn.SetActive(false);
        VoiceStatic.instance.startSpeaking("");
    }

    public void stop()
    {

        v.Pause();
        playBtn.SetActive(true);
        VoiceStatic.instance.startSpeaking("");

    }

    public static void allstop()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("video");


        foreach (var item in obj)
        {
            item.GetComponent<VideoPlayer>().Stop();

            item.transform.Find("Canvas").transform.Find("PauseButton").transform.Find("PlayButton").gameObject.SetActive(true);

        }

        VoiceStatic.instance.startSpeaking("");


    }

}
