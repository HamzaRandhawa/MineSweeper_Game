using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MineSweeper : Form
    {
        int dim;
        int No_of_mines;

        Cell[][] CellsMap;
        public MineSweeper()
        {
            InitializeComponent();
        }

        void Generate_Mines_Randomly()
        {
            for (int m = 0; m < No_of_mines; m++)
            {
                Random rnd = new Random();

                int r = rnd.Next(dim);
                int c = rnd.Next(dim);

                while (CellsMap[r][c].value == -1)   //To Avoid Overplacing of mines
                {
                    r = rnd.Next(dim);
                    c = rnd.Next(dim);
                }

                CellsMap[r][c].value = -1;

                for (int ri = r - 1; ri <= r + 1; ri++)
                {
                    if (ri < 0 || ri >= dim)
                        continue;

                    for (int ci = c - 1; ci <= c + 1; ci++)
                    {
                        if (ci < 0 || ci >= dim)
                            continue;

                        if ((CellsMap[ri][ci].value != -1))
                            CellsMap[ri][ci].value++;
                    }

                }
            }
           
        }

        

        void Show_Values_on_Cells()
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                 //   CellsMap[i][j].Text = CellsMap[i][j].value.ToString();

                    Cells_Panel.Controls.Add(CellsMap[i][j]);
                }
            }
        }

        private void Open_all_Connecting_Zeroes()
        {
            bool Is_change = false;
            for(int ri=0;ri< dim;ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if(CellsMap[ri][ci].Is_open)
                    {
                        if(CellsMap[ri][ci].value==0)
                        {
                            //Again now for opening neighbours

                            for (int r = ri - 1; r <= ri + 1; r++)
                            {
                                if (r < 0 || r >= dim)
                                    continue;

                                for (int c = ci - 1; c <= ci + 1; c++)
                                {
                                    if (c < 0 || c >= dim)
                                        continue;

                                    if ((CellsMap[r][c].value != -1) && CellsMap[r][c].Is_open == false)
                                    {
                                        CellsMap[r][c].Is_open = true;
                                        Is_change = true;
                                        CellsMap[r][c].BackColor = Color.Transparent;
                                        if ((CellsMap[r][c].value != 0))
                                            CellsMap[r][c].Text = CellsMap[r][c].value.ToString();
                                    }

                                    

                                    if (Is_change)
                                        Open_all_Connecting_Zeroes();

                                    Is_change = false;
                                }

                            }

                        }
                    }
                }
            }
           
        }

        private bool Is_Win()
        {
            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {

                    if (CellsMap[ri][ci].Is_open == false)
                    {
                        if (CellsMap[ri][ci].value != -1)
                            return false;
                    }
                }
            }
            return true;
        }

        private void When_Clicked(object sender, EventArgs e)
        {
            Cell clicked_cell = (Cell)sender;

            clicked_cell.BackColor = Color.Transparent;

            if ((clicked_cell.value != 0))
                clicked_cell.Text = clicked_cell.value.ToString();

            clicked_cell.Is_open = true;
            if(clicked_cell.value==-1)
            {
                MessageBox.Show("You Loose.. Chalo Bhaago!!");
                Application.Exit();
            }

            if(Is_Win())
            {
                MessageBox.Show("You Won.. Chha Gaey!!");
                Application.Exit();
            }

            Open_all_Connecting_Zeroes();

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Easy.Checked == true)
            {
                dim = 5;
                No_of_mines = 4;
            }
            else if (Medium.Checked == true)
            {
                dim = 7;
                No_of_mines = 8;
            }
                
           else if (Hard.Checked == true)
            {
                dim = 9;
                No_of_mines = 12;
            }
               
            //else
            //{
            //         MessageBox.Show("Please Select Level.");
            //    return;
            //}

            //            MessageBox.Show("Dimension = " + dim.ToString());

            CellsMap = new Cell[dim][];
            for (int i = 0; i < dim; i++)
            {
                CellsMap[i] = new Cell[dim];
            }
            Cells_Panel.Controls.Clear();

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    CellsMap[i][j] = new Cell(i,j, Cells_Panel.Width, Cells_Panel.Height,dim);
                   /// CellsMap[i][j].Text = i.ToString() + "," + j.ToString();

                    CellsMap[i][j].Click += new System.EventHandler(this.When_Clicked);
                    //CellsMap[i][j].Width = Cells_Panel.Width / dim;
                    //CellsMap[i][j].Height = Cells_Panel.Height / dim;

                    CellsMap[i][j].BackColor = Color.Blue;
                   // CellsMap[i][j].Margin.All=(0,0,0,0)

                    Cells_Panel.Controls.Add(CellsMap[i][j]);
                }
            }
            Generate_Mines_Randomly();
            Show_Values_on_Cells();
           
        }


        private void Easy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
