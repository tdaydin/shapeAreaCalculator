using ShapeAreaCalculator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeAreaCalculator
{
    public partial class lRadius : Form
    {
        double _radius = 0;
        double _height = 0;
        double _width = 0;
        double _side = 0;
        double _length = 0;

        public lRadius()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] types = new string[5]
            {
                "Square",
                "Rectangle",
                "Circle",
                "Right Angle Triangle",
                "Triangle"
            };

            cbChoose.Items.AddRange(types);

            tbRadius.Enabled = false;
            tbHeight.Enabled = false;
            tbWidth.Enabled = false;
            tbSide.Enabled = false;
            tbLength.Enabled = false;
            bCalculate.Enabled = false;
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            bCalculate.Enabled = true;
            if (cbChoose.Text == "Circle")
            {
                tbRadius.Enabled = true;
                tbHeight.Enabled = false;
                tbWidth.Enabled = false;
                tbSide.Enabled = false;
                tbLength.Enabled = false;
            }
            else if (cbChoose.Text == "Square")
            {
                tbSide.Enabled = true;
                tbHeight.Enabled = false;
                tbWidth.Enabled = false;
                tbRadius.Enabled = false;
                tbLength.Enabled = false;
            }
            else if (cbChoose.Text == "Rectangle")
            {
                tbWidth.Enabled = true;
                tbHeight.Enabled = true;
                tbSide.Enabled = false;
                tbRadius.Enabled = false;
                tbLength.Enabled = false;
            }
            else if (cbChoose.Text == "Right Angle Triangle")
            {
                tbLength.Enabled = true;
                tbHeight.Enabled = true;
                tbWidth.Enabled = false;
                tbRadius.Enabled = false;
                tbSide.Enabled = false;
            }
            else if (cbChoose.Text == "Triangle")
            {
                tbLength.Enabled = true;
                tbHeight.Enabled = false;
                tbWidth.Enabled = false;
                tbRadius.Enabled = false;
                tbSide.Enabled = false;
            }

            lbAnswer.Items.Clear();
            tbHeight.Clear();
            tbWidth.Clear();
            tbLength.Clear();
            tbRadius.Clear();
            tbSide.Clear();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (cbChoose.Text == "Circle")
            {
                lbAnswer.Items.Clear();
                _radius = Convert.ToInt32(tbRadius.Text);
                Circle circle = new Circle() { Radius = _radius };
                lbAnswer.Items.Add("Circle Area with radius " + _radius + " is: " + circle.CalculateArea());
                lbAnswer.Items.Add("Circle circumference with radius " + _radius + " is: " + circle.CalculateCircumference());
            }

            else if (cbChoose.Text == "Square")
            {
                lbAnswer.Items.Clear();
                _side = Convert.ToInt32(tbSide.Text);
                Square square = new Square() {Side = _side };
                lbAnswer.Items.Add("Square Area with radius " + _side + " is: " + square.CalculateArea());
                lbAnswer.Items.Add("Square circumference with radius " + _side + " is: " + square.CalculateCircumference());

 
            }

            else if (cbChoose.Text == "Rectangle")
            {
                lbAnswer.Items.Clear();
                _height = Convert.ToInt32(tbHeight.Text);
                _width = Convert.ToInt32(tbWidth.Text);
                RectangleShape rectangleShape = new RectangleShape() { Height = _height, Width = _width };
                lbAnswer.Items.Add("Rectangle Area with radius is: " + rectangleShape.CalculateArea());
                lbAnswer.Items.Add("Rectangle circumference with radius is: " + rectangleShape.CalculateCircumference());
            }

            else if (cbChoose.Text == "Right Angle Triangle")
            {
                lbAnswer.Items.Clear();
                _height = Convert.ToInt32(tbHeight.Text);
                _length = Convert.ToInt32(tbLength.Text);
                RightAngleTriangle rightAngleTriangle = new RightAngleTriangle() { Height = _height, Length = _length };
                lbAnswer.Items.Add("Right Angle Triangle area with radius is: " + rightAngleTriangle.CalculateArea());
                lbAnswer.Items.Add("Right Angle Triangle circumference with radius is: " + rightAngleTriangle.CalculateCircumference());
            }
            else
            {
                lbAnswer.Items.Clear();
                _length = Convert.ToInt32(tbLength.Text);
                TriangleShape triangleShape = new TriangleShape() { Length = _length };
                lbAnswer.Items.Add("Triangle area with radius is: " + triangleShape.CalculateArea());
                lbAnswer.Items.Add("Triangle circumference with radius is: " + triangleShape.CalculateCircumference());
            }



        }

       
    }
}
