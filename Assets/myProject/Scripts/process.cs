using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class process : MonoBehaviour
{

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "home")
        {
            Methods.getGameObj();
            Methods.myEvent();
            variable.time = 3;
            InvokeRepeating("loadingTime", 0f, 1f);
            Invoke("hello", 3f);
        }
        else
        {
            Methods.getGameObj();
            Methods.myEvent();
            if (GameObject.Find("wrapper") != null)
            {
                variable.votext = GameObject.Find("wrapper").transform.Find("detailplane").transform.Find("voText").GetComponent<Text>();

            }

            Methods.sayHello();

            //StartCoroutine(myUnityWebRequest()); // 加载服务器中的资源 但是事件都不能用，原因是绑定事件时 fbx游戏对象还不存在 2019年10月9日00:30:25
        }




    }
    public void loadingTime()
    {


        if (variable.time == 0)
        {
            variable.loading.SetActive(false);
            CancelInvoke("loadingTime");
        }
        variable.time--;
        Methods.changeText(variable.loadingtimetext, (variable.time + ""));

    }
    public void hello()
    {

        VoiceStatic.instance.startSpeaking("欢迎来到船政文化A——R，为了您的良好体验建议您打开声音！");
    }

    #region 加载服务器上的ab包
    public IEnumerator myUnityWebRequest()
    {
        Debug.Log(variable.ip);
        Debug.Log(variable.packageName);
        string path = variable.ip + "/" + variable.packageName; // 加载服务器地址
        Debug.Log(path);
        variable.mgs = "开始连接...";
        Debug.Log(variable.mgs);

        UnityWebRequest unityWebRequest;
        unityWebRequest = UnityWebRequestAssetBundle.GetAssetBundle(path, 0);
        unityWebRequest.useHttpContinue = false;
        variable.mgs = "访问中...";
        Debug.Log(variable.mgs);
        yield return unityWebRequest.SendWebRequest();

        if (unityWebRequest.responseCode == 200)
        {
            AssetBundle assetBundle = DownloadHandlerAssetBundle.GetContent(unityWebRequest);
            Object[] obj = assetBundle.LoadAllAssets<GameObject>();

            foreach (var o in obj)
            {
                if (o.name == "opyh")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_pyh.transform;
                    g.transform.position = new Vector3(-0.982f, 0, 0);

                }
                else if (o.name == "olxt")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_lxt.transform;
                    g.transform.position = new Vector3(0.6f, 0, 0);

                }
                else if (o.name == "ojxyh")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_jxyh.transform;
                    g.transform.position = new Vector3(-6.03f, 0, 0);
                }
                else if (o.name == "obwg")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_bwg.transform;
                    g.transform.position = new Vector3(-4.171f, 0, 0);

                }
                else if (o.name == "oczxt")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_czxt.transform;
                    g.transform.position = new Vector3(-7.83f, 0, 0);
                }


                //Instantiate(o);

            }
            //GameObject prefabGO = assetBundle.LoadAsset("FJXk") as GameObject;
            //GameObject go = GameObject.Instantiate(prefabGO);
            variable.mgs = "连接成功";
            variable.loadpanel.SetActive(false);
            Debug.Log(variable.mgs);
            Methods.getGameObj();
            Methods.myEvent();
            yield return null;
        }
        else if (unityWebRequest.responseCode == 404)
        {
            variable.mgs = "连接超时";
            Debug.Log(variable.mgs);
            yield return null;
        }


    }
    #endregion


}
