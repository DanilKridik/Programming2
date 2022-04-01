﻿using System.ComponentModel;

namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GOButton = new System.Windows.Forms.Button();
            this.SeasonNamesComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueWeekdayTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumarationsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.NameMovieTextBox = new System.Windows.Forms.TextBox();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.GenreMovieTextBox = new System.Windows.Forms.TextBox();
            this.YearReleaseMovieTextBox = new System.Windows.Forms.TextBox();
            this.DurationMinutesMovieTextBox = new System.Windows.Forms.TextBox();
            this.RatingMovieTextBox = new System.Windows.Forms.TextBox();
            this.NameFilmLabel = new System.Windows.Forms.Label();
            this.DurationMinutesFilmLabel = new System.Windows.Forms.Label();
            this.YearReleaseFilmLabel = new System.Windows.Forms.Label();
            this.GenreFilmLabel = new System.Windows.Forms.Label();
            this.RatingFilmLabel = new System.Windows.Forms.Label();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleLabel = new System.Windows.Forms.Label();
            this.WidthRectangleLabel = new System.Windows.Forms.Label();
            this.LengthRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.MainTabControl.SuspendLayout();
            this.EnumTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(2, 4);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(600, 396);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumTabPage.Size = new System.Drawing.Size(592, 370);
            this.EnumTabPage.TabIndex = 1;
            this.EnumTabPage.Text = "Enums";
            this.EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GOButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonNamesComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(309, 214);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(279, 154);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GOButton
            // 
            this.GOButton.Location = new System.Drawing.Point(146, 47);
            this.GOButton.Margin = new System.Windows.Forms.Padding(2);
            this.GOButton.Name = "GOButton";
            this.GOButton.Size = new System.Drawing.Size(86, 24);
            this.GOButton.TabIndex = 3;
            this.GOButton.Text = "GO!";
            this.GOButton.UseVisualStyleBackColor = true;
            this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
            // 
            // SeasonNamesComboBox
            // 
            this.SeasonNamesComboBox.FormattingEnabled = true;
            this.SeasonNamesComboBox.Location = new System.Drawing.Point(12, 50);
            this.SeasonNamesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonNamesComboBox.Name = "SeasonNamesComboBox";
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(113, 21);
            this.SeasonNamesComboBox.TabIndex = 2;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(12, 33);
            this.ChooseSeasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(112, 20);
            this.ChooseSeasonLabel.TabIndex = 1;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(4, 214);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(293, 154);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(178, 48);
            this.ParseWeekdayButton.Margin = new System.Windows.Forms.Padding(2);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(86, 24);
            this.ParseWeekdayButton.TabIndex = 4;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(14, 85);
            this.OutputWeekdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(124, 37);
            this.OutputWeekdayLabel.TabIndex = 3;
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(9, 50);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayTextBox.Multiline = true;
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(150, 23);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.Location = new System.Drawing.Point(9, 33);
            this.TypeValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(130, 20);
            this.TypeValueLabel.TabIndex = 0;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.ValueWeekdayTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumarationsLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(4, 0);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(584, 209);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // ValueWeekdayTextBox
            // 
            this.ValueWeekdayTextBox.Location = new System.Drawing.Point(262, 48);
            this.ValueWeekdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueWeekdayTextBox.Name = "ValueWeekdayTextBox";
            this.ValueWeekdayTextBox.Size = new System.Drawing.Size(89, 20);
            this.ValueWeekdayTextBox.TabIndex = 9;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.Location = new System.Drawing.Point(262, 28);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(87, 18);
            this.IntValueLabel.TabIndex = 8;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.Location = new System.Drawing.Point(137, 28);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(99, 18);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumarationsLabel
            // 
            this.EnumarationsLabel.Location = new System.Drawing.Point(9, 28);
            this.EnumarationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumarationsLabel.Name = "EnumarationsLabel";
            this.EnumarationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnumarationsLabel.Size = new System.Drawing.Size(112, 18);
            this.EnumarationsLabel.TabIndex = 6;
            this.EnumarationsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(137, 48);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(100, 121);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 48);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(100, 121);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MovieGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectangleGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(592, 370);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Controls.Add(this.NameMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.FindMovieButton);
            this.MovieGroupBox.Controls.Add(this.GenreMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.YearReleaseMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationMinutesMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.NameFilmLabel);
            this.MovieGroupBox.Controls.Add(this.DurationMinutesFilmLabel);
            this.MovieGroupBox.Controls.Add(this.YearReleaseFilmLabel);
            this.MovieGroupBox.Controls.Add(this.GenreFilmLabel);
            this.MovieGroupBox.Controls.Add(this.RatingFilmLabel);
            this.MovieGroupBox.Location = new System.Drawing.Point(292, 0);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(297, 367);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movie";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(2, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(112, 290);
            this.MovieListBox.TabIndex = 0;
            // 
            // NameMovieTextBox
            // 
            this.NameMovieTextBox.Location = new System.Drawing.Point(120, 37);
            this.NameMovieTextBox.Name = "NameMovieTextBox";
            this.NameMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.NameMovieTextBox.TabIndex = 17;
            this.NameMovieTextBox.TextChanged += new System.EventHandler(this.NameMovieTextBox_TextChanged);
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(120, 286);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(71, 23);
            this.FindMovieButton.TabIndex = 16;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // GenreMovieTextBox
            // 
            this.GenreMovieTextBox.Location = new System.Drawing.Point(120, 78);
            this.GenreMovieTextBox.Name = "GenreMovieTextBox";
            this.GenreMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.GenreMovieTextBox.TabIndex = 12;
            this.GenreMovieTextBox.TextChanged += new System.EventHandler(this.GenreFilmTextBox_TextChanged);
            // 
            // YearReleaseMovieTextBox
            // 
            this.YearReleaseMovieTextBox.Location = new System.Drawing.Point(120, 119);
            this.YearReleaseMovieTextBox.Name = "YearReleaseMovieTextBox";
            this.YearReleaseMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.YearReleaseMovieTextBox.TabIndex = 11;
            this.YearReleaseMovieTextBox.TextChanged += new System.EventHandler(this.YearReleaseFilmTextBox_TextChanged);
            // 
            // DurationMinutesMovieTextBox
            // 
            this.DurationMinutesMovieTextBox.Location = new System.Drawing.Point(120, 160);
            this.DurationMinutesMovieTextBox.Name = "DurationMinutesMovieTextBox";
            this.DurationMinutesMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.DurationMinutesMovieTextBox.TabIndex = 10;
            this.DurationMinutesMovieTextBox.TextChanged += new System.EventHandler(this.DurationMinutesFilmTextBox_TextChanged);
            // 
            // RatingMovieTextBox
            // 
            this.RatingMovieTextBox.Location = new System.Drawing.Point(120, 201);
            this.RatingMovieTextBox.Name = "RatingMovieTextBox";
            this.RatingMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.RatingMovieTextBox.TabIndex = 9;
            this.RatingMovieTextBox.TextChanged += new System.EventHandler(this.RatingFilmTextBox_TextChanged);
            // 
            // NameFilmLabel
            // 
            this.NameFilmLabel.Location = new System.Drawing.Point(120, 19);
            this.NameFilmLabel.Name = "NameFilmLabel";
            this.NameFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.NameFilmLabel.TabIndex = 8;
            this.NameFilmLabel.Text = "Name:";
            // 
            // DurationMinutesFilmLabel
            // 
            this.DurationMinutesFilmLabel.Location = new System.Drawing.Point(120, 142);
            this.DurationMinutesFilmLabel.Name = "DurationMinutesFilmLabel";
            this.DurationMinutesFilmLabel.Size = new System.Drawing.Size(105, 15);
            this.DurationMinutesFilmLabel.TabIndex = 7;
            this.DurationMinutesFilmLabel.Text = "Duration in minutes:";
            // 
            // YearReleaseFilmLabel
            // 
            this.YearReleaseFilmLabel.Location = new System.Drawing.Point(120, 101);
            this.YearReleaseFilmLabel.Name = "YearReleaseFilmLabel";
            this.YearReleaseFilmLabel.Size = new System.Drawing.Size(94, 15);
            this.YearReleaseFilmLabel.TabIndex = 6;
            this.YearReleaseFilmLabel.Text = "Year of release:";
            // 
            // GenreFilmLabel
            // 
            this.GenreFilmLabel.Location = new System.Drawing.Point(120, 60);
            this.GenreFilmLabel.Name = "GenreFilmLabel";
            this.GenreFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.GenreFilmLabel.TabIndex = 5;
            this.GenreFilmLabel.Text = "Genre:";
            // 
            // RatingFilmLabel
            // 
            this.RatingFilmLabel.Location = new System.Drawing.Point(120, 183);
            this.RatingFilmLabel.Name = "RatingFilmLabel";
            this.RatingFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.RatingFilmLabel.TabIndex = 4;
            this.RatingFilmLabel.Text = "Rating:";
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectangleGroupBox.Controls.Add(this.WidthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.LengthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.WidthRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.LengthRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.RectangleListBox);
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 0);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(283, 367);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Ractangles";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(126, 284);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(71, 24);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(126, 78);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.WidthRectangleTextBox.TabIndex = 6;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(126, 119);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.ColorRectangleTextBox.TabIndex = 5;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(126, 37);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.LengthRectangleTextBox.TabIndex = 4;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleLabel
            // 
            this.ColorRectangleLabel.Location = new System.Drawing.Point(126, 100);
            this.ColorRectangleLabel.Name = "ColorRectangleLabel";
            this.ColorRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.ColorRectangleLabel.TabIndex = 3;
            this.ColorRectangleLabel.Text = "Color:";
            // 
            // WidthRectangleLabel
            // 
            this.WidthRectangleLabel.Location = new System.Drawing.Point(126, 60);
            this.WidthRectangleLabel.Name = "WidthRectangleLabel";
            this.WidthRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.WidthRectangleLabel.TabIndex = 2;
            this.WidthRectangleLabel.Text = "Width:";
            // 
            // LengthRectangleLabel
            // 
            this.LengthRectangleLabel.Location = new System.Drawing.Point(126, 19);
            this.LengthRectangleLabel.Name = "LengthRectangleLabel";
            this.LengthRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.LengthRectangleLabel.TabIndex = 1;
            this.LengthRectangleLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(8, 19);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(112, 290);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 400);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.MainTabControl.ResumeLayout(false);
            this.EnumTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox RatingMovieTextBox;

        private System.Windows.Forms.TextBox DurationMinutesMovieTextBox;

        private System.Windows.Forms.TextBox YearReleaseMovieTextBox;

        private System.Windows.Forms.TextBox GenreMovieTextBox;

        private System.Windows.Forms.TextBox NameMovieTextBox;

        private System.Windows.Forms.Button FindMovieButton;

        private System.Windows.Forms.GroupBox MovieGroupBox;

        private System.Windows.Forms.TextBox RatingFilmTextBox;

        private System.Windows.Forms.TextBox DurationMinutesFilmTextBox;

        private System.Windows.Forms.TextBox YearReleaseFilmTextBox;

        private System.Windows.Forms.TextBox GenreFilmTextBox;

        private System.Windows.Forms.TextBox NameFilmTextBox;

        private System.Windows.Forms.TextBox ColorRectangleTextBox;

        private System.Windows.Forms.TextBox WidthRectangleTextBox;

        private System.Windows.Forms.TextBox LengthRectangleTextBox;

        private System.Windows.Forms.Button FindRectangleButton;

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button FindRactangleButton;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label GenreFilmLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label YearReleaseFilmLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label DurationMinutesFilmLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label RatingFilmLabel;

        private System.Windows.Forms.Label NameFilmLabel;

        private System.Windows.Forms.Label WidthRectangleLabel;
        private System.Windows.Forms.Label ColorRectangleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LengthRectangleLabel;

        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.ListBox FilmListBox;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox FilmGroupBox;
        private System.Windows.Forms.GroupBox RectangleGroupBox;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TabPage ClassesTabPage;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TextBox ValueWeekdayTextBox;

        private System.Windows.Forms.TabControl MainTabControl;

        private System.Windows.Forms.TextBox ValueWeekdayBox;

        private System.Windows.Forms.Label EnumarationsLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label IntValueLabel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label OutputWeekdayLabel;

        private System.Windows.Forms.ListBox ValuesListBox;

        private System.Windows.Forms.ListBox EnumsListBox;

        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.Button GOButton;

        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.ComboBox SeasonNamesComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label TypeValueLabel;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TabPage EnumTabPage;

        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabControl EnumTabControl;
        private System.Windows.Forms.TabPage tabPage2;

        

        private System.Windows.Forms.ListBox MovieListBox;
        #endregion
    }
}