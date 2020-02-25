using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class Form1 : Form
    {
        private PictureBox selectedTile;
        private int MapSizeX;
        private int MapSizeY;
        private int MapTileSize;
        private int editMode = 0;
        private Dictionary<Point, PictureBox> tileMap = new Dictionary<Point, PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsOpaque(Bitmap bitmap)
        {
            bool trans = true;

            Color color = bitmap.GetPixel(bitmap.Height / 2, bitmap.Height / 2);
            if ((color.A != 0 || color.B != 0 || color.R != 0 || color.G != 0))
                trans = false;
            else
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    for (var x = 0; x < bitmap.Width; x++)
                    {
                        color = bitmap.GetPixel(x, y);
                        if (color.A != 0 || color.B != 0 || color.R != 0 || color.G != 0)
                            trans = false;

                    }
                }
            }
            return trans;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int tileWidth = 16;
            int tileHeight = 16;
            int tileRows = 32;
            int tileCols = 34;

            using (Bitmap sourceBmp = new Bitmap(@"C:\Users\JAMiller4\Desktop\PersonalScripts\Unity\TopDown\Assets\Tiny RPG Forest\Artwork\Environment\tileset.png"))
            {
                int count = 0;
                Size s = new Size(tileWidth, tileHeight);
                Rectangle destRect = new Rectangle(Point.Empty, s);

                for (int row = 0; row < tileRows; row++)
                {
                    for (int col = 0; col < tileCols; col++)
                    {
                        PictureBox p = new PictureBox
                        {
                            Size = s
                        };
                        Point loc = new Point(tileWidth * col, tileHeight * row);
                        Rectangle srcRect = new Rectangle(loc, s);
                        Bitmap tile = new Bitmap(tileWidth, tileHeight);
                        Graphics G = Graphics.FromImage(tile);
                        G.DrawImage(sourceBmp, destRect, srcRect, GraphicsUnit.Pixel);

                        if (IsOpaque(tile))
                        {
                            continue;
                        }

                        p.Image = tile;
                        p.Location = loc;
                        p.Tag = count;
                        p.Name = String.Format("Col={0:00}-Row={1:00}", col, row);
                        p.Padding = new Padding(1);

                        p.MouseClick += P_ClickedPull;
                        //p.BorderStyle = BorderStyle.FixedSingle;

                        // p.MouseDown += p_MouseDown;
                        // p.MouseUp += p_MouseUp;
                        // p.MouseMove += p_MouseMove;
                        //this.Controls.Add(p);
                        TilePanel.Controls.Add(p);
                        count++;
                    }
                }
            }
        }

        public void P_ClickedPull(object sender, EventArgs e)
        {
            editMode = 0;
            TileModeButton.Checked = true;
            selectedTile = (PictureBox)sender;
        }

        public void P_ClickedSet(object sender, EventArgs e)
        {
            if (editMode == 0 && selectedTile != null)
            {//Tiles
                foreach (PictureBox c in MapGroupBox.Controls)
                {
                    if (c.Tag != null)
                        
                        if (c == (PictureBox)sender)
                        {
                            c.Image = selectedTile.Image;
                            c.Tag = selectedTile.Tag;
                            break;
                        }

                }
            }
            else if (editMode == 1)
            {//Walls
                foreach (PictureBox c in MapGroupBox.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c == (PictureBox)sender)
                        {
                            c.BackColor = Color.Red;
                            Bitmap bmp = (Bitmap)c.Image;

                            c.Tag += "W";
                            c.Image = (Bitmap)bmp;
                            break;
                        }
                    }
                }
            }
            else if (editMode == 2)
            {//Items
                foreach (PictureBox c in MapGroupBox.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c == (PictureBox)sender)
                        {
                            c.BackColor = Color.Yellow;
                            Bitmap bmp = (Bitmap)c.Image;

                            c.Tag += "I" + selectedTile.Tag;
                            c.Image = (Bitmap)bmp;
                            break;
                        }
                    }
                }
            }
            else if (editMode == 3)
            {//NPC
                foreach (PictureBox c in MapGroupBox.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c == (PictureBox)sender)
                        {
                            c.BackColor = Color.Magenta;
                            Bitmap bmp = (Bitmap)c.Image;

                            c.Tag += "N" + selectedTile.Tag;
                            c.Image = (Bitmap)bmp;
                            break;
                        }
                    }
                }
            }
            else if (editMode == 8)
            {//Spawn Points
                foreach (PictureBox c in MapGroupBox.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c == (PictureBox)sender)
                        {
                            c.BackColor = Color.LawnGreen;
                            Bitmap bmp = (Bitmap)c.Image;

                            c.Tag += "S";
                            c.Image = (Bitmap)bmp;
                            break;
                        }
                    }
                }
            }
        }

        private void GenMapButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(MapXBox.Text, out MapSizeX))
            {
                if (int.TryParse(MapYBox.Text, out MapSizeY))
                {
                    if (int.TryParse(TileSizeBox.Text, out MapTileSize))
                    {
                        while (MapGroupBox.Controls.Count > 0)
                        {
                            MapGroupBox.Controls.RemoveAt(0);
                        }
                        tileMap.Clear();
                        //The added 1 and 2 is just for visual. Kepps the border lines from looks too ugly
                        MapGroupBox.Size = new Size((MapSizeX * MapTileSize) + 2, (MapSizeY * MapTileSize) + 1);

                        Size s = new Size(MapTileSize, MapTileSize);
                        Rectangle destRect = new Rectangle(Point.Empty, s);
                        for (int row = 0; row < MapSizeY; row++)
                            for (int col = 0; col < MapSizeX; col++)
                            {
                                PictureBox p = new PictureBox
                                {
                                    Size = s
                                };
                                Point loc = new Point(MapTileSize * col, MapTileSize * row);
                                                                
                                Bitmap flag = new Bitmap(MapTileSize, MapTileSize);
                                Graphics flagGraphics = Graphics.FromImage(flag);

                                flagGraphics.FillRectangle(Brushes.White, 0, 0, MapTileSize, MapTileSize);

                                p.Image = flag;
                                p.Location = loc;
                                p.Tag = "B";
                                p.Name = string.Format("Col={0:00}-Row={1:00}", col, row);
                                p.Padding = new Padding(1);

                                p.MouseClick += P_ClickedSet;

                                tileMap.Add(loc, p);
                                MapGroupBox.Controls.Add(p);
                            }

                        ExMapXBox.Text = MapSizeX.ToString();
                        ExMapYBox.Text = MapSizeY.ToString();
                        ExTileSizeBox.Text = MapTileSize.ToString();

                        return;
                    }
                }
            }
            MessageBox.Show("Map dimensions were entered incorrectly or were invalid");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string output = MapSizeX + "x" + MapSizeY + "\n";
            for (int row = 0; row < MapSizeY; row++)
            {
                for (int col = 0; col < MapSizeX; col++)
                {
                    output += tileMap[new Point(MapTileSize * col, MapTileSize * row)].Tag;
                    output += ",";
                }
                output = output.Remove(output.Length - 1, 1) + "\n";
            }

            string[] lines = output.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            string filename;
            if (string.IsNullOrEmpty(MapNameBox.Text))
            {
                filename = "map";
            }
            else
            {
                filename = MapNameBox.Text;
            }

            using (StreamWriter file =
            new StreamWriter(Directory.GetCurrentDirectory() + @"\" + filename + ".txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }

        private void MapNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TileModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 0;
        }

        private void WallModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 1;
        }

        private void ItemModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 2;
        }

        private void NPCModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 4;
        }

        private void EntryModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 5;
        }

        private void ExitModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 6;
        }

        private void TriggerModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 7;
        }

        private void SpawnPointModeButton_CheckedChanged(object sender, EventArgs e)
        {
            editMode = 8;
        }
    }
}
