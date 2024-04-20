using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    [SerializeField] float firstHealth;
    [SerializeField] float maxHealth;
    [SerializeField] float minHealth = 0;
    [SerializeField] bool player;
    private float nowHealth;
    // Start is called before the first frame update
    void Start()
    {
        nowHealth = firstHealth;
    }

    public void damage (int i) 
    {
        nowHealth -= i;
        if (nowHealth <= minHealth) { dead(); }
        print("damage");
    }
    public void heal(int i)
    {
        nowHealth += i;
        if (nowHealth > maxHealth) { nowHealth = maxHealth; }
    }

    void dead()
    {
        if (player)
        {
            SceneManager.LoadScene(0);
        }
        else
        { 
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
