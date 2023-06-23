using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
    Text text; // UIのテキストを入れる変数

    void Start()
    {
        this.text = GameObject.Find("Text").GetComponent<Text>(); // テキストのオブジェクト名"Text"
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        text.text="ゲームクリア";
        Debug.Log("ゲームクリア！");
    }
}
