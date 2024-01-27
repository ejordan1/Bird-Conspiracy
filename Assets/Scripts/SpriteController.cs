using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{

    private SpriteSwitcher spriteSwitcher;
    private Animator animator;
    private RectTransform rect;

    void Awake()
    {
        spriteSwitcher = GetComponent<SpriteSwitcher>();
        animator = GetComponent<Animator>();
        rect = GetComponent<RectTransform>();
    }
    // Start is called before the first frame update
    public void Setup (Sprite sprite)
    {
        spriteSwitcher.SetImage(sprite);
    }

    public void Show(Vector2 coords)
    {
        animator.SetTrigger("Show");
        rect.localPosition = coords;
    }

    public void Hide()
    {
        animator.SetTrigger("Hide");
    }

    public void Move(Vector2 coords, float speed)
    {
        StartCoroutine(MoveCoroutine(coords, speed));
    }

    private IEnumerator MoveCoroutine(Vector2 coords, float speed)
    {
        while (rect.localPosition.x != coords.x || rect.localPosition.y != coords.y)
        {
            rect.localPosition = Vector2.MoveTowards(rect.localPosition, coords, Time.deltaTime * 1000f * speed);
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void SwitchSprite(Sprite sprite)
    {
        if(spriteSwitcher.GetImage() != sprite)
        {
            spriteSwitcher.SwitchImage(sprite);
        }
    }
}
