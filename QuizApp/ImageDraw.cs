using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace QuizApp
{
    public class Image
    {
        //プロパティの定義
        public Bitmap Img { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //コンストラクタ
        public Image(string imagePath,int x,int y)
        {
            Img = new Bitmap(imagePath);
            X = x;
            Y = y;
            Width = 60;
            Height = 60;
        }

        //フォルダ内のPNG画像をすべて読み込んでimagesリストに格納するメソッド
        public List<>
    }
}
