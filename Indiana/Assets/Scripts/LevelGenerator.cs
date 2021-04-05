using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



public class LevelGenerator : MonoBehaviour
{
    // - - пустое место
    // o - обычная плитка
    // v - падающая плитка
    // q - обычная плитка с зерном
    // x - падающая плитка с зерном

    // public GameObject[] prefabs;



    public string[] level = File.ReadAllLines("level.txt");

    [ContextMenu("Create Platforms")]
    void CreatePlatforms()
    {
        GameObject Parent = GameObject.Find("Platforms");

        Object Static_Platform = Resources.Load("Static Platform", typeof(GameObject));
        Object Hiding_Platform = Resources.Load("Hiding Platform", typeof(GameObject));
        Object Seed = Resources.Load("Seed", typeof(GameObject));
        //GameObject Hiding_Platform = Instantiate(Resources.Load("Hiding Platform", typeof(GameObject))) as GameObject;
        //GameObject Seed = Instantiate(Resources.Load("Seed", typeof(GameObject))) as GameObject;

        for (int i = 0; i < level.Length; i++)
        {

            int stringLength = level[i].Length;
            char [] levelString = level[i].ToCharArray(0, stringLength);
            for (int j = 0; j < levelString.Length; j++)
            {
                
                if (levelString[j] == 'o' || levelString[j] == 'q')
                {

                    GameObject oq = Instantiate(Static_Platform, new Vector3(i * 3, 0, j * 3), Quaternion.identity) as GameObject;
                    oq.transform.SetParent(Parent.transform, false);
                    //Instantiate(Static_Platform, new Vector3(i * 3, 0, j * 3), Quaternion.identity);


                }
                if (levelString[j] == 'v' || levelString[j] == 'x')
                {

                    GameObject vx = Instantiate(Hiding_Platform, new Vector3(i * 3, 0, j * 3), Quaternion.identity) as GameObject;
                    vx.transform.SetParent(Parent.transform, false);

                }
                if (levelString[j] == 'x' || levelString[j] == 'q')
                {
                    GameObject xq = Instantiate(Seed, new Vector3(i * 3, 1, j * 3), Quaternion.identity) as GameObject;
                    xq.transform.SetParent(Parent.transform, false);
                }

            }
        }         
    }    
}
