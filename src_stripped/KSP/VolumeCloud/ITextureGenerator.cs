﻿// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.ITextureGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.VolumeCloud
{
  public interface ITextureGenerator
  {
    Color Sample(Vector3 pos);
  }
}
