using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectClicks : MonoBehaviour
{
    public GameObject buttons, m_cube;
    public Text playTxt, gameName;

    private bool clicked;

    void OnMouseDown()
    {
        if(!clicked){
            playTxt.gameObject.SetActive(false);
            gameName.text = "0";
            buttons.GetComponent<ScrollObjects>().speed = -5f;
            buttons.GetComponent<ScrollObjects>().checkPos = -150f;
            m_cube.GetComponent<Animation>().Play("StartGameCube");
        }  
    }
}
