using System;
using System.IO;


namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools
{
    internal static class FileFolderHelper
    {
        private static readonly string AppDataPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        internal static readonly string AppFolderPath =
            Path.Combine(AppDataPath, "CSharpKMANotes");

        internal static readonly string StorageFilePath = 
            Path.Combine(AppFolderPath, "loguser.cskma");

        internal static bool CreateFolderAndCheckFileExistance(string filePath)
        {
            var file = new FileInfo(filePath);
            return file.CreateFolderAndCheckFileExistance();
        }

        internal static bool CreateFolderAndCheckFileExistance(this FileInfo file)
        {
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            return file.Exists;
        }
    }
}