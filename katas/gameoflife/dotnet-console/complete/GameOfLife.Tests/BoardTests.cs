using GameOfLife.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameOfLife.Tests
{
    /// <summary>
    /// Rules:
    /// 1. Any live cell with fewer than two live neighbors dies,
    ///    as if caused by underpopulation.
    /// 2. Any live cell with more than three live neighbors dies,
    ///    as if by overcrowding.
    /// 3. Any live cell with two or three live neighbors lives
    ///    on to the next generation.
    /// 4. Any dead cell with exactly three live neighbors becomes
    ///    a live cell.
    /// </summary>
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_should_throw_ArgumentNullException_if_initial_state_is_null()
        {
            var board = new Board(null);
        }

        [TestMethod]
        public void Update_on_empty_board_should_return_empty_board()
        {
            var board = new Board(new string[0, 0]);
            board.Update();
            CollectionAssert.AreEquivalent(new string[0, 0], board.Cells);
        }

        [TestMethod]
        public void Update_on_board_with_zero_length_rows_should_return_board_with_same_dimensions()
        {
            var board = new Board(new string[10, 0]);
            board.Update();
            CollectionAssert.AreEquivalent(new string[10, 0], board.Cells);
        }

        [TestMethod]
        public void Update_should_kill_any_cell_with_fewer_than_two_live_neighbors()
        {
            var initialState = new[,]
            {
                {".", ".", "."},
                {".", "*", "."}, // Second cell in row has no live neighbors, should die
                {".", ".", "."},
                {".", "*", "*"}, // Second cell in row has one live neighbor, should die
                {".", ".", "."}
            };

            var board = new Board(initialState);
            board.Update();
            Assert.AreEqual(".", board.Cells[1, 1]);
            Assert.AreEqual(".", board.Cells[3, 1]);
        }

        [TestMethod]
        public void Update_should_kill_any_live_cell_with_more_than_three_live_neighbors()
        {
            var initialState = new[,]
            {
                {"*", "*", "."},
                {".", "*", "."},
                {"*", ".", "*"}
            };

            var board = new Board(initialState);
            board.Update();
            Assert.AreEqual(".", board.Cells[1, 1]);
        }

        [TestMethod]
        public void Update_should_keep_alive_any_live_cell_with_two_or_three_live_neighbors()
        {
            var initialState = new[,]
            {
                {".", ".", "."},
                {".", "*", "."}, // Second cell has two live neighbors, should stay alive
                {"*", ".", "*"},
                {".", "*", "."}, // Second cell has three live neighbors, should stay alive
                {".", "*", "."} 
            };

            var board = new Board(initialState);
            board.Update();
            Assert.AreEqual("*", board.Cells[1, 1]);
            Assert.AreEqual("*", board.Cells[3, 1]);
        }
        
        [TestMethod]
        public void Update_should_keep_any_dead_cells_dead_if_they_have_less_than_three_live_neighbors()
        {
            var initialState = new[,]
            {
                {".", "*", "."}, // First cell in row has one live neighbor, should stay dead
                {".", ".", "."},
                {".", "*", "."}, // First cell in row has two live neighbors, should stay dead
                {".", "*", "."},
                {".", ".", "."}
            };

            var board = new Board(initialState);
            board.Update();
            Assert.AreEqual(".", board.Cells[0, 0]);
            Assert.AreEqual(".", board.Cells[2, 0]);
        }

        [TestMethod]
        public void Update_should_keep_any_dead_cells_dead_if_they_have_more_than_three_live_neighbors()
        {
            var initialState = new[,]
            {
                {".", "*", "."},
                {"*", ".", "*"}, // Middle cell in this row has 4 neighbors, should stay dead
                {".", "*", "."},
                {"*", "*", "."},
                {".", ".", "."}, // Middle cell in this row has 5 neighbors, should stay dead
                {"*", "*", "*"},
            };

            var board = new Board(initialState);
            board.Update();
            Assert.AreEqual(".", board.Cells[1, 1]);
            Assert.AreEqual(".", board.Cells[4, 1]);
        }

        [TestMethod]
        public void Update_should_make_any_dead_cells_live_if_they_have_three_live_neighbors()
        {
            var initialState = new[,]
            {
                {".", "*", "."},
                {"*", ".", "*"}, // Middle cell in this row has 3 neighbors, should be made live
                {".", ".", "."}
            };

            var board = new Board(initialState);
            board.Update();
            Assert.AreEqual("*", board.Cells[1, 1]);
        }
    }
}
