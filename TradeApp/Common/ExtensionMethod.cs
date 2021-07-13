using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using TheLast.Model;
using TradeApp.Model;

namespace TheLast.Common
{
    public static class ExtensionMethod
    {
        public static string To2Digit(this int val)
        {
            if (val > 9)
                return val.ToString();
            return $"0{val}";
        }

        public static DateTime UnixTimeStampToDateTime(this int unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static void InitBasicJson(this int val)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\basic_setting.json";
            var isExist = File.Exists(path);
            if (!isExist)
            {
                var model = new BasicSettingModel
                {
                    TimeZone = (int)enumTimeZone.OneHour,
                    ListModel = new List<GeneralModel>
                    {
                        new GeneralModel{ Indicator = (int)enumChooseData.MA, Period = 7 },
                        new GeneralModel{ Indicator = (int)enumChooseData.EMA, Period = 7 },
                        new GeneralModel{ Indicator = (int)enumChooseData.Volumne, Period = 20 },
                        new GeneralModel{ Indicator = (int)enumChooseData.CandleStick_1, Period = (int)enumCandleStick.C },
                        new GeneralModel{ Indicator = (int)enumChooseData.CandleStick_2, Period = (int)enumCandleStick.C },
                        new GeneralModel{ Indicator = (int)enumChooseData.MACD, High = 12, Low = 26, Signal = 9 },
                        new GeneralModel{ Indicator = (int)enumChooseData.RSI, Period = 14 },
                        new GeneralModel{ Indicator = (int)enumChooseData.ADX, Period = 14 },
                        new GeneralModel{ Indicator = (int)enumChooseData.CurrentValue, Period = 0 },
                    }
                };
                string json = JsonConvert.SerializeObject(model);

                //write string to file
                File.WriteAllText(path, json);
            }
        }
       
        public static BasicSettingModel LoadBasicJson(this int val)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\basic_setting.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<BasicSettingModel>(json);
                return result;
            }
        }

        public static void UpdateJson(this BasicSettingModel _model)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\basic_setting.json";
            string json = JsonConvert.SerializeObject(_model);

            //write string to file
            File.WriteAllText(path, json);
        }

        public static void InitAdvanceJson(this int val)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\advance_setting.json";
            var isExist = File.Exists(path);
            if (!isExist)
            {
                var model = new AdvanceSettingModel();
                string json = JsonConvert.SerializeObject(model);
                
                //write string to file
                File.WriteAllText(path, json);
            }
        }

        public static AdvanceSettingModel LoadAdvanceJson(this int val)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\advance_setting.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<AdvanceSettingModel>(json);
                return result;
            }
        }

        public static void UpdateJson(this AdvanceSettingModel _model)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\advance_setting.json";
            string json = JsonConvert.SerializeObject(_model);

            //write string to file
            File.WriteAllText(path, json);
        }

        public static string ToDisplayStatus<T>(this Enum val)
        {
            return val.GetAttribute<DisplayAttribute>().Name;
        }

        public static string ToDisplayStatusEnumInterval(this int val)
        {
            return ((enumInterval)val).GetAttribute<DisplayAttribute>().Name;
        }

        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
           where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }

        public static T GetJsonFile<T>(string url)
        {
            if (WebRequest.Create(url) is HttpWebRequest webRequest)
            {
                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var contributorsAsJson = sr.ReadToEnd();
                        var contributors = JsonConvert.DeserializeObject<T>(contributorsAsJson);
                        return (T)Convert.ChangeType(contributors, typeof(T));
                    }
                }
            }
            return (T)Convert.ChangeType(null, typeof(T));
        }

        public static JArray GetJsonArray(string url)
        {
            if (WebRequest.Create(url) is HttpWebRequest webRequest)
            {
                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";
                try
                {
                    using (var s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (var sr = new StreamReader(s))
                        {
                            var contributorsAsJson = sr.ReadToEnd();
                            var contributors = JArray.Parse(contributorsAsJson);
                            return contributors;
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static T To<T>(this ElementModel model)
        {
            if (model == null)
                return default(T);
            return StaticValues.MapperConfig.Map<T>(model); 
        }

        public static T To<T>(this List<ElementModel> model)
        {
            if (model == null)
                return default(T);
            return StaticValues.MapperConfig.Map<T>(model);
        }
    }
}
