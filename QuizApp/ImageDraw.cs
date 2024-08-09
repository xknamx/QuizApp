using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace QuizApp
{
    public class Image : Form
    {
        
    
       
        
        int formHeight;
        

        //プロパティの定義
        public Bitmap Img { get; set; }
        public int X { get; private set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        //コンストラクタ
        public Image(string imagePath,int y)
        {
            Img = new Bitmap(imagePath);
            X = 0;
            Y = y;
            Width = 60;
            Height = 60;

        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Img, X, Y, Width, Height);
            //プレイヤーの画像を描画するメソッド
            //引数は　画像　位置　（サイズ）
        }


    }
}
