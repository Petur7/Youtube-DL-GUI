using IWshRuntimeLibrary;
using System.IO;
using System;

namespace Shortcut
{
    class Shortcut
    {
        public static void createShortcut(string sourceLocation, string shortcutLocation)
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.TargetPath = sourceLocation;

            string[] workingDirList = sourceLocation.Split('\\');
            Array.Resize(ref workingDirList, workingDirList.Length - 1);
            string workingDir = Path.Combine(workingDirList);
            shortcut.WorkingDirectory = workingDir.Insert(2, "\\");

            shortcut.Save();
        }
    }
}