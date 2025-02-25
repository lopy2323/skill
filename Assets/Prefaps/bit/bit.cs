using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public bool state = false;

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            // Zet de sprite kleur op groen als state true is
            spriteRenderer.color = Color.green;
        }
        else
        {
            // Zet de sprite kleur op rood als state false is
            spriteRenderer.color = Color.red;
        }
    }
    private void OnMouseUp()
    {
        state = !state; // Wissel tussen true en false
    }
}
