using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;

namespace QuanLyThuVien
{
    class FileText
    {
        private String _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private System.IO.FileStream fs;
        public String[] ReadLoaiSach()
        {
            int i = 0;
            fs = new System.IO.FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            String str;
            String[] parts = new string[5];
            while(i < 5)
            {
                str = sr.ReadLine();
                parts[i] = str;
                i++;
            }
            sr.Close();
            fs.Close();
            return parts;
        }
        public String[] ReadSach()
        {
            int i = 0;
            fs = new System.IO.FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            String str;
            String[] parts = new string[15];
            while (i < 15)
            {
                str = sr.ReadLine();
                parts[i] = str;
                i++;
            }
            sr.Close();
            fs.Close();
            return parts;
        }
    }
}
