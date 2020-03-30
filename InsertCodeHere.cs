using System;
// ReSharper disable UnusedVariable
#pragma warning disable 219

namespace WebShopV06
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            // Example 1
            /*int noOfBooksInOrder = 8;
            int noOfDVDsInOrder = 3;
            int noOfGamesInOrder = 2;*/

            // Eaxmple 2
            int noOfBooksInOrder = 0;
            int noOfDVDsInOrder = 12;
            int noOfGamesInOrder = 4;

            // Eaxmple 3
            /*int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;*/

            // Eaxmple 4
            /*int noOfBooksInOrder = 3;
            int noOfDVDsInOrder = 5;
            int noOfGamesInOrder = 4;*/

            double totalNetPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;

            // SO#1
            bool receiveSpecialOffer1 = false;
            receiveSpecialOffer1 = totalNetPrice > 1000;

            // SO#2
            bool receiveSpecialOffer2 = false;
            receiveSpecialOffer2 = noOfBooksInOrder > noOfGamesInOrder;

            // SO#3
            bool receiveSpecialOffer3 = false;
            bool booksGreaterThanTen = noOfBooksInOrder >= 10;
            bool DVDsGreaterThanTen = noOfDVDsInOrder >= 10;
            bool gamesGreaterThanTen = noOfGamesInOrder >= 10;
            bool anyGreaterThanTen = booksGreaterThanTen || DVDsGreaterThanTen || gamesGreaterThanTen;
            receiveSpecialOffer3 = anyGreaterThanTen;

            // SO#4
            bool receiveSpecialOffer4 = false;
            bool DVDsBetweenTenAndTwenty = (noOfDVDsInOrder >= 10) && (noOfDVDsInOrder <= 20);
            bool gamesAtleastFive = noOfGamesInOrder >= 5;
            bool qualified = DVDsBetweenTenAndTwenty || gamesAtleastFive;
            receiveSpecialOffer4 = qualified;

            // ESO
            bool receiveExtraSpecialOffer = false;
            

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
            Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
            Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
            Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
            Console.WriteLine($"You qualify for extra special offer : {receiveExtraSpecialOffer}");

            // The LAST line of code should be ABOVE this line
        }
    }
}