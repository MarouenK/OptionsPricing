using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace OptionsPricing
{
    public partial class OptionsPricing : Form
    {
        public OptionsPricing()
        {
            InitializeComponent();
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            double s;
            bool r0 = Double.TryParse(textBoxStockPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out s);

            double k;
            bool r1 = Double.TryParse(textBoxStrikePrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out k);

            double r;
            bool r2 = Double.TryParse(textBoxRiskFreeRate.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r);

            double t=0;
            bool r3 = false;
            if (textBoxTimeToMat.Text.Contains('/'))
            {
                string[] mat = textBoxTimeToMat.Text.Split('/');
                double mat0;
                double mat1;
                bool r03 = Double.TryParse(mat[0], NumberStyles.Any, CultureInfo.InvariantCulture, out mat0);
                bool r13 = Double.TryParse(mat[1], NumberStyles.Any, CultureInfo.InvariantCulture, out mat1);
                if (r03 && r13)
                {
                    t = mat0 / mat1;
                    r3 = true;
                }
            }
            else
            {
                r3 = Double.TryParse(textBoxTimeToMat.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out t);
            }

            double std;
            bool r4 = Double.TryParse(textBoxStdDev.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out std);

            if (r0 && r1 && r2 && r3 && r4)
            {
                double[] rootSol = OptionsPricingHelper.GetOptionRootSolutions(s, k, t, std, r);
                double callPrice = OptionsPricingHelper.GetOptionCallPrice(s, k, r, t, rootSol);
                double putPrice = OptionsPricingHelper.GetOptionPutPrice(s, k, r, t, rootSol);

                textBoxCallPrice.Text = callPrice.ToString();
                textBoxPutPrice.Text = putPrice.ToString();
            }
            else
            {
                MessageBox.Show("Please make sure all variables are filled correctly","Input variables Error");
            }
            
        }
    }
}
