using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour
{
    public GameObject objText;

    // Start is called before the first frame update
    void Start()
    {
        objText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
