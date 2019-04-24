using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Zoo
{
    class Tente
    {
        Bitmap[,] tableauTente = new Bitmap[3, 3];
        public Tente()
        {
            remplirTableauAvecImage();
        }

        private void remplirTableauAvecImage()
        {
            tableauTente[0, 1] = TestTilesetMario.TilesetImageGenerator.GetTile(1);
            tableauTente[0, 2] = TestTilesetMario.TilesetImageGenerator.GetTile(2);
            tableauTente[0, 3] = TestTilesetMario.TilesetImageGenerator.GetTile(3);
            tableauTente[1, 0] = TestTilesetMario.TilesetImageGenerator.GetTile(4);
            tableauTente[1, 1] = TestTilesetMario.TilesetImageGenerator.GetTile(5);
            tableauTente[1, 2] = TestTilesetMario.TilesetImageGenerator.GetTile(6);
            tableauTente[2, 0] = TestTilesetMario.TilesetImageGenerator.GetTile(7);
            tableauTente[2, 1] = TestTilesetMario.TilesetImageGenerator.GetTile(8);
            tableauTente[2, 2] = TestTilesetMario.TilesetImageGenerator.GetTile(9);
        }

        public Bitmap[,] getListeBitmapTente()
        {
            return tableauTente;
        }
    }
}
