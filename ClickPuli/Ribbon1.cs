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
            cbSelectUnderscore.Checked = Settings1.Default.SelectUnderscore;
            addIn.UpdateUnderscoreLimitChar();
            cbSelectPeriod.Checked = Settings1.Default.SelectPeriod;
            addIn.UpdatePeriodLimitChar();
            cbSelectComma.Checked = Settings1.Default.SelectComma;
            addIn.UpdateCommaLimitChar();
            cbSelectSemicolon.Checked = Settings1.Default.SelectSemicolon;
            addIn.UpdateSemicolonLimitChar();
            cbSelectExclamationMark.Checked = Settings1.Default.SelectExclamationMark;
            addIn.UpdateExclamationMarkLimitChar();
            cbSelectQuestionMark.Checked = Settings1.Default.SelectQuestionMark;
            addIn.UpdateQuestionMarkLimitChar();
            cbSelectHash.Checked = Settings1.Default.SelectHash;
            addIn.UpdateHashLimitChar();
            cbSelectParentheses.Checked = Settings1.Default.SelectParentheses;
            addIn.UpdateParenthesisLimitChar();
            cbSelectSquareBrackets.Checked = Settings1.Default.SelectSquareBrackets;
            addIn.UpdateSquareBracketsLimitChar();
            cbSelectBraces.Checked = Settings1.Default.SelectBraces;
            addIn.UpdateBracesLimitChar();
            cbSelectChevrons.Checked = Settings1.Default.SelectChevrons;
            addIn.UpdateChevronsLimitChar();
            cbSelectQuotes.Checked = Settings1.Default.SelectQuotes;
            addIn.UpdateQuotesLimitChar();
            cbSelectDoubleQuotes.Checked = Settings1.Default.SelectDoubleQuotes;
            addIn.UpdateDoubleQuotesLimitChar();
            cbSelectHyphen.Checked = Settings1.Default.SelectHyphen;
            addIn.UpdateHyphenLimitChar();
            cbSelectColon.Checked = Settings1.Default.SelectColon;
            addIn.UpdateColonLimitChar();

            cbIncludeTrailingSpace.Checked = Settings1.Default.IncludeTrailingSpace;
            cbAutoCopy.Checked = Settings1.Default.AutoCopy;
        }

        private void cbIncludeTrailingSpace_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.IncludeTrailingSpace = cbIncludeTrailingSpace.Checked;
            Settings1.Default.Save();
        }

        private void cbAutoCopy_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.AutoCopy = cbAutoCopy.Checked;
            Settings1.Default.Save();
        }

        private void cbSelectUnderscore_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectUnderscore = cbSelectUnderscore.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateUnderscoreLimitChar();
        }

        private void cbSelectColon_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectColon = cbSelectColon.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateColonLimitChar();
        }

        private void cbSelectComma_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectComma = cbSelectComma.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateCommaLimitChar();
        }

        private void cbSelectSemicolon_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectSemicolon = cbSelectSemicolon.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateSemicolonLimitChar();
        }

        private void cbSelectExclamationMark_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectExclamationMark = cbSelectExclamationMark.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateExclamationMarkLimitChar();
        }

        private void cbSelectHash_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectHash = cbSelectHash.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateHashLimitChar();
        }

        private void cbSelectParentheses_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectParentheses = cbSelectParentheses.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateParenthesisLimitChar();
        }

        private void cbSelectSquareBrackets_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectSquareBrackets = cbSelectSquareBrackets.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateSquareBracketsLimitChar();
        }

        private void cbSelectBraces_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectBraces = cbSelectBraces.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateBracesLimitChar();
        }

        private void cbSelectChevrons_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectChevrons = cbSelectChevrons.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateChevronsLimitChar();
        }

        private void cbSelectQuotes_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectQuotes = cbSelectQuotes.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateQuotesLimitChar();
        }

        private void cbSelectDoubleQuotes_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectDoubleQuotes = cbSelectDoubleQuotes.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateDoubleQuotesLimitChar();
        }

        private void cbSelectHyphen_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectHyphen = cbSelectHyphen.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateHyphenLimitChar();
        }

        private void cbSelectPeriod_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectPeriod = cbSelectPeriod.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdatePeriodLimitChar();
        }

        private void cbSelectQuestionMark_Click(object sender, RibbonControlEventArgs e)
        {
            Settings1.Default.SelectQuestionMark = cbSelectQuestionMark.Checked;
            Settings1.Default.Save();
            var addIn = Globals.ThisAddIn;
            addIn.UpdateQuestionMarkLimitChar();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            var addIn = Globals.ThisAddIn;
            addIn.aboutForm.ShowDialog();
        }
    }
}
