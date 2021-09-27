
using System;
using System.Collections.Generic;
using Xunit;


namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void getWizardsByRowlingReturnsList()
        {
            List<string> expected = new List<string> { "Harry Potter", "Ron Weasley", "Hermione Granger", "Fred Weasley", "George Weasley", "Tom Marvelo Riddle", "Albus Percival Wulfric Brian Dumbledore", "Severus Snape", "Sirius Black", "Gellert Grindelwald" };
            IEnumerable<string> actual = Queries.getWizardsByRowling();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getWizardsByRowlingLinqReturnsList()
        {
            List<string> expected = new List<string> { "Harry Potter", "Ron Weasley", "Hermione Granger", "Fred Weasley", "George Weasley", "Tom Marvelo Riddle", "Albus Percival Wulfric Brian Dumbledore", "Severus Snape", "Sirius Black", "Gellert Grindelwald" };
            IEnumerable<string> actual = Queries.getWizardsByRowlingLinq();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getFirstSithLordYearReturns1977()
        {
            int expected = 1977;
            int? actual = Queries.getFirstSithLordYear();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getFirstSithLordYearLinqReturns1977()
        {
            int expected = 1977;
            int? actual = Queries.getFirstSithLordYearLinq();
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void getWizardsByHarryPotterTest()
        {
            List<(string, int?)> expected = new List<(string, int?)> { ("Harry Potter", 1997), ("Ron Weasley", 1997), ("Hermione Granger", 1997), ("Fred Weasley", 1997), ("George Weasley", 1997), ("Tom Marvelo Riddle", 1997), ("Albus Percival Wulfric Brian Dumbledore", 1997), ("Severus Snape", 1997), ("Sirius Black", 1997), ("Gellert Grindelwald", 1997) };
            IEnumerable<(string, int?)> actual = Queries.getWizardsByHarryPotter();
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void getWizardsByHarryPotterLinqTest()
        {
            List<(string, int?)> expected = new List<(string, int?)> { ("Harry Potter", 1997), ("Ron Weasley", 1997), ("Hermione Granger", 1997), ("Fred Weasley", 1997), ("George Weasley", 1997), ("Tom Marvelo Riddle", 1997), ("Albus Percival Wulfric Brian Dumbledore", 1997), ("Severus Snape", 1997), ("Sirius Black", 1997), ("Gellert Grindelwald", 1997) };
            IEnumerable<(string, int?)> actual = Queries.getWizardsByHarryPotterLinq();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getWizardsByCreaterOrderedReturnsList()
        {
            List<String> expected = new List<string> { "Gandalf", "Saruman", "Sauron", "Albus Percival Wulfric Brian Dumbledore", "Fred Weasley", "Gellert Grindelwald", "George Weasley", "Harry Potter", "Hermione Granger", "Ron Weasley", "Severus Snape", "Sirius Black", "Tom Marvelo Riddle", "Darth Maul", "Darth Revan", "Darth Vader", "Eragon" };
            IEnumerable<String> actual = Queries.getWizardsByCreaterOrdered();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getWizardsByCreaterLinqOrderedReturnsList()
        {
            List<String> expected = new List<string> { "Gandalf", "Saruman", "Sauron", "Albus Percival Wulfric Brian Dumbledore", "Fred Weasley", "Gellert Grindelwald", "George Weasley", "Harry Potter", "Hermione Granger", "Ron Weasley", "Severus Snape", "Sirius Black", "Tom Marvelo Riddle", "Darth Maul", "Darth Revan", "Darth Vader", "Eragon" };
            IEnumerable<String> actual = Queries.getWizardsByCreaterOrderedLinq();
            Assert.Equal(expected, actual);
        }


    }
}

