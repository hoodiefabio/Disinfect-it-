using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCooldown : MonoBehaviour
{
    public float coolDown = 3f;
    public float timer;
    private SpriteRenderer sprite;
    Color originalColor;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        originalColor = sprite.color;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer > 0.1)
        {
            sprite.color = Color.white;
        }
        else sprite.color = originalColor;
    }
}
