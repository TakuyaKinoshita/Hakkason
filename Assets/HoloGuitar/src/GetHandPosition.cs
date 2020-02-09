using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHandPosition : MonoBehaviour , IMixedRealityHandJointHandler {
    //public Vector3 GetPosition() {
    //    eventData.InputData.TryGetValue(TrackedHandJoint.IndexTip, out MixedRealityPose pose
    //}

    public void OnHandJointsUpdated(InputEventData<IDictionary<TrackedHandJoint, MixedRealityPose>> eventData)
    {
        throw new System.NotImplementedException();
    }
    void IMixedRealityHandJointHandler.OnHandJointsUpdated(InputEventData<IDictionary<TrackedHandJoint, MixedRealityPose>> eventData)
    {
        Debug.Log((eventData.InputData.TryGetValue(TrackedHandJoint.IndexTip, out MixedRealityPose pose)));
        //if (eventData.Handedness == myHandedness)
        //{
        //    if (eventData.InputData.TryGetValue(TrackedHandJoint.IndexTip, out MixedRealityPose pose))
        //    {
        //        Debug>Logger()
        //    }
        //}
    }
}
