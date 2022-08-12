using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float health = 1f;
    public float points = 10f;
    private Score score;
    private GameObject cursor;
    private CursorCooldown cooldown;

    private void Start()
    {
        cursor = GameObject.Find("Cursor");
        score = GameObject.Find("UI").GetComponent<Score>();
        cooldown = cursor.GetComponent<CursorCooldown>();
    }


    private void Update()
    {
        if(health == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if(health == 0)
        {
            Death();
        }     

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButton(0) && collision.gameObject.CompareTag("Player") && cooldown.timer < 0)
        {
            health--;
            score.score += points;
            cooldown.timer = cooldown.coolDown;
        }
    }

    void Death()
    {
        Destroy(this.gameObject);
    }
}
