using System;
using System.Windows.Forms;

namespace SQL_Fromatter
{
    public partial class SQL_Formatter : Form
    {
        Ext_list<String> file_paths;

        public SQL_Formatter()
        {
            InitializeComponent();

            file_paths = new Ext_list<string>();
            file_paths.CountChanged += File_paths_CountChanged;
        }

        private void File_paths_CountChanged(object sender, Ext_list<string>.ListEventArgs e)
        {
            refresh_list();
        }

        private void pnl_dropArea_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pnl_dropArea_DragDrop(object sender, DragEventArgs e)
        {
            string[] filename = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in filename)
            {
                file_paths.Add(item);
            }
        }

        private void btn_removeFile_Click(object sender, EventArgs e)
        {
            try
            {
                file_paths.RemoveAt(lst_files.SelectedIndex);
                refresh_list();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a file to remove.");
            } 
        }

        private void btn_formatSQL_Click(object sender, EventArgs e)
        {

        }

        private void refresh_list()
        {
            lst_files.Items.Clear();
            foreach (var item in file_paths)
            {
                lst_files.Items.Add(item);
            }
        }
    }
}