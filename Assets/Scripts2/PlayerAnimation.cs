using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    int horizontal, vertical;

    private void Awake()
    {
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void UpdateAnimatorValues(float horizontalMovement, float verticalMovement)
    {
        // danp time = blend time,
        if (PlayerManager.Instance.isSprinting) {verticalMovement = 2;}
        PlayerManager.Instance.playerAnim.SetFloat(horizontal, horizontalMovement, 0.1f, Time.deltaTime);
        PlayerManager.Instance.playerAnim.SetFloat(vertical, verticalMovement, 0.1f, Time.deltaTime);
    }
}
