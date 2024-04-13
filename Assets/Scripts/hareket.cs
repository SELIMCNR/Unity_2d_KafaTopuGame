using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{

    public int hiz;
    public string player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.D) && player=="1")
        {
            transform.Translate(hiz * Time.deltaTime , 0, 0);
        }
        if (Input.GetKey(KeyCode.A) && player == "1")
        {
            transform.Translate(hiz * Time.deltaTime*-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && player == "2")
        {
            //zýplama karakter
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300000);
        }
        if (Input.GetKey(KeyCode.RightArrow) && player == "2")
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && player == "2")
        {
            transform.Translate(hiz * Time.deltaTime*-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && player == "1")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300000);
        }
    }
}
