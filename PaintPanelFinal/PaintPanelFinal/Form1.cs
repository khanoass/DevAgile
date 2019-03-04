using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintPanelFinal
{
    public partial class Form1 : Form
    {
        private bool Brush = true;

        private Shapes DrawingShapes = new Shapes();

        private bool IsPainting = false;                
        private bool IsEraseing = false;

        private Point LastPos = new Point(0, 0);

        private Color CurrentColour = Color.Black;

        private float CurrentWidth = 10;                
        private int ShapeNum = 0;             
        
        private Point MouseLoc = new Point(0, 0);                               
        

        /// <summary>
        /// constructeur de form 1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            pnlDrawZone.GetType().GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(pnlDrawZone, new object[] { System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.DoubleBuffer, true });

        }
        /// <summary>
        /// désssine quand le curseur de la souris est au dessous du controle et que le bouton est appuyer  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDrawZone_MouseDown(object sender, MouseEventArgs e)
        {
            //si brush retourne true
            if (Brush)
            {
                
                IsPainting = true;
                ShapeNum++;
                LastPos = new Point(0, 0);
            }
            
            else
            {
                IsEraseing = true;
            }
        }
        /// <summary>
        /// desssine quand la souris bouge 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDrawZone_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLoc = e.Location;
            //si il est en option désinné
            if (IsPainting)
            {
                //si l'actuelle position est différentes que l'ancienne 
                if (LastPos != e.Location)
                {
                    //récupère sa position
                    LastPos = e.Location;
                    //déssine une nouvel form en appelant NewShape
                    DrawingShapes.NewShape(LastPos, CurrentWidth, CurrentColour, ShapeNum);
                }
            }
            if (IsEraseing)
            {
                //efface la forme en appelant la methode RemoveShape 
                DrawingShapes.RemoveShape(e.Location, CurrentWidth);
            }
            //redessine le controle
            pnlDrawZone.Refresh();
        }
        /// <summary>
        /// quand le curseur de la souris est au dessous du controle et que le bouton n'est pas appuyer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDrawZone_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsPainting)
            {
                IsPainting = false;
            }
            if (IsEraseing)
            {
                IsEraseing = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDrawZone_Paint(object sender, PaintEventArgs e)
        {
            //donne un style
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //Déssine
            for (int i = 0; i < DrawingShapes.NumberOfShapes() - 1; i++)
            {
                //récupère l
                Shape T = DrawingShapes.GetShape(i);
                Shape T1 = DrawingShapes.GetShape(i + 1);


                if (T.ShapeNumber == T1.ShapeNumber)
                {
                    Pen p = new Pen(T.Colour, T.Width);

                    p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    e.Graphics.DrawLine(p, T.Location, T1.Location);

                    p.Dispose();
                }
            }
           
            
        }

        private void btnSwitchGD_Click(object sender, EventArgs e)
        {
            Brush = !Brush;
            if (Brush == true)
            {
                btnSwitchGD.Text="Gommer";
            }
            else
            {
                btnSwitchGD.Text = "Dessiner";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DrawingShapes = new Shapes();
            pnlDrawZone.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                CurrentColour = colorDialog1.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Change the width of the pen. Oh and convert it to a float
            CurrentWidth = Convert.ToSingle(numericUpDown1.Value);
        }
    }
}
