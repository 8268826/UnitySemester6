using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int randomNumber;
    public GameObject someObject;

    private void Start()
    {

    }

    private void Update()
    {
        Randomeizer();
    }

    void Randomeizer()
    {
        randomNumber = Random.Range(1, 100); //[1;99)
        Debug.Log(randomNumber);

        if (randomNumber == 3)
        {
            Debug.Log("Проверка условия");
        }
    }
}
