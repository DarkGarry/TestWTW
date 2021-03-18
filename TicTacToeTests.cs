/*Igor Dubovets Unit tests TicTacToe*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2_TicTacToe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_TicTacToe.Program.Tests
{
    [TestClass()]
    public class TicTacToeTests
    {
        [TestMethod()]
        public void TicTacToeTest()
        {
            TicTacToe t = new TicTacToe(4);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void PlacePiece2x2_win1_Test()
        {
            TicTacToe t = new TicTacToe(2);
            int ret = t.PlacePiece(1, 1, 1);
            Assert.AreEqual(0, ret);
            ret = t.PlacePiece(1, 0, 2);
            Assert.AreEqual(0, ret); ;
            ret = t.PlacePiece(0, 0, 1);
            Assert.AreEqual(1, ret);
        }

        [TestMethod()]
        public void PlacePiece2x2_TurnAfterGameOverTest()
        {
            TicTacToe t = new TicTacToe(2);
            int ret = t.PlacePiece(1, 1, 1);

            Assert.AreEqual(0, ret);
            ret = t.PlacePiece(1, 0, 2);
            Assert.AreEqual(0, ret); ;
            ret = t.PlacePiece(0, 0, 1);
            Assert.AreEqual(1, ret);
            Exception e = Assert.ThrowsException<Exception>(() => ret = t.PlacePiece(0, 1, 2));
            Assert.AreEqual("Game is over", e.Message);
        }

        [TestMethod()]
        public void PlacePiece3x3_win1Test()
        {
            TicTacToe t = new TicTacToe(3);
            int ret = t.PlacePiece(0, 0, 1);
            Assert.AreEqual(0, ret);
            ret = t.PlacePiece(1, 0, 2);
            Assert.AreEqual(0, ret); ;
            ret = t.PlacePiece(0, 1, 1);
            Assert.AreEqual(0, ret);
            ret = t.PlacePiece(1, 1, 2);
            Assert.AreEqual(0, ret);
            ret = t.PlacePiece(0, 2, 1);
            Assert.AreEqual(1, ret);
        }

        [TestMethod()]
        public void PlacePiece3x3_drawTest()
        {
            TicTacToe t = new TicTacToe(3);
            
            Assert.AreEqual(0, t.PlacePiece(0, 0, 1));
            Assert.AreEqual(0, t.PlacePiece(1, 1, 2));
            Assert.AreEqual(0, t.PlacePiece(0, 1, 1));
            Assert.AreEqual(0, t.PlacePiece(0, 2, 2));
            Assert.AreEqual(0, t.PlacePiece(2, 0, 1));
            Assert.AreEqual(0, t.PlacePiece(1, 0, 2));
            Assert.AreEqual(0, t.PlacePiece(1, 2, 1));
            Assert.AreEqual(0, t.PlacePiece(2, 2, 2));
            Assert.AreEqual(0, t.PlacePiece(2, 1, 1));
            int ret;
            Exception e = Assert.ThrowsException<Exception>(() => ret = t.PlacePiece(0, 1, 2));
            Assert.AreEqual("Game is over", e.Message);
        }

        [TestMethod()]
        public void PlacePiece1x1Test()
        {
            TicTacToe t = new TicTacToe(1);
            int ret = t.PlacePiece(0, 0, 1);
            Assert.AreEqual(1, ret);
        }
    }
}