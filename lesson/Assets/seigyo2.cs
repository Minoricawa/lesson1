using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seigyo2 : MonoBehaviour {

    // Use this for initialization
    void Start() {
        int i = 0;
        string e ="うん。";

        while (i <= 100)
        {
            i = Random.Range(1, 100);

            if (i <= 5)
            {
                Debug.Log(i+"  クリティカル＾＾");
                break;
            }
            else if (i >= 96)
            {
                Debug.Log(i+"  ファンブル；；");
                break;
            }
            else
            {
                Debug.LogFormat("{0}  {1}",i,e);
                break;
            }
        }
        }

        // Update is called once per frame
        void Update() {

        }
    }