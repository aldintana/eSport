using System;
using System.Windows.Forms;
using eSport.WinUI.Korisnik;

namespace eSport.WinUI
{
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tereniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazTerena frmPrikazTerena = new frmPrikazTerena();
            frmPrikazTerena.MdiParent = this;
            frmPrikazTerena.WindowState = FormWindowState.Maximized;
            frmPrikazTerena.Show();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazKorisnika frmPrikazKorisnika = new frmPrikazKorisnika();
            frmPrikazKorisnika.MdiParent = this;
            frmPrikazKorisnika.WindowState = FormWindowState.Maximized;
            frmPrikazKorisnika.Show();
        }

        private void historijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazTermina frmPrikazTermina = new frmPrikazTermina(false);
            frmPrikazTermina.MdiParent = this;
            frmPrikazTermina.WindowState = FormWindowState.Maximized;
            frmPrikazTermina.Show();
        }

        private void aktivniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazTermina frmPrikazTermina = new frmPrikazTermina(true);
            frmPrikazTermina.MdiParent = this;
            frmPrikazTermina.WindowState = FormWindowState.Maximized;
            frmPrikazTermina.Show();
        }

        private void aktivniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrikazTurnira frmPrikazTurnira = new frmPrikazTurnira(true);
            frmPrikazTurnira.MdiParent = this;
            frmPrikazTurnira.WindowState = FormWindowState.Maximized;
            frmPrikazTurnira.Show();
        }

        private void historijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrikazTurnira frmPrikazTurnira = new frmPrikazTurnira(false);
            frmPrikazTurnira.MdiParent = this;
            frmPrikazTurnira.WindowState = FormWindowState.Maximized;
            frmPrikazTurnira.Show();
        }
    }
}
