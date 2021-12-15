using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper5
{
    public partial class Form1 : Form
    {
        int RowCount = 5, ColCount = 3;
        Button[,] buttons;
        MinesweeperModel.Model model = new MinesweeperModel.Model();
        public Form1()
        {
            InitializeComponent();

            InitializeComponent2();
        }

        private void InitializeComponent2()
        {
            buttons = new Button[RowCount, ColCount];
            for (int r = 0; r < RowCount; r++)
                for (int c = 0; c < ColCount; c++)
                {
                    buttons[r, c] = new System.Windows.Forms.Button();
                    buttons[r, c].Dock = DockStyle.Fill;
                    // TabIndex in order 0..RowCount*ColCount-1
                    this.tableLayoutPanel1.Controls.Add(buttons[r, c], c, r);
                    buttons[r, c].Text = $"[{r}][{c}]";
                    buttons[r, c].UseVisualStyleBackColor = true;

                    buttons[r, c].Click += OnButtonClick;
                }

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ColumnCount = ColCount;
            for (int c = 0; c < ColCount; c++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / ColCount)); 
            }


            this.tableLayoutPanel1.RowCount = RowCount;
            for (int r = 0; r < RowCount; r++)
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / RowCount));
           
           
        
            // TODO change cursor to arrow


        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            model.OpenCell(0, 0); // how to dtermine row and column?

            // UpdateUI based on move
            // OPtion1 update entire UI from model
            // Option 2 (RECOMMENDED) update cells that changed

            // if Bomb, how does model indicate that?
            ((Button)sender).Text = ":-)";
        }
    }
}
