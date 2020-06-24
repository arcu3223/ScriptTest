using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 課題 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 配列を初期化する
        int[] points = { 20, 10, 50, 30, 40 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 4; i >= 0 ; i--)
        {
            Debug.Log(points[i]);
        }
        }

        // Update is called once per frame
        void Update()
    {

    }
}