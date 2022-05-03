using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tempPanelProject
{
    internal class CustomPanel : Panel
    {
        Panel panel;
        Label productName;
        Label productDescription;
        Label productInfo;
        PictureBox image;
        Form currentForm;
        TableLayoutPanel markupPanel;
        static int exampleNumb = 0;
        public CustomPanel(Form katForm)
        {
            currentForm = katForm;
            //exampleNumb++;
        }

        public void Create(TableLayoutPanel pan, int panelValue)
        {
            int temp = 0;
            for(int i=0; i<panelValue; i++)
            {
                panel = new Panel();
                panel.Size = new Size(400, 200);
                panel.Dock = DockStyle.Fill;
                //panel.Location = new Point(10, 10+210*exampleNumb);
                panel.BackColor = SystemColors.ControlDark;
                pan.Controls.Add(panel, 1, 0 + exampleNumb++);
                //pan.Controls.Add(panel);

                markupPanel = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    RowCount = 2,
                    BackColor = SystemColors.ControlLight,
                    ColumnCount = 2,
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
                };
                panel.Controls.Add(markupPanel);

                productName = new Label();
                productName.Size = new Size(60, 30);
                //productName.Location = new Point(10, 40);
                productName.BackColor = SystemColors.Control;
                productName.Dock = DockStyle.Fill;
                productName.Text = "ProductName";
                markupPanel.Controls.Add(productName, 1, 0);

                productDescription = new Label();
                productDescription.Size = new Size(60, 30);
                //productDescription.Location = new Point(10, 80);
                productDescription.BackColor = SystemColors.Control;
                productDescription.Dock = DockStyle.Fill;
                productDescription.Text = "ProductDescription";
                markupPanel.Controls.Add(productDescription, 1, 1);

                image = new PictureBox();
                image.Size = new Size(70, 70);
                image.Dock = DockStyle.Fill;
                image.Image = Image.FromFile(@"test.jpg");
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                markupPanel.Controls.Add(image, 0, 0);

                productInfo = new Label();
                productInfo.Size = new Size(60, 30);
                productInfo.Dock = DockStyle.Fill;
                productInfo.Text = "ProductInfo";
                productInfo.BackColor = SystemColors.Control;
                markupPanel.Controls.Add(productInfo, 0, 1);

            }
        }

        public bool Fill()
        {
            return true;
        }
    }
}
