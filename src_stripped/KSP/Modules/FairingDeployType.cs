﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.FairingDeployType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Modules
{
  public enum FairingDeployType : byte
  {
    [Description("PartModules/Fairings/DeployTypes/None")] None,
    [Description("PartModules/Fairings/DeployTypes/Shroud")] Shroud,
    [Description("PartModules/Fairings/DeployTypes/Clamshellx2")] Clamshellx2,
    [Description("PartModules/Fairings/DeployTypes/Clamshellx3")] Clamshellx3,
    [Description("PartModules/Fairings/DeployTypes/Clamshellx4")] Clamshellx4,
  }
}
