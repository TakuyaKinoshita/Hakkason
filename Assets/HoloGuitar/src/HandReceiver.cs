using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;

public class HandReceiver : MonoBehaviour {
    public TrackedHandJoint handjoint;
    public float WaitSecondCorutine = 0.1f;
    public bool GetTransForm(out Vector3 _fingerposition)
    {
        IMixedRealityController c = GetController(Handedness.Left);
            var jointedHand = c as IMixedRealityHand;
            MixedRealityPose MiddleDistalParm;
            if (jointedHand.TryGetJoint(handjoint, out MiddleDistalParm))
            {
                _fingerposition = MiddleDistalParm.Position;
                return true;
            }
        _fingerposition = new Vector3(0, 0, 0);
        return false;
    }
    private static IMixedRealityController GetController(Handedness handedness)
    {
        foreach (IMixedRealityController c in CoreServices.InputSystem.DetectedControllers)
        {
            if (c.ControllerHandedness.IsMatch(handedness))
            {
                return c;
            }
        }

        return null;
    }
    //public void StartGetHandPositon()
    //{
    //    StartCoroutine( GetHandPosition() );
    //}
    //public void EndGetHandPosition()
    //{
    //    StopCoroutine( GetHandPosition() );
    //}
    //public IEnumerator GetHandPosition()
    //{
    //    while(true)
    //    {
    //        GetTransForm();
    //        yield return new WaitForSeconds(WaitSecondCorutine);
    //    }
    //}
}
