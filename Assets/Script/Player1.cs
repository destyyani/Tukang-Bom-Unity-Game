using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject prefabBom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        var x = 0;
        var y = 0;

        if (Input.GetKeyDown(KeyCode.B))
        { x = -1; }
        if (Input.GetKeyDown(KeyCode.N))
        { x = 1; }
        if (Input.GetKeyDown(KeyCode.M))
        { y = -1; }
        if (Input.GetKeyDown(KeyCode.J))
        { y = 1; }
    */
        float x = Input.GetAxis("Horizontal") * 10f *Time.deltaTime;
        float y = Input.GetAxis("Vertical") * 10f * Time.deltaTime;
        transform.Translate(x, y, 0f);

        var posX = Mathf.Round(transform.position.x);
        var posY = MathF.Round(transform.position.y);
        var pos = new Vector3(posX, posY);

        if (Input.GetKeyDown(KeyCode.Space)) //naruh Bom
        {
            if (JumlahLife.JumlahBom > 0)
            {
               // Debug.Log("Bom akan ditaruh");
                Instantiate(prefabBom, pos, Quaternion.identity);
             //   Debug.Log("bom ditaruh");
                JumlahLife.JumlahBom--;
             }
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ledakan")
        {
            JumlahLife.LiveDestroy = true;
                       
        }
        if (collision.gameObject.tag == "Exit")
        {
            JumlahLife.Win = true;

        }
    }

    private void LateUpdate()
    {
        if (JumlahLife.LiveDestroy) 
        {
            JumlahLife.coltime++;
            if(JumlahLife.coltime==1)
            {
                JumlahLife.LifePlayer--;
            }

            if (JumlahLife.LifePlayer <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector3(-3, -3);
            }
            JumlahLife.LiveDestroy = false;
        }
    }
}
