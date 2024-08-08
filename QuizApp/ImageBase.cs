using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public class ImageBase
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (currentImage != null)
            {
                // 画像をフォームに描画
                e.Graphics.DrawImage(currentImage, new Rectangle(0, 50, this.Width, this.Height - 50));
            }
        }
    }
}