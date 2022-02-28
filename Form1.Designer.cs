namespace CryptoManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.walletContentListView = new System.Windows.Forms.ListView();
            this.BuyButton = new System.Windows.Forms.Button();
            this.buyPriceInput = new System.Windows.Forms.RichTextBox();
            this.buyPriceLabel = new System.Windows.Forms.Label();
            this.buyValueInput = new System.Windows.Forms.RichTextBox();
            this.buyValueLabel = new System.Windows.Forms.Label();
            this.TokenTypeList = new System.Windows.Forms.ListBox();
            this.TokenTypeLabel = new System.Windows.Forms.Label();
            this.walletListLabel = new System.Windows.Forms.Label();
            this.walletListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.editionBoxButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // walletContentListView
            // 
            this.walletContentListView.AllowColumnReorder = true;
            this.walletContentListView.HideSelection = false;
            this.walletContentListView.Location = new System.Drawing.Point(12, 12);
            this.walletContentListView.MultiSelect = false;
            this.walletContentListView.Name = "walletContentListView";
            this.walletContentListView.Size = new System.Drawing.Size(303, 403);
            this.walletContentListView.TabIndex = 0;
            this.walletContentListView.UseCompatibleStateImageBehavior = false;
            this.walletContentListView.SelectedIndexChanged += new System.EventHandler(this.walletContentListView_SelectedIndexChanged);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(440, 99);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(230, 23);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Tag = "";
            this.BuyButton.Text = "Validate buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // buyPriceInput
            // 
            this.buyPriceInput.Location = new System.Drawing.Point(558, 39);
            this.buyPriceInput.Name = "buyPriceInput";
            this.buyPriceInput.Size = new System.Drawing.Size(112, 23);
            this.buyPriceInput.TabIndex = 3;
            this.buyPriceInput.Text = "";
            this.buyPriceInput.TextChanged += new System.EventHandler(this.buyPriceInput_TextChanged);
            // 
            // buyPriceLabel
            // 
            this.buyPriceLabel.AutoSize = true;
            this.buyPriceLabel.Location = new System.Drawing.Point(555, 19);
            this.buyPriceLabel.Name = "buyPriceLabel";
            this.buyPriceLabel.Size = new System.Drawing.Size(66, 13);
            this.buyPriceLabel.TabIndex = 4;
            this.buyPriceLabel.Text = "Buy price (€)";
            this.buyPriceLabel.Click += new System.EventHandler(this.buyPriceLabel_Click);
            // 
            // buyValueInput
            // 
            this.buyValueInput.Location = new System.Drawing.Point(440, 39);
            this.buyValueInput.Name = "buyValueInput";
            this.buyValueInput.Size = new System.Drawing.Size(112, 23);
            this.buyValueInput.TabIndex = 5;
            this.buyValueInput.Text = "";
            this.buyValueInput.TextChanged += new System.EventHandler(this.buyValueInput_TextChanged);
            // 
            // buyValueLabel
            // 
            this.buyValueLabel.AutoSize = true;
            this.buyValueLabel.Location = new System.Drawing.Point(437, 19);
            this.buyValueLabel.Name = "buyValueLabel";
            this.buyValueLabel.Size = new System.Drawing.Size(70, 13);
            this.buyValueLabel.TabIndex = 6;
            this.buyValueLabel.Text = "Value (token)";
            this.buyValueLabel.Click += new System.EventHandler(this.buyValueLabel_Click);
            // 
            // TokenTypeList
            // 
            this.TokenTypeList.BackColor = System.Drawing.SystemColors.Window;
            this.TokenTypeList.DisplayMember = "1";
            this.TokenTypeList.FormattingEnabled = true;
            this.TokenTypeList.Items.AddRange(new object[] {
            "ALGO",
            "AVAX",
            "BTC",
            "DOGE",
            "ETH",
            "GRT",
            "ICP",
            "LINK",
            "LTC",
            "MANA",
            "MATIC",
            "XLM",
            "XMR",
            "XRP",
            "XTZ"});
            this.TokenTypeList.Location = new System.Drawing.Point(321, 37);
            this.TokenTypeList.Name = "TokenTypeList";
            this.TokenTypeList.Size = new System.Drawing.Size(113, 56);
            this.TokenTypeList.Sorted = true;
            this.TokenTypeList.TabIndex = 7;
            // 
            // TokenTypeLabel
            // 
            this.TokenTypeLabel.AutoSize = true;
            this.TokenTypeLabel.Location = new System.Drawing.Point(318, 19);
            this.TokenTypeLabel.Name = "TokenTypeLabel";
            this.TokenTypeLabel.Size = new System.Drawing.Size(38, 13);
            this.TokenTypeLabel.TabIndex = 8;
            this.TokenTypeLabel.Text = "Token";
            // 
            // walletListLabel
            // 
            this.walletListLabel.AutoSize = true;
            this.walletListLabel.Location = new System.Drawing.Point(673, 19);
            this.walletListLabel.Name = "walletListLabel";
            this.walletListLabel.Size = new System.Drawing.Size(37, 13);
            this.walletListLabel.TabIndex = 9;
            this.walletListLabel.Text = "Wallet";
            // 
            // walletListBox
            // 
            this.walletListBox.FormattingEnabled = true;
            this.walletListBox.Items.AddRange(new object[] {
            "Coinbase",
            "MoneroGUI",
            "Bitpanda",
            "AgoraDesk",
            ""});
            this.walletListBox.Location = new System.Drawing.Point(676, 39);
            this.walletListBox.Name = "walletListBox";
            this.walletListBox.Size = new System.Drawing.Size(112, 56);
            this.walletListBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 415);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(151, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(164, 415);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(151, 23);
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // editionBoxButton
            // 
            this.editionBoxButton.AutoSize = true;
            this.editionBoxButton.Location = new System.Drawing.Point(321, 419);
            this.editionBoxButton.Name = "editionBoxButton";
            this.editionBoxButton.Size = new System.Drawing.Size(87, 17);
            this.editionBoxButton.TabIndex = 13;
            this.editionBoxButton.Text = "Edition mode";
            this.editionBoxButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editionBoxButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.walletListBox);
            this.Controls.Add(this.walletListLabel);
            this.Controls.Add(this.TokenTypeLabel);
            this.Controls.Add(this.TokenTypeList);
            this.Controls.Add(this.buyValueLabel);
            this.Controls.Add(this.buyValueInput);
            this.Controls.Add(this.buyPriceLabel);
            this.Controls.Add(this.buyPriceInput);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.walletContentListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView walletContentListView;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.RichTextBox buyPriceInput;
        private System.Windows.Forms.Label buyPriceLabel;
        private System.Windows.Forms.RichTextBox buyValueInput;
        private System.Windows.Forms.Label buyValueLabel;
        private System.Windows.Forms.Label TokenTypeLabel;
        private System.Windows.Forms.ListBox TokenTypeList;
        private System.Windows.Forms.Label walletListLabel;
        private System.Windows.Forms.ListBox walletListBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.CheckBox editionBoxButton;
    }
}

