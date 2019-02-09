using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seigyo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int i = 7;
        
         if (i%3 == 0) {
            Debug.Log("それは3の倍数です。");
        }
        else if (i%5 == 0) {
            Debug.Log("それは5の倍数です。");
        }
        else if (i>=10&&i<=40) {
            Debug.Log("恐らく10から40の間と思われます。");
        }
        else{
            Debug.Log("すみません、よく分かりません。");
        }


        string name = "秋山";

        switch (name)
        {
            case "秋山":
                Debug.Log("出席番号前の方ですね？");
                break;

            case "中島":
                Debug.Log("出席番号真ん中の方ですね？");
                break;

            case "山本":
                Debug.Log("出席番号後ろの方ですね？");
                break;

            default:
                Debug.Log("すみません、よく分かりません。");
                break;
        }

        for (int n = 20; n <= 100; n=n+17)
        {
            Debug.Log(n + "だよ。");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
