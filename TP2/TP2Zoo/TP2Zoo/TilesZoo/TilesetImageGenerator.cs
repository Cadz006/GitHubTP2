using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTilesetMario
{
    class TilesetImageGenerator
    {
        // Différentes tailles concernant les images dans le fichier de tuiles de jeu
        public const int IMAGE_WIDTH = 32, IMAGE_HEIGHT = 32;
        private const int TILE_LEFT = 0, TILE_TOP = 0;
        private const int SEPARATEUR_TILE = 0;

        // La valeur entière correspond "par hasard" à la position de l'image dans la List<TileCoord>
        public static int CLOTURE = 0;
        public static int BRIQUE_BRUNE = 1;
        public static int CIEL_BLEU = 2;
        public static int COIN_BLOCK = 3;
        public static int NUAGE = 4;
        public static int HACHE = 5;

        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();

        /// <summary>
        /// Constructeur statique
        /// </summary>
        static TilesetImageGenerator()
        {

            //ajout des morceaux de la tente dans la listeCoord
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 27 }); // Toit tente 1           (0)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 28 }); // Toit tente 2           (1)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 29 }); // Toit tente 3           (2)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 27 }); // Milieu tente 1         (3)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 28 }); // Milieu tente 2         (4)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 29 }); // Milieu tente 3         (5)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 27 }); // Bas tente 1            (6)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 28 }); // Bas tente 2            (7)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 29 }); // Bas tente 3            (8)

            //AJOUT DES TUILES GASON ET CHEMIN BRIQUE POUR LE FOND DE BASE
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 0 }); // GASON                    (9)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 7 }); // CHEMIN BRIQUE           (10)

            //AJOUT DES CLOTURES DE BRIQUES POUR LES ENCLOS
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 20 }); // CLOTÛRE COTÉ DROIT     (11)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 22 }); // CLOTÛRE COTÉ BAS       (12)
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 22 }); // CLOTÛRE COTÉ HAUT       (13)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 23 }); // CLOTÛRE COIN BAS DROIT (14)
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 23 }); // CLOTÛRE COIN HAUT DROIT (15)

            //AJOUT DES TUILES DE DIFFÉRENTS TYPES DE TERRAINS
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 16 }); // PAVÉ UNI               (16)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 4 }); // SABLE                   (17)
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 0 }); // EAU                      (18)
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 3 }); // CHUTE EAU                (19)
            listeCoord.Add(new TileCoord() { Ligne = 12, Colonne = 13 }); // ROCHE MONTAGNE         (20)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 4 }); // GASON HAUT              (21)
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 25 }); // VIGNE 1                 (22)
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 25 }); // VIGNE 2                 (23)
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 10 }); // ARBUSTE 1               (24)
            listeCoord.Add(new TileCoord() { Ligne = 11, Colonne = 19 }); // ARBUSTE 2              (25)

            // AJOUT DES TUILES DE RIVAGE
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 3 }); // RIVE SABLE COIN HAUT G  (26)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 5 }); // RIVE SABLE COIN HAUT D  (27)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 3 }); // RIVE SABLE COIN BAS G   (28)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 5 }); // RIVE SABLE COIN BAS D   (29)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 3 }); // RIVE SABLE COTE G       (30)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 5 }); // RIVE SABLE COTE D       (31)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 4 }); // RIVE SABLE HAUT         (32)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 4 }); // RIVE SABLE BAS          (33)

            // AJOUT TUILES RIVIÈRES
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 3 }); // RIVIÈRE VERTICALE        (34)
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 3 }); // RIVIÈRE HORIZONTALE      (35)

            // AJOUT DES TUILES TERRES
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 10 }); // TERRE CENTRALE          (36)
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 9 }); // TERRE COIN HAUT G        (37)
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 11 }); // TERRE COIN HAUT D       (38)
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 9 }); // TERRE COIN BAS G         (39)
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 11 }); // TERRE COIN BAS D        (40)
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 9 }); // TERRE GAUCHE             (41)
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 11 }); // TERRE DROITE            (42)
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 10 }); // TERRE BAS               (43)
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 10 }); // TERRE HAUT              (44)

            // AJOUT TUILES DÉCORATIVES
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 26 }); // BAS STATUE              (45)
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 26 }); // HAUT STATUE             (46)
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 29 }); // ROCHE                   (47)
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 22 }); // PANIER FRUIT 1          (48)
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 23 }); // PANIER FRUIT 2          (49)

            // AJOUT TUILES MAISONS
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 13 }); // BAS DE MAISON 1        (50)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 14 }); // BAS DE MAISON 2        (51)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 15 }); // BAS DE MAISON 3        (52)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 16 }); // BAS DE MAISON 4        (53)
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 17 }); // BAS DE MAISON 5        (54)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 13 }); // MILIEU DE MAISON 1     (55)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 14 }); // MILIEU DE MAISON 2     (56)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 15 }); // MILIEU DE MAISON 3     (57)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 16 }); // MILIEU DE MAISON 4     (58)
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 17 }); // MILIEU DE MAISON 5     (59)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 13 }); // MILIEU DE MAISON 6     (60)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 14 }); // MILIEU DE MAISON 7     (61)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 15 }); // MILIEU DE MAISON 8     (62)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 16 }); // MILIEU DE MAISON 9     (63)
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 17 }); // MILIEU DE MAISON 10    (64)
            listeCoord.Add(new TileCoord() { Ligne = 11, Colonne = 9 }); // TOIT DE MAISON 1        (65)
            listeCoord.Add(new TileCoord() { Ligne = 11, Colonne = 10 }); // TOIT DE MAISON 2       (66)
            listeCoord.Add(new TileCoord() { Ligne = 11, Colonne = 11 }); // TOIT DE MAISON 3       (67)
            listeCoord.Add(new TileCoord() { Ligne = 11, Colonne = 12 }); // TOIT DE MAISON 4       (68)
            listeCoord.Add(new TileCoord() { Ligne = 11, Colonne = 13 }); // TOIT DE MAISON 5       (69)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 9 }); // TOIT DE MAISON 6        (70)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 10 }); // TOIT DE MAISON 7       (71)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 11 }); // TOIT DE MAISON 8       (72)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 12 }); // TOIT DE MAISON 9       (73)
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 13 }); // TOIT DE MAISON 10      (74)

            // AJOUT TUILES COMPTOIR
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 24 }); // COMPTOIR HORIZ. 1       (75)
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 25 }); // COMPTOIR HORIZ. 2       (76)
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 26 }); // COMPTOIR HORIZ. 3       (77)
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 24 }); // COMPTOIR VERT. 1        (78)
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 24 }); // COMPTOIR VERT. 2        (79)

            // AJOUT TUILES TRONC ET BOULDER
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 25 }); // TRONC 1                 (80)
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 26 }); // TRONC 2                 (81)
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 25 }); // TRONC 3                 (82)
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 26 }); // TRONC 4                 (83)
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 28 }); // BOULDER 1               (84)
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 29 }); // BOULDER 2               (85)
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 28 }); // BOULDER 3               (86)
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 29 }); // BOULDER 4               (87)

            // AJOUT TUILE AFFICHE
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 20 }); // AFFICHE                (88)



            //ajout des morceaux de la tente dans la liste Bitmap
            listeBitmap.Add(LoadTile(0));
            listeBitmap.Add(LoadTile(1));
            listeBitmap.Add(LoadTile(2));
            listeBitmap.Add(LoadTile(3));
            listeBitmap.Add(LoadTile(4));
            listeBitmap.Add(LoadTile(5));
            listeBitmap.Add(LoadTile(6));
            listeBitmap.Add(LoadTile(7));
            listeBitmap.Add(LoadTile(8));
            listeBitmap.Add(LoadTile(9));
            listeBitmap.Add(LoadTile(10));
            listeBitmap.Add(LoadTile(11));
            listeBitmap.Add(LoadTile(12));
            listeBitmap.Add(LoadTile(13));
            listeBitmap.Add(LoadTile(14));
            listeBitmap.Add(LoadTile(15));
            listeBitmap.Add(LoadTile(16));
            listeBitmap.Add(LoadTile(17));
            listeBitmap.Add(LoadTile(18));
            listeBitmap.Add(LoadTile(19));
            listeBitmap.Add(LoadTile(20));
            listeBitmap.Add(LoadTile(21));
            listeBitmap.Add(LoadTile(22));
            listeBitmap.Add(LoadTile(23));
            listeBitmap.Add(LoadTile(24));
            listeBitmap.Add(LoadTile(25));
            listeBitmap.Add(LoadTile(26));
            listeBitmap.Add(LoadTile(27));
            listeBitmap.Add(LoadTile(28));
            listeBitmap.Add(LoadTile(29));
            listeBitmap.Add(LoadTile(30));
            listeBitmap.Add(LoadTile(31));
            listeBitmap.Add(LoadTile(32));
            listeBitmap.Add(LoadTile(33));
            listeBitmap.Add(LoadTile(34));
            listeBitmap.Add(LoadTile(35));
            listeBitmap.Add(LoadTile(36));
            listeBitmap.Add(LoadTile(37));
            listeBitmap.Add(LoadTile(38));
            listeBitmap.Add(LoadTile(39));
            listeBitmap.Add(LoadTile(40));
            listeBitmap.Add(LoadTile(41));
            listeBitmap.Add(LoadTile(42));
            listeBitmap.Add(LoadTile(43));
            listeBitmap.Add(LoadTile(44));
            listeBitmap.Add(LoadTile(45));
            listeBitmap.Add(LoadTile(46));
            listeBitmap.Add(LoadTile(47));
            listeBitmap.Add(LoadTile(48));
            listeBitmap.Add(LoadTile(49));
            listeBitmap.Add(LoadTile(50));
            listeBitmap.Add(LoadTile(51));
            listeBitmap.Add(LoadTile(52));
            listeBitmap.Add(LoadTile(53));
            listeBitmap.Add(LoadTile(54));
            listeBitmap.Add(LoadTile(55));
            listeBitmap.Add(LoadTile(56));
            listeBitmap.Add(LoadTile(57));
            listeBitmap.Add(LoadTile(58));
            listeBitmap.Add(LoadTile(59));
            listeBitmap.Add(LoadTile(60));
            listeBitmap.Add(LoadTile(61));
            listeBitmap.Add(LoadTile(62));
            listeBitmap.Add(LoadTile(63));
            listeBitmap.Add(LoadTile(64));
            listeBitmap.Add(LoadTile(65));
            listeBitmap.Add(LoadTile(66));
            listeBitmap.Add(LoadTile(67));
            listeBitmap.Add(LoadTile(68));
            listeBitmap.Add(LoadTile(69));
            listeBitmap.Add(LoadTile(70));
            listeBitmap.Add(LoadTile(71));
            listeBitmap.Add(LoadTile(72));
            listeBitmap.Add(LoadTile(73));
            listeBitmap.Add(LoadTile(74));
            listeBitmap.Add(LoadTile(75));
            listeBitmap.Add(LoadTile(76));
            listeBitmap.Add(LoadTile(77));
            listeBitmap.Add(LoadTile(78));
            listeBitmap.Add(LoadTile(79));
            listeBitmap.Add(LoadTile(80));
            listeBitmap.Add(LoadTile(81));
            listeBitmap.Add(LoadTile(82));
            listeBitmap.Add(LoadTile(83));
            listeBitmap.Add(LoadTile(84));
            listeBitmap.Add(LoadTile(85));
            listeBitmap.Add(LoadTile(86));
            listeBitmap.Add(LoadTile(87));
            listeBitmap.Add(LoadTile(88));
        }

        private static Bitmap LoadTile(int posListe)
        {
            Image source = TP2Zoo.Properties.Resources.zoo_tileset;
            TileCoord coord = listeCoord[posListe];
            Rectangle crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetTile(int posListe)
        {
            return listeBitmap[posListe];
        }

    }

    public class TileCoord
    {
        public int Ligne { get; set; }
        public int Colonne { get; set; }
    };
}

