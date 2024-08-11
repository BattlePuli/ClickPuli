using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickPuli
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            // Populate the settings ribbon so that it mathces the stored settings.
            cbStopOnUnderscore.Checked = Settings1.Default.stopOnUnderscore;
            cbStopOnPeriod.Checked = Settings1.Default.stopOnPeriod;
            cbStopOnComma.Checked = Settings1.Default.stopOnComma;
            cbStopOnSemicolon.Checked = Settings1.Default.stopOnSemicolon;
            cbStopOnExclamationMark.Checked = Settings1.Default.stopOnExclamationMark;
            cbStopOnQuestionMark.Checked = Settings1.Default.stopOnQuestionMark;
            cbStopOnHash.Checked = Settings1.Default.stopOnHash;
            cbStopOnParentheses.Checked = Settings1.Default.stopOnParentheses;
            cbStopOnSquareBrackets.Checked = Settings1.Default.stopOnSquareBrackets;
            cbStopOnBraces.Checked = Settings1.Default.stopOnBraces;
            cbStopOnChevrons.Checked = Settings1.Default.stopOnChevrons;
            cbStopOnQuotes.Checked = Settings1.Default.stopOnQuotes;
            cbStopOnDoubleQuotes.Checked = Settings1.Default.stopOnDoubleQuotes;
            cbStopOnHyphen.Checked = Settings1.Default.stopOnHyphen;
            cbStopOnColon.Checked = Settings1.Default.stopOnColon;

            cbIncludeTrailingSpace.Checked = Settings1.Default.includeTrailingSpace;
            cbAutoCopy.Checked = Settings1.Default.autoCopy;

            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbIncludeTrailingSpace_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.includeTrailingSpace = cbIncludeTrailingSpace.Checked;
            Settings1.Default.Save();
        }

        private void cbAutoCopy_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.autoCopy = cbAutoCopy.Checked;
            Settings1.Default.Save();
        }

        private void cbStopOnUnderscore_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnUnderscore = cbStopOnUnderscore.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnColon_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnColon = cbStopOnColon.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnComma_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnComma = cbStopOnComma.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnSemicolon_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnSemicolon = cbStopOnSemicolon.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnExclamationMark_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnExclamationMark = cbStopOnExclamationMark.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnHash_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnHash = cbStopOnHash.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnParentheses_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnParentheses = cbStopOnParentheses.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnSquareBrackets_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnSquareBrackets = cbStopOnSquareBrackets.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnBraces_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnBraces = cbStopOnBraces.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnChevrons_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnChevrons = cbStopOnChevrons.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnQuotes_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnQuotes = cbStopOnQuotes.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnDoubleQuotes_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnDoubleQuotes = cbStopOnDoubleQuotes.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnHyphen_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnHyphen = cbStopOnHyphen.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnPeriod_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnPeriod = cbStopOnPeriod.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void cbStopOnQuestionMark_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnQuestionMark = cbStopOnQuestionMark.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateLimitChars();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            var addIn = Globals.ThisAddIn;
            addIn.aboutForm.ShowDialog();
        }
    }
}
