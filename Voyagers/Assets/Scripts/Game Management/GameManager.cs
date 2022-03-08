using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void showIt(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void hideIt(GameObject obj)
    {
        obj.SetActive(false);
    }
}