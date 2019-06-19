using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphUtil;

namespace AStarWinApp
{
    public partial class Form1 : Form
    {

        private GridGraph _graph;
        private CellButton[,] _grid;
        
        public Form1()
        {
            _graph = new GridGraph(15, 15);
            
            InitializeComponent();
            cbAlgorithm.SelectedIndex = 0;
            AdjustTable();
            CreateGrid();
        }

        private void AdjustTable()
        {
            CellGrid.RowCount = _graph.X;
            CellGrid.ColumnCount = _graph.Y;
            CellGrid.RowStyles.Clear();
            for (int i = 0; i < _graph.X; i++)
            {
                CellGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            }
            CellGrid.ColumnStyles.Clear();
            for (int i = 0; i < _graph.Y; i++)
            {
                CellGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            }
        }

        private void CreateGrid()
        {
            _grid = new CellButton[_graph.X,_graph.Y];
            for (int i = 0; i < _graph.X; i++)
            {
                for (int j = 0; j < _graph.Y; j++)
                {
                    var btn = new CellButton(i, j);
                    _grid[i, j] = btn;
                    btn.Click += ToggleBtnState;
                    CellGrid.Controls.Add(btn, i, j);
                }
            }
        }

        private void ToggleBtnState(object sender, EventArgs e)
        {
            var btn = (CellButton) sender;
            btn.ToggleState();
            _graph.SetCell(btn.X, btn.Y, btn.State);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var cellGridControl in CellGrid.Controls)
            {
                var btn = (CellButton) cellGridControl;
                btn.SetUnmarked();
            }

            IEnumerable<CellNode> path = null;
            switch (cbAlgorithm.SelectedIndex)
            {
                case 0:
                    path = _graph.AStar(0, 0, _graph.X - 1, _graph.Y - 1);
                    break;
                case 1:
                    path = _graph.Dijkstra(0, 0, _graph.X - 1, _graph.Y - 1);
                    break;
                default:
                    path = _graph.AStar(0, 0, _graph.X - 1, _graph.Y - 1);
                    break;
            }
            if (path == null)
                return;
            foreach (var cellNode in path)
            {
                _grid[cellNode.X, cellNode.Y].SetMarked();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _graph = new GridGraph(_graph.X, _graph.Y);
            foreach (var cellGridControl in CellGrid.Controls)
            {
                var btn = (CellButton) cellGridControl;
                btn.ResetState();
            }
        }
    }
}