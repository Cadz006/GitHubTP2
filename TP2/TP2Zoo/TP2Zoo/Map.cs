using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTilesetMario;

namespace TP2Zoo
{
    public partial class Map : UserControl
    {
        Bitmap[,] tableauInterface = new Bitmap[50, 25];
        //Bitmap[,] tableauEnclos = new Bitmap[50, 25];
        Bitmap[,] tableauInitial = new Bitmap[50, 25];



        public Map()
        {
            InitializeComponent();
            RemplirTableauInitial(tableauInitial);
            RemplirTableauInitial(tableauInterface);
            DefinirCheminVisiteur();
            DefinirEnclos();
            DefinirEnvironEnclos_1();
            DefinirEnvironEnclos_2();
            DefinirEnvironEnclos_3();
            DefinirEnvironEnclos_4();
            DefinirDecor();
            DefinirMaison();
            DefinirEntree();
        }

        private void RemplirTableauInitial(Bitmap[,] tableau)
        {

            int hauteur = tableau.GetLength(0);
            int largeur = tableau.GetLength(1);

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    if ((35 <= i && i < 37) && j == 9)
                    {
                        tableau[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((17 <= j && j < 19) && i == 29)
                    {
                        tableau[i, j] = TilesetImageGenerator.GetTile(35);
                    }
                    else if ((17 <= j && j < 19) && i == 20)
                    {
                        tableau[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((8 <= i && i < 10) && j == 11)
                    {
                        tableau[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((2 <= j && j < 4) && i == 11)
                    {
                        tableau[i, j] = TilesetImageGenerator.GetTile(35);
                    }
                    else
                    {
                        tableau[i, j] = TilesetImageGenerator.GetTile(9);
                    }

                }
            }
        }

        private void DefinirEnclos()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    ///DEUX ENCLOS EN HAUT
                    if (i == 11 && (0 <= j && j < 6))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    else if (j == 5 && (12 <= i && i < 17))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(13);
                    }
                    else if (i == 17 && (6 <= j && j < 10))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    else if (j == 9 && (18 <= i && i < 45))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(12);
                    }
                    else if (i == 45 && (6 <= j && j < 9))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    else if (j == 6 && (45 <= i && i < 50))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(13);
                    }
                    else if (i == 17 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(15);
                    }
                    else if (i == 45 && j == 9)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(14);
                    }
                    ///SÉPARATEUR DES DEUX ENCLOS DU HAUT
                    else if (i == 26 && (0 <= j && j < 9))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    ///TROISÌEME ENCLOS EN BAS À GAUCHE
                    else if (j == 11 && (0 <= i && i < 11))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(13);
                    }
                    else if (i == 11 && (12 <= j && j < 16))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    else if (j == 15 && (12 <= i && i < 20))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(13);
                    }
                    else if (i == 20 && (16 <= j && j < 25))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    else if (i == 11 && j == 11)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(15);
                    }
                    else if (i == 20 && j == 15)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(15);
                    }
                    ///QUATRIÈME ENCLOS EN BAS À DROITE
                    else if (i == 29 && (15 <= j && j < 25))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(11);
                    }
                    else if (j == 15 && (30 <= i && i < 50))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(13);
                    }
                }
            }
        }

        private void DefinirCheminVisiteur()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // Chemin brique
                    if ((13 <= i && i < 50) && (11 <= j && j < 14))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(10);
                    }
                    else if ((23 <= i && i < 27) && (14 <= j && j < 25))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(10);
                    }
                    else if ((7 <= j && j < 11) && (13 <= i && i < 16))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(10);
                    }
                    else if ((7 <= j && j < 10) && (0 <= i && i < 13))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(10);
                    }
                    // Rivière
                    else if ((35 <= i && i < 37) && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(34);
                    }
                    else if ((35 <= i && i < 37) && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(34);
                    }
                    else if ((17 <= j && j < 19) && (27 <= i && i < 29))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(35);
                    }
                    else if ((17 <= j && j < 19) && (21 <= i && i < 23))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(35);
                    }
                    else if (j == 10 && (8 <= i && i < 10))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(34);
                    }
                    else if ((4 <= j && j < 7) && (8 <= i && i < 10))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(34);
                    }
                    else if ((2 <= j && j < 4) && (8 <= i && i < 10))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((2 <= j && j < 4) && i == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(35);
                    }
                    // Rive
                    else if (i == 9 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(27);
                    }
                    else if (i == 8 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(32);
                    }
                    else if (i == 7 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(26);
                    }
                    else if (i == 7 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(30);
                    }
                    else if (i == 7 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                }
            }
        }

        private void DefinirEnvironEnclos_1()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // Montagne part 1
                    if ((27 <= i && i < 35) && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(20);
                    }
                    else if ((32 <= i && i < 35) && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(20);
                    }
                    else if (i == 34 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(20);
                    }
                    // Chute d'eau
                    else if ((0 <= j && j < 3) && (i >= 35 && i <= 36))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(19);
                    }
                    // Montagne part 2
                    else if ((37 <= i && i < 50) && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(20);
                    }
                    else if ((37 <= i && i < 40) && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(20);
                    }
                    else if (i == 37 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(20);
                    }
                    // Lac
                    else if ((32 <= i && i < 34) && (2 <= j && j < 4))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((33 <= i && i < 39) && (3 <= j && j < 5))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((38 <= i && i < 40) && (2 <= j && j < 4))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((35 <= i && i < 37) && (5 <= j && j < 9))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    // Plage
                    else if (i == 31 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(26);
                    }
                    else if (i == 31 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(30);
                    }
                    else if (i == 31 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 32 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(17);
                    }
                    else if (i == 32 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 33 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(33);
                    }
                    else if (i == 34 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(17);
                    }
                    else if (i == 34 && (j >= 6 && j < 9))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(30);
                    }
                    else if (i == 32 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 37 && (6 <= j && j < 9))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(31);
                    }
                    else if (i == 39 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(29);
                    }
                    else if (i == 37 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(17);
                    }
                    else if (i == 38 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(33);
                    }
                    else if (i == 39 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(17);
                    }
                    else if (i == 40 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(29);
                    }
                    else if (i == 40 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(31);
                    }
                    else if (i == 40 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(27);
                    }
                    // Gason haut
                    else if ((39 <= i && i < 45) && (7 <= j && j < 9))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(21);
                    }
                    // Arbuste
                    else if ((28 <= i && i < 30) && (3 <= j && j < 5))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if ((31 <= i && i < 33) && (6 <= j && j < 8))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if ((42 <= i && i < 44) && (2 <= j && j < 4))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                }
            }
        }

        private void DefinirEnvironEnclos_2()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // Étang
                    if ((30 <= i && i < 38) && (16 <= j && j < 20))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    // Rive sablée
                    else if (i == 38 && j == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(27);
                    }
                    else if (i == 38 && (17 <= j && j < 20))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(31);
                    }
                    else if (i == 38 && j == 20)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(29);
                    }
                    else if ((31 <= i && i < 38) && j == 20)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(33);
                    }
                    else if (i == 30 && j == 20)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 38 && j == 20)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(29);
                    }
                    // Terre
                    else if ((40 <= i && i < 49) && (17 <= j && j < 24))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(36);
                    }
                    else if ((31 <= i && i < 40) && (22 <= j && j < 24))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(36);
                    }
                    else if (((40 <= i && i < 49) && j == 16))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(44);
                    }
                    else if (((31 <= i && i < 39) && j == 21))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(44);
                    }
                    else if (((31 <= i && i < 49) && j == 24))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(43);
                    }
                    else if (((17 <= j && j < 24) && i == 49))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(42);
                    }
                    else if (((22 <= j && j < 24) && i == 30))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(41);
                    }
                    else if (((17 <= j && j < 21) && i == 39))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(41);
                    }
                    else if (i == 30 && j == 21)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(37);
                    }
                    else if (i == 39 && j == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(37);
                    }
                    else if (i == 49 && j == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(38);
                    }
                    else if (i == 49 && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(40);
                    }
                    else if (i == 30 && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(39);
                    }
                    else if (i == 39 && j == 21)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(36);
                    }
                    // ARBUSTE
                    
                }
            }
        }

        private void DefinirEnvironEnclos_3()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // Rivière
                    if ((8 <= i && i < 20) && j == 17)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((8 <= i && i < 20) && j == 18)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((12 <= j && j < 17) && i == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((12 <= j && j < 17) && i == 9)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    // Rive
                    else if ((11 <= i && i < 19) && j == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(32);
                    }
                    else if ((8 <= i && i < 19) && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(33);
                    }
                    else if ((13 <= j && j < 19) && i == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(30);
                    }
                    else if ((13 <= j && j < 16) && i == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(31);
                    }
                    else if (i == 7 && j == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(26);
                    }
                    else if (i == 7 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 19 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(29);
                    }
                    else if (i == 19 && j == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(27);
                    }
                    else if (i == 10 && j == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(17);
                    }
                    else if (i == 10 && j == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(27);
                    }
                    // Gason haut
                    else if ((20 <= j && j < 25) && (7 <= i && i < 20))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(21);
                    }
                    // Carré de terre
                    else if ((20 <= j && j < 24) && (1 <= i && i < 6))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(36);
                    }
                    else if ((20 <= j && j < 24) && i == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(41);
                    }
                    else if ((20 <= j && j < 24) && i == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(42);
                    }
                    else if ((1 <= i && i < 6) && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(44);
                    }
                    else if (i == 0 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(37);
                    }
                    else if (i == 0 && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(39);
                    }
                    else if ((1 <= i && i < 6) && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(43);
                    }
                    else if (i == 6 && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(40);
                    }
                    else if (i == 6 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(38);
                    }
                }
            }
        }

        private void DefinirEnvironEnclos_4()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // Rivière
                    if ((2 <= j && j < 4) && (12 <= i && i < 15))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((0 <= j && j < 2) && (13 <= i && i < 15))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    else if ((2 <= j && j < 4) && (12 <= i && i < 15))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(18);
                    }
                    // Arbuste
                    else if (i == 16 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }

                    else if (i == 18 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 20 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 22 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 24 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 16 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 18 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 20 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 22 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 24 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 16 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 18 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 20 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 22 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 24 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 18 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 20 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 22 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 24 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 18 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 20 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 22 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 24 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 17 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 19 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 21 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 23 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 25 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 17 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 19 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 21 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 23 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 25 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 19 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 21 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 23 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 25 && j == 5)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 19 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 21 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 23 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 25 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    // Rive
                    else if (i == 15 && (0 <= j && j < 4))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(31);
                    }
                    else if (i == 15 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(29);
                    }
                    else if (j == 4 && (13 <= i && i < 15))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(33);
                    }
                    else if (i == 12 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 12 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(28);
                    }
                    else if (i == 12 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(30);
                    }
                }
            }
        }

        private void DefinirDecor()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // STATUES
                    if (i == 22 && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(45);
                    }
                    else if (i == 22 && j == 23)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(46);
                    }
                    else if (i == 27 && j == 24)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(45);
                    }
                    else if (i == 27 && j == 23)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(46);
                    }
                    // ARBUSTE
                    else if (i == 22 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 22 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 27 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 27 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 14 && i == 37)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 14 && i == 34)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 14 && i == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 6 && i == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 6 && i == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 34)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 37)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 6 && i == 16)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 14 && i == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 14 && i == 27)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (j == 10 && i == 45)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(25);
                    }
                    else if (i == 40 && j == 17)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 40 && j == 19)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 40 && j == 21)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 39 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 37 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 35 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 33 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    else if (i == 31 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(24);
                    }
                    // ROCHES
                    else if (i == 49 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(47);
                    }
                    else if (i == 0 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(47);
                    }
                    else if (i == 0 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(47);
                    }
                    // Panier de fruits
                    else if (i == 30 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(48);
                    }
                    else if (i == 31 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(49);
                    }
                    else if (i == 16 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(48);
                    }
                    else if (i == 17 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(49);
                    }
                    else if (i == 39 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(48);
                    }
                    else if (i == 40 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(49);
                    }
                    else if (i == 43 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(48);
                    }
                    else if (i == 44 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(49);
                    }
                    else if (i == 13 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(48);
                    }
                    else if (i == 14 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(49);
                    }
                    else if (i == 21 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(48);
                    }
                    else if (i == 22 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(49);
                    }
                    // TRONC
                    else if (i == 5 && j == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(80);
                    }
                    else if (i == 6 && j == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(81);
                    }
                    else if (i == 5 && j == 13)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(82);
                    }
                    else if (i == 6 && j == 13)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(83);
                    }
                    else if (i == 0 && j == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(80);
                    }
                    else if (i == 1 && j == 12)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(81);
                    }
                    else if (i == 0 && j == 13)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(82);
                    }
                    else if (i == 1 && j == 13)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(83);
                    }
                    else if (i == 2 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(84);
                    }
                    else if (i == 3 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(85);
                    }
                    else if (i == 2 && j == 15)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(86);
                    }
                    else if (i == 3 && j == 15)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(87);
                    }
                    // BOULDER
                    else if (i == 46 && j == 17)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(84);
                    }
                    else if (i == 47 && j == 17)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(85);
                    }
                    else if (i == 46 && j == 18)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(86);
                    }
                    else if (i == 47 && j == 18)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(87);
                    }
                    else if (i == 43 && j == 21)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(84);
                    }
                    else if (i == 44 && j == 21)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(85);
                    }
                    else if (i == 43 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(86);
                    }
                    else if (i == 44 && j == 22)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(87);
                    }
                    // AFFICHES
                    else if (i == 46 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                    else if (i == 3 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                    else if (i == 29 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                    else if (i == 15 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                    else if (i == 12 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                    else if (i == 20 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                    else if (i == 38 && j == 14)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(88);
                    }
                }
            }
        }

        private void DefinirMaison()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    if (i == 0 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(50);
                    }
                    else if (i == 1 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(51);
                    }
                    else if (i == 2 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(52);
                    }
                    else if (i == 3 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(53);
                    }
                    else if (i == 4 && j == 4)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(54);
                    }
                    else if (i == 0 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(55);
                    }
                    else if (i == 1 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(56);
                    }
                    else if (i == 2 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(57);
                    }
                    else if (i == 3 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(58);
                    }
                    else if (i == 4 && j == 3)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(59);
                    }
                    else if (i == 0 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(60);
                    }
                    else if (i == 1 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(61);
                    }
                    else if (i == 2 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(62);
                    }
                    else if (i == 3 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(63);
                    }
                    else if (i == 4 && j == 2)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(64);
                    }
                    else if (i == 0 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(65);
                    }
                    else if (i == 1 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(66);
                    }
                    else if (i == 2 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(67);
                    }
                    else if (i == 3 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(68);
                    }
                    else if (i == 4 && j == 1)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(69);
                    }
                    else if (i == 0 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(70);
                    }
                    else if (i == 1 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(71);
                    }
                    else if (i == 2 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(72);
                    }
                    else if (i == 3 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(73);
                    }
                    else if (i == 4 && j == 0)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(74);
                    }
                    // ENTRÉE
                    else if (i == 2 && (5 <= j && j < 7))
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(16);
                    }
                }
            }
        }

        private void DefinirEntree()
        {
            int hauteur = tableauInterface.GetLength(0);
            int largeur = tableauInterface.GetLength(1);
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    // TENTE
                    if (i == 47 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(0);
                    }
                    else if (i == 48 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(1);
                    }
                    else if (i == 49 && j == 7)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(2);
                    }
                    else if (i == 47 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(3);
                    }
                    else if (i == 48 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(4);
                    }
                    else if (i == 49 && j == 8)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(5);
                    }
                    else if (i == 47 && j == 9)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(6);
                    }
                    else if (i == 48 && j == 9)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(7);
                    }
                    else if (i == 49 && j == 9)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(8);
                    }
                    // COMPTOIR
                    else if (i == 47 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(75);
                    }
                    else if (i == 48 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(76);
                    }
                    else if (i == 49 && j == 10)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(77);
                    }
                    else if (i == 27 && j == 21)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(78);
                    }
                    else if (i == 27 && j == 20)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(79);
                    }
                    else if (i == 4 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(75);
                    }
                    else if (i == 5 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(76);
                    }
                    else if (i == 6 && j == 6)
                    {
                        tableauInterface[i, j] = TilesetImageGenerator.GetTile(77);
                    }
                    
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            for (int i = 0; i < tableauInitial.GetLength(0); i++)
            {
                for (int j = 0; j < tableauInitial.GetLength(1); j++)
                {
                    g.DrawImage(tableauInitial[i, j], i * 32, j * 32, 32, 32);
                }
            }

            for (int i = 0; i < tableauInterface.GetLength(0); i++)
            {
                for (int j = 0; j < tableauInterface.GetLength(1); j++)
                {
                    g.DrawImage(tableauInterface[i, j], i * 32, j * 32, 32, 32);
                }
            }

        }
    }
}
