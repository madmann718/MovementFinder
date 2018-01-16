using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
using Aurigma.GraphicsMill;


namespace MovementFinder
{
    public partial class Form1 : Form
    {
        //Some field declarations
        private string largeFileName = "";
        
        private Aurigma.GraphicsMill.Bitmap analyzeBitmap;

        //private System.Drawing.Bitmap movementBitmap = new System.Drawing.Bitmap(Properties.Resources.movement);

        private string[] inputFiles;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            largePicBox.Visible = false;
            outputMessage.Text = "";
        }

        private void LinkLarge_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outputMessage.Text = "";

            //Get a file
            fileDialog.FileName = "";
            fileDialog.Title = "Select main image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                largeFileName = fileDialog.FileName.ToString();
                largeLabel.Text = largeFileName;
                largePicBox.Image = System.Drawing.Image.FromFile(largeFileName);
                largePicBox.Visible = true;
            }

            //Get an area of interest
            Aurigma.GraphicsMill.Bitmap wholeBitmap = new Aurigma.GraphicsMill.Bitmap(largeFileName);
            testPicBox.Image = (System.Drawing.Image)wholeBitmap;
            Aurigma.GraphicsMill.Bitmap bitmap = new Aurigma.GraphicsMill.Bitmap(MovementDetection.FindAreaOfInterest(wholeBitmap));

            //Process area of interest bitmap into B&W we can analyze
            Aurigma.GraphicsMill.Bitmap processedBitmap = MovementDetection.GreyscaleAndThreshold(bitmap);

            //Have to turn it back into 24-bit or the pattern matching won't work
            processedBitmap.ColorManagement.Convert(Aurigma.GraphicsMill.PixelFormat.Format24bppRgb);


            //Store it in global 
            analyzeBitmap = new Aurigma.GraphicsMill.Bitmap(processedBitmap);

            //Update GUI image
            largePicBox.Image = (System.Drawing.Image)processedBitmap;

            Compare();
        }

        private void Compare()
        {
            outputMessage.Text = "";

            //FileLoc overload
            //bool verdict = MovementDetection.CheckForMovement(@"C:\Users\Brian\Desktop\Movement Examples\0709_09_MOVEMENT_EXAMPLE.jpg");

            //Bitmap overload
            //bool verdict = MovementDetection.CheckForMovement(largeImage);

            //Aurigma overload
            Aurigma.GraphicsMill.Bitmap aurigmaBitmap = new Aurigma.GraphicsMill.Bitmap(analyzeBitmap);
            bool verdict = MovementDetection.CheckForMovement(aurigmaBitmap);

            AnnounceVerdict(verdict);
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
        }

        private void AnnounceVerdict(bool verdict)
        {
            if (verdict)
            {
                ShowStatus("Movement Found!");
            }

        else
            {
                ShowStatus("Movement Not Found.");
            }
        }

        private void ShowStatus(string status)
        {
            outputMessage.Text = status;
            outputMessage.Invalidate();
            outputMessage.Update();
            outputMessage.Refresh();
        }

        private void folderLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "";

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<string> badFiles = MovementDetection.CheckFolderForMovement(folderDialog.SelectedPath);

                message = "Movement found in\n";
                foreach (var badFile in badFiles)
                {
                    message += badFile + "\n";
                }

                MessageBox.Show(message);
            }

        }
    }
}

