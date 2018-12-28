using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DAL
{
    public class ImageManage
    {
        public static bool CheckImageSize(string fileName,out int imgSize)
        {
            imgSize=0;
            int imageCapacity = 2000;
            //���ͼƬ��С�Ƿ����Ҫ��
            FileInfo f = new FileInfo(fileName);
            if (f.Length > imageCapacity * 1024)
            {
                //BigMessageBox.Show("��Ƭ�ļ���С���ɳ���" + imageCapacity.ToString() + "K!", "ͼƬ̫��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                imgSize = imageCapacity;
                return false;
            }
            return true;
        }

        public static Image GetImageFromServer(string fileName)
        {
            Image img = null;
            string filePath = Application.StartupPath + "\\ImageEmp\\" + fileName;
            try
            {
                FileStream fs = File.OpenRead(filePath);
                img = Image.FromStream(fs);
                fs.Close();
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message);
            }
            return img;
        }

        public static Image GetImageFromLocal(string fileName)
        {
            Image img = null;
            try
            {
                FileStream fs = File.OpenRead(fileName);
                img = Image.FromStream(fs);
                fs.Close();
            }
            catch (IOException ie)
            {
                LogManager.WriteTextLog("Framework", "ImageManage", "GetImageFromLocal", ie.Message);
            }
            return img;
        }

        //��ͼƬ���ڷ�������
        public static void CopyImageFileToServer(string originalFile, string newFile)
        {
            if (originalFile.Equals(""))
            {
                return;
            }
            else
            {
                string filePath = Application.StartupPath + "\\ImageEmp\\" + newFile;
                int sizeBuffer = 1024;
                byte[] buffer = new byte[sizeBuffer];
                FileStream fsReader = new FileStream(originalFile, FileMode.Open, FileAccess.Read);
                FileStream fsWriter = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                BufferedStream bsReader = new BufferedStream(fsReader);
                BufferedStream bsWriter = new BufferedStream(fsWriter);
                try
                {
                    while (bsReader.Read(buffer, 0, buffer.Length) > 0)
                    {
                        bsWriter.Write(buffer, 0, buffer.Length);
                    }
                }
                catch (IOException ie)
                {

                    LogManager.WriteTextLog("Framework", "ImageManage", "CopyImageFileToServer", ie.Message);
                }
                finally
                {
                    bsReader.Close();
                    bsWriter.Close();
                }
            }
        }

        public static void UpdateImageFile(string originalFile, string newFile)
        {
            CopyImageFileToServer(originalFile, newFile);
        }
    }
}