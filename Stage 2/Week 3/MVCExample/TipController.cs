using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    class TipController
    {
        /// 

        /// The TipCalculatorController class brings together 
        /// the TipView and the TipModel classes

        /// 

        private TipModel aTip;
        private TipView aView;

        public TipController()
        {
            // instantiate a view
            aView = new TipView();
            // instantiate a model
            aTip = new TipModel();

            // note the interaction between the model and view
            // in inputting and outputting the information
            aTip.Amount = aView.GetAmountValue();
            aTip.TipPercent = aView.GetPctValue();
            aView.ShowTipandTotal(aTip.CalculateTip(), aTip.CalculateTotal());
        }
    }
}
