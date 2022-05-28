using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        score = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        // �J�[�\���L�[�̓��͂��擾
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // �J�[�\���L�[�̓��͂ɍ��킹�Ĉړ�������ݒ�
        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Ridigbody �ɗ͂�^���ċʂ𓮂���
        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        // �Ԃ������I�u�W�F�N�g�����W�A�C�e���������ꍇ
        if (other.gameObject.CompareTag("PickUp"))
        {
            // ���̎��W�A�C�e�����\���ɂ��܂�
            other.gameObject.SetActive(false);

            score = score + 1;

            SetCountText ();
        }
    }

    void SetCountText()
    {
        scoreText.text = "Count: " + score.ToString();

        if (score >= 5)
        {
            winText.text = "You Win";
        }
    }
}

