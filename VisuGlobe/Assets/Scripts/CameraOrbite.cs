using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbite : MonoBehaviour
{
    public GameObject cible;
    public float anglesParSeconde = 45;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.transform.position = new Vector3(2, 0, 0); this.transform.transform.rotation = Quaternion.Euler(0, -90f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(cible.transform.position, Vector3.up, anglesParSeconde * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(cible.transform.position, Vector3.forward, -anglesParSeconde * Time.deltaTime);//TODO

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(cible.transform.position, Vector3.forward, anglesParSeconde * Time.deltaTime);//TODO

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(cible.transform.position, Vector3.up, -anglesParSeconde * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(cible.transform.position, Vector3.up, anglesParSeconde * Time.deltaTime);

        }


    }
}
