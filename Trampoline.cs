using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //kercimi i shtuar
        other.GetComponent<Jump>().jumpStrength = 10;

    }

    void OnTriggerExit(Collider other)
    {
        //kercimi i zvogeluar
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
