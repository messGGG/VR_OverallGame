using UnityEngine;
using VRTK;

public class SlingshotJumpController : MonoBehaviour
{
    private VRTK_SlingshotJump slingshotJump;

    private void Awake()
    {
        slingshotJump = GetComponent<VRTK_SlingshotJump>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
        }
    }
}