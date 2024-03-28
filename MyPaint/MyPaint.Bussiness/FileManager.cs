using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using MyPaint.Bussiness;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace MyPaint.Bussiness
{
    public class FileManager
    {
        public static bool SaveDrawingAsBitmap(PictureBox pictureBox)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Imagini BMP (*.bmp)|*.bmp|Toate fișierele (*.*)|*.*";
                saveFileDialog.Title = "Save the file as BMP";
                saveFileDialog.FileName = "drawing.bmp"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                        pictureBox.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, pictureBox.Width, pictureBox.Height));

                        bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("The drawing was successfully saved in " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public static bool SaveInJsonFormat(List<Shape> shapes)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Fișiere JSON (*.json)|*.json|Toate fișierele (*.*)|*.*"
;
                saveFileDialog.Title = "Save the json file";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {

                        string json = JsonConvert.SerializeObject(shapes, new JsonSerializerSettings
                        {
                            TypeNameHandling = TypeNameHandling.All 
                        });

                        File.WriteAllText(filePath, json);  

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to save the file: " + ex.Message);
                    }
                }
            }
            return false;
        }


        public static Bitmap OpenImageFromFile()
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a file";
                openFileDialog.Filter = "Imagini (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|Toate fișierele (*.*)|*.*";

                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(openFileDialog.FileName);

                        return bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open the file: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return null;
            }
        }
        public static List<Shape> OpenDrawingFromJson()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fișiere JSON (*.json)|*.json|Toate fișierele (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string json = File.ReadAllText(openFileDialog.FileName);

                        List<Shape> shapesList = JsonConvert.DeserializeObject<List<Shape>>(json, new JsonSerializerSettings
                        {
                            TypeNameHandling = TypeNameHandling.All 
                        });

                        return shapesList;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open JSON file: " + ex.Message);
                    }
                }
                return null;
            }
        }
    }
}
