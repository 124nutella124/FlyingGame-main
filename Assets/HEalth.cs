using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HEalth : MonoBehaviour
{
    public float mxHp;
    public float hp;

    public UnityEvent onDie;

    public void DAmage(float damage)
    {
        hp -= damage;

        if(hp < 0)
            onDie.Invoke();
    }

}
