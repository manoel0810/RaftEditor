using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RaftEditor
{
    public partial class Form1 : Form
    {
        string FilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPD = new OpenFileDialog()
            {
                Filter = "Arquivo *.rgd|*.rgd",
                Multiselect = false
            };

            OPD.FileOk += OPD_FileOk;
            OPD.ShowDialog();
            OPD.Dispose();
        }

        private void OPD_FileOk(object sender, CancelEventArgs e)
        {
            var OPF = (OpenFileDialog)sender;
            FilePath = OPF.FileNames[0];

            ReadFile(FilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable Modos = new DataTable();
            Modos.Columns.Add("value", typeof(int));
            Modos.Columns.Add("description", typeof(string));

            int ID = 0;
            foreach (string s in new string[] { "Normal", "Difícil", "Criativo", "Fácil", "Pacífico" })
            {
                DataRow Row = Modos.NewRow();
                Row["value"] = ID <= 3 ? ID : ID + 1;
                Row["description"] = s;
                Modos.Rows.Add(Row);
                ID++;
            }

            Cb_Modos.DataSource = Modos;
            Cb_Modos.DisplayMember = "description";
            Cb_Modos.ValueMember = "value";
        }

        private void Cb_Modos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Modos.SelectedIndex != -1)
            {
                Lb_Msg.Text = "Alterado (não salvo)";
                Lb_Msg.ForeColor = Color.Red;
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("Nenhum arquivo *.rgd carregado!", "Raft - SaveEditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var OBJ = (DataRowView)Cb_Modos.SelectedItem;

                using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                {
                    if (fs.Length < 0x4cc)  ///0x4cc é o endereço respectivo à variável que define a dificuldade do jogo dentro do binário .rgd
                    {
                        MessageBox.Show($"ERRO: Não foi possível ler o offset 0x4cc em {Path.GetFileName(FilePath)}", "Raft - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fs.Close();
                        return;
                    }

                    fs.Position = 0x4cc;
                    using (BinaryWriter Write = new BinaryWriter(fs))
                    {
                        Write.Write(OBJ.Row.Field<Int32>("value"));
                        Write.Flush();
                        Write.Close();
                    }

                    fs.Close();
                }

                Lb_Msg.Text = "Modificado (salvo)";
                Lb_Msg.ForeColor = Color.Green;

                if (DialogResult.Yes == MessageBox.Show("Attention! Modifying the game save can corrupt the file. Make sure the save version is compatible for the correct address and that the game is not running. Do you want to continue?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    ReadFile(FilePath);
                else
                    return;

                MessageBox.Show("A dificuldade do jogo foi alterada com êxito", "Raft Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                Lb_Msg.Text = "ERRO: ao salvar";
                Lb_Msg.ForeColor = Color.Red;

                throw ex;
            }
        }

        private void ReadFile(string PATH)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.Open))
            {
                if (fs.Length < 0x4cc)
                {
                    MessageBox.Show($"ERRO: Não foi possível ler o offset 0x4cc em {Path.GetFileName(FilePath)}", "Raft - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fs.Close();
                    return;
                }

                fs.Position = 0x4cc;
                using (BinaryReader Reader = new BinaryReader(fs))
                {
                    int MODE = Reader.ReadInt32();
                    Lb_Modo.ForeColor = Color.DarkBlue;

                    switch (MODE)
                    {
                        case 0:
                            Lb_Modo.Text = "Normal";
                            Lb_Msg.Text = "Arquivo lido";
                            Lb_Msg.ForeColor = Color.Green;
                            break;
                        case 1:
                            Lb_Modo.Text = "Dificil";
                            Lb_Msg.Text = "Arquivo lido";
                            Lb_Msg.ForeColor = Color.Green;
                            break;
                        case 2:
                            Lb_Modo.Text = "Criativo";
                            Lb_Msg.Text = "Arquivo lido";
                            Lb_Msg.ForeColor = Color.Green;
                            break;
                        case 3:
                            Lb_Modo.Text = "Fácil";
                            Lb_Msg.Text = "Arquivo lido";
                            Lb_Msg.ForeColor = Color.Green;
                            break;
                        case 5:
                            Lb_Modo.Text = "Pacífico";
                            Lb_Msg.Text = "Arquivo lido";
                            Lb_Msg.ForeColor = Color.Green;
                            break;
                        default:
                            Lb_Modo.Text = "??????";
                            Lb_Msg.Text = "(Indeterminado)";
                            Lb_Msg.ForeColor = Color.DarkOrange;
                            break;
                    }

                    Reader.Close();
                }

                fs.Close();
            }
        }
    }
}
