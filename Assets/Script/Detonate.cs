using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonate : MonoBehaviour
{
    public GameObject prefabLedakan;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(efekBom());
    }

    IEnumerator efekBom ()
    {
       
            Debug.Log("Started at" + Time.time);
            for (float i=0f; i<=1f; i+=Time.deltaTime)
            { yield return null; }
           // Debug.Log("Ended at" + Time.time);
            Destroy(gameObject);
            Instantiate(prefabLedakan, transform.position, Quaternion.identity);
            JumlahLife.JumlahBom++;
            
            
        
    }
}
