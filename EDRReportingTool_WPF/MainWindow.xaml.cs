using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using LiveCharts;
using LiveCharts.Wpf;
namespace EDRReportingTool_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global variable
        EDIDConfigTable_tst[] EDIDConfigTable_ast;
        int CurPrjName_s16 = 0;
        int CurRepType_s16 = 0;
        string newline = Environment.NewLine;
        string noEDID = "No EDID";
        string space = " ";
        public MainWindow()
        {
            InitializeComponent();
            FormLoad();
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4,2,7,2,27 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June" };
            //YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart
            SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                //PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            SeriesCollection[3].Values.Add(5d);





            DataContext = this;
        }

        public class DataGridView {
            public string EDID { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
            public string Length { get; set; }
            public string RecordingSection { get; set; }
            //public string Unit { get; set; }

        }
        
        public void FormLoad()
        {
            CbbPrjLoad();
            CbbTypeLoad();
        }
        public void CbbPrjLoad()
        {
            cbbProject.Items.Add("CNMS before C13.6.4");
            cbbProject.Items.Add("CNMS from C13.6.4");
            cbbProject.Items.Add("SGMW/Geely 6 data with 121 bytes sensor");
            cbbProject.Items.Add("CNMS from C15");
            cbbProject.Items.Add("GWM Feature");
            cbbProject.Items.Add("GWM with EPP/RO");
            cbbProject.Items.Add("GWM Full");
            cbbProject.Items.Add("TMC B4");
            cbbProject.Items.Add("TMC B5");
            cbbProject.Items.Add("HRYT");
        }
        public void CbbTypeLoad()
        {
            cbbType.Items.Add("Production Diagnostic");
            cbbType.Items.Add("Customer Diagnostic");
            cbbType.SelectedIndex = 0;    
        }
        void CbbProjectSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbProject.SelectedItem.ToString())
            {
                case "CNMS before C13.6.4":
                    CurPrjName_s16 = (int)projectName_ten.CNMSBfC13_en;
                    break;
                case "CNMS from C13.6.4":
                    CurPrjName_s16 = (int)projectName_ten.CNMSAfC13_en;
                    break;
                case "SGMW/Geely 6 data with 121 bytes sensor":
                    CurPrjName_s16 = (int)projectName_ten.SGMWGeely121Bytes_en;
                    break;
                case "CNMS from C15":
                    CurPrjName_s16 = (int)projectName_ten.CNMSAfC15_en;
                    //MessageBox.Show("This feature will be supported later! Not available now");
                    break;
                case "GWM Feature":
                    CurPrjName_s16 = (int)projectName_ten.GWMFeature;
                    break;
                case "GWM with EPP/RO":
                    CurPrjName_s16 = (int)projectName_ten.GWMFeatureWithEppRo;
                    break;
                case "GWM Full":
                    CurPrjName_s16 = (int)projectName_ten.GWMFull_en;
                    break;
                case "TMC B5":
                    CurPrjName_s16 = (int)projectName_ten.TMCB5_en;
                    break;
                case "TMC B4":
                    CurPrjName_s16 = (int)projectName_ten.TMCB4_en;
                    break;
                case "HRYT":
                    CurPrjName_s16 = (int)projectName_ten.HRYT_en;
                    break;
                default:
                    break;
            }
        }
        void CbbTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbType.SelectedItem.ToString())
            {
                case "Customer Diagnostic":
                    CurRepType_s16 = (int)reportType_ten.CD_en;
                    ckbCDCustReport.IsEnabled = true;
                    break;
                case "Production Diagnostic":
                    CurRepType_s16 = (int)reportType_ten.PD_en;
                    ckbCDCustReport.IsEnabled = false;
                    break;
                default:
                    break;
            }
        }
        public string[] ReadTxt()
        {
            string TextIn_str = "";
            var Bytes_ab = System.IO.File.ReadAllBytes(@txtPath.Text);
            char[] HexChars_achar = "0123456789ABCDEF".ToCharArray();
            char MSB_char, LSB_char;
            for (int i = 0; i < Bytes_ab.Length; i++)
            {
                byte Byte_b = Bytes_ab[i];
                MSB_char = HexChars_achar[(Byte_b >> 4) & 0x0F];
                LSB_char = HexChars_achar[Byte_b & 0xF];
                TextIn_str += MSB_char;
                TextIn_str += LSB_char;
                TextIn_str += newline;  
            }
            return TextIn_str.Split('\n');
        }
        public string[] ReadXML()
        {
            string textIn = "";
            XmlTextReader xtr = new XmlTextReader(@txtPath.Text);
            while (xtr.Read())
            {

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "payload_value")
                {
                    textIn += xtr.ReadElementString();
                }
            }
            return textIn.Split('\n');
        }
        public int LengthOfByte(EDIDConfigTable_tst[] CurEDIDConfigTable_ast, int CurSupportReport_s16)
        {
            int SumOfLength_s16 = 0;
            for (int i = 0; i < CurEDIDConfigTable_ast.Length; i++)
            {
                if ((int)CurEDIDConfigTable_ast[i].SupportReport_en <= CurSupportReport_s16)
                    SumOfLength_s16 += CurEDIDConfigTable_ast[i].DataSamples_u16 * CurEDIDConfigTable_ast[i].BytesPerDataSample_u16;
            }
            return SumOfLength_s16;
        }
        public void ReportHanling_PD(EDIDConfigTable_tst[] CurEDIDConfigTable_ast)
        {
            //Is XML file?
            if (txtPath.Text.Substring(txtPath.Text.Length - 3, 3) == "xml")
            {
                //read XML file
                string[] DataInput_astr = ReadXML();
                UInt16 IndexDecodeData_u16 = 4;
                UInt16 LengthOfData_u16 = (UInt16)CurEDIDConfigTable_ast.Length;
                List<DataGridView> DataGridViewSample = new List<DataGridView>();
                for (UInt16 IndexOfData_u16 = 0; IndexOfData_u16 < LengthOfData_u16; IndexOfData_u16++)
                {
                    UInt16 DataLength_u16 = (UInt16)(CurEDIDConfigTable_ast[IndexOfData_u16].DataSamples_u16 * CurEDIDConfigTable_ast[IndexOfData_u16].BytesPerDataSample_u16);
                    string EDID_str = CurEDIDConfigTable_ast[IndexOfData_u16].EDID_str;
                    string Name_str = CurEDIDConfigTable_ast[IndexOfData_u16].DataElement_str;
                    string Length_str = DataLength_u16.ToString();
                    string Unit_str = CurEDIDConfigTable_ast[IndexOfData_u16].Unit_str;
                    string RecordingSection_str = CurEDIDConfigTable_ast[IndexOfData_u16].RecordingSection_str;
                    string Value_str = "";
                    
                    try
                    {
                        //Bosch Data don't have EDID
                        if (((int)CurEDIDConfigTable_ast[IndexOfData_u16].SupportReport_en != (int)SupportReport_ten.BoschData_en) || (CurEDIDConfigTable_ast[IndexOfData_u16].EDID_str == "5000"))
                            IndexDecodeData_u16 += 2;

                        //Map value
                        for (UInt16 IndexEachData_u16 = 0; IndexEachData_u16 < DataLength_u16; IndexEachData_u16++)
                        {
                            if (IndexDecodeData_u16 < DataInput_astr.Length)
                            {
                                Value_str = Value_str + DataInput_astr[IndexDecodeData_u16].Substring(0, 2) + space;
                                if (((IndexEachData_u16 + 1) % 16 == 0) && (IndexEachData_u16 != DataLength_u16 - 1))
                                {
                                    Value_str += newline;
                                }
                                IndexDecodeData_u16++;
                            }
                            else
                            {
                                IndexOfData_u16 = LengthOfData_u16;
                            }
                        }

                        DataGridViewSample.Add(new DataGridView() { EDID = EDID_str, Name = Name_str, Length = Length_str, Value = Value_str, RecordingSection = RecordingSection_str });

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Length is not match. Please check the input");
                        //MessageBox.Show("Fail at:"+dataName[indexOfData].ToString());
                    }
                }
                dataGridView1.ItemsSource = DataGridViewSample;
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(dataGridView1.ItemsSource);
                view.Filter = UserFilter;
                int Length_s16 = LengthOfByte(CurEDIDConfigTable_ast, (int)SupportReport_ten.BoschData_en);

            }
            else
            {
                MessageBox.Show("Please add xml file");
            }
        }

        public void ReportHanling_CD(EDIDConfigTable_tst[] CurEDIDConfigTable_ast)
        {
            if (txtPath.Text.Substring(txtPath.Text.Length - 3, 3) == "txt")
            {
                string[] DataInput_astr = ReadTxt();
                UInt16 IndexDecodeData_u16 = 0;
                for (int i = 0; i < DataInput_astr.Length; i++)
                {
                    if (DataInput_astr[i].Substring(0, 2) == "62")
                    {
                        IndexDecodeData_u16 = (UInt16)(i + 3);
                        break;
                    }
                }
                UInt16 LengthOfData_u16 = (UInt16)CurEDIDConfigTable_ast.Length;
                for (UInt16 IndexOfData_u16 = 0; IndexOfData_u16 < LengthOfData_u16; IndexOfData_u16++)
                {
                    //FA XX and FB XX report
                    if (CurEDIDConfigTable_ast[IndexOfData_u16].SupportReport_en == SupportReport_ten.CNEDRData_en)
                    {
                        UInt16 DataLength_u16 = (UInt16)(CurEDIDConfigTable_ast[IndexOfData_u16].DataSamples_u16 * CurEDIDConfigTable_ast[IndexOfData_u16].BytesPerDataSample_u16);
                        string EDID_str = CurEDIDConfigTable_ast[IndexOfData_u16].EDID_str;
                        string Name_str = CurEDIDConfigTable_ast[IndexOfData_u16].DataElement_str;
                        string Length_str = DataLength_u16.ToString();
                        string Unit_str = CurEDIDConfigTable_ast[IndexOfData_u16].Unit_str;
                        string Value_str = "";

                        try
                        {
                            for (UInt16 IndexEachData_u16 = 0; IndexEachData_u16 < DataLength_u16; IndexEachData_u16++)
                            {
                                if (IndexDecodeData_u16 < DataInput_astr.Length)
                                {
                                    Value_str = Value_str + DataInput_astr[IndexDecodeData_u16].Substring(0, 2) + space;
                                    if (((IndexEachData_u16 + 1) % 16 == 0) && (IndexEachData_u16 != DataLength_u16 - 1))
                                    {
                                        Value_str += newline;
                                    }
                                    IndexDecodeData_u16++;
                                }
                                else
                                {
                                    IndexOfData_u16 = LengthOfData_u16;
                                }
                            }

                            string[] strRow = { EDID_str, Name_str, Value_str, Length_str };
                            //dataGridView1.Rows.Add(strRow);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Length is not match. Please check the input");
                            //MessageBox.Show("Fail at:"+dataName[indexOfData].ToString());
                        }
                    }
                    //FB XX report only
                    if ((CurEDIDConfigTable_ast[IndexOfData_u16].SupportReport_en == SupportReport_ten.CustData_en) && (ckbCDCustReport.IsChecked == true))
                    {
                        UInt16 DataLength_u16 = (UInt16)(CurEDIDConfigTable_ast[IndexOfData_u16].DataSamples_u16 * CurEDIDConfigTable_ast[IndexOfData_u16].BytesPerDataSample_u16);
                        string EDID_str = CurEDIDConfigTable_ast[IndexOfData_u16].EDID_str;
                        string Name_str = CurEDIDConfigTable_ast[IndexOfData_u16].DataElement_str;
                        string Length_str = DataLength_u16.ToString();
                        string Unit_str = CurEDIDConfigTable_ast[IndexOfData_u16].Unit_str;
                        string Value_str = "";

                        try
                        {
                            for (UInt16 IndexEachData_u16 = 0; IndexEachData_u16 < DataLength_u16; IndexEachData_u16++)
                            {
                                if (IndexDecodeData_u16 < DataInput_astr.Length)
                                {
                                    Value_str = Value_str + DataInput_astr[IndexDecodeData_u16].Substring(0, 2) + space;
                                    if (((IndexEachData_u16 + 1) % 16 == 0) && (IndexEachData_u16 != DataLength_u16 - 1))
                                    {
                                        Value_str += newline;
                                    }
                                    IndexDecodeData_u16++;
                                }
                                else
                                {
                                    IndexOfData_u16 = LengthOfData_u16;
                                }
                            }

                            string[] strRow = { EDID_str, Name_str, Value_str, Length_str };
                            //dataGridView1.Rows.Add(strRow);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Length is not match. Please check the input");
                            //MessageBox.Show("Fail at:"+dataName[indexOfData].ToString());
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please add txt file");
            }
        }
        public void LoadInput(int prjName, int repType)
        {
            bool isEDID_b = (repType == (int)reportType_ten.PD_en) ? true : false;
            switch (prjName)
            {
                case (int)projectName_ten.CNMSBfC13_en:
                    break;
                case (int)projectName_ten.CNMSAfC13_en:
                    break;
                case (int)projectName_ten.SGMWGeely121Bytes_en:
                    break;
                case (int)projectName_ten.CNMSAfC15_en:
                    break;
                case (int)projectName_ten.GWMFeature:
                    break;
                case (int)projectName_ten.GWMFeatureWithEppRo:
                    break;
                case (int)projectName_ten.GWMFull_en:
                    break;
                case (int)projectName_ten.TMCB5_en:
                    break;
                case (int)projectName_ten.TMCB4_en:
                    break;
                case (int)projectName_ten.HRYT_en:
                    EDIDConfigTable_ast = EDIDConfigHRYT_ast;
                    break;
                default:
                    break;
            }
            if (isEDID_b == true)
                ReportHanling_PD(EDIDConfigTable_ast);
            else
            {
                ReportHanling_CD(EDIDConfigTable_ast);
            }


        }
        public void RunMapping()
        {

            LoadInput(CurPrjName_s16, CurRepType_s16);
        }
        private void BtnRun_Click(object sender, RoutedEventArgs e)
        {
            RunMapping();
        }
        void BtnBrowseClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @txtPath.Text,
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|xml files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == true)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }
        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return (((item as DataGridView).EDID.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0) | ((item as DataGridView).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0));
        }
        private void TxtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dataGridView1.ItemsSource).Refresh();
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
