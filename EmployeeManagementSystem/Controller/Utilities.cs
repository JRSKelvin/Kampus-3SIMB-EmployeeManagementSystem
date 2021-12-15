using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using EmployeeManagementSystem.Properties;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Controller
{
    public class Utilities
    {
        #region Properties
        private static string[] paramList;

        public static BackgroundWorker workerparam = null;
        private static BackgroundWorker InitWorker(WorkerProcess process, string[] listofParams)
        {
            paramList = listofParams;
            _processEnum = process;
            BackgroundWorker worker = new BackgroundWorker();
            worker.ProgressChanged += Worker_ProgressChanged; 
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            workerparam = worker;
            return worker;
        }

        private static void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private static void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }
        #endregion
        #region Enum
        private static WorkerProcess _processEnum;

        public enum WorkerProcess
        {
            CopyFile, GetClassList, OpenFileNewThread
        }
        public static void WorkerFire(WorkerProcess process, string[] listofParams)
        {
            BackgroundWorker worker = InitWorker(process, listofParams);
            worker.RunWorkerAsync();
        }
        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (_processEnum)
            {
                case WorkerProcess.CopyFile:
                    CopyToServer(paramList[0], paramList[1]);
                    break;
                case WorkerProcess.GetClassList:

                    break;
                case WorkerProcess.OpenFileNewThread:
                    OpenFileDocs(paramList[0]);
                    break;
                default:
                    break;
            }
        }
        #endregion
        public Utilities()
        {

        }



        public static Image GetImage(string loc)
        {
            try
            {
                using (Image image = Image.FromFile(loc))
                {
                    Bitmap bitmap = new Bitmap(image);
                    image.Dispose();
                    return bitmap;
                }
            }
            catch (Exception)
            {
                Image image = Resources.Anonym;
                return image;
            }
        }
        public enum LocType
        {
            Photo,
            Document
        }
        public enum LocationType
        {
            SubjectPhoto, StudentDocuments, StudentPhoto, ParentPhoto, InventoryPhoto, EmployeePhoto, EmployeeDocument
        }
        public static string GetFileDbLocationString(LocationType type, string name, OpenFileDialog dialog)
        {
            string dbstring;
            string ext = Path.GetExtension(dialog.FileName);
            switch (type)
            {
                case LocationType.EmployeePhoto:
                    dbstring = $@"\\{Db.ServerIPAddress}\DocumentEmployee\Img\{name}{ext}";
                    return dbstring;
                case LocationType.EmployeeDocument:
                    dbstring = $@"\\{Db.ServerIPAddress}\DocumentEmployee\Docs\{ name}{ ext}";
                    return dbstring;
                default:
                    return null;
            }
        }

        public static string GetSelectedDatagridValue(Guna2DataGridView datagrid, string targetHeader)
        {
            if (datagrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = datagrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagrid.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells[targetHeader].Value);
                return a;
            }
            else
            {
                return string.Empty;
            }
        }
        public static string GetFileDbLocationString(LocType type, string name, OpenFileDialog dialog)
        {
            string dbstring;
            string ext = Path.GetExtension(dialog.FileName);
            switch (type)
            {
                case LocType.Document:
                    dbstring = $@"\\{Db.ServerIPAddress}\DocumentEmployee\Docs\" + name + ext;
                    return dbstring;
                case LocType.Photo:
                    dbstring = $@"\\{Db.ServerIPAddress}\DocumentEmployee\Img\{ name}{ ext}";
                    return dbstring;
                default:
                    return null;
            }
        }
        public static void OpenFileDocs(string path)
        {
            Process.Start(path);
        }
        public static OpenFileDialog OpenImage(PictureBox picture)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = ("Image Files(*.BMP; *.JPG; *.JPEG; *.PNG;)| *.BMP; *.JPG; *.JPEG; *.PNG; | All files(*.*) | *.*");
            if (opf.ShowDialog() == DialogResult.OK)
            {
                using (Image im = Image.FromFile(opf.FileName))
                {
                    Bitmap bm = new Bitmap(im);
                    picture.Image = bm;
                    im.Dispose();
                }
                return opf;
            }
            else
            {
                picture.Image = Resources.icons8_question_mark_480px;
                return null;
            }
        }
        public static OpenFileDialog OpenFile(string filter)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = (filter);
            if (opf.ShowDialog() == DialogResult.OK)
            {

            }
            return opf;
        }
        private static void CopyToServer(string from, string to)
        {
            try
            {
                FileStream fsOut = new FileStream(to, FileMode.Create);
                FileStream fsIn = new FileStream(from, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] bt = new byte[10000];
                int reaDbyte;
                while ((reaDbyte = fsIn.Read(bt, 0, bt.Length)) > 0)
                {
                    fsOut.Write(bt, 0, reaDbyte);
                    workerparam.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
                }
                fsIn.Close();
                fsOut.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static string GetPublicIpAddress()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }



    }
}
