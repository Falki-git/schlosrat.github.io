﻿// Decompiled with JetBrains decompiler
// Type: KSP.IFlightControllableInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Controllability;

namespace KSP
{
  public interface IFlightControllableInput : 
    IFlightControlInput,
    IControlInput,
    IVehicleControlsReader,
    IFlightControlReader
  {
    void AtomicSet(
      float? mainThrottle,
      float? roll,
      float? yaw,
      float? pitch,
      float? rollTrim,
      float? yawTrim,
      float? pitchTrim,
      float? wheelSteer,
      float? wheelSteerTrim,
      float? wheelThrottle,
      float? wheelThrottleTrim,
      bool? killRot,
      bool? gearUp,
      bool? gearDown,
      bool? headlight);
  }
}
