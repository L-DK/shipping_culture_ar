using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrlDir : MonoBehaviour
{
    private bool flag = false;
    void Start()
    {
        

             GameObject.Find("changeDir_luoxing").GetComponent<Button>().onClick.AddListener(delegate ()
             {
                 Debug.Log("111111");
                 if (flag)
                 {
                     GameObject.Find("obj_lxt").transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                     flag = !flag;

                 }
                 else
                 {
                     GameObject.Find("obj_lxt").transform.localEulerAngles = new Vector3(90f, 0.0f, 0.0f);
                     flag = !flag;
                 }
             });
  

        GameObject.Find("changeDir_fj").GetComponent<Button>().onClick.AddListener(delegate ()
        {
            if (flag)
            {
                GameObject.Find("obj_feiji").transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                flag = !flag;

            }
            else
            {
                GameObject.Find("obj_feiji").transform.localEulerAngles = new Vector3(90f, 0.0f, 0.0f);
                flag = !flag;
            }

        });

        GameObject.Find("changeDir_pyj").GetComponent<Button>().onClick.AddListener(delegate ()
        {
            if (flag)
            {
                GameObject.Find("obj_pyj").transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                flag = !flag;

            }
            else
            {
                GameObject.Find("obj_pyj").transform.localEulerAngles = new Vector3(90f, 0.0f, 0.0f);
                flag = !flag;
            }

        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
