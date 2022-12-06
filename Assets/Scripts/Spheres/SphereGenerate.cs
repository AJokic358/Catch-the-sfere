using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerate : MonoBehaviour
{
    public GameObject[] sphereFall;
    public bool genSphere = false;
    public int sphereLoc;
    public int sphereCol;
    public float xPos;
    void Update()
    {
        if (genSphere == false)
        {
            genSphere = true;
            sphereLoc = Random.Range(1, 4);
            sphereCol = Random.Range(0, 3);
            if(sphereLoc == 1)
            {
                xPos = -1.5f;
            }
            if (sphereLoc == 2)
            {
                xPos = 0;
            }
            if (sphereLoc == 3)
            {
                xPos = 1.5f;
            }
            StartCoroutine(SphereFalling());
        }
    }

    IEnumerator SphereFalling()
    {
        Instantiate(sphereFall[sphereCol], new Vector3(xPos, 8, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        genSphere = false;
    }
}//class
