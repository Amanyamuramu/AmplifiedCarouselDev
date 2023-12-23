using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    // �A�C�e���̃v���n�u
    [SerializeField] GameObject item;

    // �A�C�e������鐔 
    [SerializeField] int itemCount = 100;

    public float height = 0.0f;
    public float density = 1f;

    // �A�C�e���̃C���X�^���X
    List<GameObject> items = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ���N���b�N  
        if (Input.GetMouseButtonDown(0))
        {
            // �A�C�e����S�폜
            foreach (var i in items)
            {
                Destroy(i);
            }
            items.Clear();

            // �{�b�N�X�T�C�Y�̔���
            Vector3 halfExtents = new Vector3(density, density, density);

            // �A�C�e�������
            for (int i = 0; i < itemCount; i++)
            {
                // 10�񎎂�
                for (int n = 0; n < 100; n++)
                {
                    // �����_���̈ʒu
                    float x = Random.Range(-5.0f, 5.0f);
                    float z = Random.Range(-5.0f, 5.0f);
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
    }
}