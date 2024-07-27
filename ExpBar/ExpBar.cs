using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpBar : MonoBehaviour
{
	public Slider expBar;
	public Exp playerExp;
	private void Start()
	{
		playerExp = GameObject.FindGameObjectWithTag("Player").GetComponent<Exp>();
		expBar = GetComponent<Slider>();
		expBar.maxValue = playerExp.maxExp;
		expBar.value = playerExp.maxExp;
	}
	public void SetExp(int xp)
	{
		expBar.value = xp;
	}
}
