using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MergingData
{
    public partial class Form1 : Form
    {
        DialogResult resultInput = DialogResult.None;
        DialogResult resultOnput = DialogResult.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInputDirectory_Click(object sender, EventArgs e)
        {
            resultInput = fbdInput.ShowDialog();
            try 
            {
                if (resultInput == DialogResult.OK)
                {
                    tbxInputDirectory.Text = fbdInput.SelectedPath;
                }
            }  
            catch (Exception exp)
            {
                MessageBox.Show("错误的路径");
            }
        }

        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            DialogResult resultOutput = fbdOutput.ShowDialog();

            try
            {
                if (resultOutput == DialogResult.OK)
                {
                    tbxOutputDirectory.Text = fbdOutput.SelectedPath;
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("错误的路径");
            }
        }

        private void btnMerginData_Click(object sender, EventArgs e)
        {
            if (tbxInputDirectory.Text != "" && tbxOutputDirectory.Text != "" && Directory.Exists(tbxInputDirectory.Text) && Directory.Exists(tbxOutputDirectory.Text))
            {
                ApplicationClass app = new ApplicationClass();
                Workbook book = null;
                Worksheet sheet = null;
                Range range = null;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                Dictionary<string, object> outdic = new Dictionary<string, object>();

                //File file = null;
                string[] filename = null;

                //object[,] values = null;

                try
                {
                    app.Visible = false;
                    app.ScreenUpdating = false;
                    app.DisplayAlerts = false;

                    //string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    //filename = Directory.GetFiles(execPath.Substring(6), "*.xls");
                    filename = Directory.GetFiles(tbxInputDirectory.Text, "*.xls");
                    //Array.Sort(filename);

                    ArrayList al = new ArrayList();

                    foreach (string f in filename)
                    {
                        Console.WriteLine(f.ToString());
                        book = app.Workbooks.Open(f,
                              Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                              Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                              Missing.Value, Missing.Value, Missing.Value, Missing.Value);

                        sheet = (Worksheet)book.Worksheets[1];
                        range = sheet.get_Range("A32", "B132");
                        object[,] values = (object[,])range.Value2;
                        //values = (object[,])range.Value2;

                        Console.WriteLine("Row Count: " + values.GetLength(0).ToString());
                        Console.WriteLine("Col Count: " + values.GetLength(1).ToString());

                        Console.Write("\t");
                        for (int j = 1; j <= values.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", j);
                        }

                        #region test
                        Console.WriteLine();
                        for (int i = 1; i <= values.GetLength(0); i++)
                        {
                            Console.Write("{0}\t", i);

                            string dicKey = "";
                            string dicValue = "";
                            for (int j = 1; j <= values.GetLength(1); j++)
                            {
                                switch (j)
                                {
                                    case 1:
                                        dicKey = values[i, j].ToString();
                                        break;
                                    case 2:
                                        dicValue = values[i, j].ToString();
                                        break;
                                }
                                Console.Write("{0}\t", values[i, j]);
                            }
                            dic.Add(dicKey, dicValue);
                            dicKey = dicValue = "";
                            Console.WriteLine();
                        #endregion test
                        }
                        Console.WriteLine("---------------------------------");

                        al.Clear();
                        al.Add(210);
                        al.Add(222);
                        al.Add(228);
                        al.Add(254);
                        al.Add(260);
                        al.Add(280);
                        al.Add(296);
                        for (int i = 0; i != al.Count; i++)
                        {
                            Console.WriteLine("{0}\t{1}", al[i], dic[al[i].ToString()]);
                        }

                        outdic.Add(f.Split('\\')[f.Split('\\').Length - 1], dic);
                        dic = new Dictionary<string, string>();
                        // dic.Clear()  cannot using this method.
                    }
                    Workbook outbooks = app.Workbooks.Add(Missing.Value);
                    Worksheet outsheet = (Worksheet)outbooks.Worksheets[1];

                    string[,] insvalue = new string[outdic.Count, 1];
                    string[,] inscvalue = new string[outdic.Count, al.Count];
                    for (int i = 0; i != outdic.Count; i++)
                    {
                        //insvalue[i, 0] = outdic.Keys[i];
                    }

                    int c = 0;
                    // int d = 0;
                    foreach (KeyValuePair<string, object> d in outdic)
                    {
                        // Console.WriteLine(d.Key.ToString() + d.Value.ToString());
                        insvalue[c, 0] = d.Key;
                        c++;
                        //Console.WriteLine(c + d.Key);
                    }

                    outsheet.get_Range("A1", "A" + filename.Length).set_Value(XlRangeValueDataType.xlRangeValueDefault, insvalue);

                    Array.Clear(insvalue, 0, insvalue.Length);
                    Console.WriteLine("1111111111111111111");

                    int row = 0;
                    foreach (KeyValuePair<string, object> p in outdic)
                    {
                        // Console.WriteLine(d.Key.ToString() + d.Value.ToString());

                        //foreach (KeyValuePair<string, string> bb in (Dictionary<string, string>)outdic[d.Key])
                        //{
                        //    //Console.WriteLine(c + "\t" + bb.Key);
                        //    // Console.WriteLine("{0}\t{1}", al[i], dic[al[i].ToString()]);
                        //    inscvalue[0, d] = bb[]
                        //    //for (int i = 0; i != al.Count; i++)
                        //    //{
                        //    //    Console.WriteLine("{0}\t{1}", al[i], bb[al[i].ToString()]);
                        //    //}
                        //}
                        Dictionary<string, string> dddd = (Dictionary<string, string>)p.Value;
                        // Console.WriteLine(dddd["300"]);
                        //for (int i = 0; i != outdic.Count; i++)
                        //{
                        for (int j = 0; j != al.Count; j++)
                        {
                            Console.WriteLine("---->   {0}\t{1}", al[j], dddd[al[j].ToString()]);
                            inscvalue[row, j] = dddd[al[j].ToString()];
                        }
                        row++;
                        //}
                        outsheet.get_Range("B1", "H" + filename.Length).set_Value(XlRangeValueDataType.xlRangeValueDefault, inscvalue);
                    }


                    //outbooks.Save();
                    outbooks.SaveAs(tbxOutputDirectory.Text + "\\Output.xls",
                                    Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value,
                                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
                finally
                {
                    range = null;
                    sheet = null;
                    if (book != null)
                        book.Close(false, Missing.Value, Missing.Value);
                    book = null;
                    if (app != null)
                        app.Quit();
                    app = null;
                }
            }
            else
            {
                MessageBox.Show("请输入正确的文件夹路径");
            }
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 12");
        }
    }
}
