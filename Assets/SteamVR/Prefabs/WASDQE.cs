using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WASDQE : MonoBehaviour
{

    public GameObject head;
    float Y;



    // Use this for initialization
    void Start()
    {

        Y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = new Vector3(transform.position.x, Y, transform.position.z);


        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(head.transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-head.transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(-head.transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(head.transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Y -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Y += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.J))
        {
            this.transform.rotation = new Quaternion(this.transform.rotation.x, this.transform.rotation.y + (90 * Time.deltaTime), this.transform.rotation.z, 0);
        }



    }

}
