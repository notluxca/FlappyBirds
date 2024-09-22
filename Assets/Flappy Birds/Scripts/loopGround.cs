using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopGround : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    public float width;
    private Vector2 startSize;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRenderer.size.x,spriteRenderer.size.y);

    }

    void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + GameManager.Instance.pipeSpeed * Time.deltaTime, spriteRenderer.size.y);
        if(spriteRenderer.size.x > width){
            spriteRenderer.size = startSize;
            
        }
    }
}
