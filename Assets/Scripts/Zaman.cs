using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zaman : MonoBehaviour
{
    public float zaman, verilen;
    public Text süre;
    // Start is called before the first frame update
    void Start()
    {
        zaman = verilen;
    }

    // Update is called once per frame
    void Update()
    {
        süre.text = zaman.ToString("f2");
        zaman -= Time.deltaTime;
        if( zaman < 0 )
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
    }
}
