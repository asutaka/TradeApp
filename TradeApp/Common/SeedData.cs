using System.Collections.Generic;
using System.Data;
using System.Linq;
using TheLast.Model;

namespace TheLast.Common
{
    public static class SeedData
    {
        public static DataTable GetDataTimeZone()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumTimeZone.ThirteenMinute;
            dr1["Name"] = enumTimeZone.ThirteenMinute.ToDisplayStatus<enumTimeZone>();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumTimeZone.OneHour;
            dr2["Name"] = enumTimeZone.OneHour.ToDisplayStatus<enumTimeZone>();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumTimeZone.FourHour;
            dr3["Name"] = enumTimeZone.FourHour.ToDisplayStatus<enumTimeZone>();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumTimeZone.OneDay;
            dr4["Name"] = enumTimeZone.OneDay.ToDisplayStatus<enumTimeZone>();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumTimeZone.OneWeek;
            dr5["Name"] = enumTimeZone.OneWeek.ToDisplayStatus<enumTimeZone>();

            var dr6 = dt.NewRow();
            dr6["Id"] = (int)enumTimeZone.OneMonth;
            dr6["Name"] = enumTimeZone.OneMonth.ToDisplayStatus<enumTimeZone>();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            dt.Rows.Add(dr6);
            return dt;
        }

        public static DataTable GetDataCandleStick()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumCandleStick.O;
            dr1["Name"] = enumCandleStick.O.ToDisplayStatus<enumCandleStick>();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumCandleStick.H;
            dr2["Name"] = enumCandleStick.H.ToDisplayStatus<enumCandleStick>();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumCandleStick.L;
            dr3["Name"] = enumCandleStick.L.ToDisplayStatus<enumCandleStick>();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumCandleStick.C;
            dr4["Name"] = enumCandleStick.C.ToDisplayStatus<enumCandleStick>();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            return dt;
        }

        public static DataTable GetOperator()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumOperator.Greater;
            dr1["Name"] = enumOperator.Greater.ToDisplayStatus<enumOperator>();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumOperator.GreaterOrEqual;
            dr2["Name"] = enumOperator.GreaterOrEqual.ToDisplayStatus<enumOperator>();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumOperator.Equal;
            dr3["Name"] = enumOperator.Equal.ToDisplayStatus<enumOperator>();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumOperator.LessThanOrEqual;
            dr4["Name"] = enumOperator.LessThanOrEqual.ToDisplayStatus<enumOperator>();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumOperator.LessThan;
            dr5["Name"] = enumOperator.LessThan.ToDisplayStatus<enumOperator>();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            return dt;
        }
        public static DataTable GetUnit()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumUnit.Ratio;
            dr1["Name"] = enumUnit.Ratio.ToDisplayStatus<enumUnit>();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumUnit.Value;
            dr2["Name"] = enumUnit.Value.ToDisplayStatus<enumUnit>();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            return dt;
        }
        public static DataTable GetDataChooseData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumChooseData.MA;
            dr1["Name"] = enumChooseData.MA.ToDisplayStatus<enumChooseData>();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumChooseData.EMA;
            dr2["Name"] = enumChooseData.EMA.ToDisplayStatus<enumChooseData>();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumChooseData.Volumne;
            dr3["Name"] = enumChooseData.Volumne.ToDisplayStatus<enumChooseData>();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumChooseData.CandleStick_1;
            dr4["Name"] = enumChooseData.CandleStick_1.ToDisplayStatus<enumChooseData>();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumChooseData.CandleStick_2;
            dr5["Name"] = enumChooseData.CandleStick_2.ToDisplayStatus<enumChooseData>();

            var dr6 = dt.NewRow();
            dr6["Id"] = (int)enumChooseData.MACD;
            dr6["Name"] = enumChooseData.MACD.ToDisplayStatus<enumChooseData>();

            var dr7 = dt.NewRow();
            dr7["Id"] = (int)enumChooseData.RSI;
            dr7["Name"] = enumChooseData.RSI.ToDisplayStatus<enumChooseData>();

            var dr8 = dt.NewRow();
            dr8["Id"] = (int)enumChooseData.ADX;
            dr8["Name"] = enumChooseData.ADX.ToDisplayStatus<enumChooseData>();

            var dr9 = dt.NewRow();
            dr9["Id"] = (int)enumChooseData.CurrentValue;
            dr9["Name"] = enumChooseData.CurrentValue.ToDisplayStatus<enumChooseData>();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            dt.Rows.Add(dr6);
            dt.Rows.Add(dr7);
            dt.Rows.Add(dr8);
            dt.Rows.Add(dr9);
            return dt;
        }

        public static List<CryptonDetailDataModel> GetCryptonList()
        {
            List<string> BLACK_LIST = new List<string> { "PSGUSDT", "ACMUSDT", "ATMUSDT", "BUSDUSDT", "ASRUSDT", "AUDUSDT", "EURUSDT", "SUSDUSDT", "TUSDUSDT", "JUVUSDT" };
            var cryptonModel = ExtensionMethod.GetJsonFile<CryptonDataModel>(ConstValues.COIN_LIST);
            return cryptonModel.Data.Where(x => !BLACK_LIST.Contains(x.S) 
                                            && x.S.Substring(x.S.Length - 4) == "USDT"
                                            && !x.S.Contains("UP")
                                            && !x.S.Contains("DOWN"))
                                    .OrderBy(x => x.S).ToList();
        }
    }
}
