using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRReportingTool_WPF
{
    public partial class MainWindow
    {
        //How many projects.
        enum projectName_ten
        {
            CNMSBfC13_en,
            CNMSAfC13_en,
            SGMWGeely121Bytes_en,
            CNMSAfC15_en,
            GWMFeature,
            GWMFeatureWithEppRo,
            GWMFull_en,
            TMCB5_en,
            TMCB4_en,
            HRYT_en,
            MaxProjectName_en
        }

        enum reportType_ten
        {
            CD_en,
            PD_en
        }

        public enum SupportReport_ten
        {
            CNEDRData_en,
            CustData_en,
            BoschData_en
        }
        public struct EDIDConfigTable_tst
        {
            public string EDID_str; //EDID
            public string DataElement_str; //Description Data
            public UInt16 DataSamples_u16; // DataSamples
            public UInt16 BytesPerDataSample_u16;
            public string Unit_str;
            public string DataFormatType_str;
            public Int16 RangeMin_s16;
            public Int32 RangeMax_s32;
            public Double Factor_db;
            public Int16 Offset_s16;
            public Int16 StartTimeMs_s16;
            public Int16 EndTimeMs_s16;
            public UInt16 SampleRateHz_u16;
            public string RecordingSection_str;
            public string DecodingType_str;
            public Dictionary<string, string> DataValueTable_dstr;
            public string RangeExceededLowerBoundary_str;
            public string RangeExceededUpperBoundary_str;
            public string SubEDIDOrder_str;
            public string SubEDIDs_str;
            public string SupportedEdrVariants_str;
            public SupportReport_ten SupportReport_en;

            public EDIDConfigTable_tst
                (string EDID_str,
                string DataElement_str,
                UInt16 DataSamples_u16,
                UInt16 BytesPerDataSample_u16,
                string Unit_str,
                string DataFormatType_str,
                Int16 RangeMin_s16,
                Int32 RangeMax_s32,
                Double Factor_db,
                Int16 Offset_s16,
                Int16 StartTimeMs_s16,
                Int16 EndTimeMs_s16,
                UInt16 SampleRateHz_u16,
                string RecordingSection_str,
                string DecodingType_str,
                Dictionary<string, string> DataValueTable_dstr,
                string RangeExceededLowerBoundary_str,
                string RangeExceededUpperBoundary_str,
                string SubEDIDOrder_str,
                string SubEDIDs_str,
                string SupportedEdrVariants_str,
                SupportReport_ten SupportReport_en)
            {
                this.EDID_str = EDID_str;
                this.DataElement_str = DataElement_str;
                this.DataSamples_u16 = DataSamples_u16;
                this.BytesPerDataSample_u16 = BytesPerDataSample_u16;
                this.Unit_str = Unit_str;
                this.DataFormatType_str = DataFormatType_str;
                this.RangeMin_s16 = RangeMin_s16;
                this.RangeMax_s32 = RangeMax_s32;
                this.Factor_db = Factor_db;
                this.Offset_s16 = Offset_s16;
                this.StartTimeMs_s16 = StartTimeMs_s16;
                this.EndTimeMs_s16 = EndTimeMs_s16;
                this.SampleRateHz_u16 = SampleRateHz_u16;
                this.RecordingSection_str = RecordingSection_str;
                this.DecodingType_str = DecodingType_str;
                this.DataValueTable_dstr = DataValueTable_dstr;
                this.RangeExceededLowerBoundary_str = RangeExceededLowerBoundary_str;
                this.RangeExceededUpperBoundary_str = RangeExceededUpperBoundary_str;
                this.SubEDIDOrder_str = SubEDIDOrder_str;
                this.SubEDIDs_str = SubEDIDs_str;
                this.SupportedEdrVariants_str = SupportedEdrVariants_str;
                this.SupportReport_en = SupportReport_en;
            }
        };






    }
}
