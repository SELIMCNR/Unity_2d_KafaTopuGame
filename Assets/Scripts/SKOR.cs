using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SKOR : MonoBehaviour
{
    public int ÝlkGol, ÝkinciGol;
    public Text skor1, skor2;
    Rigidbody2D golrigi;
    public bool GolOldu;
    public Vector3 BirinciOyuncu ,ÝkinciOyuncu,Top;
    // Start is called before the first frame update
    void Start()
    {
        BirinciOyuncu = GameObject.FindWithTag("PLAYER1").transform.position;
        ÝkinciOyuncu = GameObject.FindWithTag("PLAYER2").transform.position;
        Top = transform.position;
        GolOldu = false;
    }

    // Update is called once per frame
    void Update()
    {
        skor1.text = ÝlkGol.ToString() ;
        skor2.text = ÝkinciGol.ToString();
    }
     void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.name == "GOL1")
        {
            if(GolOldu==false)
            {

            }
            ÝlkGol++;
            GolOldu = true;
            Invoke("Resetle", 0);
        }
        if (temas.gameObject.name == "GOL2")
        {
            if (GolOldu == false)
            {

            }
            ÝkinciGol++;
            GolOldu = true;
            Invoke("Resetle", 0);
        }


    }

    void Resetle()
    {
        GameObject.FindWithTag("PLAYER1").transform.position = BirinciOyuncu;
        GameObject.FindWithTag("PLAYER2").transform.position = ÝkinciOyuncu;
        transform.position = Top;
        GolOldu=false;
        CancelInvoke("Resetle");
    }
}
