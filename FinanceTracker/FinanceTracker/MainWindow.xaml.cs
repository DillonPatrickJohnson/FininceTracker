﻿using System.Windows;

namespace FinanceTracker {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			InitializeComponent();
		}

		private void importButton_Click(object sender, RoutedEventArgs e) {
			Parser parser = new Parser();
			parser.loadFile();

		}
	}
}
