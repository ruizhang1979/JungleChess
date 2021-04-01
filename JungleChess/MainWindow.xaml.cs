﻿using System;
using System.Windows;

namespace JungleChess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChessBoard chessBoard;
        public MainWindow()
        {
            InitializeComponent();
            chessBoard = new ChessBoard(Math.Min(ChessBoard.Width, ChessBoard.Height));
            DataContext = chessBoard;
        }
    }
}
