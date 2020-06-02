using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour
{
    private GameObject unitychan;
    private float difference;
    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {
        //障害物に衝突した場合
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag"  || other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }

        Debug.Log(other.gameObject.tag);
    }

}