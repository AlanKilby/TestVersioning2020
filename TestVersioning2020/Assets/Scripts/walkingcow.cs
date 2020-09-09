using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingcow : MonoBehaviour
{
    public int vacheMagique;
    public bool vacheMarche;
    public int vitesseVache;

    
    // Start is called before the first frame update
   
    
    void Start()
    {
        if (vacheMarche)
        {
            vacheMagique = 5
            vitesseVache = 12
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
