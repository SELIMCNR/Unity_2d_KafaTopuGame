using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girCik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnGir()
    {
        Application.LoadLevel("SAHNEOYUN");
    }
    public void BtnCik()
    {
        Application.Quit();
    }
}
