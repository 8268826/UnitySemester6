using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPractical4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
            Destroy(other.gameObject);
    }
}
