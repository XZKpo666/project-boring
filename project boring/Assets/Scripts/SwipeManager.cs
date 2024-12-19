using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeManager : MonoBehaviour
{
    public RectTransform button1;
    public RectTransform button2;
    public RectTransform button3;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private bool isSwiping = false;

    // 定義佈局
    private enum LayoutState { Initial, Swiped }
    private LayoutState currentState = LayoutState.Initial;

    void Update()
    {
        HandleTouchInput();
    }

    void HandleTouchInput()
    {
        // 開始觸摸
        if (Input.GetMouseButtonDown(0))
        {
            startTouchPosition = Input.mousePosition;
            isSwiping = true;
        }

        // 結束觸摸
        if (Input.GetMouseButtonUp(0) && isSwiping)
        {
            endTouchPosition = Input.mousePosition;
            isSwiping = false;
            DetectSwipe();
        }
    }

    void DetectSwipe()
    {
        float deltaX = endTouchPosition.x - startTouchPosition.x;
        float deltaY = endTouchPosition.y - startTouchPosition.y;

        // 設置閾值以避免誤判
        float swipeThreshold = 50f;

        if (Mathf.Abs(deltaX) > swipeThreshold || Mathf.Abs(deltaY) > swipeThreshold)
        {
            if (deltaX > 0 && deltaY > 0)
            {
                // 右下滑
                OnSwipeRightDown();
            }
            else if (deltaX < 0 && deltaY > 0)
            {
                // 左下滑
                OnSwipeLeftDown();
            }
            else if (deltaX > 0 && deltaY < 0)
            {
                // 右上滑
                OnSwipeRightUp();
            }
            else if (deltaX < 0 && deltaY < 0)
            {
                // 左上滑
                OnSwipeLeftUp();
            }
        }
    }

    void OnSwipeRightDown()
    {
        if (currentState == LayoutState.Initial)
        {
            SwitchToSwipedLayout();
        }
    }

    void OnSwipeLeftUp()
    {
        if (currentState == LayoutState.Swiped)
        {
            SwitchToInitialLayout();
        }
    }

    // 你可以根據需求實現其他滑動方向的處理
    void OnSwipeLeftDown() { /* ... */ }
    void OnSwipeRightUp() { /* ... */ }

    void SwitchToSwipedLayout()
    {
        currentState = LayoutState.Swiped;

        StartCoroutine(AnimateButton(button1, new Vector2(-160, 300), new Vector2(150, 150)));
        StartCoroutine(AnimateButton(button2, Vector2.zero, new Vector2(450, 450)));
        StartCoroutine(AnimateButton(button3, new Vector2(160, -300), new Vector2(150, 150)));
    }

    void SwitchToInitialLayout()
    {
        currentState = LayoutState.Initial;

        StartCoroutine(AnimateButton(button1, Vector2.zero, new Vector2(450, 450)));
        StartCoroutine(AnimateButton(button2, new Vector2(160, -300), new Vector2(150, 150)));
        StartCoroutine(AnimateButton(button3, new Vector2(0, 0), new Vector2(0, 0))); // 或其他適當的尺寸
    }

    IEnumerator AnimateButton(RectTransform button, Vector2 targetPosition, Vector2 targetSize)
    {
        float duration = 0.5f;
        float elapsed = 0f;

        Vector2 initialPosition = button.anchoredPosition;
        Vector2 initialSize = button.sizeDelta;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);

            button.anchoredPosition = Vector2.Lerp(initialPosition, targetPosition, t);
            button.sizeDelta = Vector2.Lerp(initialSize, targetSize, t);

            yield return null;
        }

        button.anchoredPosition = targetPosition;
        button.sizeDelta = targetSize;
    }
}

