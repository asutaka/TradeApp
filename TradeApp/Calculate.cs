using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheLast.Common;
using TheLast.Model;
using TicTacTec.TA.Library;
using TradeApp.Model;

namespace TheLast
{
    public class Calculate
    {
        private string _code;
        public Calculate(string Code)
        {
            _code = Code;
        }
        public OutputModel GetOutput()
        {
            return new OutputModel { Code = _code, Point = CalculatePoint() };
        }
        private decimal CalculatePoint()
        {
            if (!StaticValues.advanceModel.LstInterval.Any())
                return 0;
            var lstOutput = new List<decimal>();
            var lstTask = new List<Task>();
            foreach (var item in StaticValues.advanceModel.LstInterval)
            {
                if (item == (int)enumInterval.ThirteenMinute)
                {
                    var interval = (int)enumInterval.ThirteenMinute;
                    var task = Task.Run(() =>
                    {
                        lstOutput.Add(CalculateFromInterval(StaticValues.advanceModel.LstElement15M, StaticValues.advanceModel.LstIndicator15M, interval));
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneHour)
                {
                    var interval = (int)enumInterval.OneHour;
                    var task = Task.Run(() =>
                    {
                        lstOutput.Add(CalculateFromInterval(StaticValues.advanceModel.LstElement1H, StaticValues.advanceModel.LstIndicator1H, interval));
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.FourHour)
                {
                    var interval = (int)enumInterval.FourHour;
                    var task = Task.Run(() =>
                    {
                        lstOutput.Add(CalculateFromInterval(StaticValues.advanceModel.LstElement4H, StaticValues.advanceModel.LstIndicator4H, interval));
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneDay)
                {
                    var interval = (int)enumInterval.OneDay;
                    var task = Task.Run(() =>
                    {
                        lstOutput.Add(CalculateFromInterval(StaticValues.advanceModel.LstElement1D, StaticValues.advanceModel.LstIndicator1D, interval));
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneWeek)
                {
                    var interval = (int)enumInterval.OneWeek;
                    var task = Task.Run(() =>
                    {
                        lstOutput.Add(CalculateFromInterval(StaticValues.advanceModel.LstElement1W, StaticValues.advanceModel.LstIndicator1W, interval));
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneMonth)
                {
                    var interval = (int)enumInterval.OneMonth;
                    var task = Task.Run(() =>
                    {
                        lstOutput.Add(CalculateFromInterval(StaticValues.advanceModel.LstElement1M, StaticValues.advanceModel.LstIndicator1M, interval));
                    });
                    lstTask.Add(task);
                }
            }
            Task.WaitAll(lstTask.ToArray());
            return lstOutput.Sum();
        }
        private OutputIndicatorModel CalculateIndicator(GeneralModel model, double[] arrOpen, double[] arrClose, double[] arrHigh, double[] arrLow, double[] arrVolumne, int count)
        {
            var outputModel = new OutputIndicatorModel { Indicator = model.Indicator, Period = model.Period, Value = 0 };
            double[] output1 = new double[1000];
            double[] output2 = new double[1000];
            double[] output3 = new double[1000];
            if (model.Indicator == (int)enumChooseData.MA)
            {
                Core.MovingAverage(0, count - 1, arrClose, model.Period, Core.MAType.Sma, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.EMA)
            {
                Core.MovingAverage(0, count - 1, arrClose, model.Period, Core.MAType.Ema, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.Volumne)
            {
                Core.MovingAverage(0, count - 1, arrVolumne, model.Period, Core.MAType.Sma, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.CandleStick_1)
            {
                var takeNum = 1;
                if (model.Period == (int)enumCandleStick.O)
                {
                    outputModel.Value = arrOpen.ElementAt(count - takeNum);
                }
                if(model.Period == (int)enumCandleStick.H)
                {
                    outputModel.Value = arrHigh.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.L)
                {
                    outputModel.Value = arrLow.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.C)
                {
                    outputModel.Value = arrClose.ElementAt(count - takeNum);
                }
            }
            else if (model.Indicator == (int)enumChooseData.CandleStick_2)
            {
                var takeNum = 2;
                if (model.Period == (int)enumCandleStick.O)
                {
                    outputModel.Value = arrOpen.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.H)
                {
                    outputModel.Value = arrHigh.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.L)
                {
                    outputModel.Value = arrLow.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.C)
                {
                    outputModel.Value = arrClose.ElementAt(count - takeNum);
                }
            }
            else if (model.Indicator == (int)enumChooseData.MACD)
            {
                Core.Macd(0, count - 1, arrClose, model.Low, model.High, model.Signal, out int outBegIdx, out int outNbElement, output1, output2, output3);
                outputModel.Value = output1[count - 1];
            }
            else if (model.Indicator == (int)enumChooseData.RSI)
            {
                Core.Rsi(0, count - 1, arrClose, model.Period, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.ADX)
            {
                Core.Adx(0, count - 1, arrHigh, arrLow, arrClose, model.Period, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if(model.Indicator == (int)enumChooseData.CurrentValue)
            {
                outputModel.Value = GetCurrentValue();
            }
            return outputModel;
        }
        private decimal CalculateFromInterval(List<ElementModel> elementModels, List<IndicatorModel> indicatorModels, int interval)
        {
            var lstOutputIndicator = new List<OutputIndicatorModel>();
            var lstModel = LoadDatasource(interval.ToDisplayStatusEnumInterval());
            if (!lstModel.Any())
                return 0;
            var arrOpen = lstModel.Select(x => x.Open).ToArray();
            var arrClose = lstModel.Select(x => x.Close).ToArray();
            var arrHigh = lstModel.Select(x => x.High).ToArray();
            var arrLow = lstModel.Select(x => x.Low).ToArray();
            var arrVolumne = lstModel.Select(x => x.Volumne).ToArray();
            var count = lstModel.Count;
            if (count < 20)
                return 0;

            var lstTask = new List<Task>();
            foreach (var item in elementModels.To<List<GeneralModel>>())
            {
                var task = Task.Run(() =>
                {
                    lstOutputIndicator.Add(CalculateIndicator(item, arrOpen, arrClose, arrHigh, arrLow, arrVolumne, count));
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            return MethodMark(lstOutputIndicator, indicatorModels);
        }
        private decimal MethodMark(List<OutputIndicatorModel> lstModel, List<IndicatorModel> indicatorModels)
        {
            decimal point = 0;
            var lstTask = new List<Task>();
            foreach (var item in indicatorModels)
            {
                var task = Task.Run(() =>
                {
                    point += MethodMarkUnit(lstModel, item);
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            return point;
        }
        private decimal MethodMarkUnit(List<OutputIndicatorModel> lstModel, IndicatorModel indicator)
        {
            decimal point = 0;
            var indicator1 = indicator.Element1.To<GeneralModel>();
            var indicator2 = indicator.Element2.To<GeneralModel>();
            double result = (double)indicator.Result;

            if (indicator.Unit == (int)enumUnit.Ratio)
            {
                var currentValue = GetCurrentValue();
                result = (double)indicator.Result * currentValue / 100;
            }
            double firstValue = lstModel.FirstOrDefault(x => x.Indicator == indicator1.Indicator && x.Period == indicator1.Period).Value;
            double secondValue = 0;
            if (indicator2 != null)
                secondValue = lstModel.FirstOrDefault(x => x.Indicator == indicator2.Indicator && x.Period == indicator2.Period).Value;
            double div = firstValue - secondValue;
            if (div < 0)
                return point;
            if (indicator.Operator == (int)enumOperator.Equal
                && div == result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.Greater
                && div > result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.GreaterOrEqual
                && div >= result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.LessThan
                && div < result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.LessThanOrEqual
                && div <= result)
            {
                point += indicator.Point;
            }
            return point;
        }
        private double GetCurrentValue()
        {
            var url = $"{ConstValues.COIN_DETAIL}symbol={_code}&interval=15m&limit=1";
            var arrData = ExtensionMethod.GetJsonArray(url);
            var currentVal = double.Parse(arrData[0][4].ToString());
            return currentVal;
        }
        private List<CandleStickDataModel> LoadDatasource(string interval)
        {
            var lstModel = new List<CandleStickDataModel>();
            try
            {
                var url = $"{ConstValues.COIN_DETAIL}symbol={_code}&interval={interval}";
                var arrData = ExtensionMethod.GetJsonArray(url);

                lstModel = arrData.Select(x => new CandleStickDataModel
                {
                    Time = ((int)((long)x[0] / 1000)).UnixTimeStampToDateTime(),
                    Open = float.Parse(x[1].ToString()),
                    High = float.Parse(x[2].ToString()),
                    Low = float.Parse(x[3].ToString()),
                    Close = float.Parse(x[4].ToString()),
                    Volumne = float.Parse(x[5].ToString())
                }).ToList();
                return lstModel;
            }
            catch
            {
                return lstModel;
            }
        }
    }
    public class OutputIndicatorModel
    {
        public int Indicator { get; set; }
        public int Period { get; set; }
        public double Value { get; set; }
    }
}
