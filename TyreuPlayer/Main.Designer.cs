﻿using System;

namespace TyreuPlayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.NameLabel = new Telerik.WinControls.UI.RadLabel();
            this.VolumeTrackBar = new Telerik.WinControls.UI.RadTrackBar();
            this.customShape1 = new Telerik.WinControls.CustomShape(this.components);
            this.object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5 = new Telerik.WinControls.EditorRootRadElement();
            this.customShape2 = new Telerik.WinControls.CustomShape(this.components);
            this.DurationTrackBar = new Telerik.WinControls.UI.RadTrackBar();
            this.CurrentDurationLabel = new Telerik.WinControls.UI.RadLabel();
            this.FullDurationLabel = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.TitleLabel = new Telerik.WinControls.UI.RadLabel();
            this.ArtistLabel = new Telerik.WinControls.UI.RadLabel();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerContextMenu = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.AddTrackItem = new Telerik.WinControls.UI.RadMenuItem();
            this.AddFolderItem = new Telerik.WinControls.UI.RadMenuItem();
            this.AddToQueueItem = new Telerik.WinControls.UI.RadMenuItem();
            this.DeleteFromQueueItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.Playlist = new Telerik.WinControls.UI.RadListView();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.OpenTrack = new System.Windows.Forms.OpenFileDialog();
            this.LikeButton = new Telerik.WinControls.UI.RadButton();
            this.PlayButton = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.CoverBox = new System.Windows.Forms.PictureBox();
            this.PlaylistButton = new Telerik.WinControls.UI.RadButton();
            this.ReplayButton = new Telerik.WinControls.UI.RadButton();
            this.ShuffleButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.CloseLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDurationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullDurationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            this.radCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShuffleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.NameLabel);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.CloseLabel);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.BorderHighlightThickness = 0;
            this.radPanel1.Size = new System.Drawing.Size(816, 57);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(202, 29);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Tyreu Player I (beta)";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            this.NameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseDown);
            this.NameLabel.MouseEnter += new System.EventHandler(this.NameLabel_MouseHover);
            this.NameLabel.MouseLeave += new System.EventHandler(this.NameLabel_MouseLeave);
            this.NameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseUp);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.AutoSize = false;
            this.VolumeTrackBar.Location = new System.Drawing.Point(12, 63);
            this.VolumeTrackBar.Maximum = 100F;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.ShowButtons = true;
            this.VolumeTrackBar.Size = new System.Drawing.Size(419, 42);
            this.VolumeTrackBar.SmallChange = 0;
            this.VolumeTrackBar.SmallTickFrequency = 0;
            this.VolumeTrackBar.TabIndex = 5;
            this.VolumeTrackBar.ThemeName = "Fluent";
            this.VolumeTrackBar.ThumbSize = new System.Drawing.Size(20, 20);
            this.VolumeTrackBar.TickStyle = Telerik.WinControls.Enumerations.TickStyles.None;
            this.VolumeTrackBar.Value = 100F;
            this.VolumeTrackBar.ValueChanged += new System.EventHandler(this.VolumeTrackBar_ValueChanged);
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.VolumeTrackBar.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.VolumeTrackBar.GetChildAt(0))).Shape = null;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.VolumeTrackBar.GetChildAt(0))).MinSize = new System.Drawing.Size(100, 0);
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0))).IsVertical = false;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarScaleContainerElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.TrackBarScaleContainerElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BorderColor = System.Drawing.SystemColors.ControlDark;
            ((Telerik.WinControls.UI.TrackBarScaleContainerElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.TrackBarScaleElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).ShowSlideArea = true;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).SlideAreaWidth = 5;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).ShowHorizontalLine = false;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).HorizontalLineWidth = 1;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Shape = null;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).StretchVertically = false;
            ((Telerik.WinControls.UI.TrackBarScaleElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(2))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.TrackBarScaleElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.TrackBarIndicatorContainerElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchVertically = false;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).ShowHorizontalLine = false;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Shape = null;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).MinSize = new System.Drawing.Size(0, 4);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).ThumbSize = new System.Drawing.Size(20, 20);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).HorizontalLineWidth = 1;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).DefaultSize = new System.Drawing.Size(15, 15);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).Shape = null;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).MinSize = new System.Drawing.Size(10, 10);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).MaxSize = new System.Drawing.Size(30, 30);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).StretchHorizontally = false;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).StretchVertically = true;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2))).IsVertical = false;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VolumeTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // customShape1
            // 
            this.customShape1.AsString = "20,20,200,100:64,32,False,0,0,0,0,0:149.9658,42.08904,False,0,0,0,0,0:119.8288,79" +
    ".76028,False,0,0,0,0,0:67.77398,86.95206,False,0,0,0,0,0:";
            // 
            // object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5
            // 
            this.object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5.Name = "object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5";
            this.object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5.StretchHorizontally = true;
            this.object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5.StretchVertically = true;
            // 
            // customShape2
            // 
            this.customShape2.AsString = "20,20,200,100:20,20,False,0,0,0,0,0:220,20,False,0,0,0,0,0:220,120,False,0,0,0,0," +
    "0:20,120,False,0,0,0,0,0:";
            // 
            // DurationTrackBar
            // 
            this.DurationTrackBar.AutoSize = false;
            this.DurationTrackBar.Location = new System.Drawing.Point(40, 527);
            this.DurationTrackBar.Maximum = 1F;
            this.DurationTrackBar.Name = "DurationTrackBar";
            this.DurationTrackBar.Size = new System.Drawing.Size(366, 42);
            this.DurationTrackBar.SmallChange = 0;
            this.DurationTrackBar.SmallTickFrequency = 0;
            this.DurationTrackBar.TabIndex = 7;
            this.DurationTrackBar.ThemeName = "Fluent";
            this.DurationTrackBar.ThumbSize = new System.Drawing.Size(20, 20);
            this.DurationTrackBar.TickStyle = Telerik.WinControls.Enumerations.TickStyles.None;
            this.DurationTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DurationTrackBar_MouseUp);
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.DurationTrackBar.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.DurationTrackBar.GetChildAt(0))).Shape = null;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.DurationTrackBar.GetChildAt(0))).MinSize = new System.Drawing.Size(100, 0);
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0))).IsVertical = false;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarBodyElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarScaleContainerElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.TrackBarScaleContainerElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BorderColor = System.Drawing.SystemColors.ControlDark;
            ((Telerik.WinControls.UI.TrackBarScaleContainerElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.TrackBarScaleElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).ShowSlideArea = true;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).SlideAreaWidth = 5;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).ShowHorizontalLine = false;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).HorizontalLineWidth = 1;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Shape = null;
            ((Telerik.WinControls.UI.TrackBarLineElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(1))).StretchVertically = false;
            ((Telerik.WinControls.UI.TrackBarScaleElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(2))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.TrackBarScaleElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.TrackBarIndicatorContainerElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchVertically = false;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).ShowHorizontalLine = false;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).Shape = null;
            ((Telerik.WinControls.UI.TrackBarRangeElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(1))).MinSize = new System.Drawing.Size(0, 4);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).ThumbSize = new System.Drawing.Size(20, 20);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).HorizontalLineWidth = 1;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).DefaultSize = new System.Drawing.Size(15, 15);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).Shape = null;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).MinSize = new System.Drawing.Size(10, 10);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).MaxSize = new System.Drawing.Size(30, 30);
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).StretchHorizontally = false;
            ((Telerik.WinControls.UI.TrackBarThumbElement)(this.DurationTrackBar.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0).GetChildAt(2))).StretchVertically = true;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2))).IsVertical = false;
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            ((Telerik.WinControls.UI.TrackBarArrowButton)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.DurationTrackBar.GetChildAt(0).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // CurrentDurationLabel
            // 
            this.CurrentDurationLabel.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F);
            this.CurrentDurationLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentDurationLabel.Location = new System.Drawing.Point(35, 557);
            this.CurrentDurationLabel.Name = "CurrentDurationLabel";
            this.CurrentDurationLabel.Size = new System.Drawing.Size(37, 25);
            this.CurrentDurationLabel.TabIndex = 8;
            this.CurrentDurationLabel.Text = "0:00";
            // 
            // FullDurationLabel
            // 
            this.FullDurationLabel.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F);
            this.FullDurationLabel.ForeColor = System.Drawing.Color.White;
            this.FullDurationLabel.Location = new System.Drawing.Point(365, 557);
            this.FullDurationLabel.Name = "FullDurationLabel";
            this.FullDurationLabel.Size = new System.Drawing.Size(37, 25);
            this.FullDurationLabel.TabIndex = 9;
            this.FullDurationLabel.Text = "0:00";
            this.FullDurationLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // radPanel2
            // 
            this.radPanel2.AllowDrop = true;
            this.radPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.radPanel2.Controls.Add(this.CoverBox);
            this.radPanel2.Location = new System.Drawing.Point(70, 133);
            this.radPanel2.MaximumSize = new System.Drawing.Size(300, 300);
            this.radPanel2.MinimumSize = new System.Drawing.Size(300, 300);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Padding = new System.Windows.Forms.Padding(15);
            // 
            // 
            // 
            this.radPanel2.RootElement.MaxSize = new System.Drawing.Size(300, 300);
            this.radPanel2.RootElement.MinSize = new System.Drawing.Size(300, 300);
            this.radPanel2.Size = new System.Drawing.Size(300, 300);
            this.radPanel2.TabIndex = 13;
            this.radPanel2.Text = "radPanel2";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = false;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 452);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(419, 30);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Welcome!";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = false;
            this.ArtistLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArtistLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistLabel.Location = new System.Drawing.Point(12, 488);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(419, 30);
            this.ArtistLabel.TabIndex = 15;
            this.ArtistLabel.Text = "This is Tyreu Player I";
            this.ArtistLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TrackPlaying);
            // 
            // PlayerContextMenu
            // 
            this.PlayerContextMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.AddTrackItem,
            this.AddFolderItem,
            this.AddToQueueItem,
            this.DeleteFromQueueItem});
            // 
            // AddTrackItem
            // 
            this.AddTrackItem.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.AddTrackItem.AngleTransform = 0F;
            this.AddTrackItem.FlipText = false;
            this.AddTrackItem.HintText = "";
            this.AddTrackItem.Image = null;
            this.AddTrackItem.ImageIndex = -1;
            this.AddTrackItem.ImageKey = "";
            this.AddTrackItem.Margin = new System.Windows.Forms.Padding(0);
            this.AddTrackItem.Name = "AddTrackItem";
            this.AddTrackItem.Padding = new System.Windows.Forms.Padding(0);
            this.AddTrackItem.RightToLeft = false;
            this.AddTrackItem.Text = "Добавить трек";
            this.AddTrackItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTrackItem.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AddFolderItem
            // 
            this.AddFolderItem.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.AddFolderItem.AngleTransform = 0F;
            this.AddFolderItem.FlipText = false;
            this.AddFolderItem.HintText = "";
            this.AddFolderItem.Image = null;
            this.AddFolderItem.ImageIndex = -1;
            this.AddFolderItem.ImageKey = "";
            this.AddFolderItem.Margin = new System.Windows.Forms.Padding(0);
            this.AddFolderItem.Name = "AddFolderItem";
            this.AddFolderItem.Padding = new System.Windows.Forms.Padding(0);
            this.AddFolderItem.RightToLeft = false;
            this.AddFolderItem.Text = "Добавить папку";
            this.AddFolderItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddFolderItem.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AddToQueueItem
            // 
            this.AddToQueueItem.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.AddToQueueItem.AngleTransform = 0F;
            this.AddToQueueItem.FlipText = false;
            this.AddToQueueItem.HintText = "";
            this.AddToQueueItem.Image = null;
            this.AddToQueueItem.ImageIndex = -1;
            this.AddToQueueItem.ImageKey = "";
            this.AddToQueueItem.Margin = new System.Windows.Forms.Padding(0);
            this.AddToQueueItem.Name = "AddToQueueItem";
            this.AddToQueueItem.Padding = new System.Windows.Forms.Padding(0);
            this.AddToQueueItem.RightToLeft = false;
            this.AddToQueueItem.Text = "Добавить в очередь";
            this.AddToQueueItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddToQueueItem.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // DeleteFromQueueItem
            // 
            this.DeleteFromQueueItem.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.DeleteFromQueueItem.AngleTransform = 0F;
            this.DeleteFromQueueItem.FlipText = false;
            this.DeleteFromQueueItem.HintText = "";
            this.DeleteFromQueueItem.Image = null;
            this.DeleteFromQueueItem.ImageIndex = -1;
            this.DeleteFromQueueItem.ImageKey = "";
            this.DeleteFromQueueItem.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteFromQueueItem.Name = "DeleteFromQueueItem";
            this.DeleteFromQueueItem.Padding = new System.Windows.Forms.Padding(0);
            this.DeleteFromQueueItem.RightToLeft = false;
            this.DeleteFromQueueItem.Text = "Удалить из очереди";
            this.DeleteFromQueueItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteFromQueueItem.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Playlist
            // 
            this.Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playlist.Location = new System.Drawing.Point(0, 0);
            this.Playlist.Name = "Playlist";
            this.radContextMenuManager1.SetRadContextMenu(this.Playlist, this.PlayerContextMenu);
            this.Playlist.Size = new System.Drawing.Size(319, 693);
            this.Playlist.TabIndex = 0;
            this.Playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Playlist_MouseDoubleClick);
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).BackColor2 = System.Drawing.Color.Bisque;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).BackColor3 = System.Drawing.Color.Beige;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).BackColor4 = System.Drawing.Color.Azure;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).BackColor = System.Drawing.Color.BlanchedAlmond;
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadListViewElement)(this.Playlist.GetChildAt(0))).AngleTransform = 0F;
            ((Telerik.WinControls.UI.SimpleListViewElement)(this.Playlist.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Blue;
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radCollapsiblePanel1.HorizontalHeaderAlignment = Telerik.WinControls.UI.RadHorizontalAlignment.Center;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(457, 63);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(457, 63, 347, 695);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.Playlist);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(319, 693);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(347, 695);
            this.radCollapsiblePanel1.TabIndex = 18;
            this.radCollapsiblePanel1.VerticalHeaderAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            this.radCollapsiblePanel1.Collapsing += new System.ComponentModel.CancelEventHandler(this.ClosingPlaylist);
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.radCollapsiblePanel1.GetChildAt(0))).ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.radCollapsiblePanel1.GetChildAt(0))).IsExpanded = true;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1))).HorizontalHeaderAlignment = Telerik.WinControls.UI.RadHorizontalAlignment.Center;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1))).VerticalHeaderAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.CollapsiblePanelTextElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).TextOrientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.CollapsiblePanelTextElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Text = "";
            ((Telerik.WinControls.UI.CollapsiblePanelTextElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.CollapsiblePanelTextElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ((Telerik.WinControls.UI.CollapsiblePanelTextElement)(this.radCollapsiblePanel1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchVertically = false;
            // 
            // OpenTrack
            // 
            this.OpenTrack.Filter = "Music Files|*.mp3;*.wav;*.m4a;.flac;*.ogg;*.wma";
            this.OpenTrack.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenTrack_FileOk);
            // 
            // LikeButton
            // 
            this.LikeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.LikeButton.Image = global::TyreuPlayer.Properties.Resources.Дизлайк;
            this.LikeButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeButton.Location = new System.Drawing.Point(203, 575);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(40, 40);
            this.LikeButton.TabIndex = 12;
            this.LikeButton.Text = "radButton3";
            this.LikeButton.Click += new System.EventHandler(this.ToggleLike);
            ((Telerik.WinControls.UI.RadButtonElement)(this.LikeButton.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Дизлайк;
            ((Telerik.WinControls.UI.RadButtonElement)(this.LikeButton.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.LikeButton.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.LikeButton.GetChildAt(0))).Text = "radButton3";
            ((Telerik.WinControls.UI.RadButtonElement)(this.LikeButton.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LikeButton.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LikeButton.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LikeButton.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LikeButton.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.LikeButton.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.PlayButton.Image = global::TyreuPlayer.Properties.Resources.Play;
            this.PlayButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayButton.Location = new System.Drawing.Point(187, 626);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(72, 60);
            this.PlayButton.TabIndex = 17;
            this.PlayButton.ThemeName = "Fluent";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlayButton.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Play;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlayButton.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlayButton.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlayButton.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlayButton.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlayButton.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlayButton.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlayButton.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlayButton.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlayButton.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radButton2
            // 
            this.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton2.Image = global::TyreuPlayer.Properties.Resources.Следующий;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.Location = new System.Drawing.Point(280, 634);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(60, 45);
            this.radButton2.TabIndex = 17;
            this.radButton2.ThemeName = "Fluent";
            this.radButton2.Click += new System.EventHandler(this.NextTrackButton_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Следующий;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton2.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton2.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton2.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton2.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton2.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radButton1
            // 
            this.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton1.Image = global::TyreuPlayer.Properties.Resources.Предыдущий;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(100, 634);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(60, 45);
            this.radButton1.TabIndex = 16;
            this.radButton1.ThemeName = "Fluent";
            this.radButton1.Click += new System.EventHandler(this.PrevTrackButton_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Предыдущий;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // CoverBox
            // 
            this.CoverBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoverBox.Image = global::TyreuPlayer.Properties.Resources.cover;
            this.CoverBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CoverBox.Location = new System.Drawing.Point(15, 15);
            this.CoverBox.Name = "CoverBox";
            this.radContextMenuManager1.SetRadContextMenu(this.CoverBox, this.PlayerContextMenu);
            this.CoverBox.Size = new System.Drawing.Size(270, 270);
            this.CoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverBox.TabIndex = 13;
            this.CoverBox.TabStop = false;
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.PlaylistButton.Image = global::TyreuPlayer.Properties.Resources.Меню_black;
            this.PlaylistButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlaylistButton.Location = new System.Drawing.Point(203, 718);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Size = new System.Drawing.Size(40, 40);
            this.PlaylistButton.TabIndex = 11;
            this.PlaylistButton.Text = "radButton3";
            this.PlaylistButton.Click += new System.EventHandler(this.TogglePlaylist);
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlaylistButton.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Меню_black;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlaylistButton.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlaylistButton.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlaylistButton.GetChildAt(0))).Text = "radButton3";
            ((Telerik.WinControls.UI.RadButtonElement)(this.PlaylistButton.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlaylistButton.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlaylistButton.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlaylistButton.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PlaylistButton.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.PlaylistButton.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // ReplayButton
            // 
            this.ReplayButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.ReplayButton.Image = global::TyreuPlayer.Properties.Resources.Повторение_black;
            this.ReplayButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReplayButton.Location = new System.Drawing.Point(330, 718);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(40, 40);
            this.ReplayButton.TabIndex = 11;
            this.ReplayButton.Text = "radButton2";
            this.ReplayButton.Click += new System.EventHandler(this.ToggleReplay);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ReplayButton.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Повторение_black;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ReplayButton.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ReplayButton.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ReplayButton.GetChildAt(0))).Text = "radButton2";
            ((Telerik.WinControls.UI.RadButtonElement)(this.ReplayButton.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ReplayButton.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ReplayButton.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ReplayButton.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ReplayButton.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ReplayButton.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.ShuffleButton.Image = global::TyreuPlayer.Properties.Resources.Перемешать_black;
            this.ShuffleButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShuffleButton.Location = new System.Drawing.Point(70, 718);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(40, 40);
            this.ShuffleButton.TabIndex = 10;
            this.ShuffleButton.Text = "radButton1";
            this.ShuffleButton.Click += new System.EventHandler(this.ToggleShuffle);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ShuffleButton.GetChildAt(0))).Image = global::TyreuPlayer.Properties.Resources.Перемешать_black;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ShuffleButton.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ShuffleButton.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ShuffleButton.GetChildAt(0))).Text = "radButton1";
            ((Telerik.WinControls.UI.RadButtonElement)(this.ShuffleButton.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ShuffleButton.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ShuffleButton.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ShuffleButton.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ShuffleButton.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ShuffleButton.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel3.AutoSize = false;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radLabel3.Image = ((System.Drawing.Image)(resources.GetObject("radLabel3.Image")));
            this.radLabel3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel3.Location = new System.Drawing.Point(627, 0);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(47, 47);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeAndMaximize_MouseDown);
            this.radLabel3.MouseEnter += new System.EventHandler(this.MinimizeAndMaximize_MouseHover);
            this.radLabel3.MouseLeave += new System.EventHandler(this.AnyLabel_MouseLeave);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel3.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel3.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel3.GetChildAt(0))).Text = "";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel2.AutoSize = false;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radLabel2.Image = ((System.Drawing.Image)(resources.GetObject("radLabel2.Image")));
            this.radLabel2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel2.Location = new System.Drawing.Point(674, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 47);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Click += new System.EventHandler(this.MinimizeLabel_Click);
            this.radLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeAndMaximize_MouseDown);
            this.radLabel2.MouseEnter += new System.EventHandler(this.MinimizeAndMaximize_MouseHover);
            this.radLabel2.MouseLeave += new System.EventHandler(this.AnyLabel_MouseLeave);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel2.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel2.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel2.GetChildAt(0))).Text = "";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel1.AutoSize = false;
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radLabel1.Image = ((System.Drawing.Image)(resources.GetObject("radLabel1.Image")));
            this.radLabel1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.Location = new System.Drawing.Point(721, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 47);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Click += new System.EventHandler(this.MaximizeLabel_Click);
            this.radLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeAndMaximize_MouseDown);
            this.radLabel1.MouseEnter += new System.EventHandler(this.MinimizeAndMaximize_MouseHover);
            this.radLabel1.MouseLeave += new System.EventHandler(this.AnyLabel_MouseLeave);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "";
            // 
            // CloseLabel
            // 
            this.CloseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseLabel.AutoSize = false;
            this.CloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.CloseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.CloseLabel.Image = ((System.Drawing.Image)(resources.GetObject("CloseLabel.Image")));
            this.CloseLabel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseLabel.Location = new System.Drawing.Point(768, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(47, 47);
            this.CloseLabel.TabIndex = 3;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseLabel_MouseDown);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseHover);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.AnyLabel_MouseLeave);
            ((Telerik.WinControls.UI.RadLabelElement)(this.CloseLabel.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            ((Telerik.WinControls.UI.RadLabelElement)(this.CloseLabel.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadLabelElement)(this.CloseLabel.GetChildAt(0))).Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(816, 770);
            this.Controls.Add(this.LikeButton);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.ArtistLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.PlaylistButton);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.FullDurationLabel);
            this.Controls.Add(this.CurrentDurationLabel);
            this.Controls.Add(this.DurationTrackBar);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(816, 770);
            this.MinimumSize = new System.Drawing.Size(446, 770);
            this.Name = "Main";
            this.Opacity = 0D;
            this.radContextMenuManager1.SetRadContextMenu(this, this.PlayerContextMenu);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.BorderHighlightColor = System.Drawing.Color.Black;
            this.RootElement.MaxSize = new System.Drawing.Size(816, 770);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tyreu Player I";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDurationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullDurationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist)).EndInit();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            this.radCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LikeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShuffleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel CloseLabel;
        private Telerik.WinControls.UI.RadLabel NameLabel;
        private Telerik.WinControls.UI.RadTrackBar VolumeTrackBar;
        private Telerik.WinControls.CustomShape customShape1;
        private Telerik.WinControls.EditorRootRadElement object_9158d6bb_c6d5_42ad_a932_7b98575cc2d5;
        private Telerik.WinControls.CustomShape customShape2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTrackBar DurationTrackBar;
        private Telerik.WinControls.UI.RadLabel CurrentDurationLabel;
        private Telerik.WinControls.UI.RadLabel FullDurationLabel;
        private Telerik.WinControls.UI.RadButton ShuffleButton;
        private Telerik.WinControls.UI.RadButton ReplayButton;
        private Telerik.WinControls.UI.RadButton PlaylistButton;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.PictureBox CoverBox;
        private Telerik.WinControls.UI.RadLabel TitleLabel;
        private Telerik.WinControls.UI.RadLabel ArtistLabel;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton PlayButton;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadContextMenu PlayerContextMenu;
        private Telerik.WinControls.UI.RadMenuItem AddTrackItem;
        private Telerik.WinControls.UI.RadMenuItem AddFolderItem;
        private Telerik.WinControls.UI.RadMenuItem AddToQueueItem;
        private Telerik.WinControls.UI.RadMenuItem DeleteFromQueueItem;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.OpenFileDialog OpenTrack;
        private Telerik.WinControls.UI.RadButton LikeButton;
        private Telerik.WinControls.UI.RadListView Playlist;
    }
}