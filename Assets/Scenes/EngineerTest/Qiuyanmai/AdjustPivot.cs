using UnityEngine;

public class AdjustAnchorPoint : MonoBehaviour
{
    public Vector2 newAnchorCenter; // 新的锚点中心位置

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            // 保存原始锚点中心和位置
            Vector2 oldAnchorCenter = (rectTransform.anchorMin + rectTransform.anchorMax) / 2;
            Vector2 oldAnchoredPos = rectTransform.anchoredPosition;

            // 设置新的锚点
            rectTransform.anchorMin = newAnchorCenter;
            rectTransform.anchorMax = newAnchorCenter;

            // 计算位置偏移量
            RectTransform parentRectTransform = rectTransform.parent as RectTransform;
            Vector2 deltaAnchor = newAnchorCenter - oldAnchorCenter;
            Vector2 deltaMove = new Vector2(deltaAnchor.x * parentRectTransform.rect.width, deltaAnchor.y * parentRectTransform.rect.height);

            // 调整位置
            rectTransform.anchoredPosition = oldAnchoredPos - deltaMove;
        } else {
            Debug.Log("no RectTransform found");
        }
    }
}