using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject Bullet1Prefab;
    public float bulletforce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shooting();
        }        
    }
    public void shooting()
    {
        GameObject hitInfo = Instantiate(Bullet1Prefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = hitInfo.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
    }

}
