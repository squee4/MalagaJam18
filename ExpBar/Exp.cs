using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Exp : MonoBehaviour
{
	public int curExp = 0;
	public int maxExp = 100;
	public ExpBar expBar;
	void Start()
	{
		curExp = maxExp;
		InvokeRepeating("LoseExpPerSec", 1f, 1f);  //1s delay, repeat every 1s
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			LoseExp(10);
		}
	}
	public void LoseExp(int xp)
	{
		if (curExp > 0)
		{
			if (curExp - xp < 0)
			{
				curExp = 0;
				expBar.SetExp(curExp);
			}
			else
			{
				curExp -= xp;
				expBar.SetExp(curExp);
			}

		}
	}

	public void WinExp(int xp)
	{
		if (curExp < 100)
		{
			if (curExp + xp > 100)
			{
				curExp = 100;
				expBar.SetExp(curExp);
			}
			else
			{
				curExp += xp;
				expBar.SetExp(curExp);
			}

		}
	}

	void LoseExpPerSec()
	{
		if (curExp > 0)
		{
			curExp -= 2;
			expBar.SetExp(curExp);
		}
	}

	void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Comida"))
        {
            WinExp(5);
            //Destroy coin
            Destroy(c2d);
        }
    }
}