﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.TypeValidationFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter
{
  [Flags]
  public enum TypeValidationFlags
  {
    None = 0,
    AllowNil = 1,
    AutoConvert = 2,
    Default = AutoConvert, // 0x00000002
  }
}
