using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_interface : MonoBehaviour
{
    public Text op1;
    public Text op2;
    public Sprite standart;
    public Sprite cross_;
    public Sprite o_;
    GameObject[] grid = new GameObject[9];
    int k = 1;
    byte[] cells = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    // Start is called before the first frame update
    void Start()
    {
        op1.text = datathinks.oponentname1;
        op2.text = datathinks.oponentname2;
        grid[0] = GameObject.Find("1");
        grid[1] = GameObject.Find("2");
        grid[2] = GameObject.Find("3");
        grid[3] = GameObject.Find("4");
        grid[4] = GameObject.Find("5");
        grid[5] = GameObject.Find("6");
        grid[6] = GameObject.Find("7");
        grid[7] = GameObject.Find("8");
        grid[8] = GameObject.Find("9");
        if (op1.text == "Computer") comclickbuton();
    }

    public void comclickbuton()
    {
        float temp = 0;
        int n = 9, tmp = 0;
        if (k == 1)
        {
            if (Random.value < 0.5f) n = 4;
            else
            {
                temp = Random.value;
                if (temp < 0.25f) n = 0;
                else if (temp >= 0.25f && temp < 0.5f) n = 2;
                else if (temp >= 0.5f && temp < 0.75f) n = 6;
                else n = 8;
                tmp = n;
            }
        }
        else if (k == 2 && cells[4] == 0) n = 4;
        else
        {
            temp = Random.value;
            if (temp < 0.25f && cells[0] == 0) n = 0;
            else temp += 0.25f;
            if (temp >= 0.25f && temp < 0.5f && cells[2] == 0) n = 2;
            else temp += 0.25f;
            if (temp >= 0.5f && temp < 0.75f && cells[6] == 0) n = 6;
            else temp += 0.25f;
            if (temp >= 0.75f && cells[8] == 0) n = 8;
            if(n==9)
            {
                if (temp >= 0.75f && cells[8] == 0) n = 8;
                else temp -= 0.25f;
                if (temp >= 0.5f && temp < 0.75f && cells[6] == 0) n = 6;
                else temp -= 0.25f;
                if (temp >= 0.25f && temp < 0.5f && cells[2] == 0) n = 2;
                else temp -= 0.25f;
                if(temp < 0.25f && cells[0] == 0) n = 0;
            }
            tmp = n;
        }
        if (k == 3)
        {
            if (tmp == 0)
            {
                if (cells[1] == 0 && cells[2] == 0)
                {
                    if (Random.value < 0.5f) n = 1;
                    else n = 2;
                }
                else if (cells[4] == 0 && cells[8] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 8;
                }
                else if (cells[3] == 0 && cells[6] == 0)
                {
                    if (Random.value < 0.5f) n = 6;
                    else n = 3;
                }
            }
            if (tmp == 1)
            {
                if (cells[0] == 0 && cells[2] == 0)
                {
                    if (Random.value < 0.5f) n = 0;
                    else n = 2;
                }
                else if (cells[4] == 0 && cells[7] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 7;
                }
            }
            if (tmp == 2)
            {
                if (cells[1] == 0 && cells[1] == 0)
                {
                    if (Random.value < 0.5f) n = 1;
                    else n = 0;
                }
                else if (cells[5] == 0 && cells[8] == 0)
                {
                    if (Random.value < 0.5f) n = 5;
                    else n = 8;
                }
                else if (cells[4] == 0 && cells[6] == 0)
                {
                    if (Random.value < 0.5f) n = 6;
                    else n = 4;
                }
            }
            if (tmp == 3)
            {
                if (cells[0] == 0 && cells[6] == 0)
                {
                    if (Random.value < 0.5f) n = 0;
                    else n = 6;
                }
                else if (cells[4] == 0 && cells[5] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 5;
                }
            }
            if (tmp == 4)
            {
                if (cells[1] == 0 && cells[7] == 0)
                {
                    if (Random.value < 0.5f) n = 1;
                    else n = 7;
                }
                else if (cells[5] == 0 && cells[3] == 0)
                {
                    if (Random.value < 0.5f) n = 5;
                    else n = 3;
                }
                else if (cells[2] == 0 && cells[6] == 0)
                {
                    if (Random.value < 0.5f) n = 6;
                    else n = 2;
                }
                else if (cells[0] == 0 && cells[8] == 0)
                {
                    if (Random.value < 0.5f) n = 0;
                    else n = 8;
                }
            }
            if (tmp == 5)
            {
                if (cells[8] == 0 && cells[2] == 0)
                {
                    if (Random.value < 0.5f) n = 8;
                    else n = 2;
                }
                else if (cells[4] == 0 && cells[3] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 3;
                }
            }
            if (tmp == 6)
            {
                if (cells[3] == 0 && cells[0] == 0)
                {
                    if (Random.value < 0.5f) n = 3;
                    else n = 0;
                }
                else if (cells[4] == 0 && cells[2] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 2;
                }
                else if (cells[7] == 0 && cells[8] == 0)
                {
                    if (Random.value < 0.5f) n = 7;
                    else n = 8;
                }
            }
            if (tmp == 7)
            {
                if (cells[6] == 0 && cells[8] == 0)
                {
                    if (Random.value < 0.5f) n = 6;
                    else n = 8;
                }
                else if (cells[4] == 0 && cells[1] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 1;
                }
            }
            if (tmp == 8)
            {
                if (cells[5] == 0 && cells[2] == 0)
                {
                    if (Random.value < 0.5f) n = 5;
                    else n = 2;
                }
                else if (cells[4] == 0 && cells[0] == 0)
                {
                    if (Random.value < 0.5f) n = 4;
                    else n = 0;
                }
                else if (cells[7] == 0 && cells[6] == 0)
                {
                    if (Random.value < 0.5f) n = 6;
                    else n = 7;
                }
            }
        }
        if (k == 4)
        {
            if ((cells[0] == cells[1] && cells[0] == 1) || (cells[8] == cells[5] && cells[8] == 1) && cells[2] == 0) n = 2;
            else if (((cells[3] == cells[4] && cells[3] == 1) || (cells[8] == cells[2] && cells[8] == 1)) && cells[5] == 0) n = 5;
            else if (((cells[6] == cells[7] && cells[6] == 1) || (cells[2] == cells[5] && cells[2] == 1)) && cells[8] == 0) n = 8;
            else if (((cells[1] == cells[2] && cells[1] == 1) || (cells[3] == cells[6] && cells[3] == 1)) && cells[0] == 0) n = 0;
            else if (((cells[4] == cells[5] && cells[4] == 1) || (cells[0] == cells[6] && cells[0] == 1)) && cells[3] == 0) n = 3;
            else if (((cells[8] == cells[7] && cells[7] == 1) || (cells[3] == cells[0] && cells[3] == 1)) && cells[6] == 0) n = 6;
            else if (((cells[0] == cells[2] && cells[0] == 1) || (cells[7] == cells[4] && cells[4] == 1)) && cells[1] == 0) n = 1;
            else if (((cells[1] == cells[7] && cells[1] == 1) || (cells[3] == cells[5] && cells[3] == 1)) && cells[4] == 0) n = 4;
            else if (((cells[6] == cells[8] && cells[6] == 1) || (cells[1] == cells[4] && cells[1] == 1)) && cells[7] == 0) n = 7;
            else if ((cells[2] == cells[6] && cells[2] == 1) || (cells[0] == cells[8] && cells[0] == 1) && cells[4] == 0) n = 4;
            else if (cells[0] == cells[4] && cells[0] == 1 && cells[8] == 0) n = 8;
            else if (cells[2] == cells[4] && cells[2] == 1 && cells[6] == 0) n = 6;
            else if (cells[6] == cells[4] && cells[4] == 1 && cells[2] == 0) n = 2;
            else if (cells[8] == cells[4] && cells[8] == 1 && cells[0] == 0) n = 0;
            if (n == 9)
            {
                if (tmp == 0)
                {
                    if (cells[1] == 0 && cells[2] == 0)
                    {
                        if (Random.value < 0.5f) n = 1;
                        else n = 2;
                    }
                    else if (cells[4] == 0 && cells[8] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 8;
                    }
                    else if (cells[3] == 0 && cells[6] == 0)
                    {
                        if (Random.value < 0.5f) n = 6;
                        else n = 3;
                    }
                }
                if (tmp == 1)
                {
                    if (cells[0] == 0 && cells[2] == 0)
                    {
                        if (Random.value < 0.5f) n = 0;
                        else n = 2;
                    }
                    else if (cells[4] == 0 && cells[7] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 7;
                    }
                }
                if (tmp == 2)
                {
                    if (cells[1] == 0 && cells[1] == 0)
                    {
                        if (Random.value < 0.5f) n = 1;
                        else n = 0;
                    }
                    else if (cells[5] == 0 && cells[8] == 0)
                    {
                        if (Random.value < 0.5f) n = 5;
                        else n = 8;
                    }
                    else if (cells[4] == 0 && cells[6] == 0)
                    {
                        if (Random.value < 0.5f) n = 6;
                        else n = 4;
                    }
                }
                if (tmp == 3)
                {
                    if (cells[0] == 0 && cells[6] == 0)
                    {
                        if (Random.value < 0.5f) n = 0;
                        else n = 6;
                    }
                    else if (cells[4] == 0 && cells[5] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 5;
                    }
                }
                if (tmp == 4)
                {
                    if (cells[1] == 0 && cells[7] == 0)
                    {
                        if (Random.value < 0.5f) n = 1;
                        else n = 7;
                    }
                    else if (cells[5] == 0 && cells[3] == 0)
                    {
                        if (Random.value < 0.5f) n = 5;
                        else n = 3;
                    }
                    else if (cells[2] == 0 && cells[6] == 0)
                    {
                        if (Random.value < 0.5f) n = 6;
                        else n = 2;
                    }
                    else if (cells[0] == 0 && cells[8] == 0)
                    {
                        if (Random.value < 0.5f) n = 0;
                        else n = 8;
                    }
                }
                if (tmp == 5)
                {
                    if (cells[8] == 0 && cells[2] == 0)
                    {
                        if (Random.value < 0.5f) n = 8;
                        else n = 2;
                    }
                    else if (cells[4] == 0 && cells[3] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 3;
                    }
                }
                if (tmp == 6)
                {
                    if (cells[3] == 0 && cells[0] == 0)
                    {
                        if (Random.value < 0.5f) n = 3;
                        else n = 0;
                    }
                    else if (cells[4] == 0 && cells[2] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 2;
                    }
                    else if (cells[7] == 0 && cells[8] == 0)
                    {
                        if (Random.value < 0.5f) n = 7;
                        else n = 8;
                    }
                }
                if (tmp == 7)
                {
                    if (cells[6] == 0 && cells[8] == 0)
                    {
                        if (Random.value < 0.5f) n = 6;
                        else n = 8;
                    }
                    else if (cells[4] == 0 && cells[1] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 1;
                    }
                }
                if (tmp == 8)
                {
                    if (cells[5] == 0 && cells[2] == 0)
                    {
                        if (Random.value < 0.5f) n = 5;
                        else n = 2;
                    }
                    else if (cells[4] == 0 && cells[0] == 0)
                    {
                        if (Random.value < 0.5f) n = 4;
                        else n = 0;
                    }
                    else if (cells[7] == 0 && cells[6] == 0)
                    {
                        if (Random.value < 0.5f) n = 6;
                        else n = 7;
                    }
                }
            }
        }
        if (k == 5 || k == 7 || k==9)
        {
            //look for win
            if (((cells[0] == cells[1] && cells[0] == 1) || (cells[8] == cells[5] && cells[8] == 1)) && cells[2] == 0) n = 2;
            else if (((cells[3] == cells[4] && cells[3] == 1) || (cells[8] == cells[2] && cells[8] == 1)) && cells[5] == 0) n = 5;
            else if (((cells[6] == cells[7] && cells[6] == 1) || (cells[2] == cells[5] && cells[2] == 1)) && cells[8] == 0) n = 8;
            else if (((cells[1] == cells[2] && cells[1] == 1) || (cells[3] == cells[6] && cells[3] == 1)) && cells[0] == 0) n = 0;
            else if (((cells[4] == cells[5] && cells[4] == 1) || (cells[0] == cells[6] && cells[0] == 1)) && cells[3] == 0) n = 3;
            else if (((cells[8] == cells[7] && cells[7] == 1) || (cells[3] == cells[0] && cells[3] == 1)) && cells[6] == 0) n = 6;
            else if (((cells[0] == cells[2] && cells[0] == 1) || (cells[7] == cells[4] && cells[4] == 1)) && cells[1] == 0) n = 1;
            else if (((cells[1] == cells[7] && cells[1] == 1) || (cells[3] == cells[5] && cells[3] == 1)) && cells[4] == 0) n = 4;
            else if (((cells[6] == cells[8] && cells[6] == 1) || (cells[1] == cells[4] && cells[1] == 1)) && cells[7] == 0) n = 7;
            else if (((cells[2] == cells[6] && cells[2] == 1) || (cells[0] == cells[8] && cells[0] == 1)) && cells[4] == 0) n = 4;
            else if(cells[0] == cells[4] && cells[0] == 1 && cells[8] == 0) n = 8;
            else if(cells[2] == cells[4] && cells[2] == 1 && cells[6] == 0) n = 6;
            else if(cells[6] == cells[4] && cells[4] == 1 && cells[2] == 0) n = 2;
            else if(cells[8] == cells[4] && cells[8] == 1 && cells[0] == 0) n = 0;
            //look for not lose
            if (n == 9)
            {
                if (((cells[0] == cells[1] && cells[0] == 2) || (cells[8] == cells[5] && cells[8] == 2)) && cells[2] == 0) n = 2;
                else if (((cells[3] == cells[4] && cells[3] == 2) || (cells[8] == cells[2] && cells[8] == 2)) && cells[5] == 0) n = 5;
                else if (((cells[6] == cells[7] && cells[6] == 2) || (cells[2] == cells[5] && cells[2] == 2)) && cells[8] == 0) n = 8;
                else if (((cells[1] == cells[2] && cells[1] == 2) || (cells[3] == cells[6] && cells[3] == 2)) && cells[0] == 0) n = 0;
                else if (((cells[4] == cells[5] && cells[4] == 2) || (cells[0] == cells[6] && cells[0] == 2)) && cells[3] == 0) n = 3;
                else if (((cells[8] == cells[7] && cells[7] == 2) || (cells[3] == cells[0] && cells[3] == 2)) && cells[6] == 0) n = 6;
                else if (((cells[0] == cells[2] && cells[0] == 2) || (cells[7] == cells[4] && cells[4] == 2)) && cells[1] == 0) n = 1;
                else if (((cells[1] == cells[7] && cells[1] == 2) || (cells[3] == cells[5] && cells[3] == 2)) && cells[4] == 0) n = 4;
                else if (((cells[6] == cells[8] && cells[6] == 2) || (cells[1] == cells[4] && cells[1] == 2)) && cells[7] == 0) n = 7;
                else if (((cells[2] == cells[6] && cells[2] == 2) || (cells[0] == cells[8] && cells[0] == 2)) && cells[4] == 0) n = 4;
                else if (cells[0] == cells[4] && cells[0] == 2 && cells[8] == 0) n = 8;
                else if (cells[2] == cells[4] && cells[2] == 2 && cells[6] == 0) n = 6;
                else if (cells[6] == cells[4] && cells[4] == 2 && cells[2] == 0) n = 2;
                else if (cells[8] == cells[4] && cells[8] == 2 && cells[0] == 0) n = 0;
            }
        }
        //look for win
        if (k == 6 || k == 8)
        {
            if (((cells[0] == cells[1] && cells[0] == 2) || (cells[8] == cells[5] && cells[8] == 2)) && cells[2] == 0) n = 2;
            else if (((cells[3] == cells[4] && cells[3] == 2) || (cells[8] == cells[2] && cells[8] == 2)) && cells[5] == 0) n = 5;
            else if (((cells[6] == cells[7] && cells[6] == 2) || (cells[2] == cells[5] && cells[2] == 2)) && cells[8] == 0) n = 8;
            else if (((cells[1] == cells[2] && cells[1] == 2) || (cells[3] == cells[6] && cells[3] == 2)) && cells[0] == 0) n = 0;
            else if (((cells[4] == cells[5] && cells[4] == 2) || (cells[0] == cells[6] && cells[0] == 2)) && cells[3] == 0) n = 3;
            else if (((cells[8] == cells[7] && cells[7] == 2) || (cells[3] == cells[0] && cells[3] == 2)) && cells[6] == 0) n = 6;
            else if (((cells[0] == cells[2] && cells[0] == 2) || (cells[7] == cells[4] && cells[4] == 2)) && cells[1] == 0) n = 1;
            else if (((cells[1] == cells[7] && cells[1] == 2) || (cells[3] == cells[5] && cells[3] == 2)) && cells[4] == 0) n = 4;
            else if (((cells[6] == cells[8] && cells[6] == 2) || (cells[1] == cells[4] && cells[1] == 2)) && cells[7] == 0) n = 7;
            else if (((cells[2] == cells[6] && cells[2] == 2) || (cells[0] == cells[8] && cells[0] == 2)) && cells[4] == 0) n = 4;
            else if(cells[0] == cells[4] && cells[0] == 2 && cells[8] == 0) n = 8;
            else if(cells[2] == cells[4] && cells[2] == 2 && cells[6] == 0) n = 6;
            else if(cells[6] == cells[4] && cells[4] == 2 && cells[2] == 0) n = 2;
            else if(cells[8] == cells[4] && cells[8] == 2 && cells[0] == 0) n = 0;
            //look for not lose
            if (n == 9)
            {
                if (((cells[0] == cells[1] && cells[0] == 1) || (cells[8] == cells[5] && cells[8] == 1)) && cells[2] == 0) n = 2;
                else if (((cells[3] == cells[4] && cells[3] == 1) || (cells[8] == cells[2] && cells[8] == 1)) && cells[5] == 0) n = 5;
                else if (((cells[6] == cells[7] && cells[6] == 1) || (cells[2] == cells[5] && cells[2] == 1)) && cells[8] == 0) n = 8;
                else if (((cells[1] == cells[2] && cells[1] == 1) || (cells[3] == cells[6] && cells[3] == 1)) && cells[0] == 0) n = 0;
                else if (((cells[4] == cells[5] && cells[4] == 1) || (cells[0] == cells[6] && cells[0] == 1)) && cells[3] == 0) n = 3;
                else if (((cells[8] == cells[7] && cells[7] == 1) || (cells[3] == cells[0] && cells[3] == 1)) && cells[6] == 0) n = 6;
                else if (((cells[0] == cells[2] && cells[0] == 1) || (cells[7] == cells[4] && cells[4] == 1)) && cells[1] == 0) n = 1;
                else if (((cells[1] == cells[7] && cells[1] == 1) || (cells[3] == cells[5] && cells[3] == 1)) && cells[4] == 0) n = 4;
                else if (((cells[6] == cells[8] && cells[6] == 1) || (cells[1] == cells[4] && cells[1] == 1)) && cells[7] == 0) n = 7;
                else if (((cells[2] == cells[6] && cells[2] == 1) || (cells[0] == cells[8] && cells[0] == 1)) && cells[4] == 0) n = 4;
                else if (cells[0] == cells[4] && cells[0] == 1 && cells[8] == 0) n = 8;
                else if (cells[2] == cells[4] && cells[2] == 1 && cells[6] == 0) n = 6;
                else if (cells[6] == cells[4] && cells[4] == 1 && cells[2] == 0) n = 2;
                else if (cells[8] == cells[4] && cells[8] == 1 && cells[0] == 0) n = 0;
            }
        }
        if (n == 9) 
        {
            for(int i = 0; i < 9; ++i)
            {
                if (cells[i] == 0) n = i; break;
            }
        }
        if (k % 2 != 0) { grid[n].gameObject.GetComponent<Image>().sprite = cross_; cells[n] = 1; }
        else { grid[n].gameObject.GetComponent<Image>().sprite = o_; cells[n] = 2; }
        grid[n].gameObject.GetComponent<Button>().interactable = false;
        Debug.Log("comm"+k);
        Debug.Log("comtile"+n);
        ++k;
        check();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton1()
    {
        if (k % 2 != 0) { grid[0].gameObject.GetComponent<Image>().sprite = cross_;cells[0] = 1; }
        else { grid[0].gameObject.GetComponent<Image>().sprite = o_; cells[0] = 2; }
        grid[0].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k!=9 && !show) comclickbuton();
        if (k == 9 && !show) show1 = true;
    }
    public void clickbuton2()
    {
        if (k % 2 != 0) { grid[1].gameObject.GetComponent<Image>().sprite = cross_; cells[1] = 1; }
        else { grid[1].gameObject.GetComponent<Image>().sprite = o_; cells[1] = 2; }
        grid[1].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton3()
    {
        if (k % 2 != 0) { grid[2].gameObject.GetComponent<Image>().sprite = cross_; cells[2] = 1; }
        else { grid[2].gameObject.GetComponent<Image>().sprite = o_; cells[2] = 2; }
        grid[2].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton4()
    {
        if (k % 2 != 0) { grid[3].gameObject.GetComponent<Image>().sprite = cross_; cells[3] = 1; }
        else { grid[3].gameObject.GetComponent<Image>().sprite = o_; cells[3] = 2; }
        grid[3].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton5()
    {
        if (k % 2 != 0) { grid[4].gameObject.GetComponent<Image>().sprite = cross_; cells[4] = 1; }
        else { grid[4].gameObject.GetComponent<Image>().sprite = o_; cells[4] = 2; }
        grid[4].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton6()
    {
        if (k % 2 != 0) { grid[5].gameObject.GetComponent<Image>().sprite = cross_; cells[5] = 1; }
        else { grid[5].gameObject.GetComponent<Image>().sprite = o_; cells[5] = 2; }
        grid[5].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton7()
    {
        if (k % 2 != 0) { grid[6].gameObject.GetComponent<Image>().sprite = cross_; cells[6] = 1; }
        else { grid[6].gameObject.GetComponent<Image>().sprite = o_; cells[6] = 2; }
        grid[6].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton8()
    {
        if (k % 2 != 0) { grid[7].gameObject.GetComponent<Image>().sprite = cross_; cells[7] = 1; }
        else { grid[7].gameObject.GetComponent<Image>().sprite = o_; cells[7] = 2; }
        grid[7].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }
    public void clickbuton9()
    {
        if (k % 2 != 0) { grid[8].gameObject.GetComponent<Image>().sprite = cross_; cells[8] = 1; }
        else { grid[8].gameObject.GetComponent<Image>().sprite = o_; cells[8] = 2; }
        grid[8].gameObject.GetComponent<Button>().interactable = false;
        ++k;
        check();
        if (k != 10 && !show) comclickbuton();
        if (k == 10 && !show) show1 = true;
    }

    public void exitetgame()
    {
        Application.Quit();
    }

    void check()
    {
        if (k > 5)
        {
            for (int i = 0; i < 3; ++i)
                if (cells[i * 3] == cells[(i * 3) + 1] && cells[(i * 3) + 1] == cells[(i * 3) + 2] && cells[i * 3] == 1) gameend(op1.text);
            for (int i = 0; i < 3; ++i)
                if (cells[i] == cells[i + 3] && cells[i + 3] == cells[i + 6] && cells[i] == 1) gameend(op1.text);
            if (cells[0] == cells[4] && cells[4] == cells[8] && cells[0] == 1) gameend(op1.text);
            if (cells[2] == cells[4] && cells[4] == cells[6] && cells[2] == 1) gameend(op1.text);
        }
        if (k > 6)
        {
            for (int i = 0; i < 3; ++i)
                if (cells[i * 3] == cells[(i * 3) + 1] && cells[(i * 3) + 1] == cells[(i * 3) + 2] && cells[i * 3] == 2) gameend(op2.text);
            for (int i = 0; i < 3; ++i)
                if (cells[i] == cells[i + 3] && cells[i + 3] == cells[i + 6] && cells[i] == 2) gameend(op2.text);
            if (cells[0] == cells[4] && cells[4] == cells[8] && cells[0] == 2) gameend(op2.text);
            if (cells[2] == cells[4] && cells[4] == cells[6] && cells[2] == 2) gameend(op2.text);
        }
    }
    public void refreshgame()
    {
        k = 1;
        cells = null;
        cells = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        grid[0].gameObject.GetComponent<Image>().sprite = standart;
        grid[0].gameObject.GetComponent<Button>().interactable = true;
        grid[1].gameObject.GetComponent<Image>().sprite = standart;
        grid[1].gameObject.GetComponent<Button>().interactable = true;
        grid[2].gameObject.GetComponent<Image>().sprite = standart;
        grid[2].gameObject.GetComponent<Button>().interactable = true;
        grid[3].gameObject.GetComponent<Image>().sprite = standart;
        grid[3].gameObject.GetComponent<Button>().interactable = true;
        grid[4].gameObject.GetComponent<Image>().sprite = standart;
        grid[4].gameObject.GetComponent<Button>().interactable = true;
        grid[5].gameObject.GetComponent<Image>().sprite = standart;
        grid[5].gameObject.GetComponent<Button>().interactable = true;
        grid[6].gameObject.GetComponent<Image>().sprite = standart;
        grid[6].gameObject.GetComponent<Button>().interactable = true;
        grid[7].gameObject.GetComponent<Image>().sprite = standart;
        grid[7].gameObject.GetComponent<Button>().interactable = true;
        grid[8].gameObject.GetComponent<Image>().sprite = standart;
        grid[8].gameObject.GetComponent<Button>().interactable = true;
        if (op1.text == "Computer") comclickbuton();
    }

    private Rect windowRect = new Rect((Screen.width - 200) / 2, (Screen.height - 300) / 2, 200, 300);
    private bool show = false,show1=false;
    string win;
    void OnGUI()
    {
        if (show)
            windowRect = GUI.Window(0, windowRect, DialogWindow, "Winner: "+ win);
        else if(show1) windowRect = GUI.Window(0, windowRect, DialogWindow, "Tie");
    }
    void DialogWindow(int windowID)
    {
        GUI.Label(new Rect(5, 20, windowRect.width, 20), "Again?");
        if (GUI.Button(new Rect(5, 50, windowRect.width - 10, 20), "Restart"))
        {
            refreshgame();
            show1 = false;
            show = false;
        }
        if (GUI.Button(new Rect(5, 80, windowRect.width - 10, 20), "Exit"))
        {
            Application.Quit();
            show = false;
            show1 = false;
        }
    }

    void gameend(string winner)
    {
        win = winner;
        show=true;  
    }
    public void tomenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
