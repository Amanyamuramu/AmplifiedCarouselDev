using UnityEngine;

public class PingPongMover : MonoBehaviour
{
    // U•
    [SerializeField] private float _amplitude =0.4f;

    // üŠú
    [SerializeField] private float _period = 3.5f;

    // ˆÊ‘Š
    [SerializeField, Range(0, 1)] private float _phase = 0.75f;

    // “®‚©‚·²
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


    // ‰Šú‰»
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

            // üŠú‚ÆˆÊ‘Š‚ğl—¶‚µ‚½Œ»İŠÔŒvZ
            var t = 4 * _amplitude * (countup / _period + _phase + 0.25f);

            // ‰•œ‚µ‚½’l‚ğŒvZ
            var value = Mathf.PingPong(t, 2 * _amplitude) - _amplitude;

            // •ÏˆÊŒvZ
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

            // ˆÊ’u‚ğ”½‰f
            _transform.localPosition = _initPosition + changePos;
        }
    }

    void StopUpdown()
    {
        countup = 0f;
        updown = false;
    }
}