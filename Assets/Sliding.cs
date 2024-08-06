using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliding : MonoBehaviour
{
    
    public GameObject[] UIImages;
    int modelIndex = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Dispaly(int id)
    {
        for( int i=0; i < UIImages.Length; i++)
        {
            if (i == id)
                UIImages[id].SetActive(true);
        }
    }

    public void ChangeRight()
    {
        UIImages[modelIndex].SetActive(false);
        if (modelIndex < UIImages.Length - 1)
        {
            modelIndex++;

        }

        else
            modelIndex = 0;

        //GameObject clearUp = GameObject.FindGameObjectWithTag("Image");
        //Destroy(clearUp);
        UIImages[modelIndex].SetActive(true);


    }

    public void ChangeLeft()
    {
        UIImages[modelIndex].SetActive(false);
        if(modelIndex > 0)
        {
            modelIndex--;
            
        }

        else
            modelIndex = UIImages.Length - 1;

        //GameObject clearUp = GameObject.FindGameObjectWithTag("Image");
        //Destroy(clearUp);
        UIImages[modelIndex].SetActive(true);

    }    

}


