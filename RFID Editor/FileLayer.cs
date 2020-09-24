using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSFileLayer
{
    class FileLayer
    {
        /// <summary>
        /// 文件的读取操作
        /// </summary>
        /// <param name="szPath"></param>
        /// <returns></returns>
        public static byte[] Read(string szPath)
        {
            FileInfo fi = new FileInfo(szPath);
            if (fi.Length != 4 * 1024)
            {
                return null;
            }

            FileStream fs = new FileStream(szPath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] btBuf = br.ReadBytes((int)fi.Length);

            br.Close();
            fs.Close();

            return btBuf;
        }
        /// <summary>
        /// 修正1KB文件到4K
        /// </summary>
        /// <param name="szPath"></param>
        /// <returns></returns>
        public static byte[] ReadWhileFixDump(string szPath)
        {
            FileInfo fi = new FileInfo(szPath);

            if (!(fi.Length == 4 * 1024 || fi.Length == 1024))
            {
                return null;
            }

            FileStream fs = new FileStream(szPath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            List<byte> blBuf = new List<byte>();
            blBuf.AddRange(br.ReadBytes((int)fi.Length));

            if (fi.Length == 1024)
            {
                byte[] btTmp = new byte[3072];
                blBuf.AddRange(btTmp);
            }

            br.Close();
            fs.Close(); 

            return blBuf.ToArray();
        }
        /// <summary>
        /// dump文件的写入控制
        /// </summary>
        /// <param name="szPath"></param>
        /// <param name="btData"></param>
        public static void Write(string szPath, byte[] btData)
        {
            FileStream fs = new FileStream(szPath, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(btData);
            bw.Close();
            fs.Close();
        }
        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <param name="szPath"></param>
        /// <returns></returns>
        public static bool Exists(string szPath)
        {
            return File.Exists(szPath);
        }
        public static void Delete(string szPath) 
        {
            File.Delete(szPath);
        }
        public static void Copy(string srcFile, string destFile)
        {
            File.Copy(srcFile, destFile);
        }
        
    }
}
