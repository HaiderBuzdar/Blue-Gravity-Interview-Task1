using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public Animator _PlayerAnimator;

    public string Walk, Attack;

    public Rigidbody2D _PlayerRB;

    public float MoveSpeed = 2f;

    Vector2 Movement = new Vector2();

    public bool CanControl;

    private void Awake()
    {
        Instance = this;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void Update()
    {
        GetInputs();
    }

    void GetInputs()
    {
        if (CanControl)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            float c = Mathf.Abs(x + y);
            _PlayerAnimator.SetFloat(Walk, c);
            Movement = new Vector2(x, y);

            if (Mathf.Abs(x) > 0)
            {
                CheckRotation();

            }
        }
        
    }
    void CheckRotation()
    {
        bool opposit = Movement.x < 0;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, opposit ? 180 : 0, 0));
    }
    void MovePlayer()
    {
        if (CanControl)
            _PlayerRB.velocity = Movement * MoveSpeed;
    }

    public void PlayerAttack()
    {
        _PlayerAnimator.Play("PlayerAttack");

    }

    public void PlayGame()
    {
        CanControl = true;
    }

    public void ShopEnter()
    {
        CanControl = false;
    }
}
