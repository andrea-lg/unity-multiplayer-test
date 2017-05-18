using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalCameraPlayer : NetworkBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<drive>().enabled = true;
            GetComponent<WASDQE>().enabled = true;
            GetComponentInChildren<Camera>().enabled = true;

        }

        controllerScript[] controllers = GetComponentsInChildren<controllerScript>();
        foreach (controllerScript obj in controllers)
        {
            obj.gameObject.SetActive(true);
        }
    }

    [Command]
    void CmdFire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }
}