using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_03242016;
using Xunit;

namespace Notes_03242016_Tests.Tests {
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class CustomerTests {
        [Fact]
        //POSITIVE TEST
        public void TestSetFirstName() {
            //Arrange
            Customer tester = new Customer("Tester", "Testington");

            //Act
            tester.FirstName = "somethingElse";

            //Assert
            Assert.Equal("somethingElse", tester.FirstName);
        }

        [Fact]
        //NEGATIVE TEST
        public void TestFirstNameCannotBeNull() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            // Assert
            Assert.Throws(typeof(ArgumentNullException), () => {
                // Act
                tester.FirstName = null;
            });
            Assert.Equal("Tester", tester.FirstName); //Have to make sure it didn't change the first name.
        }

        [Fact]
        //NEGATIVE TEST
        public void TestFirstNameCannotBeEmptyString() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            //Assert
            Assert.Throws(typeof(ArgumentNullException), () => {
                // Act
                tester.FirstName = "";
            });
            Assert.Equal("Tester", tester.FirstName); //Have to make sure it didn't change the first name.
        }

        [Fact]
        //NEGATIVE TEST
        public void TestFirstNameCannotBeWhiteSpace() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            //Assert
            Assert.Throws(typeof(ArgumentNullException), () => {
                // Act
                tester.FirstName = " \t\n\r";
            });
            Assert.Equal("Tester", tester.FirstName); //Have to make sure it didn't change the first name.
        }

        [Fact]
        //POSITIVE TEST
        public void TestSetLastName() {
            //Arrange
            Customer tester = new Customer("Tester", "Testington");

            //Act
            tester.LastName = "somethingElse";

            //Assert
            Assert.Equal("somethingElse", tester.LastName);
        }

        [Fact]
        //NEGATIVE TEST
        public void TestLastNameCannotBeNull() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            // Assert
            Assert.Throws(typeof(ArgumentNullException), () => {
                // Act
                tester.LastName = null;
            });
            Assert.Equal("Testington", tester.LastName); //Have to make sure it didn't change the first name.
        }

        [Fact]
        //NEGATIVE TEST
        public void TestLastNameCannotBeEmptyString() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            //Assert
            Assert.Throws(typeof(ArgumentNullException), () => {
                // Act
                tester.LastName = "";
            });
            Assert.Equal("Testington", tester.LastName); //Have to make sure it didn't change the first name.
        }

        [Fact]
        //NEGATIVE TEST
        public void TestLastNameCannotBeWhiteSpace() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            //Assert
            Assert.Throws(typeof(ArgumentNullException), () => {
                // Act
                tester.LastName = " \t\n\r";
            });
            Assert.Equal("Testington", tester.LastName); //Have to make sure it didn't change the first name.
        }

        [Fact]
        //POSITIVE TEST
        public void TestConstructorConstructs() {
            // Arrange
            Customer tester = new Customer("Tester", "Testington");

            // Act


            // Assert
            Assert.Equal("Tester", tester.FirstName);
            Assert.Equal("Testington", tester.LastName);
        }
    }
}
