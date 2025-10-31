using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    private Rigidbody2D rigid;
    private SpriteRenderer sprite;
    private Animator anim;
    private InputController inputContoller;
    private GroundCheck groundCheck;

    [SerializeField]
    private GameObject groundSensor;

    [SerializeField]
    private float moveSpeed = 5.0f;

    /*[SerializeField]
    private float speed = 5.0f;*/

    [SerializeField]
    private float jumppower = 3.0f;

    [SerializeField]
    private Vector2 movementDirection = Vector2.zero;

    [SerializeField]
    private AudioClip[] playerSfxClip;

    [SerializeField]
    Sprite[] playerSprites;
    void Awake()
    {
        inputContoller = GetComponent<InputController>();
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        groundCheck = groundSensor.GetComponent<GroundCheck>();
    }

    private void Start()
    {
        // OnMoveEvent에 Move를 호출하라고 등록함
        inputContoller.OnMoveEvent += Move;
        inputContoller.OnJumpEvent += Jump;
        ChangePlayerSprite();
    }
    private void Update()
    {
        #region 레거시 인풋
        /*if (Input.GetButtonDown("Jump")&& !anim.GetBool("jump"))
        {
            rigid.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
            anim.SetBool("jump", true);
        }
        
           

        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
        if (Input.GetButtonDown("Horizontal"))
            sprite.flipX = Input.GetAxisRaw("Horizontal") == -1;

        if (Mathf.Abs( rigid.velocity.x) < 0.3)
            anim.SetBool("walk", false);
        else
            anim.SetBool("walk", true);*/
        #endregion

        #region 인풋 시스템


        #endregion
    }

    void FixedUpdate()
    {
        #region 레거시 인풋
        /*float h = Input.GetAxisRaw("Horizontal");

        
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        
        if (rigid.velocity.x > maxspeed)
            rigid.velocity = new Vector2(maxspeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxspeed*(-1))
            rigid.velocity = new Vector2(maxspeed*(-1), rigid.velocity.y);

        if (rigid.velocity.y < 0) {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.9f)
                    anim.SetBool("jump", false);
            }
        }*/

        #endregion
        #region 인풋 시스템
        ApplyMoveMent(movementDirection);

        if (groundCheck.is_Ground && Mathf.Abs(rigid.velocity.y) < 0.01f)
        {
            anim.SetBool("jump", false);
        }
        #endregion

    }
    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void ApplyMoveMent(Vector2 direction)
    {
        if(direction != Vector2.zero)
        {
            if(direction.x < 0)
            {
                sprite.flipX = true;
            }
            else if(direction.x > 0)
            {
                sprite.flipX = false;
            }
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }

        direction = direction * moveSpeed;
        rigid.velocity = new Vector2(direction.x,rigid.velocity.y);
    }

    private void Jump()
    {
        if (groundCheck.is_Ground == true)
        {
            rigid.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
            anim.SetBool("jump", true);
            SoundManager.Instance.PlaySfx(playerSfxClip[0]);
        }
    }

    private void ChangePlayerSprite()
    {
        int playersprite = GameManager.Instance.PlayerSprite;
        sprite.sprite = playerSprites[playersprite];
        switch (playersprite)
        {
            case 1:
                anim.SetBool("IsGreen", true);
                break;
            case 2:
                anim.SetBool("IsRed", true);
                break;
            case 3:
                anim.SetBool("IsYellow", true);
                break;
        }
    }
}
