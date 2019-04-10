using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = new int[5];
		int i;

		//配列arrayの初期化
		for (i = 0; i < 5; i++) {
			array [i] = i;
		}
		Debug.Log("正順");
		//配列array出力　正順
		for (i = 0; i < 5; i++) {
			Debug.Log(array[i]);
		}
		Debug.Log("逆順");
		//配列arrayの出力　逆順
		for (i = 4; i >=0 ; i--) {
			Debug.Log(array[i]);
		}

	}
	
	// Update is called once per frame
	void Update () {
	}
}
