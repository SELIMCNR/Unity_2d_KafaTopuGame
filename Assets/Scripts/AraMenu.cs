using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AraMenu : MonoBehaviour
{

    public bool dur;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        dur = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            dur = !dur;
        }
        if (dur)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (!dur)
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
