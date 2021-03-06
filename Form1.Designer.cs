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
            this.TotalBuyLabel = new System.Windows.Forms.Label();
            this.TokenCurrentPriceListView = new System.Windows.Forms.ListView();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.ReloadPriceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // walletContentListView
            // 
            this.walletContentListView.AllowColumnReorder = true;
            this.walletContentListView.HideSelection = false;
            this.walletContentListView.Location = new System.Drawing.Point(12, 12);
            this.walletContentListView.MultiSelect = false;
            this.walletContentListView.Name = "walletContentListView";
            this.walletContentListView.Size = new System.Drawing.Size(384, 403);
            this.walletContentListView.TabIndex = 0;
            this.walletContentListView.UseCompatibleStateImageBehavior = false;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(524, 97);
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
            this.buyPriceInput.Location = new System.Drawing.Point(642, 37);
            this.buyPriceInput.Name = "buyPriceInput";
            this.buyPriceInput.Size = new System.Drawing.Size(112, 23);
            this.buyPriceInput.TabIndex = 3;
            this.buyPriceInput.Text = "";
            this.buyPriceInput.TextChanged += new System.EventHandler(this.buyPriceInput_TextChanged);
            // 
            // buyPriceLabel
            // 
            this.buyPriceLabel.AutoSize = true;
            this.buyPriceLabel.Location = new System.Drawing.Point(639, 17);
            this.buyPriceLabel.Name = "buyPriceLabel";
            this.buyPriceLabel.Size = new System.Drawing.Size(66, 13);
            this.buyPriceLabel.TabIndex = 4;
            this.buyPriceLabel.Text = "Buy price (€)";
            // 
            // buyValueInput
            // 
            this.buyValueInput.Location = new System.Drawing.Point(524, 37);
            this.buyValueInput.Name = "buyValueInput";
            this.buyValueInput.Size = new System.Drawing.Size(112, 23);
            this.buyValueInput.TabIndex = 5;
            this.buyValueInput.Text = "";
            this.buyValueInput.TextChanged += new System.EventHandler(this.buyValueInput_TextChanged);
            // 
            // buyValueLabel
            // 
            this.buyValueLabel.AutoSize = true;
            this.buyValueLabel.Location = new System.Drawing.Point(521, 17);
            this.buyValueLabel.Name = "buyValueLabel";
            this.buyValueLabel.Size = new System.Drawing.Size(70, 13);
            this.buyValueLabel.TabIndex = 6;
            this.buyValueLabel.Text = "Value (token)";
            // 
            // TokenTypeList
            // 
            this.TokenTypeList.BackColor = System.Drawing.SystemColors.Window;
            this.TokenTypeList.DisplayMember = "1";
            this.TokenTypeList.FormattingEnabled = true;
            this.TokenTypeList.Location = new System.Drawing.Point(405, 35);
            this.TokenTypeList.Name = "TokenTypeList";
            this.TokenTypeList.Size = new System.Drawing.Size(113, 82);
            this.TokenTypeList.Sorted = true;
            this.TokenTypeList.TabIndex = 7;
            // 
            // TokenTypeLabel
            // 
            this.TokenTypeLabel.AutoSize = true;
            this.TokenTypeLabel.Location = new System.Drawing.Point(402, 17);
            this.TokenTypeLabel.Name = "TokenTypeLabel";
            this.TokenTypeLabel.Size = new System.Drawing.Size(38, 13);
            this.TokenTypeLabel.TabIndex = 8;
            this.TokenTypeLabel.Text = "Token";
            // 
            // walletListLabel
            // 
            this.walletListLabel.AutoSize = true;
            this.walletListLabel.Location = new System.Drawing.Point(757, 17);
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
            "Metamask"});
            this.walletListBox.Location = new System.Drawing.Point(760, 37);
            this.walletListBox.Name = "walletListBox";
            this.walletListBox.Size = new System.Drawing.Size(112, 82);
            this.walletListBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(10, 419);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(204, 419);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(192, 23);
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // editionBoxButton
            // 
            this.editionBoxButton.AutoSize = true;
            this.editionBoxButton.Location = new System.Drawing.Point(405, 423);
            this.editionBoxButton.Name = "editionBoxButton";
            this.editionBoxButton.Size = new System.Drawing.Size(87, 17);
            this.editionBoxButton.TabIndex = 13;
            this.editionBoxButton.Text = "Edition mode";
            this.editionBoxButton.UseVisualStyleBackColor = true;
            // 
            // TotalBuyLabel
            // 
            this.TotalBuyLabel.AutoSize = true;
            this.TotalBuyLabel.Location = new System.Drawing.Point(402, 323);
            this.TotalBuyLabel.Name = "TotalBuyLabel";
            this.TotalBuyLabel.Size = new System.Drawing.Size(62, 13);
            this.TotalBuyLabel.TabIndex = 14;
            this.TotalBuyLabel.Text = "Total Spent";
            // 
            // TokenCurrentPriceListView
            // 
            this.TokenCurrentPriceListView.HideSelection = false;
            this.TokenCurrentPriceListView.Location = new System.Drawing.Point(405, 163);
            this.TokenCurrentPriceListView.Name = "TokenCurrentPriceListView";
            this.TokenCurrentPriceListView.Size = new System.Drawing.Size(467, 121);
            this.TokenCurrentPriceListView.TabIndex = 15;
            this.TokenCurrentPriceListView.UseCompatibleStateImageBehavior = false;
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(402, 366);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(61, 13);
            this.TotalValueLabel.TabIndex = 16;
            this.TotalValueLabel.Text = "Total Value";
            // 
            // ReloadPriceButton
            // 
            this.ReloadPriceButton.Location = new System.Drawing.Point(405, 383);
            this.ReloadPriceButton.Name = "ReloadPriceButton";
            this.ReloadPriceButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadPriceButton.TabIndex = 17;
            this.ReloadPriceButton.Text = "Reload price";
            this.ReloadPriceButton.UseVisualStyleBackColor = true;
            this.ReloadPriceButton.Click += new System.EventHandler(this.ReloadPriceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ReloadPriceButton);
            this.Controls.Add(this.TotalValueLabel);
            this.Controls.Add(this.TokenCurrentPriceListView);
            this.Controls.Add(this.TotalBuyLabel);
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
        private System.Windows.Forms.Label TotalBuyLabel;
        private System.Windows.Forms.ListView TokenCurrentPriceListView;
        private System.Windows.Forms.Label TotalValueLabel;
        private System.Windows.Forms.Button ReloadPriceButton;
    }
}

