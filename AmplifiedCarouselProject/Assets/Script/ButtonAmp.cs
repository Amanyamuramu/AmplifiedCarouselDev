using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI���g�����ߒǉ�

public class ButtonAmp : MonoBehaviour
{
    [SerializeField] private Text suuji_text;//Text�^�̕ϐ�suuji_text��錾
    public int suuji;

    void Start()
    {
    }

    //�{�^��������������s����֐��@���s���邽�߂ɂ̓{�^���֊֐��o�^���K�v
    //int�^�̈���number��錾
    public void Push_Button(int number)
    {
        suuji_text.text = "" + number;//suuji_text�Ɉ����̐��l����
        suuji = number;
    }
}