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

    public Transform _Player;

    Vector2 Movement = new Vector2();

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
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float c = Mathf.Abs(x + y);
        _PlayerAnimator.SetFloat(Walk, c);
        Movement = new Vector2(x, y);

        if (c>0)
        {
            CheckRotation();

        }
    }
    void CheckRotation()
    {
        bool opposit = Movement.x < 0;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, opposit ? 180 : 0, 0));
    }
    void MovePlayer()
    {
        _PlayerRB.velocity = Movement * MoveSpeed;
    }


    public void PlayerAttack()
    {
        _PlayerAnimator.Play("PlayerAttack");

    }
}
