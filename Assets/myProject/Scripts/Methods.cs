using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Networking;
public class Methods : MonoBehaviour
{


    #region 你好
    public static void sayHello()
    {
        VoiceStatic.instance.startSpeaking("请扫描卡片！");
    }
    #endregion
    #region 语音简介
    public static void playVoice(string str)
    {
        switch (str)
        {
            case "lxt":
                Debug.Log("罗星塔语音");
                VoiceStatic.instance.startSpeaking(variable.voice_lxt);
                break;
            case "pyh":
                Debug.Log("平远航语音");
                VoiceStatic.instance.startSpeaking(variable.voice_pyh);
                break;
            case "jxyh":
                Debug.Log("甲型一号语音");
                VoiceStatic.instance.startSpeaking(variable.voice_jxyh);
                break;
            case "czxt":
                Debug.Log("船政学堂语音");
                VoiceStatic.instance.startSpeaking(variable.voice_czxt);
                break;

            case "bwg":
                Debug.Log("博物馆语音");
                VoiceStatic.instance.startSpeaking(variable.voice_bwg);
                break;
            case "amstl":
                VoiceStatic.instance.startSpeaking(variable.voice_amstl);
                break;
                
            case "jqxyj":
                VoiceStatic.instance.startSpeaking(variable.voice_jqxyj);
                break;
                
            case "gshc":
                VoiceStatic.instance.startSpeaking(variable.voice_gshc);
                break;
                
            case "mal":
                VoiceStatic.instance.startSpeaking(variable.voice_mal);
                break;     
            case "hsy":
                VoiceStatic.instance.startSpeaking(variable.voice_hsy);
                break;
            case "sbz":
                VoiceStatic.instance.startSpeaking(variable.voice_sbz);
                break;
            case "dsc":
                VoiceStatic.instance.startSpeaking(variable.voice_dsc);
                break;
            case "yf":
                VoiceStatic.instance.startSpeaking(variable.voice_yf);
                break;
            case "zty":
                VoiceStatic.instance.startSpeaking(variable.voice_zty);
                break;
            case "zzt":
                VoiceStatic.instance.startSpeaking(variable.voice_zzt);
                break;

        }
    }
    #endregion

    #region 修改文字
    public static void changeText(Text obj, string str)
    {

        obj.text = str;
    }

    #endregion

    /// <summary>
    /// 获取对象、线框、添加新对象时要修改
    /// </summary>
    public static void getGameObj()
    {
        if (GameObject.Find("loadpanel") != null)
        {
            variable.loadpanel = GameObject.Find("loadpanel");

        }
        if (GameObject.Find("Image_lxt") != null)
        {
            variable.Image_lxt = GameObject.Find("Image_lxt");

        }
        if (GameObject.Find("Image_pyh") != null)
        {
            variable.Image_pyh = GameObject.Find("Image_pyh");

        }
        if (GameObject.Find("Image_bwg") != null)
        {
            variable.Image_bwg = GameObject.Find("Image_bwg");

        }
        if (GameObject.Find("Image_jxyh") != null)
        {
            variable.Image_jxyh = GameObject.Find("Image_jxyh");

        }
        if (GameObject.Find("Image_czxt") != null)
        {
            variable.Image_czxt = GameObject.Find("Image_czxt");


        }

        if (GameObject.Find("Image_amstl") != null)
        {
            variable.Image_amstl = GameObject.Find("Image_amstl");


        }
        if (GameObject.Find("Image_jqxyj") != null)
        {
            variable.Image_jqxyj = GameObject.Find("Image_jqxyj");


        }
        if (GameObject.Find("Image_gshc") != null)
        {
            variable.Image_gshc = GameObject.Find("Image_gshc");


        }
        if (GameObject.Find("Image_mal") != null)
        {
            variable.Image_mal = GameObject.Find("Image_mal");


        }
        if (GameObject.Find("Image_hsy") != null)
        {
            variable.Image_hsy = GameObject.Find("Image_hsy");


        }



        // 查找罗星塔线框
        if (GameObject.Find("lxt") != null)
        {
            variable.LXTXK = GameObject.Find("lxt").transform.Find("LXTXK").gameObject;

        }
        // 查找罗星塔线框
        if (GameObject.Find("lxt") != null)
        {
            variable.LXTXK = GameObject.Find("lxt").transform.Find("LXTXK").gameObject;

        }
        // 查找博物馆线框
        if (GameObject.Find("bwg") != null)
        {
            variable.BWGXK = GameObject.Find("bwg").transform.Find("BWGXK").gameObject;

        }
        // 查找甲型一号线框
        if (GameObject.Find("jxyh") != null)
        {
            variable.JXYHXK = GameObject.Find("jxyh").transform.Find("JXYHXK").gameObject;

        }
        // 查找船政学堂线框
        if (GameObject.Find("czxt") != null)
        {
            variable.CZXTXK = GameObject.Find("czxt").transform.Find("CZXTXK").gameObject;

        }
        // 查找平远航线框
        if (GameObject.Find("pyhobj") != null)
        {
            variable.PYHXK = GameObject.Find("pyh").transform.Find("PYHXK").gameObject;

        }


        if (GameObject.Find("amstlobj") != null)
        {
            variable.AMSTLXK = GameObject.Find("amstl").transform.Find("AMSTLXK").gameObject;

        }
        if (GameObject.Find("jqxyjobj") != null)
        {
            variable.JQXYJXK = GameObject.Find("jqxyj").transform.Find("JQXYJXK").gameObject;

        }
        if (GameObject.Find("gshcobj") != null)
        {
            variable.GSHCXK = GameObject.Find("gshc").transform.Find("GSHCXK").gameObject;

        }
        if (GameObject.Find("malobj") != null)
        {
            variable.MALXK = GameObject.Find("mal").transform.Find("MALXK").gameObject;

        }
        if (GameObject.Find("hsyobj") != null)
        {
            variable.HSYXK = GameObject.Find("hsy").transform.Find("HSYXK").gameObject;

        }





        // 查找罗星塔对象
        if (GameObject.Find("lxtobj") != null)
        {
            variable.lxtobj = GameObject.Find("lxtobj");

        }
        // 查找博物馆对象
        if (GameObject.Find("bwgobj") != null)
        {
            variable.bwgobj = GameObject.Find("bwgobj");

        }
        // 查找甲型一号对象
        if (GameObject.Find("jxyhobj") != null)
        {
            variable.jxyhobj = GameObject.Find("jxyhobj");

        }
        // 查找船政学堂对象
        if (GameObject.Find("czxtobj") != null)
        {
            variable.czxtobj = GameObject.Find("czxtobj");

        }
        // 查找平远航对象
        if (GameObject.Find("pyhobj") != null)
        {
            variable.pyhobj = GameObject.Find("pyhobj");

        }
        if (GameObject.Find("amstlobj") != null)
        {
            variable.amstlobj = GameObject.Find("amstlobj");

        }
        if (GameObject.Find("jqxyjobj") != null)
        {
            variable.jqxyjobj = GameObject.Find("jqxyjobj");

        }
        if (GameObject.Find("gshcobj") != null)
        {
            variable.gshcobj = GameObject.Find("gshcobj");

        }
        if (GameObject.Find("malobj") != null)
        {
            variable.malobj = GameObject.Find("malobj");

        }
        if (GameObject.Find("hsyobj") != null)
        {
            variable.hsyobj = GameObject.Find("hsyobj");

        }


        if (GameObject.Find("wrapper") != null)
        {
            variable.detailplane = GameObject.Find("wrapper").transform.Find("detailplane").gameObject;
            variable.bottomBTn = GameObject.Find("wrapper").transform.Find("bottomBTn").gameObject;
            variable.full = GameObject.Find("wrapper").transform.Find("detailplane").transform.Find("full").gameObject;
            variable.bottomFull = GameObject.Find("wrapper").transform.Find("bottomBTn").transform.Find("bottomFull").gameObject;
            variable.bottomChangeStyle = GameObject.Find("wrapper").transform.Find("bottomBTn").transform.Find("changeStyle").gameObject;
            variable.nametext = GameObject.Find("wrapper").transform.Find("detailplane").transform.Find("name").gameObject.GetComponent<Text>();
        }
        if (GameObject.Find("loading") != null)
        {
            variable.loading = GameObject.Find("loading");
            variable.loadingtimetext = GameObject.Find("loadingtime").GetComponent<Text>();
        }

    }

    /// <summary>
    /// 添加事件方法
    /// </summary>
    public static void myEvent()
    {



        if (variable.full != null)
        {
            variable.full.GetComponent<Button>().onClick.AddListener(delegate ()
            {
                variable.detailplane.SetActive(false);
                variable.bottomBTn.SetActive(true);
            });

        }

        if (variable.bottomFull != null)
        {
            variable.bottomFull.GetComponent<Button>().onClick.AddListener(delegate ()
            {
                variable.detailplane.SetActive(true);
                variable.bottomBTn.SetActive(false);
            });

        }

        // 第一次进入播放
        if (variable.isFirst)
        {
            //VoiceStatic.instance.startSpeaking(variable.hello);
            variable.isFirst = false;
        }

        if (GameObject.Find("isMutedText") != null)
        {
            variable.isMutedText = GameObject.Find("isMutedText").GetComponent<Text>();

        }

        if (GameObject.Find("changeStyle") != null)
        {
            GameObject.Find("changeStyle").GetComponent<Button>().onClick.AddListener(delegate ()
            {

                if (variable.isMuted == false)
                {
                    variable.isMuted = !variable.isMuted;
                    VoiceStatic.instance.startSpeaking("");
                }
                else
                {
                    variable.isMuted = !variable.isMuted;
                    VoiceStatic.instance.startSpeaking(variable.currentVoice);
                }


            });

        }

        if (variable.bottomChangeStyle != null)
        {
            variable.bottomChangeStyle.GetComponent<Button>().onClick.AddListener(delegate ()
            {


                switch (variable.TrackableName)
                {
                    case "lxt":
                        {

                            variable.lxtobj.SetActive(!variable.lxtobj.activeSelf);
                            variable.LXTXK.SetActive(!variable.LXTXK.activeSelf);
                        }
                        break;
                    case "bwg":
                        {
                            variable.bwgobj.SetActive(!variable.bwgobj.activeSelf);
                            variable.BWGXK.SetActive(!variable.BWGXK.activeSelf);
                        }
                        break;
                    case "jxyh":
                        {
                            Debug.Log("进来了");
                            Debug.Log("obj=" + variable.jxyhobj + "::" + variable.jxyhobj.activeSelf + "xk=" + variable.jxyhobj.activeSelf);
                            variable.jxyhobj.SetActive(!variable.jxyhobj.activeSelf);
                            variable.JXYHXK.SetActive(!variable.JXYHXK.activeSelf);
                        }
                        break;
                    case "czxt":
                        {
                            variable.czxtobj.SetActive(!variable.czxtobj.activeSelf);
                            variable.CZXTXK.SetActive(!variable.CZXTXK.activeSelf);
                        }
                        break;
                    case "pyh":
                        {
                            variable.pyhobj.SetActive(!variable.pyhobj.activeSelf);
                            variable.PYHXK.SetActive(!variable.PYHXK.activeSelf);
                        }
                        break;

                    case "amstl":
                        {
                            variable.amstlobj.SetActive(!variable.amstlobj.activeSelf);
                            variable.AMSTLXK.SetActive(!variable.AMSTLXK.activeSelf);
                        }
                        break;
                    case "jqxyj":
                        {
                            variable.jqxyjobj.SetActive(!variable.jqxyjobj.activeSelf);
                            variable.JQXYJXK.SetActive(!variable.JQXYJXK.activeSelf);
                        }
                        break;
                    case "gshc":
                        {
                            variable.gshcobj.SetActive(!variable.gshcobj.activeSelf);
                            variable.GSHCXK.SetActive(!variable.GSHCXK.activeSelf);
                        }
                        break;
                    case "mal":
                        {
                            variable.malobj.SetActive(!variable.malobj.activeSelf);
                            variable.MALXK.SetActive(!variable.MALXK.activeSelf);
                        }
                        break;
                    case "hsy":
                        {
                            variable.hsyobj.SetActive(!variable.hsyobj.activeSelf);
                            variable.HSYXK.SetActive(!variable.HSYXK.activeSelf);
                        }
                        break;
                    default:
                        break;
                }


            });

        }


        if (GameObject.Find("isMuted") != null)
        {
            GameObject.Find("isMuted").GetComponent<Button>().onClick.AddListener(delegate ()
            {
                if (variable.isMuted == false)
                {
                    variable.isMuted = !variable.isMuted;
                    VoiceStatic.instance.startSpeaking("");
                }
                else
                {
                    variable.isMuted = !variable.isMuted;
                    VoiceStatic.instance.startSpeaking(variable.currentVoice);
                }

                //if (isMutedText.text == "静音")
                //{
                //    isMutedText.text = "播放";
                //}
                //else
                //{
                //    isMutedText.text = "静音";
                //}

                Debug.Log("静音按钮");
            });
        }



        #region 导航
        //if (GameObject.Find("back") != null)
        //{
        //    Debug.Log(GameObject.Find("back").GetComponent<Button>());

        //    //GameObject.Find("back").GetComponent<Button>().onClick.AddListener(delegate ()
        //    //{
        //    //    SceneManager.LoadScene(0);
        //    //});

        //}


        if (GameObject.Find("ToAR") != null)
        {
            GameObject.Find("ToAR").GetComponent<Button>().onClick.AddListener(delegate ()
            {

                SceneManager.LoadScene(1);

                //if (variable.isToAR)
                //{
                //    SceneManager.LoadScene(1);

                //}
                //else
                //{

                //    if (GameObject.Find("okImg") != null)
                //    {

                //        GameObject.Find("okImg").SetActive(false);

                //    }
                //    // 更改首页文字
                //    if (GameObject.Find("homeText") != null && GameObject.Find("Content") != null)
                //    {

                //        GameObject.Find("homeText").GetComponent<Text>().text = variable.introduce;
                //        GameObject.Find("homeText").GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1000);
                //        GameObject.Find("Content").GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1000);
                //        VoiceStatic.instance.startSpeaking(variable.introduce);
                //    }


                //    variable.isToAR = true;


                //}

            });

        }
        #endregion

    }




}
