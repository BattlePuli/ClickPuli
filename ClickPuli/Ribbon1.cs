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
            // Update the UI and the internal vars based on the stored settings.
            var addIn = Globals.ThisAddIn;
            cbStopOnUnderscore.Checked = Settings1.Default.stopOnUnderscore;
            addIn.updateUnderscoreLimitChar();
            cbStopOnPeriod.Checked = Settings1.Default.stopOnPeriod;
            addIn.updatePeriodLimitChar();
            cbStopOnComma.Checked = Settings1.Default.stopOnComma;
            addIn.updateCommaLimitChar();
            cbStopOnSemicolon.Checked = Settings1.Default.stopOnSemicolon;
            addIn.updateSemicolonLimitChar();
            cbStopOnExclamationMark.Checked = Settings1.Default.stopOnExclamationMark;
            addIn.updateExclamationMarkLimitChar();
            cbStopOnQuestionMark.Checked = Settings1.Default.stopOnQuestionMark;
            addIn.updateQuestionMarkLimitChar();
            cbStopOnHash.Checked = Settings1.Default.stopOnHash;
            addIn.updateHashLimitChar();
            cbStopOnParentheses.Checked = Settings1.Default.stopOnParentheses;
            addIn.updateParenthesisLimitChar();
            cbStopOnSquareBrackets.Checked = Settings1.Default.stopOnSquareBrackets;
            addIn.updateSquareBracketsLimitChar();
            cbStopOnBraces.Checked = Settings1.Default.stopOnBraces;
            addIn.updateBracesLimitChar();
            cbStopOnChevrons.Checked = Settings1.Default.stopOnChevrons;
            addIn.updateChevronsLimitChar();
            cbStopOnQuotes.Checked = Settings1.Default.stopOnQuotes;
            addIn.updateQuotesLimitChar();
            cbStopOnDoubleQuotes.Checked = Settings1.Default.stopOnDoubleQuotes;
            addIn.updateDoubleQuotesLimitChar();
            cbStopOnHyphen.Checked = Settings1.Default.stopOnHyphen;
            addIn.updateHyphenLimitChar();
            cbStopOnColon.Checked = Settings1.Default.stopOnColon;
            addIn.updateColonLimitChar();

            cbIncludeTrailingSpace.Checked = Settings1.Default.includeTrailingSpace;
            cbAutoCopy.Checked = Settings1.Default.autoCopy;
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
            addIn.updateUnderscoreLimitChar();
        }

        private void cbStopOnColon_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnColon = cbStopOnColon.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateColonLimitChar();
        }

        private void cbStopOnComma_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnComma = cbStopOnComma.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateCommaLimitChar();
        }

        private void cbStopOnSemicolon_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnSemicolon = cbStopOnSemicolon.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateSemicolonLimitChar();
        }

        private void cbStopOnExclamationMark_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnExclamationMark = cbStopOnExclamationMark.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateExclamationMarkLimitChar();
        }

        private void cbStopOnHash_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnHash = cbStopOnHash.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateHashLimitChar();
        }

        private void cbStopOnParentheses_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnParentheses = cbStopOnParentheses.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateParenthesisLimitChar();
        }

        private void cbStopOnSquareBrackets_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnSquareBrackets = cbStopOnSquareBrackets.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateSquareBracketsLimitChar();
        }

        private void cbStopOnBraces_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnBraces = cbStopOnBraces.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateBracesLimitChar();
        }

        private void cbStopOnChevrons_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnChevrons = cbStopOnChevrons.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateChevronsLimitChar();
        }

        private void cbStopOnQuotes_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnQuotes = cbStopOnQuotes.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateQuotesLimitChar();
        }

        private void cbStopOnDoubleQuotes_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnDoubleQuotes = cbStopOnDoubleQuotes.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateDoubleQuotesLimitChar();
        }

        private void cbStopOnHyphen_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnHyphen = cbStopOnHyphen.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateHyphenLimitChar();
        }

        private void cbStopOnPeriod_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnPeriod = cbStopOnPeriod.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updatePeriodLimitChar();
        }

        private void cbStopOnQuestionMark_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.stopOnQuestionMark = cbStopOnQuestionMark.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.updateQuestionMarkLimitChar();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            var addIn = Globals.ThisAddIn;
            addIn.aboutForm.ShowDialog();
        }
    }
}
