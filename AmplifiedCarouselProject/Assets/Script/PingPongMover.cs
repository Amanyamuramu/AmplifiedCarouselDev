using UnityEngine;

public class PingPongMover : MonoBehaviour
{
    // �U��
    [SerializeField] private float _amplitude =0.4f;

    // ����
    [SerializeField] private float _period = 3.5f;

    // �ʑ�
    [SerializeField, Range(0, 1)] private float _phase = 0.75f;

    // ��������
    private enum Axis
    {
        Z,
        Y,
        X
    }

    [SerializeField] private Axis _axis;

    private Transform _transform;
    private Vector3 _initPosition;
    private bool updown = false;
    //private float countdown = 17.5f;
    private float countup = 0.0f;


    // ������
    private void Awake()
    {
        _transform = transform;
        _initPosition = _transform.localPosition;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            updown = true;
            Invoke("StopUpdown", 17.5f);
        }

        if (updown == true)
        {
            countup += Time.deltaTime;

            // �����ƈʑ����l���������ݎ��Ԍv�Z
            var t = 4 * _amplitude * (countup / _period + _phase + 0.25f);

            // ���������l���v�Z
            var value = Mathf.PingPong(t, 2 * _amplitude) - _amplitude;

            // �ψʌv�Z
            var changePos = Vector3.zero;

            switch (_axis)
            {
                case Axis.X:
                    changePos.x = value;
                    break;
                case Axis.Y:
                    changePos.y = value;
                    break;
                case Axis.Z:
                    changePos.z = value;
                    break;
            }

            // �ʒu�𔽉f
            _transform.localPosition = _initPosition + changePos;
        }
    }

    void StopUpdown()
    {
        countup = 0f;
        updown = false;
    }
}