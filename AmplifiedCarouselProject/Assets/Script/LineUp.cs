using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineUp : MonoBehaviour
{
    //����
    public float high;
    //�I�u�W�F�N�g�Ԃ̕�
    public float width = 0.26f;
    //�ォ�猩�ďc�AZ���̃I�u�W�F�N�g�̗�
    public int vertical = 57;
    //�ォ�猩�ĉ��AX���̃I�u�W�F�N�g�̗�
    public int horizontal = 57;

    //Prefab�����闓�����
    public GameObject cube;

    //�ʒu������ϐ�
    Vector3 pos;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //���̃X�N���v�g����ꂽ�I�u�W�F�N�g�̈ʒu
            pos = transform.position;

            //Z����vertical�̐��������ׂ�
            for (int vi = 0; vi < vertical; vi++)
            {
                //X����horizontal�̐��������ׂ�
                for (int hi = 0; hi < horizontal; hi++)
                {
                    //Prefab��Cube�𐶐�����
                    GameObject copy = Instantiate(cube,
                        //�����������̂�z�u����ʒu
                        new Vector3(
                            //X��
                            pos.x + horizontal * width / 2 - hi * width - width / 2,
                            //Y��
                            high,
                            //Z��
                            pos.z + vertical * width / 2 - vi * width - width / 2
                        //Quaternion.identity�͖���]���w�肷��
                        ), Quaternion.Euler(90f, 0f, 0f));
                }
            }
        }
    }
}