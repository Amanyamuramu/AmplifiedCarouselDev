using System;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;


public class TrackerTracking : MonoBehaviour
{
    //�g���b�J�[�̈ʒu���W�i�[�p
    private Vector3 Tracker1Posision;

    //�g���b�J�[�̉�]���W�i�[�p�i�N�H�[�^�j�I���j
    private Quaternion Tracker1RotationQ;
    //�g���b�J�[�̉�]���W�i�[�p�i�I�C���[�p�j
    private Vector3 Tracker1Rotation;

    //�g���b�J�[��pose�����擾���邽�߂�tracker1�Ƃ����֐���SteamVR_Actions.default_Pose���Œ�
    private SteamVR_Action_Pose tracker1 = SteamVR_Actions.default_Pose;

    //1�t���[�����ɌĂяo�����Update���]�b�g
    void Update()
    {
        //�ʒu���W���擾
        Tracker1Posision = tracker1.GetLocalPosition(SteamVR_Input_Sources.Waist);
        //��]���W���N�H�[�^�j�I���Œl���󂯎��
        Tracker1RotationQ = tracker1.GetLocalRotation(SteamVR_Input_Sources.Waist);
        //�擾�����l���N�H�[�^�j�I�� �� �I�C���[�p�ɕϊ�
        Tracker1Rotation = Tracker1RotationQ.eulerAngles;

        //�擾�����f�[�^��\���iT1D�FTracker1�ʒu�CT1R�FTracker1��]�j
        // Debug.Log("T1D:" + Tracker1Posision.x + ", " + Tracker1Posision.y + ", " + Tracker1Posision.z + "\n" +
        //             "T1R:" + Tracker1Rotation.x + ", " + Tracker1Rotation.y + ", " + Tracker1Rotation.z);
    }
}