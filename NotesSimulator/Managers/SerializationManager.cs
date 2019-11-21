using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers
{
    internal static class SerializationManager
    {
        internal static void Serialize<TObject>(TObject obj, string filePath)
        {
            try
            {
                var file = new FileInfo(filePath);
                if (file.CreateFolderAndCheckFileExistance())
                {
                    file.Delete();
                }
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, obj);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to serialize data to file {filePath}"+ex.Message, ex);
            }
        }

        internal static void DeleteSerialization(string filePath)
        {
            try
            {
                var file = new FileInfo(filePath);
                if (file.CreateFolderAndCheckFileExistance())
                {
                    file.Delete();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception($"Failed to Deserialize Data From File {filePath}", ex);

            }
        }

        internal static TObject Deserialize<TObject>(string filePath) where TObject : class
        {
            try
            {
                if (!FileFolderHelper.CreateFolderAndCheckFileExistance(filePath))
                    throw new FileNotFoundException("File doesn't exist.");                                                                                                                    
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    return (TObject)formatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw new FileNotFoundException($"Failed to Deserialize Data From File {filePath}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception($"Failed to Deserialize Data From File {filePath}", ex);
               
            }
        }
    }
}
