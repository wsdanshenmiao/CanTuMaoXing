using UnityEngine;

public class FindAnimator : MonoBehaviour
{
    void Start()
    {
        // 使用GetComponentInChildren查找子对象上的Animator组件
        Animator playerAnimator = GetComponentInChildren<Animator>();

        if (playerAnimator != null)
        {
            // 如果找到了Animator组件，可以在这里进行操作
            Debug.Log("找到了子对象上的Animator组件");
            // 例如，播放一个动画
            playerAnimator.Play("PlayerRun");
        }
        else
        {
            // 如果没有找到Animator组件，输出提示信息
            Debug.Log("没有找到子对象上的Animator组件");
        }
    }
}