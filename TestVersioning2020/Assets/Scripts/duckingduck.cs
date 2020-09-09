using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckingduck : MonoBehaviour
{

    public bool isTheDuckMad;
    public int duckFood;
    public int duckClothes;

    // Start is called before the first frame update
    void Start()
    {
        if (!isTheDuckMad)
        {
            duckFood = 45;
            duckClothes = duckFood + 55;
        }
        else
        {
            duckFood = 0;
            duckClothes = 69;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
