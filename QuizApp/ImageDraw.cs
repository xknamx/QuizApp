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
        private List<Bitmap> images;
        //画像を格納するリストの宣言
        private Random random;
        //Randomオブジェクトの宣言
        private Bitmap currentImage;
        //ランダムに選ばれたBitmapオブジェクトの宣言


        //プロパティの定義
        public Bitmap Img { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //コンストラクタ
        public Image(string imagePath, int x, int y)
        {
            Img = new Bitmap(imagePath);
            X = x;
            Y = y;
            Width = 60;
            Height = 60;
        }

        //フォルダ内のPNG画像をすべて読み込んでimagesリストに格納するメソッド
        public List<Bitmap> LoadPngImage(string folderPath)
        {
            //Bitmap型の画像を格納するimagesリストを生成
            List<Bitmap> images = new List<Bitmap>();

            //引数に指定したファルダ内のpngファイルのファイル名をfiles配列に格納
            string[] files = Directory.GetFiles(folderPath, "*.png");

            //配列に格納したpngファイルをBitmap型にしてimagesリストに格納
            foreach (string file in files)
            {
                Bitmap image = new Bitmap(file);
                images.Add(image);
            }

            return images;
        }

        //ヒヨコを一羽増やすメソッド
        public void AddPiyo()
        {
            if (images.Count > 0)
            {
                //imagesリストの中身が空でなければ
                //imagesリストから一つランダムに取り出す
                int index = random.Next(images.Count);
                currentImage = images[index];
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int x = 60;
            if (currentImage != null)
            {
                // 画像をフォームに描画
                e.Graphics.DrawImage(currentImage, new Rectangle(0, x, 60,60));
            }
        }
    }
}
