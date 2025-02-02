﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Platforms.IPlatformAccessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
  public interface IPlatformAccessor
  {
    CoreModules FilterSupportedCoreModules(CoreModules module);

    string GetEnvironmentVariable(string envvarname);

    bool IsRunningOnAOT();

    string GetPlatformName();

    void DefaultPrint(string content);

    string DefaultInput(string prompt);

    Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

    Stream IO_GetStandardStream(StandardFileType type);

    string IO_OS_GetTempFilename();

    void OS_ExitFast(int exitCode);

    bool OS_FileExists(string file);

    void OS_FileDelete(string file);

    void OS_FileMove(string src, string dst);

    int OS_Execute(string cmdline);
  }
}
