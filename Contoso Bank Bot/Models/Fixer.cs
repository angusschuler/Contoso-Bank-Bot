using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Contoso_Bank_Bot.Models
{

    public class Fixer
    {
        public static async Task<double?> ConversionAsync(HttpClient client, string Currency1, string Currency2)
        {
            try
            {
                string x = await client.GetStringAsync(new Uri("http://api.fixer.io/latest?base=" + Currency1.ToUpper() + ";symbols=" + Currency2.ToUpper()));
                Currency.RootObject rootObject;
                rootObject = JsonConvert.DeserializeObject<Currency.RootObject>(x);
                double rate;

                switch (Currency2.ToUpper())
                {
                    case "AUD":
                        rate = rootObject.rates.AUD; 
                        break;
                    case "BGN":
                        rate = rootObject.rates.BGN;
                        break;
                    case "BRL":
                        rate = rootObject.rates.BRL;
                        break;
                    case "CAD":
                        rate = rootObject.rates.CAD;
                        break;
                    case "CHF":
                        rate = rootObject.rates.CHF;
                        break;
                    case "CNY":
                        rate = rootObject.rates.CNY;
                        break;
                    case "CZK":
                        rate = rootObject.rates.CZK;
                        break;
                    case "DKK":
                        rate = rootObject.rates.DKK;
                        break;
                    case "EUR":
                        rate = rootObject.rates.EUR;
                        break;
                    case "GBP":
                        rate = rootObject.rates.GBP;
                        break;
                    case "HKD":
                        rate = rootObject.rates.HKD;
                        break;
                    case "HRK":
                        rate = rootObject.rates.HRK;
                        break;
                    case "HUF":
                        rate = rootObject.rates.HUF;
                        break;
                    case "IDR":
                        rate = rootObject.rates.IDR;
                        break;
                    case "ILS":
                        rate = rootObject.rates.ILS;
                        break;
                    case "INR":
                        rate = rootObject.rates.INR;
                        break;
                    case "JPY":
                        rate = rootObject.rates.JPY;
                        break;
                    case "KRW":
                        rate = rootObject.rates.KRW;
                        break;
                    case "MXN":
                        rate = rootObject.rates.MXN;
                        break;
                    case "MYR":
                        rate = rootObject.rates.MYR;
                        break;
                    case "NOK":
                        rate = rootObject.rates.NOK;
                        break;
                    case "NZD":
                        rate = rootObject.rates.NZD;
                        break;
                    case "PHP":
                        rate = rootObject.rates.PHP;
                        break;
                    case "PLN":
                        rate = rootObject.rates.PLN;
                        break;
                    case "RON":
                        rate = rootObject.rates.RON;
                        break;
                    case "RUB":
                        rate = rootObject.rates.RUB;
                        break;
                    case "SEK":
                        rate = rootObject.rates.SEK;
                        break;
                    case "SGD":
                        rate = rootObject.rates.SGD;
                        break;
                    case "THB":
                        rate = rootObject.rates.THB;
                        break;
                    case "TRY":
                        rate = rootObject.rates.TRY;
                        break;
                    case "USD":
                        rate = rootObject.rates.USD;
                        break;
                    case "ZAR":
                        rate = rootObject.rates.ZAR;
                        break;
                    default:
                        return null;
                }                
                return rate;
            }
            catch (WebException ex)
            {
                //handle your exception here  
                throw ex;
            }
        }
    }
}