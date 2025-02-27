using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{

    public GameObject itemPrefab;
    public float r;

    // Start is called before the first frame update
    void Start()
    {

       // for (int i = 0; i < 10; i++)
        //{
         //   spawObject();
        //}

    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.B))
        // {
        //   spawObject();
        // }
    }

    void spawObject()
    {
        Vector2 randomPos2D = Random.insideUnitCircle * r;
        Vector3 randomPos = new Vector3(randomPos2D.x, randomPos2D.y, -1);
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }
}