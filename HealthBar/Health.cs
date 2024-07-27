using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Health : MonoBehaviour
{
	public int curHealth = 0;
	public int maxHealth = 100;
	public HealthBar healthBar;
	void Start()
	{
		curHealth = maxHealth;
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			DamagePlayer(10);
		}
	}
	public void DamagePlayer(int hp)
	{
		if (curHealth > 0)
		{
			if (curHealth - hp < 0)
			{
				curHealth = 0;
				healthBar.SetHealth(curHealth);
			}
			else
			{
				curHealth -= hp;
				healthBar.SetHealth(curHealth);
			}
		}
	}

	public void HealPlayer(int hp)
	{
		if (curHealth < 100)
		{
			if (curHealth + hp > 100)
			{
				curHealth = 100;
				healthBar.SetHealth(curHealth);
			}
			else
			{
				curHealth += hp;
				healthBar.SetHealth(curHealth);
			}
		}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            DamagePlayer(10);
        }

    }
}

