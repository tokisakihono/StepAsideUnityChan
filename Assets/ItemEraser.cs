using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity������ItemEraser�̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        //Unity������ItemEraser�̈ʒu�i�����W�j�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu�ɍ��킹��ItemEraser�̈ʒu���ړ�
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
       
        
    }
    //�K�v�̂Ȃ��Ȃ����A�C�e�����폜
    void OnTrriggerEnter(Collider other)
    {
        Debug.Log("�ՓˁF" + other.gameObject.tag);
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
