using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //UnityちゃんとItemEraserの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //UnityちゃんとItemEraserの位置（ｚ座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてItemEraserの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
       
        
    }
    //必要のなくなったアイテムを削除
    void OnTrriggerEnter(Collider other)
    {
        Debug.Log("衝突：" + other.gameObject.tag);
        if (other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
    }


}
