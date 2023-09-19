using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEditor.Experimental.GraphView;

public class LaunchArena : MonoBehaviour
{
    public GameObject prefabWall;
    public GameObject prefabPilar;
    public GameObject prefabPlayer1;
    //public GameObject prefabPlayer2;
    public GameObject exitWay;
    public GameObject prefabBom;
   // public GameObject wallCount;

    public TMP_Text TextScore;
    public TMP_Text TextLive;
    public TMP_Text TextWall;
    public TMP_Text TextWin;

    // Start is called before the first frame update
    void Start()
    {
       
       exitWay.transform.position = new Vector2 (-9, 3);
       JumlahLife.powerBomRandom = (int)(UnityEngine.Random.value * 7);
       Instantiate(prefabBom, new Vector3(1, JumlahLife.powerBomRandom -3, 0), Quaternion.identity);    
       Debug.Log("Posisi bonus bom ada di:  1," + (JumlahLife.powerBomRandom-3));

        Debug.Log(JumlahLife.powerBomRandom.ToString());
        
        for (var i = -3; i <= 3; i++)
        {
            for (var j = -3; j <= 3; j++)
            {
             if (i%2==0 && j%2==0)
                {
                    Instantiate(prefabPilar, new Vector3(i, j, 0), Quaternion.identity);
                }else
                {
                 //if((i==-3 && j==-3) || (i==-2 && j==-3)||(i==-3 && j==-2) || (i==3 && j==3)|| (i == 3 && j == 3) || (i == 3 && j == 3))
                   if((i == -3 && j == -3) || (i == -2 && j == -3) || (i == -3 && j == -2))
                    { }
                 else
                    {
                        Instantiate(prefabWall, new Vector3(i, j, 0), Quaternion.identity);
                        JumlahLife.wallcount++;
                    }

                }
            }

           }

          Instantiate(prefabPlayer1, new Vector3(-3, -3, 0), Quaternion.identity);
       // Instantiate(prefabPlayer2, new Vector3(3, 3, 0), Quaternion.identity);

     
    }

    // Update is called once per frame
    private void Update()
    {
        TextScore.text = "BOM : " + JumlahLife.JumlahBom.ToString();
        //TextLive.text = JumlahLife.LifePlayer.ToString();
        TextWall.text = "WALL : " +JumlahLife.wallcount.ToString();

        if (JumlahLife.LifePlayer > 0)
        {
            TextLive.text = "Live : ";
            for (var l = 0; l < JumlahLife.LifePlayer; l++)
            {
                TextLive.text += "♥";
            }
        }
        else
        {
            TextLive.text = "GAME OVER";
        }
            if (JumlahLife.wallcount == 0)
            {
                exitWay.transform.position = new Vector3(JumlahLife.powerBomRandom - 3, 0);
                TextLive.text = "Silahkan Keluar";
            }
            
        if (JumlahLife.Win == true)
        {
            TextWin.text = "Anda Menang";
        }
    }
}
