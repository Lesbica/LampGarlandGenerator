using Flyweight;
using System;

namespace LampGarlandGenerator
{
    public partial class Form1 : Form
    {
        private GarlandGenerator garlandGenerator = new GarlandGenerator();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            garlandGenerator.AddLampType("RedLamp", "Photos/RedLamp.jpg");
            garlandGenerator.AddLampType("GreenLamp", "Photos/GreenLamp.jpg");
            garlandGenerator.AddLampType("BlueLamp", "Photos/BlueLamp.jpg");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Size lampSize = new Size(50, 50);

            foreach (var lamp in garlandGenerator.GetLamps())
            {
                Rectangle destinationRect = new Rectangle(lamp.Location, lampSize);

                e.Graphics.DrawImage(lamp.Type.Photo, destinationRect);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Point randomLocation = new Point(random.Next(0, Width - 50), random.Next(0, Height - 50));

            string[] availableLampTypes = { "RedLamp", "GreenLamp", "BlueLamp" };
            string randomLampType = availableLampTypes[random.Next(availableLampTypes.Length)];

            garlandGenerator.GenerateLamp(randomLocation, randomLampType);
            Refresh();
        }
    }
}