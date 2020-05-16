using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceStatic
{
    public static readonly VoiceStatic instance = (VoiceStatic)Activator.CreateInstance(typeof(VoiceStatic));

    //AndroidJavaClass
    AndroidJavaClass UnityPlayer;

    AndroidJavaObject currentActivity;

    AndroidJavaObject iflyVoiceJava;

    public VoiceStatic()
    {
#if UNITY_ANDROID
                //Initialize AndroidJavaClass(Please do not delete the commended codes for that those code are for test and check)
                UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                currentActivity=UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                //TODO 把appid换成自己在xfyun上申请的Android版appid
                iflyVoiceJava=new AndroidJavaObject("com.unity3d.player.IFlyVoiceJava","5d76269b",currentActivity);
 
                iflyVoiceJava.Call ("setInitListener", new XfInitListener ());
                iflyVoiceJava.Call ("setTtsListener", new XfSynthesizerListener ());
                iflyVoiceJava.Call ("setRecognizerListener", new xfRecognizerListener ());
                iflyVoiceJava.Call ("initVoice");
#endif
    }

    public void startSpeaking(string text)
    {
        iflyVoiceJava.Call("startSpeak", new AndroidJavaObject("java.lang.String", text));
    }

    public void startRecognize()
    {
        iflyVoiceJava.Call("startRecognize");
    }
}