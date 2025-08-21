using UnityEngine;
using System.Collections;

public class UIFader : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void FadeIn(float duration)
    {
        gameObject.SetActive(true);
        StartCoroutine(FadeRoutine(0f, 1f, duration));
    }

    public void FadeOut(float duration)
    {
        StartCoroutine(FadeRoutine(1f, 0f, duration));
    }

    private IEnumerator FadeRoutine(float start, float end, float duration)
    {
        float elapsed = 0f;
        canvasGroup.alpha = start;

        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime; // unscaled to ensure it works during pause
            canvasGroup.alpha = Mathf.Lerp(start, end, elapsed / duration);
            yield return null;
        }

        canvasGroup.alpha = end;

        if (end == 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
