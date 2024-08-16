using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using ClickPuli.Properties;

namespace ClickPuli
{
    public partial class ThisAddIn
    {
        Word.Application application;
        const double lookAheadLimit = 100;
        const double lookBehindLimit = 100;
        static List<string> defaultLimitChars = new List<string>() { " ", ",", ";", "\n", "\t", "¶", "(", ")", "[", "]", "{", "}", ".", Environment.NewLine };
        public List<string> limitChars = new List<string>(defaultLimitChars);
        public FrmAbout aboutForm = new FrmAbout();

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            application = this.Application;
            application.WindowBeforeDoubleClick += new Word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(application_WindowBeforeDoubleClick);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void AddLimitChar(string str)
        {
            if (!limitChars.Contains(str))
            {
                limitChars.Add(str);
            }
        }

        // This is where the magic happens.
        public void application_WindowBeforeDoubleClick(Word.Selection selection, ref bool Cancel)
        {
            Cancel = true;

            string limitCharsString = "";
            foreach (string item in limitChars) limitCharsString += item;
            selection.MoveStartUntil(limitCharsString, -lookBehindLimit);
            selection.MoveEndUntil(limitCharsString, lookAheadLimit);

            if (Settings1.Default.IncludeTrailingSpace)
            {
                selection.MoveEndWhile(" ", 1);
            }

            if (Settings1.Default.AutoCopy)
            {
                selection.Copy();
            }
        }

        public void UpdateUnderscoreLimitChar()
        {
            if (Settings1.Default.SelectUnderscore)
            {
                limitChars.Remove("_");
            }
            else
            {
                AddLimitChar("_");
            }
        }

        public void UpdateColonLimitChar()
        {
            if (Settings1.Default.SelectColon)
            {
                limitChars.Remove(":");
            }
            else
            {
                AddLimitChar(":");
            }
        }

        public void UpdateSemicolonLimitChar()
        {
            if (Settings1.Default.SelectSemicolon)
            {
                limitChars.Remove(";");
            }
            else
            {
                AddLimitChar(";");
            }
        }

        public void UpdatePeriodLimitChar()
        {
            if (Settings1.Default.SelectPeriod)
            {
                limitChars.Remove(".");
                
            }
            else
            {
                AddLimitChar(".");
            }
        }

        public void UpdateCommaLimitChar()
        {
            if (Settings1.Default.SelectComma)
            {
                limitChars.Remove(",");                
            }
            else
            {
                AddLimitChar(",");
            }
        }

        public void UpdateExclamationMarkLimitChar()
        {
            if (Settings1.Default.SelectExclamationMark)
            {
                limitChars.Remove("!");                
            }
            else
            {
                AddLimitChar("!");
            }
        }

        public void UpdateQuestionMarkLimitChar()
        {
            if (Settings1.Default.SelectQuestionMark)
            {
                limitChars.Remove("?");                
            }
            else
            {
                AddLimitChar("?");
            }
        }

        public void UpdateHyphenLimitChar()
        {
            if (Settings1.Default.SelectHyphen)
            {
                limitChars.Remove("-");
            }
            else
            {
                AddLimitChar("-");
            }
        }

        public void UpdateQuotesLimitChar()
        {
            if (Settings1.Default.SelectQuotes)
            {                
                limitChars.Remove("\'");
                limitChars.Remove("’");

            }
            else
            {
                AddLimitChar("\'");
                AddLimitChar("’");
            }
        }

        public void UpdateDoubleQuotesLimitChar()
        {
            if (Settings1.Default.SelectDoubleQuotes)
            {
                limitChars.Remove("\"");
                limitChars.Remove("“");
                limitChars.Remove("”");

            }
            else
            {
                AddLimitChar("\"");
                AddLimitChar("“");
                AddLimitChar("”");
            }
        }

        public void UpdateParenthesisLimitChar()
        {
            if (Settings1.Default.SelectParentheses)
            {                
                limitChars.Remove("(");
                limitChars.Remove(")");
            }
            else
            {
                AddLimitChar("(");
                AddLimitChar(")");
            }
        }

        public void UpdateSquareBracketsLimitChar()
        {
            if (Settings1.Default.SelectSquareBrackets)
            {                
                limitChars.Remove("[");
                limitChars.Remove("]");
            }
            else
            {
                AddLimitChar("[");
                AddLimitChar("]");
            }
        }

        public void UpdateBracesLimitChar()
        {
            if (Settings1.Default.SelectBraces)
            {                
                limitChars.Remove("{");
                limitChars.Remove("}");
            }
            else
            {
                AddLimitChar("{");
                AddLimitChar("}");
            }
        }

        public void UpdateChevronsLimitChar()
        {
            if (Settings1.Default.SelectChevrons)
            {                
                limitChars.Remove("<");
                limitChars.Remove(">");
            }
            else
            {
                AddLimitChar("<");
                AddLimitChar(">");
            }
        }

        public void UpdateHashLimitChar()
        {
            if (Settings1.Default.SelectHash)
            {                
                limitChars.Remove("#");
            }
            else
            {
                AddLimitChar("#");
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
