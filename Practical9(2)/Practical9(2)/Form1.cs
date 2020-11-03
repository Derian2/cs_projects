using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical9_2_
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
      DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из приложения ? ", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (rsl == DialogResult.Yes)
      { // выходим из приложения
        Application.Exit();
      }
    }
    Image MemForImage;

    // функция загрузки изображения
    private void LoadImage(bool jpg)
    {

      // директория, которая будет выбрана как начальная в окне для выбора файла 
      openFileDialog1.InitialDirectory = "c:";

      //еслибудемвыбирать jpg файлы
      if (jpg)
      {
        // устанавливаем формат файлов для загрузки - jpg
        openFileDialog1.Filter = "image (JPEG) files (*.jpg)|*.jpg|All files (*.*)|*.*";
      }
      else
      {
        // устанавливаем формат файлов для загрузки - png
        openFileDialog1.Filter = "image (PNG) files (*.png)|*.png|All files (*.*)|*.*";
      }

      // если открытие окна выбора файла завершилось выбором файла и нажатием кнопки ОК 
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {

        try// безопасная попытка 
        {
          // пытаемся загрузить файл с именем openFileDialog1.FileName - выбранный пользователем файл. 
          MemForImage = Image.FromFile(openFileDialog1.FileName);
          // устанавливаем картинку в поле элемента PictureBox
          pictureBox2.Image = MemForImage;
        }
        catch (Exception ex)// еслипопытказагрузкинеудалась
        {
          // выводим сообщение с причиной ошибки 
          MessageBox.Show("Не удалось загрузить файл: " + ex.Message);
        }

      }

    }


    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      LoadImage(true);
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      LoadImage(false);
    }

    private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void загрузитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void вФорматеJPGToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadImage(true);
    }

    private void вФорматеPNGToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadImage(false);
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }
  }
}
