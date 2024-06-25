using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class RectangleSpawner : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public int health { get; private set; }
    public Sprite[] states;
    public bool unbreakable;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        if (!this.unbreakable)
        {
            this.health = this.states.Length;
            this.spriteRenderer.sprite = this.states[this.health - 1];
        }

        else
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        if (this.unbreakable)
        {
            return; 
        }
        if (this.health > 0)
        {
            this.health--;
            this.spriteRenderer.sprite = this.states[this.health - 1];
        }
        else
        {
            this.gameObject.SetActive(false);
        }

    }          
}