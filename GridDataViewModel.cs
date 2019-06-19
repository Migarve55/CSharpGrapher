
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using GraphUtil;

namespace AStarVisualizer
{
    public class GridDataViewModel
    {
        
        public ObservableCollection<CellData> Cells { get; set; }
        
        public Command<CellData> ToggleCommand { get; set; }

        private GridGraph _graph;

        public GridDataViewModel()
        {
            ResizeGrid(10, 10);
            ToggleCommand = new Command<CellData>(Toggle);
        }

        public void StartAStar(int sx, int sy, int ex, int ey)
        {
            IEnumerable<CellNode> path = _graph.AStar(sx, sy, ex, ey);
            
        }

        public void ResetCells()
        {
            ResizeGrid(10, 10);
        }

        public void ResizeGrid(int nx, int ny)
        {
            var cells = Enumerable.Range(0, nx * ny)
                .Select(c => new CellData(c % nx, c / ny));
            Cells = new ObservableCollection<CellData>(cells);
            
            _graph = new GridGraph(nx, ny);
        }

        private void Toggle(CellData data)
        {
            data.Active = !data.Active;
            _graph.SetCell(data.X, data.Y, data.Active);
        }
        
    }
}