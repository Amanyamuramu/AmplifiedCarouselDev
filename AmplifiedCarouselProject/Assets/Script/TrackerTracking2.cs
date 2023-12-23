using System;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;


public class TrackerTracking2 : MonoBehaviour
{
    //�g���b�J�[�̈ʒu���W�i�[�p
    private Vector3 Tracker1Posision;
    private Vector3 Tracker2Posision;

    //�g���b�J�[�̉�]���W�i�[�p�i�N�H�[�^�j�I���j
    private Quaternion Tracker1RotationQ;
    private Quaternion Tracker2RotationQ;

    //�g���b�J�[�̉�]���W�i�[�p�i�I�C���[�p�j
    private Vector3 Tracker1Rotation;
    private Vector3 Tracker2Rotation;

    //�g���b�J�[��pose�����擾���邽�߂�tracker1�Ƃ����֐���SteamVR_Actions.default_Pose���Œ�
    private SteamVR_Action_Pose tracker1 = SteamVR_Actions.default_Pose;
    private SteamVR_Action_Pose tracker2 = SteamVR_Actions.default_Pose;

    //1�t���[�����ɌĂяo�����Update���]�b�g
    void Update()
    {
        //�ʒu���W���擾
        Tracker1Posision = tracker1.GetLocalPosition(SteamVR_Input_Sources.Waist);
        Tracker2Posision = tracker2.GetLocalPosition(SteamVR_Input_Sources.Chest);
        //��]���W���N�H�[�^�j�I���Œl���󂯎��
        Tracker1RotationQ = tracker1.GetLocalRotation(SteamVR_Input_Sources.Waist);
        Tracker2RotationQ = tracker1.GetLocalRotation(SteamVR_Input_Sources.Chest);
        //�擾�����l���N�H�[�^�j�I�� �� �I�C���[�p�ɕϊ�
        Tracker1Rotation = Tracker1RotationQ.eulerAngles;
        Tracker2Rotation = Tracker2RotationQ.eulerAngles;
        //�擾�����f�[�^��\���iT1D�FTracker1�ʒu�CT1R�FTracker1��]�j
        //Debug.Log("T1D:" + Tracker1Posision.x + ", " + Tracker1Posision.y + ", " + Tracker1Posision.z + "\n" +
          //          "T1R:" + Tracker1Rotation.x + ", " + Tracker1Rotation.y + ", " + Tracker1Rotation.z);
    }
}