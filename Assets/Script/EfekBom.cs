using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfekBom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
        JumlahLife.coltime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
