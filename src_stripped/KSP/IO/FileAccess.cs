﻿// Decompiled with JetBrains decompiler
// Type: KSP.IO.FileAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.InteropServices;

namespace KSP.IO
{
  [Flags]
  [ComVisible(true)]
  [Serializable]
  public enum FileAccess
  {
    Read = 1,
    Write = 2,
    ReadWrite = Write | Read, // 0x00000003
  }
}
