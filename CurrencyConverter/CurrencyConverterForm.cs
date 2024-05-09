using CurrencyConverter.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverterForm : Form
    {
        private readonly CurrencyConverterDB db = new CurrencyConverterDB();

        private List<Currency> currencies;

        private double originAm = 1;
        private int originCurrId = 16;
        private int targetCurrId = 14;
        private int periodId = 1;

        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void ConvertCurrency()
        {
            decimal result = 0;
            decimal amount = Convert.ToDecimal(originAm);

            USDExchangeRate originRate = db.USDExchangeRates.FirstOrDefault(r => r.currency_id == originCurrId && r.period_id == periodId);
            USDExchangeRate targetRate = db.USDExchangeRates.FirstOrDefault(r => r.currency_id == targetCurrId && r.period_id == periodId);
       
            if (originCurrId == 28 && targetRate != null)
            {
                result = amount * targetRate.rate;
            } else if (targetCurrId == 28 && originRate != null)
            {
                result = amount / originRate.rate;
            } else if (targetRate != null && originRate != null)
            {
                result = targetRate.rate / originRate.rate * amount;
            }

            InpTargetAm.Text = Decimal.Round(result, 3).ToString();
        }

        private void InitData()
        {
            currencies = db.Currencies.ToList();

            SelPeriod.DataSource = db.Periods.ToList();
            SelOriginCurr.DataSource = currencies.ToList();
            SelTargetCurr.DataSource = currencies.ToList();

            InpOriginAm.Text = originAm.ToString();
            SelOriginCurr.SelectedValue = originCurrId;
            SelTargetCurr.SelectedValue = targetCurrId;
        }

        private void SelPeriodValChanged(object sender, EventArgs e)
        {
            periodId = (int)SelPeriod.SelectedValue;
            ConvertCurrency();
        }

        private void InpOriginAmTextChanged(object sender, EventArgs e)
        {
            try
            {
                if (InpOriginAm.Text != "")
                {
                    originAm = Convert.ToDouble(InpOriginAm.Text);
                    ConvertCurrency();
                }
            } catch
            {
                originAm = 1;
                InpOriginAm.Text = "1";
                MessageBox.Show("Masukkan angka!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelOriginCurrValChanged(object sender, EventArgs e)
        {
            originCurrId = (int)SelOriginCurr.SelectedValue;
            LabOriginCurr.Text = currencies.First(c => c.id == originCurrId).name;
            ConvertCurrency();
        }

        private void ButSwapClick(object sender, EventArgs e)
        {
            int originCurrTemp = originCurrId;
            int targeCurrTemp = targetCurrId;
            InpOriginAm.Text = InpTargetAm.Text;
            SelOriginCurr.SelectedValue = targeCurrTemp;
            SelTargetCurr.SelectedValue = originCurrTemp;
        }

        private void SelTargetCurrValChanged(object sender, EventArgs e)
        {
            targetCurrId = (int)SelTargetCurr.SelectedValue;
            LabTargetCurr.Text = currencies.First(c => c.id == targetCurrId).name;
            ConvertCurrency();
        }

        private void CurrencyConverterFormLoad(object sender, EventArgs e)
        {
            InitData();
            ConvertCurrency();
        }
    }
}
