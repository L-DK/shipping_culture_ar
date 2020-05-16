using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class load : MonoBehaviour
{



    void Start()
    {

        Debug.Log(variable.ip);
        StartCoroutine(myUnityWebRequest());
    }


    #region 加载服务器上的ab包
    IEnumerator myUnityWebRequest()
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
                else if (o.name == "oamstl")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_amstl.transform;
                    g.transform.position = new Vector3(-9.693f, 0, 0);
                }
                else if (o.name == "ojqxyj")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_jqxyj.transform;
                    g.transform.position = new Vector3(-10.983f, 0, 0);
                }
                else if (o.name == "ogshc")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_gshc.transform;
                    g.transform.position = new Vector3(-12.663f, 0, 0);
                }
                else if (o.name == "omal")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_mal.transform;
                    g.transform.position = new Vector3(-14.753f, 0, 0);
                }
                else if (o.name == "ohsy")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_hsy.transform;
                    g.transform.position = new Vector3(-16.38f, 0, 0);
                }
                else if (o.name == "Video_yf")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_yf.transform;
                    g.transform.position = new Vector3(-17.628f, 0, 0);
                }
                else if (o.name == "Video_sbz")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_sbz.transform;
                    g.transform.position = new Vector3(-19.19f, 0, 0);
                }
                else if (o.name == "Video_zty")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_zty.transform;
                    g.transform.position = new Vector3(-20.716f, 0, 0);
                }
                else if (o.name == "Video_dsc")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_dsc.transform;
                    g.transform.position = new Vector3(-22.256f, 0, 0);
                }
                else if (o.name == "Video_zzt")
                {
                    GameObject g = Instantiate(o) as GameObject;
                    g.transform.parent = variable.Image_zzt.transform;
                    g.transform.position = new Vector3(-23.78f, 0, 0);
                }


                //Instantiate(o);

            }
            //GameObject prefabGO = assetBundle.LoadAsset("FJXk") as GameObject;
            //GameObject go = GameObject.Instantiate(prefabGO);
            variable.mgs = "连接成功";
            Debug.Log(variable.mgs);
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