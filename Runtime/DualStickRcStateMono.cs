using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualStickRcStateMono :  A_DualStickRcStateMono
{
    public DualStickRcState m_dualStickRcState;
    public override void SetJoystickLeftHorizontal(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1, 1);
        m_dualStickRcState.m_joystickLeftHorizontalValue = percent11;
    }
    public override void SetJoystickLeftVertical(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1, 1);
        m_dualStickRcState.m_joystickLeftVerticalValue = percent11;
    }
    public override void SetJoystickRightHorizontal(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1, 1);
        m_dualStickRcState.m_joystickRightHorizontalValue = percent11;
    }
    public override void SetJoystickRightVertical(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1, 1);
        m_dualStickRcState.m_joystickRightVerticalValue = percent11;
    }



    public override void SetKillSwitchAsActive(bool killSwitch)
    {
        m_dualStickRcState.m_killSwitchValue = killSwitch;
    }

    public override void GetJoystickLeftHorizontal(out float percent11)
    {
        percent11 = m_dualStickRcState.m_joystickLeftHorizontalValue;

    }

    public override void GetJoystickLeftVertical(out float percent11)
    {
        percent11 = m_dualStickRcState.m_joystickLeftVerticalValue;
    }

    public override void GetJoystickRightHorizontal(out float percent11)
    {
        percent11 = m_dualStickRcState.m_joystickRightHorizontalValue;
    }

    public override void GetJoystickRightVertical(out float percent11)
    {
        percent11 = m_dualStickRcState.m_joystickRightVerticalValue;
    }

    public override void IsKillSwitchActive(out bool killSwitch)
    {
        killSwitch = m_dualStickRcState.m_killSwitchValue;
    }

    public override bool IsKillSwitchActive()
    {
        return m_dualStickRcState.m_killSwitchValue;
    }
}

[System.Serializable]
public struct DualStickRcState
{
    [Range(-1, 1)]
    public float m_joystickLeftHorizontalValue;
    [Range(-1, 1)]
    public float m_joystickLeftVerticalValue;
    [Range(-1, 1)]
    public float m_joystickRightHorizontalValue;
    [Range(-1, 1)]
    public float m_joystickRightVerticalValue;

    public bool m_killSwitchValue;
}


public interface I_DualStickRcStateSet
{
    void SetJoystickLeftHorizontal(float percent11);
    void SetJoystickLeftVertical(float percent11);
    void SetJoystickRightHorizontal(float percent11);
    void SetJoystickRightVertical(float percent11);
    void SetKillSwitchAsActive(bool killSwitch);
}

public interface I_DualStickRcStateGet
{
    void GetJoystickLeftHorizontal(out float percent11);
    void GetJoystickLeftVertical(out float percent11);
    void GetJoystickRightHorizontal(out float percent11);
    void GetJoystickRightVertical(out float percent11);
    void IsKillSwitchActive(out bool killSwitch);
    bool IsKillSwitchActive();

}

public interface I_DualStickRcStateSetGet : I_DualStickRcStateSet, I_DualStickRcStateGet
{
}

public abstract class A_DualStickRcStateMono : MonoBehaviour,  I_DualStickRcStateSetGet
{
    public abstract void SetJoystickLeftHorizontal(float percent11);
    public abstract void SetJoystickLeftVertical(float percent11);
    public abstract void SetJoystickRightHorizontal(float percent11);
    public abstract void SetJoystickRightVertical(float percent11);
    public abstract void SetKillSwitchAsActive(bool killSwitch);
    public abstract void GetJoystickLeftHorizontal(out float percent11);
    public abstract void GetJoystickLeftVertical(out float percent11);
    public abstract void GetJoystickRightHorizontal(out float percent11);
    public abstract void GetJoystickRightVertical(out float percent11);
    public abstract void IsKillSwitchActive(out bool killSwitch);
    public abstract bool IsKillSwitchActive();
}
