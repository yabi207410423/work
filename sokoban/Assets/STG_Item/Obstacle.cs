using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0,-0.2f,0);
    }
    void OnTriggerEnter2D(Collider2D col) //名為col的觸發事件
    {
        if (col.tag == "Ship") //如果碰撞的標籤是Ship
        {
            Destroy(col.gameObject); //消滅碰撞的物件
            Destroy(gameObject); //消滅物件本身
        }
    }
}