using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{

    public SpriteSwitcher spriteSwitcher;
    private Animator animator;
    private RectTransform rect;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rect = GetComponent<RectTransform>();
    }
    // Start is called before the first frame update
    public void Setup (Sprite sprite)
    {
        spriteSwitcher.SetImage(sprite);
    }
}
