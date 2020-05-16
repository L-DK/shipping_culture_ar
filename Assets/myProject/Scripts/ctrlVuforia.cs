using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
public class ctrlVuforia : MonoBehaviour, ITrackableEventHandler
{
    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {

        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName +
        //          " " + mTrackableBehaviour.CurrentStatus +
        //          " -- " + mTrackableBehaviour.CurrentStatusInfo);

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;

            Debug.Log("找到了名字是：" + mTrackableBehaviour.TrackableName);// 名字
            variable.isMuted = false;
            variable.TrackableName = mTrackableBehaviour.TrackableName;
            switch (mTrackableBehaviour.TrackableName)
            {
                case "lxt":
                    Methods.changeText(variable.votext, variable.voice_lxt);
                    Methods.changeText(variable.nametext, "[罗星塔]");
                    variable.currentVoice = variable.voice_lxt;
                    break;
                case "pyh":
                    Methods.changeText(variable.votext, variable.voice_pyh);
                    Methods.changeText(variable.nametext, "[平远航]");
                    variable.currentVoice = variable.voice_pyh;
                    break;
                case "jxyh":
                    Methods.changeText(variable.votext, variable.voice_jxyh);
                    Methods.changeText(variable.nametext, "[甲型一号]");
                    variable.currentVoice = variable.voice_jxyh;
                    break;
                case "czxt":
                    Methods.changeText(variable.votext, variable.voice_czxt);
                    Methods.changeText(variable.nametext, "[船政学堂]");
                    variable.currentVoice = variable.voice_czxt;
                    break;
            
                case "bwg":
                    Methods.changeText(variable.votext, variable.voice_bwg);
                    Methods.changeText(variable.nametext, "[中国船政博物馆]");
                    variable.currentVoice = variable.voice_bwg;
                    break;

                case "amstl":
                    Methods.changeText(variable.votext, variable.voice_amstl);
                    Methods.changeText(variable.nametext, "[阿姆斯特朗]");
                    variable.currentVoice = variable.voice_amstl;
                    break;

                case "jqxyj":
                    Methods.changeText(variable.votext, variable.voice_jqxyj);
                    Methods.changeText(variable.nametext, "[镜清巡洋舰]");
                    variable.currentVoice = variable.voice_jqxyj;
                    break;

                case "gshc":
                    Methods.changeText(variable.votext, variable.voice_gshc);
                    Methods.changeText(variable.nametext, "[干散货船]");
                    variable.currentVoice = variable.voice_gshc;
                    break;

                case "mal":
                    Methods.changeText(variable.votext, variable.voice_mal);
                    Methods.changeText(variable.nametext, "[闽安台]");
                    variable.currentVoice = variable.voice_mal;
                    break;

                case "hsy":
                    Methods.changeText(variable.votext, variable.voice_hsy);
                    Methods.changeText(variable.nametext, "[绘事院]");
                    variable.currentVoice = variable.voice_hsy;
                    break;
                case "sbz":
                    Methods.changeText(variable.votext, variable.voice_sbz);
                    Methods.changeText(variable.nametext, "[沈葆桢]");
                    variable.currentVoice = variable.voice_sbz;
                    break;
                case "dsc":
                    Methods.changeText(variable.votext, variable.voice_dsc);
                    Methods.changeText(variable.nametext, "[邓世昌]");
                    variable.currentVoice = variable.voice_dsc;
                    break;
                case "yf":
                    Methods.changeText(variable.votext, variable.voice_yf);
                    Methods.changeText(variable.nametext, "[严复]");
                    variable.currentVoice = variable.voice_yf;
                    break;
                case "zty":
                    Methods.changeText(variable.votext, variable.voice_zty);
                    Methods.changeText(variable.nametext, "[詹天佑]");
                    variable.currentVoice = variable.voice_zty;
                    break;
                case "zzt":
                    Methods.changeText(variable.votext, variable.voice_zzt);
                    Methods.changeText(variable.nametext, "[左宗棠]");
                    variable.currentVoice = variable.voice_zzt;
                    break;


                default:
                    break;
            }
            Methods.playVoice(mTrackableBehaviour.TrackableName);

        }
    }


    protected virtual void OnTrackingLost()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;
            Debug.Log("丢了");

            video.allstop();
        }
    }

    #endregion // PROTECTED_METHODS
}
