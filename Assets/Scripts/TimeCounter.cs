using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //�J�E���g�A�b�v
    private float countup = 0.0f;

    //�^�C�����~�b�g
    public float timeLimit = 5.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;

    //Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g����
        countup += Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countup.ToString("f1") + "�b";

        if(countup >= timeLimit)
        {
            timeText.text = "GAME OVER";
        }
    }
}
