using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRoot : MonoBehaviour {
    [SerializeField] GameObject button = null;  // ボタン
    [SerializeField] GameObject text = null;    // テキスト

    private int count = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // ボタン
    public void OnPressButton() {
        // カウント
        count++;
        // 表示
        text.GetComponent<Text>().text = count.ToString();
    }
}
