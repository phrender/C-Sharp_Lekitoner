using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsGraphics_uppgift_2
{
    public partial class Form1 : Form
    {
        bool bTopLaneDrive = true;
        bool bBottomLaneDrive = false;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);

            // Draw roads
            brush.Color = Color.Black;
            DrawRoad(brush, g, (ClientRectangle.Width / 2) - 30, 0, 60, 400); // from the top
            DrawRoad(brush, g, 0, (ClientRectangle.Height / 2) - 30, 400, 60); // From the left

            // Draw road marks
            brush.Color = Color.White;
            DrawRoadMarksX(brush, g, (ClientRectangle.Width / 2) - 5, 0, 5, 20, 10); // From the top
            DrawRoadMarksY(brush, g, 0, (ClientRectangle.Height / 2) - 5, 20, 5, 10); // From the left

            // Draw traficlight backgrounds
            brush.Color = Color.Black;
            DrawTraficLights(brush, g, 130, 70, 25, 75); // Top left
            DrawTraficLights(brush, g, 230, 120, 75, 25); // Bottom right
            DrawTraficLights(brush, g, 80, 220, 75, 25); // top right
            DrawTraficLights(brush, g, 230, 220, 25, 75); // bottom left

            #region Top lanes
            if (bTopLaneDrive)
            {
                #region Green lights
                brush.Color = Color.Green;
                DrawLightBulb(brush, g, 132, 75, 20); // Green bulb
                DrawLightBulb(brush, g, 232, 270, 20); // Green bulb
                #endregion
            }

            /*
            #region Yellow lights
            brush.Color = Color.Yellow;
            DrawLightBulb(brush, g, 132, 97, 20); // Yellow bulb
            DrawLightBulb(brush, g, 232, 247, 20); // Yellow bulb
            #endregion
            */

            if (!bTopLaneDrive)
            {
                #region Red lights
                brush.Color = Color.Red;
                DrawLightBulb(brush, g, 132, 120, 20); // Red bulb
                DrawLightBulb(brush, g, 232, 225, 20); // Red bulb
                #endregion
            }

            #endregion

            #region Side lanes

            if (bBottomLaneDrive)
            {
                #region Green lights
                brush.Color = Color.Green;
                DrawLightBulb(brush, g, 282, 122, 20); // Green bulb
                DrawLightBulb(brush, g, 82, 222, 20); // Green bulb
                #endregion
            }

            /*
            #region Yellow lights
            brush.Color = Color.Yellow;
            DrawLightBulb(brush, g, 257, 122, 20); // Yellow bulb
            DrawLightBulb(brush, g, 105, 222, 20); // Yellow bulb
            #endregion
            */

            if (!bBottomLaneDrive)
            {
                #region Red lights
                brush.Color = Color.Red;
                DrawLightBulb(brush, g, 232, 122, 20); // Red bulb
                DrawLightBulb(brush, g, 130, 222, 20); // Red bulb
                #endregion
            }

            #endregion

        }

        private void DrawRoad(Brush brush, Graphics graphic, int iStartX, int iStartY, int iRoadWidth, int iRoadLength)
        {
            graphic.FillRectangle(brush, iStartX, iStartY, iRoadWidth, iRoadLength);
        }

        private void DrawRoadMarksX(Brush brush, Graphics graphic, int iStartX, int iStartY, int iMarkWidth, int iMarkLength, int iRepetition)
        {
            for (int i = 0; i < iRepetition; i++)
            {
                graphic.FillRectangle(brush, iStartX, iStartY, iMarkWidth, iMarkLength);
                iStartY += 50;
            }
        }

        private void DrawRoadMarksY(Brush brush, Graphics graphic, int iStartX, int iStartY, int iMarkWidth, int iMarkLength, int iRepetition)
        {
            for (int i = 0; i < iRepetition; i++)
            {
                graphic.FillRectangle(brush, iStartX, iStartY, iMarkWidth, iMarkLength);
                iStartX += 50;
            }
        }

        private void DrawTraficLights(Brush brush, Graphics graphic, int iStartX, int iStartY, int iPanelWidth, int iPanelHeight)
        {
            graphic.FillRectangle(brush, iStartX, iStartY, iPanelWidth, iPanelHeight);
        }

        private void DrawLightBulb(Brush brush, Graphics graphic, int iStartX, int iStartY, int iBulbDiameter)
        {
            graphic.FillEllipse(brush, iStartX, iStartY, iBulbDiameter, iBulbDiameter);
        }

        private void btnTopLaneDrive_Click(object sender, EventArgs e)
        {
            bTopLaneDrive = true;
            bBottomLaneDrive = false;
            Invalidate();
        }

        private void btnBottomLane_Click(object sender, EventArgs e)
        {
            bBottomLaneDrive = true;
            bTopLaneDrive = false;
            Invalidate();
        }
    }
}
