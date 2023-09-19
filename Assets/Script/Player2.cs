using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public GameObject prefabBom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        var x = 0;
        var y = 0;

        if (Input.GetKeyDown(KeyCode.A))
        { x = -1; }
        if (Input.GetKeyDown(KeyCode.D))
        { x = 1; }
        if (Input.GetKeyDown(KeyCode.S))
        { y = -1; }
        if (Input.GetKeyDown(KeyCode.W))
        { y = 1; }
        
        transform.Translate(x, y, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabBom, transform.position, Quaternion.identity);
            //Destroy(this);
        }

    }
}
