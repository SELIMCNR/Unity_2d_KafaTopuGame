using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SKOR : MonoBehaviour
{
    public int �lkGol, �kinciGol;
    public Text skor1, skor2;
    Rigidbody2D golrigi;
    public bool GolOldu;
    public Vector3 BirinciOyuncu ,�kinciOyuncu,Top;
    // Start is called before the first frame update
    void Start()
    {
        BirinciOyuncu = GameObject.FindWithTag("PLAYER1").transform.position;
        �kinciOyuncu = GameObject.FindWithTag("PLAYER2").transform.position;
        Top = transform.position;
        GolOldu = false;
    }

    // Update is called once per frame
    void Update()
    {
        skor1.text = �lkGol.ToString() ;
        skor2.text = �kinciGol.ToString();
    }
     void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.name == "GOL1")
        {
            if(GolOldu==false)
            {

            }
            �lkGol++;
            GolOldu = true;
            Invoke("Resetle", 0);
        }
        if (temas.gameObject.name == "GOL2")
        {
            if (GolOldu == false)
            {

            }
            �kinciGol++;
            GolOldu = true;
            Invoke("Resetle", 0);
        }


    }

    void Resetle()
    {
        GameObject.FindWithTag("PLAYER1").transform.position = BirinciOyuncu;
        GameObject.FindWithTag("PLAYER2").transform.position = �kinciOyuncu;
        transform.position = Top;
        GolOldu=false;
        CancelInvoke("Resetle");
    }
}
