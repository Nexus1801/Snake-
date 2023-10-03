using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segments : MonoBehaviour
{
    public Sprite[] prefabSprites;

    public void ChangePrefabSprite(int i)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = prefabSprites[i];

    }
}
