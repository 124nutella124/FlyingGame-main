using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[RequireComponent(typeof(HEalth))]
public class DAmage : MonoBehaviour
{
    public Transform image;
    HEalth heath;

    private void Start()
    {
        heath = GetComponent<HEalth>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy")) ;
        heath.DAmage(10);
        image.localScale = new Vector3(heath.hp/100,1,1);
    }
}
