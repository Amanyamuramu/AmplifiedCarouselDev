using System.Collections.Generic;
using UnityEngine;

public class LineUpRandom  : MonoBehaviour
{
    // �A�C�e���̃v���n�u
    [SerializeField] GameObject item;

    // �A�C�e������鐔 
    [SerializeField] int itemCount = 57*57;
    public float density = 0.1f;

    // �A�C�e���̃C���X�^���X
    List<GameObject> items = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            // �{�b�N�X�T�C�Y�̔���
            Vector3 halfExtents = new Vector3(density, density, density);

            // �A�C�e�������
            for (int i = 0; i < itemCount; i++)
            {
                // 10�񎎂�
                for (int n = 0; n < 57*57; n++)
                {
                    // �����_���̈ʒu
                    float x = Random.Range(-7.5f, 7.5f);
                    float z = Random.Range(-7.5f, 7.5f);
                    Vector3 pos = new Vector3(x, 0f, z);
                    //pos.z = pos.y;
                    //pos.y = height;

                    // �{�b�N�X�ƃA�C�e�����d�Ȃ�Ȃ��Ƃ�
                    if (!Physics.CheckBox(pos, halfExtents, Quaternion.identity))
                    {
                        // �A�C�e�����C���X�^���X��
                        items.Add(Instantiate(item, pos, Quaternion.Euler(90f, 0f, 0f)));
                        break;
                    }
                }
            }
        }

        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    // �A�C�e����S�폜
        //    foreach (var i in items)
        //    {
        //        Destroy(i);
        //    }
        //    items.Clear();
        //}
    }
}