using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRReportingTool_WPF
{
    public partial class MainWindow
    {
        public EDIDConfigTable_tst[] EDIDConfigHRYT_ast = {
			
			/*EDID 4000: Longitudinal dv (CN-EDR) */
			new EDIDConfigTable_tst(
            "4000", /* string EDID_str */
			"Longitudinal delta-V", /* string DataElement_str */
			26, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"kph", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-126, /* Int16 RangeMin_s16 */
			126, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			250, /* Int16 EndTimeMs_s16 */
			100, /* UInt16 SampleRateHz_u16 */
			"Delta V (Based on central Highg acceleration sensors)", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"}, {"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			
			 /*EDID 4001: Max Dv Longitudinal (CN-EDR) */ 
			new EDIDConfigTable_tst(
            "4001", /* string EDID_str */
			"Maximum recorded longitudinal delta-V", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"kph", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-126, /* Int16 RangeMin_s16 */
			126, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			 
			/*EDID 4002: Time at Max Dv Longitudinal (CN-EDR) */ 
			new EDIDConfigTable_tst(
            "4002", /* string EDID_str */
			"Time to maximum recorded delta-V, longitudinal", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			300, /* Int32 RangeMax_s32 */
			2.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			
			/*EDID 4003: Clipping time, High-g X (longitudinal) */ 
			new EDIDConfigTable_tst(
            "4003", /* string EDID_str */
			"Clipping time, Longitudinal", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFF", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			
			/*EDID 4004: Clipping time, High-g Y (lateral) */ 
			new EDIDConfigTable_tst(
            "4004", /* string EDID_str */
			"Clipping time, Lateral", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFF", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			
			 /*EDID 4005: Vehicle Speed (CN-EDR) */
			new EDIDConfigTable_tst(
            "4005", /* string EDID_str */
			"Vehicle velocity", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"kph", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-1 and CN-EDR class A Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			 
			/*EDID 4006: Service Brake Activation (CN-EDR) */
			new EDIDConfigTable_tst(
            "4006", /* string EDID_str */
			"Service Brake, on-off", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			1, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-1 and CN-EDR class A Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			
			/*EDID 4007 : Safety Belt Status Driver (BLFD or BLFL/BLFR) (CN-EDR) */
			new EDIDConfigTable_tst(
            "4007", /* string EDID_str */
			"Driver’s safety belt status", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Fastened", "0"} , {"Unfastened", "1"} , {"Faulty (Switch Faulty/Invalid value)", "0xFE"} , {"Not configured (Unobtainable Value)", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
			
						/*EDID 4007 : Safety Belt Status Driver (BLFD or BLFL/BLFR) (CN-EDR) */
			new EDIDConfigTable_tst(
            "4008", /* string EDID_str */
			"Accelerator pedal position, percentage of fully open", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"%", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			100, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-1 and CN-EDR class A Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
            new EDIDConfigTable_tst(
            "4009", /* string EDID_str */
			"number of revolutions per minute of the main crankshaft of the vehicle's engine", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"kph", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			10000, /* Int32 RangeMax_s32 */
			100, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-1 and CN-EDR class A Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4010", /* string EDID_str */
			"Power- on cycle at event", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			1, /* Int16 RangeMin_s16 */
			65533, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFE"},{"Data Not Available", "0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4011", /* string EDID_str */
			"Power- on cycle at reading", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			1, /* Int16 RangeMin_s16 */
			65533, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFE"},{"Data Not Available", "0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4012", /* string EDID_str */
			"Complete status of event data record (Mandatory Data)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			1, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_HeaderData_SingleData_MandRecCompleteStatus", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Uncompleted", "0"},{"Completed", "1"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4013", /* string EDID_str */
			"Time interval from this event to the last event", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			5000, /* Int32 RangeMax_s32 */
			100, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Not Available  or 1st Event in Multi Event", "0xFF"},{"Data Value Invalid", "0xFE"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4014", /* string EDID_str */
			"Vehicle Identification Number (VIN)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			17, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ASCII", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE"},{"Data Not Available", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4015", /* string EDID_str */
			"ECU hardware number that records EDR data", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			64, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ASCII", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE"},{"Data Not Available", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4016", /* string EDID_str */
			"ECU serial number that records EDR data", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			64, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ASCII", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE"},{"Data Not Available", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4017", /* string EDID_str */
			"ECU software number that records EDR data", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			64, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ASCII", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE"},{"Data Not Available", "0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4018", /* string EDID_str */
			"Longitudinal acceleration", /* string DataElement_str */
			126, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-126, /* Int16 RangeMin_s16 */
			126, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			250, /* Int16 EndTimeMs_s16 */
			500, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"-126", /* string RangeExceededLowerBoundary_str */
			"126", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4019", /* string EDID_str */
			"Lateral acceleration", /* string DataElement_str */
			126, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-126, /* Int16 RangeMin_s16 */
			126, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			250, /* Int16 EndTimeMs_s16 */
			500, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"-126", /* string RangeExceededLowerBoundary_str */
			"126", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4020", /* string EDID_str */
			"Lateral delta-V", /* string DataElement_str */
			26, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"kph", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-126, /* Int16 RangeMin_s16 */
			126, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			250, /* Int16 EndTimeMs_s16 */
			100, /* UInt16 SampleRateHz_u16 */
			"Delta V (Based on central Highg acceleration sensors)", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4021", /* string EDID_str */
			"Maximum recorded lateral delta-V", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"kph", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-126, /* Int16 RangeMin_s16 */
			126, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
            new EDIDConfigTable_tst(
            "4022", /* string EDID_str */
			"The square of the maximum recorded resultant", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"(kph)2", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			31752, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			-127, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFE"},{"Data Not Available", "0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),
            new EDIDConfigTable_tst(
            "4023", /* string EDID_str */
			"Time to maximum recorded delta-V, lateral", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			300, /* Int32 RangeMax_s32 */
			2.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4024", /* string EDID_str */
			"Time to maximum recorded delta-V, resultant", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			300, /* Int32 RangeMax_s32 */
			2.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			300, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Data at 300ms from Start of Crash", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFE"},{"Data Not Available", "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4025", /* string EDID_str */
			"Yaw angle velocity", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"deg/sec", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-300, /* Int16 RangeMin_s16 */
			300, /* Int32 RangeMax_s32 */
			0.1, /* Double Factor_db */
			-300, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFE"},{"Data Not Available", "0xFFFF"}}, /* string DataValueTable_str*/
			"-300", /* string RangeExceededLowerBoundary_str */
			"300", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4026", /* string EDID_str */
			"Steering Angle", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"degree", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-780, /* Int16 RangeMin_s16 */
			780, /* Int32 RangeMax_s32 */
			5, /* Double Factor_db */
			-780, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFE"},{"Data Not Available", "0xFFFF"}}, /* string DataValueTable_str*/
			"0xFFFE", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4027", /* string EDID_str */
			"The time from the beginning of the event (T0) to end of the impact event", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			632, /* Int32 RangeMax_s32 */
			2.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "0xFFFE"},{"Data Not Available  or No Tend observed", "0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4028", /* string EDID_str */
			"Year when the event occurred", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			2000, /* Int16 RangeMin_s16 */
			2253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			2000, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "254"},{"Data Not Available  or No Tend observed", "255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4029", /* string EDID_str */
			"Month when the event occurred", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			1, /* Int16 RangeMin_s16 */
			12, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			2000, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"January", "1"},{"February", "2"},{"March", "3"},{"April", "4"},{"May", "5"},{"June", "6"},{"July", "7"},{"August", "8"},{"September", "9"},{"October", "10"},{"November", "11"},{"December", "12"},{"Data Value Invalid", "254"},{"Data Not Available", "255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4030", /* string EDID_str */
			"Day when the event occurred", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			1, /* Int16 RangeMin_s16 */
			31, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "254"},{"Data Not Available", "255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4031", /* string EDID_str */
			"Hour portion of time of day when the event occurred", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			23, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "254"},{"Data Not Available", "255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4032", /* string EDID_str */
			"Minute portion of time of day when the event occurred", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			59, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "254"},{"Data Not Available", "255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4033", /* string EDID_str */
			"Seconds portion of time of day when the event occurred", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			59, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			 new Dictionary<string, string>(){{"Data Value Invalid", "254"},{"Data Not Available", "255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4034", /* string EDID_str */
			"Gear Position", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Park","0"},{"Reverse","1"},{"Neutral", "2"},{"Driving" , "3"},{"Data Value Invalid" , "0xFE"},{"Data Not Available" , "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4035", /* string EDID_str */
			"Engine  throttle  position,  percentage  of  fully  open", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"%", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			100, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-1 and CN-EDR class A Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data Value Invalid","0xFE"},{"Data Not Available" , "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4036", /* string EDID_str */
			"Brake pedal position", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"%", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			100, /* Int32 RangeMax_s32 */
			5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data Value Invalid","0xFE"},{"Data Not Available" , "0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFE", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4037", /* string EDID_str */
			"Parking system status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			2, /* Int32 RangeMax_s32 */
			5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"On","0"},{"Faulted","1"},{"Off","2"},{"Data Value Invalid","0xFE"},{"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4038", /* string EDID_str */
			"Turn Signal Switch Status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Off","0"} , {"Left","1"} , {"Right","2"},{"Emergency Flasher","3"},{"Data Value Invalid","0xFE"},{"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4039", /* string EDID_str */
			"Driver's seat belt pretensioner deployment time", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4040", /* string EDID_str */
			"Driver's front airbag deployment time (Phase I)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4041", /* string EDID_str */
			"Driver's front airbag deployment time (Phase II)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4042", /* string EDID_str */
			"Driver's side airbag deployment time", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4043", /* string EDID_str */
			"Driver's side air curtain  deployment time", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4044", /* string EDID_str */
			"BLFP get from COM", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"NA", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Fastened","0"} , {"Unfastened","1"} , {"Faulty ( Swich faulty / invalid value)","0xFE"} , {"Not configured (Unobtainable value)","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4045", /* string EDID_str */
			"Frontal-row passenger’s safety belt pretensioner", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4046", /* string EDID_str */
			"PADS get from COM", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"NA", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Off (airbag available)","0"} , {"On (airbag suppressed)","1"} , {"Faulty (Switch faulty/ invalid value)","0xFE"} , {"Not configured (Unobtainable value)","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4047", /* string EDID_str */
			"Frontal-row passenger's front airbag deployment time (Phase I)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),


            new EDIDConfigTable_tst(
            "4048", /* string EDID_str */
			"Frontal-row passenger's front airbag deployment time (Phase II)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4049", /* string EDID_str */
			"Frontal-row passenger's side airbag deployment time", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4050", /* string EDID_str */
			"Frontal-row passenger's side air curtain  deployment", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Post Crash Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4051", /* string EDID_str */
			"Occupant protection system warning status", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Off","0"} , {"On","1"} , {"Invalid Data","254"} , {"Data Not Available","255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4052", /* string EDID_str */
			"Tire Pressure Monitoring System Warning Status", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Off","0"} , {"On","1"} , {"Invalid Data","254"} , {"Data Not Available","255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4053", /* string EDID_str */
			"Braking system warning status", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Off","0"} , {"On","1"} , {"Invalid Data","254"} , {"Data Not Available","255"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4054", /* string EDID_str */
			"Cruise control system status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"On but not actived","0"} , {"On and activated","1"} , {"Commanded off","2"} , {"Fault","3"} , {"Data Value Invalid","0xFE"} , {"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4055", /* string EDID_str */
			"Adaptive cruise control system status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"On but not actived","0"} , {"On and activated","1"} , {"Commanded off","2"} , {"Fault","3"} , {"Data Value Invalid","0xFE"} , {"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),


            new EDIDConfigTable_tst(
            "4056", /* string EDID_str */
			"Anti-lock brake system status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not actived","0"} , {"Actived","1"} , {"Fault","2"} , {"Data Value Invalid","0xFE"} , {"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4057", /* string EDID_str */
			"Automatic Emergency Braking (AEB) System status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"On but not actived","0"} , {"On and activated","1"} , {"Commanded off","2"} , {"Fault","3"} , {"Data Value Invalid","0xFE"} , {"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),


            new EDIDConfigTable_tst(
            "4058", /* string EDID_str */
			"Electronic stability control system status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"On but not actived","0"} , {"On and activated","1"} , {"Commanded off","2"} , {"Fault","3"} , {"Data Value Invalid","0xFE"} , {"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4059", /* string EDID_str */
			"Traction control system status", /* string DataElement_str */
			11, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"StateEncoded", /* string Unit_str */
			"StateEncoded", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-5000,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			2, /* UInt16 SampleRateHz_u16 */
			"NHTSA Table-2 and CN-EDR class B Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"On but not actived","0"} , {"On and activated","1"} , {"Commanded off","2"} , {"Fault","3"} , {"Data Value Invalid","0xFE"} , {"Data Not Available","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "4060", /* string EDID_str */
			"Pre-event synchronization timing time", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			499, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Pre Crash High Prio Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data Value Invalid","0xFFFE"} , {"Data Not Available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CNEDRData_en
        ),

            new EDIDConfigTable_tst(
            "2000", /* string EDID_str */
			"Wake up reason get from SSM", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"NA", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"KL30","0"} , {"KL15","1"} , {"Network Management","2"}}, /* string DataValueTable_str*/
			"0", /* string RangeExceededLowerBoundary_str */
			"2", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CustData_en
        ),

            new EDIDConfigTable_tst(
            "2001", /* string EDID_str */
			"System Mode from SSM", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"NA", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Normal mode","0"} , {"Sleep mode","1"} , {"Silent mode","2"}}, /* string DataValueTable_str*/
			"0", /* string RangeExceededLowerBoundary_str */
			"2", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CustData_en
        ),

            new EDIDConfigTable_tst(
            "2002", /* string EDID_str */
			"Power mode from COM", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"NA", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			253, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"OFF","0"} , {"Local ON","1"} , {"Remote ON","2"}, {"Reserve","3"}}, /* string DataValueTable_str*/
			"0", /* string RangeExceededLowerBoundary_str */
			"2", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.CustData_en
        ),

            new EDIDConfigTable_tst(
            "5000", /* string EDID_str */
			"Complete Header data", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			68, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"CombinationData", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_HeaderData", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5001", /* string EDID_str */
			"Safety belt status, 2nd row Passenger side (BLRP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5002", /* string EDID_str */
			"Safety belt status, 2nd row Driver side (BLRD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5003", /* string EDID_str */
			"Longitudinal acceleration high range, Main SMA760(Bosch Data)", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-50, /* Int16 RangeMin_s16 */
			50, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-40,/* Int16 StartTimeMs_s16 */
			100, /* Int16 EndTimeMs_s16 */
			1000, /* UInt16 SampleRateHz_u16 */
			"Cust Central Sensor Acceleration High G (Bosch Data)", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5004", /* string EDID_str */
			"Lateral acceleration high range, Main SMA760 (Bosch Data)", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-50, /* Int16 RangeMin_s16 */
			50, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-40,/* Int16 StartTimeMs_s16 */
			100, /* Int16 EndTimeMs_s16 */
			1000, /* UInt16 SampleRateHz_u16 */
			"Cust Central Sensor Acceleration High G (Bosch Data)", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5005", /* string EDID_str */
			"Lateral acceleration middle range, SMI860 (Bosch Data)", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-50, /* Int16 RangeMin_s16 */
			50, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-40,/* Int16 StartTimeMs_s16 */
			100, /* Int16 EndTimeMs_s16 */
			1000, /* UInt16 SampleRateHz_u16 */
			"Cust Central Sensor Acceleration Middle G (Bosch Data)", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5006", /* string EDID_str */
			"Longitudinal acceleration middle range, SMI860 (Bosch Data)", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-50, /* Int16 RangeMin_s16 */
			50, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-40,/* Int16 StartTimeMs_s16 */
			100, /* Int16 EndTimeMs_s16 */
			1000, /* UInt16 SampleRateHz_u16 */
			"Cust Central Sensor Acceleration Middle G (Bosch Data)", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5007", /* string EDID_str */
			"UFS Passenger", /* string DataElement_str */
			261, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-480, /* Int16 RangeMin_s16 */
			480, /* Int32 RangeMax_s32 */
			4, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-30,/* Int16 StartTimeMs_s16 */
			100, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"Upfront Sensor data", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-480", /* string RangeExceededLowerBoundary_str */
			"480", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),


            new EDIDConfigTable_tst(
            "5008", /* string EDID_str */
			"UFS driver", /* string DataElement_str */
			261, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-480, /* Int16 RangeMin_s16 */
			480, /* Int32 RangeMax_s32 */
			4, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-30,/* Int16 StartTimeMs_s16 */
			100, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"Upfront Sensor data", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-480", /* string RangeExceededLowerBoundary_str */
			"480", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5009", /* string EDID_str */
			"Pas 1st row Passenger", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-120, /* Int16 RangeMin_s16 */
			120, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-20,/* Int16 StartTimeMs_s16 */
			50, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"Front Row", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-120", /* string RangeExceededLowerBoundary_str */
			"120", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5010", /* string EDID_str */
			"Pas 1st row Driver", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-120, /* Int16 RangeMin_s16 */
			120, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-20,/* Int16 StartTimeMs_s16 */
			50, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"Front Row", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-120", /* string RangeExceededLowerBoundary_str */
			"120", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5011", /* string EDID_str */
			"Pas 2nd row Passenger", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-120, /* Int16 RangeMin_s16 */
			120, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-20,/* Int16 StartTimeMs_s16 */
			50, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"Middle Row", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-120", /* string RangeExceededLowerBoundary_str */
			"120", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5012", /* string EDID_str */
			"Pas 2nd row Driver", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"g", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-120, /* Int16 RangeMin_s16 */
			120, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-20,/* Int16 StartTimeMs_s16 */
			50, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"Middle Row", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-120", /* string RangeExceededLowerBoundary_str */
			"120", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5013", /* string EDID_str */
			"Pps 1st row Passenger", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"promille (‰)", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-50, /* Int16 RangeMin_s16 */
			150, /* Int32 RangeMax_s32 */
			1.953125, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-20,/* Int16 StartTimeMs_s16 */
			50, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"PPS Front row", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-50", /* string RangeExceededLowerBoundary_str */
			"150", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5014", /* string EDID_str */
			"Pps 1st row Driver", /* string DataElement_str */
			141, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"promille (‰)", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			-50, /* Int16 RangeMin_s16 */
			150, /* Int32 RangeMax_s32 */
			1.953125, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-20,/* Int16 StartTimeMs_s16 */
			50, /* Int16 EndTimeMs_s16 */
			2000, /* UInt16 SampleRateHz_u16 */
			"PPS Front row", /* string RecordingSection_str */
			"Signed", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","126"} , {"Data not available","127"}}, /* string DataValueTable_str*/
			"-50", /* string RangeExceededLowerBoundary_str */
			"150", /* string RangeExceededUpperBoundary_str */
			"", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5015", /* string EDID_str */
			"Fire time,  (BT2FD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			1000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireTimes_1stRow_FrontBT_2ndStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5016", /* string EDID_str */
			"Fire time,  (BT2FP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			1000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireTimes_1stRow_FrontBT_2ndStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5017", /* string EDID_str */
			"Fire time,  (IC1RD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			1000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireTimes_2ndRow_InflatableCurtainWindowAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5018", /* string EDID_str */
			"Fire time,  (IC1RP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			1000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireTimes_2ndRow_InflatableCurtainWindowAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "5019", /* string EDID_str */
			"Fire time,  (BATDHV)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			1000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireTimes_Miscellaneous", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6001", /* string EDID_str */
			"Disable line status at start of crash (0:enabled,1:disabled)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"Bitlist", /* string Unit_str */
			"Bitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			255, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_RTData", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Not deployed","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6002", /* string EDID_str */
			"Disable line status at end of crash (0:enabled,1:disabled)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"Bitlist", /* string Unit_str */
			"Bitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			255, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6003", /* string EDID_str */
			"Squib Configuration", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ContinuousBitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_Configuration", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6004", /* string EDID_str */
			"Sensor Configuration", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ContinuousBitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_Configuration", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6005", /* string EDID_str */
			"Switch Configuration", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ContinuousBitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_Configuration", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6006", /* string EDID_str */
			"Aout Configuration", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ContinuousBitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_Configuration", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6007", /* string EDID_str */
			"Static Special behavior Configuration", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ContinuousBitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_Configuration", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6008", /* string EDID_str */
			"Dynamic Special behavior Configuration", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"ContinuousBitlist", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashHighPrio_Configuration", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6009", /* string EDID_str */
			"Faults in ECU before Event", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			45, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"FaultMemory", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashLowPrio", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6010", /* string EDID_str */
			"Ecu operating time", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			4, /* UInt16 BytesPerDataSample_u16 */
			"minute", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			71582788, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashLowPrio_ECUOperatingTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","0xFFFFFFFE"} , {"Data not available","0xFFFFFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFFFFFE", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6011", /* string EDID_str */
			"Vbat before crash", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"V", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32, /* Int32 RangeMax_s32 */
			0.1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashLowPrio_BGData", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","0xFFFE"} , {"Data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFE", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6012", /* string EDID_str */
			"Ver-1 before crash", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"V", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32, /* Int32 RangeMax_s32 */
			0.1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			-1100,/* Int16 StartTimeMs_s16 */
			0, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PreCrashLowPrio_BGData", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","0xFFFE"} , {"Data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFE", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6013", /* string EDID_str */
			"Disable to Enable time, (SDisY)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6014", /* string EDID_str */
			"Disable to Enable time, (SDisX)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6015", /* string EDID_str */
			"Disable to Enable time, (SDisS)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6016", /* string EDID_str */
			"Disable to Enable time, (SDisW)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6017", /* string EDID_str */
			"Disable to Enable time, (DisSHP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6018", /* string EDID_str */
			"Disable to Enable time, (DisAHP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6019", /* string EDID_str */
			"Disable to Enable time, (DisALP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6020", /* string EDID_str */
			"Disable to Enable time, (SDisY)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6021", /* string EDID_str */
			"Disable to Enable time, (SDisX)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6022", /* string EDID_str */
			"Disable to Enable time, (SDisS)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6023", /* string EDID_str */
			"Disable to Enable time, (SDisW)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6024", /* string EDID_str */
			"Disable to Enable time, (DisSHP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6025", /* string EDID_str */
			"Disable to Enable time, (DisAHP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6026", /* string EDID_str */
			"Disable to Enable time, (DisALP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_DisableLineTimes_EnTime", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Enabled before T0","0"} , {"Never enabled","0xFFFE"} , {"data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFF", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6027", /* string EDID_str */
			"Vbat after crash", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"V", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","0xFFFE"} , {"Data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFE", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6028", /* string EDID_str */
			"Ver-1 after crash", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			2, /* UInt16 BytesPerDataSample_u16 */
			"V", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			32766, /* Int32 RangeMax_s32 */
			0.5, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"Data value invalid","0xFFFE"} , {"Data not available","0xFFFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"0xFFFE", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6029", /* string EDID_str */
			"Fire current duration (1.2A), (AB1FD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_FrontAB_1stStage", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6030", /* string EDID_str */
			"Fire current duration (1.2A), (AB1FD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_FrontAB_1stStage", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6031", /* string EDID_str */
			"Fire current duration (1.2A), (BT1FD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_FrontBT_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6032", /* string EDID_str */
			"Fire current duration (1.2A), (BT1FP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_FrontBT_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6033", /* string EDID_str */
			"Fire current duration (1.2A), (BT2FD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_FrontBT_2ndStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6034", /* string EDID_str */
			"Fire current duration (1.2A), (BT2FP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_FrontBT_2ndStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6035", /* string EDID_str */
			"Fire current duration (1.2A), (BT2FP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_SideAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6036", /* string EDID_str */
			"Fire current duration (1.2A), (SA1FP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_SideAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6037", /* string EDID_str */
			"Fire current duration (1.2A), (IC1FD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_InflatableCurtainWindowAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6038", /* string EDID_str */
			"Fire current duration (1.2A), (IC1FP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_1stRow_InflatableCurtainWindowAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6039", /* string EDID_str */
			"Fire current duration (1.2A), (IC1RD)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_2ndRow_InflatableCurtainWindowAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6040", /* string EDID_str */
			"Fire current duration (1.2A), (IC1RP)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_2ndRow_InflatableCurtainWindowAB_1stStage_DP", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "6041", /* string EDID_str */
			"Fire current duration (1.2A), (BATDHV)", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			1, /* UInt16 BytesPerDataSample_u16 */
			"ms", /* string Unit_str */
			"Numeric", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			3, /* Int32 RangeMax_s32 */
			0.025, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"StaticEdidItems_PostCrashData_EventEnd_DeploymentData_FireCount_Low_Miscellaneous", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){{"No deployed","0"} , {"Not deployed","0xFF"}}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Right", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "10000", /* string EDID_str */
			"RB_dsa_GenEventDataSampling_cs", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			70, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Algo Supplier Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "11000", /* string EDID_str */
			"RB_dsa_Gen300AlgoDataSampling_cs", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			22, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Algo Supplier Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "12000", /* string EDID_str */
			"RB_dsa_FrtIncidentDataSampling_cs", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			87, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Algo Supplier Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "13000", /* string EDID_str */
			"RB_dsa_SideIncidentDataSampling_cs", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			67, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Algo Supplier Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

            new EDIDConfigTable_tst(
            "14000", /* string EDID_str */
			"RB_dsa_RearIncidentDataSampling_cs", /* string DataElement_str */
			1, /* UInt16 DataSamples_u16 */
			20, /* UInt16 BytesPerDataSample_u16 */
			"", /* string Unit_str */
			"", /* string DataFormatType_str */
			0, /* Int16 RangeMin_s16 */
			0, /* Int32 RangeMax_s32 */
			1, /* Double Factor_db */
			0, /* Int16 Offset_s16 */
			0,/* Int16 StartTimeMs_s16 */
			10000, /* Int16 EndTimeMs_s16 */
			0, /* UInt16 SampleRateHz_u16 */
			"Algo Supplier Data", /* string RecordingSection_str */
			"Unsigned", /* string DecodingType_str */
			new Dictionary<string, string>(){}, /* string DataValueTable_str*/
			"NotSpecified", /* string RangeExceededLowerBoundary_str */
			"NotSpecified", /* string RangeExceededUpperBoundary_str */
			"Left", /* string SubEDIDOrder_str */
			"", /* string SubEDIDs_str */
			"EdrMaxVariant", /* string SupportedEdrVariants_str */
			SupportReport_ten.BoschData_en
        ),

        };

    }
}
