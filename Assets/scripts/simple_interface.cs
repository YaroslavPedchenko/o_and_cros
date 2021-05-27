using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simple_interface : MonoBehaviour
{
    public GameObject palyername;
    public GameObject order_;

    string pln="Bob";
    public Text oponent1, oponent2;

    private void Start()
    {
        oponent2.text = "Computer"; oponent1.text = pln;
    }
    public void startgame()
    {
        datathinks.oponentname1 = oponent1.text;
        datathinks.oponentname2 = oponent2.text;
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }
    public void getpalyername()
    {
       if(palyername.GetComponent<Text>().text!="")pln= palyername.GetComponent<Text>().text;
       else pln = "Bob";
        if (order_.GetComponent<Dropdown>().value == 1)
            oponent2.text = pln;
        else oponent1.text = pln;
    }
    public void exitetgame()
    {
        Application.Quit();
    }

    public void back(string name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);

    }

    public void order()
    {
        if (order_.GetComponent<Dropdown>().value == 1) { oponent1.text = "Computer"; oponent2.text = pln; }
        else { oponent2.text = "Computer"; oponent1.text = pln; }
    }
    /*void OnGUI()
    {
        GUI.Label(new Rect(300, 25, 100, 30), oponent1.text);
        GUI.Label(new Rect(700, 25, 100, 30), oponent2.text);
    }*/
}
