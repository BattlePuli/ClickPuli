namespace ClickPuli
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpStopOnCharacter = this.Factory.CreateRibbonGroup();
            this.cbSelectUnderscore = this.Factory.CreateRibbonCheckBox();
            this.cbSelectColon = this.Factory.CreateRibbonCheckBox();
            this.cbSelectSemicolon = this.Factory.CreateRibbonCheckBox();
            this.cbSelectPeriod = this.Factory.CreateRibbonCheckBox();
            this.cbSelectExclamationMark = this.Factory.CreateRibbonCheckBox();
            this.cbSelectQuestionMark = this.Factory.CreateRibbonCheckBox();
            this.cbSelectQuotes = this.Factory.CreateRibbonCheckBox();
            this.cbSelectDoubleQuotes = this.Factory.CreateRibbonCheckBox();
            this.cbSelectComma = this.Factory.CreateRibbonCheckBox();
            this.cbSelectSquareBrackets = this.Factory.CreateRibbonCheckBox();
            this.cbSelectParentheses = this.Factory.CreateRibbonCheckBox();
            this.cbSelectBraces = this.Factory.CreateRibbonCheckBox();
            this.cbSelectChevrons = this.Factory.CreateRibbonCheckBox();
            this.cbSelectHash = this.Factory.CreateRibbonCheckBox();
            this.cbSelectHyphen = this.Factory.CreateRibbonCheckBox();
            this.grpMisc = this.Factory.CreateRibbonGroup();
            this.cbIncludeTrailingSpace = this.Factory.CreateRibbonCheckBox();
            this.cbAutoCopy = this.Factory.CreateRibbonCheckBox();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpStopOnCharacter.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpStopOnCharacter);
            this.tab1.Groups.Add(this.grpMisc);
            this.tab1.Label = "ClickPuli";
            this.tab1.Name = "tab1";
            // 
            // grpStopOnCharacter
            // 
            this.grpStopOnCharacter.Items.Add(this.cbSelectUnderscore);
            this.grpStopOnCharacter.Items.Add(this.cbSelectColon);
            this.grpStopOnCharacter.Items.Add(this.cbSelectSemicolon);
            this.grpStopOnCharacter.Items.Add(this.cbSelectPeriod);
            this.grpStopOnCharacter.Items.Add(this.cbSelectExclamationMark);
            this.grpStopOnCharacter.Items.Add(this.cbSelectQuestionMark);
            this.grpStopOnCharacter.Items.Add(this.cbSelectQuotes);
            this.grpStopOnCharacter.Items.Add(this.cbSelectDoubleQuotes);
            this.grpStopOnCharacter.Items.Add(this.cbSelectComma);
            this.grpStopOnCharacter.Items.Add(this.cbSelectSquareBrackets);
            this.grpStopOnCharacter.Items.Add(this.cbSelectParentheses);
            this.grpStopOnCharacter.Items.Add(this.cbSelectBraces);
            this.grpStopOnCharacter.Items.Add(this.cbSelectChevrons);
            this.grpStopOnCharacter.Items.Add(this.cbSelectHash);
            this.grpStopOnCharacter.Items.Add(this.cbSelectHyphen);
            this.grpStopOnCharacter.Label = "Also select character(s)...";
            this.grpStopOnCharacter.Name = "grpStopOnCharacter";
            // 
            // cbSelectUnderscore
            // 
            this.cbSelectUnderscore.Label = "_";
            this.cbSelectUnderscore.Name = "cbSelectUnderscore";
            this.cbSelectUnderscore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectUnderscore_Click);
            // 
            // cbSelectColon
            // 
            this.cbSelectColon.Label = ":";
            this.cbSelectColon.Name = "cbSelectColon";
            this.cbSelectColon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectColon_Click);
            // 
            // cbSelectSemicolon
            // 
            this.cbSelectSemicolon.Label = ";";
            this.cbSelectSemicolon.Name = "cbSelectSemicolon";
            this.cbSelectSemicolon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectSemicolon_Click);
            // 
            // cbSelectPeriod
            // 
            this.cbSelectPeriod.Label = ".";
            this.cbSelectPeriod.Name = "cbSelectPeriod";
            this.cbSelectPeriod.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectPeriod_Click);
            // 
            // cbSelectExclamationMark
            // 
            this.cbSelectExclamationMark.Label = "!";
            this.cbSelectExclamationMark.Name = "cbSelectExclamationMark";
            this.cbSelectExclamationMark.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectExclamationMark_Click);
            // 
            // cbSelectQuestionMark
            // 
            this.cbSelectQuestionMark.Label = "?";
            this.cbSelectQuestionMark.Name = "cbSelectQuestionMark";
            this.cbSelectQuestionMark.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectQuestionMark_Click);
            // 
            // cbSelectQuotes
            // 
            this.cbSelectQuotes.Label = "\'";
            this.cbSelectQuotes.Name = "cbSelectQuotes";
            this.cbSelectQuotes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectQuotes_Click);
            // 
            // cbSelectDoubleQuotes
            // 
            this.cbSelectDoubleQuotes.Label = "\"";
            this.cbSelectDoubleQuotes.Name = "cbSelectDoubleQuotes";
            this.cbSelectDoubleQuotes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectDoubleQuotes_Click);
            // 
            // cbSelectComma
            // 
            this.cbSelectComma.Label = ",";
            this.cbSelectComma.Name = "cbSelectComma";
            this.cbSelectComma.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectComma_Click);
            // 
            // cbSelectSquareBrackets
            // 
            this.cbSelectSquareBrackets.Label = "[ ]";
            this.cbSelectSquareBrackets.Name = "cbSelectSquareBrackets";
            this.cbSelectSquareBrackets.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectSquareBrackets_Click);
            // 
            // cbSelectParentheses
            // 
            this.cbSelectParentheses.Label = "( )";
            this.cbSelectParentheses.Name = "cbSelectParentheses";
            this.cbSelectParentheses.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectParentheses_Click);
            // 
            // cbSelectBraces
            // 
            this.cbSelectBraces.Label = "{ }";
            this.cbSelectBraces.Name = "cbSelectBraces";
            this.cbSelectBraces.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectBraces_Click);
            // 
            // cbSelectChevrons
            // 
            this.cbSelectChevrons.Label = "< >";
            this.cbSelectChevrons.Name = "cbSelectChevrons";
            this.cbSelectChevrons.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectChevrons_Click);
            // 
            // cbSelectHash
            // 
            this.cbSelectHash.Label = "#";
            this.cbSelectHash.Name = "cbSelectHash";
            this.cbSelectHash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectHash_Click);
            // 
            // cbSelectHyphen
            // 
            this.cbSelectHyphen.Label = "-";
            this.cbSelectHyphen.Name = "cbSelectHyphen";
            this.cbSelectHyphen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbSelectHyphen_Click);
            // 
            // grpMisc
            // 
            this.grpMisc.Items.Add(this.cbIncludeTrailingSpace);
            this.grpMisc.Items.Add(this.cbAutoCopy);
            this.grpMisc.Items.Add(this.btnAbout);
            this.grpMisc.Label = "Misc";
            this.grpMisc.Name = "grpMisc";
            // 
            // cbIncludeTrailingSpace
            // 
            this.cbIncludeTrailingSpace.Label = "select trailing space";
            this.cbIncludeTrailingSpace.Name = "cbIncludeTrailingSpace";
            this.cbIncludeTrailingSpace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbIncludeTrailingSpace_Click);
            // 
            // cbAutoCopy
            // 
            this.cbAutoCopy.Label = "auto-copy";
            this.cbAutoCopy.Name = "cbAutoCopy";
            this.cbAutoCopy.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbAutoCopy_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ClickPuli.Properties.Resources.info;
            this.btnAbout.Label = "About";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShowImage = true;
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpStopOnCharacter.ResumeLayout(false);
            this.grpStopOnCharacter.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpMisc;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpStopOnCharacter;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbIncludeTrailingSpace;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbAutoCopy;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectUnderscore;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectColon;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectComma;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectSemicolon;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectExclamationMark;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectHash;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectParentheses;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectSquareBrackets;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectBraces;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectChevrons;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectQuotes;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectDoubleQuotes;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectHyphen;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectPeriod;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSelectQuestionMark;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
