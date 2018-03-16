using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAD_Assignment1.GameCore
{
    class Game
    {
        public enum GuessStatus
        {
            TooLow,
            TooHigh,
            Correct
        };

        Random randGen = new Random();
        private List<Product> _productList = new List<Product>();
        private Product _gameProduct;
        private int _numberOfTries = 0;

        private int _numRounds;

        public int NumRounds
        {
            get { return _numRounds; }
            set { _numRounds = value; }
        }


        public int NumberOfTries
        {
            get { return _numberOfTries; }
        }

        List<int> previousGuesses = new List<int>();

        public void resetStats()
        {
            previousGuesses = new List<int>();
            _numberOfTries = 0;
        }

        public Game()
        {
            _productList = PopulateProducts();
        }

        private List<Product> PopulateProducts()
        {
            List<Product> productList = new List<Product>();

            for(int i = 0; i < 10; i++)
            {
                Product tempProduct = new Product
                {
                    Description = "Product " + (i + 1),
                    Price = randGen.Next(1, 1000)
                };

                productList.Add(tempProduct);
            }

            return productList;
        }

        public GuessStatus CheckGuess(int userGuess)
        {
            if(userGuess > _gameProduct.Price)
            {
                _numberOfTries++;
                previousGuesses.Add(userGuess);
                return GuessStatus.TooHigh;
            }
            else if(userGuess < _gameProduct.Price)
            {
                _numberOfTries++;
                previousGuesses.Add(userGuess);
                return GuessStatus.TooLow;
            }
            else
            {
                _numberOfTries++;
                previousGuesses.Add(userGuess);
                return GuessStatus.Correct;
            }
        }

        public Product Start()
        {
            int index = randGen.Next(0, 9);
            _gameProduct = _productList[index];
            int tempStore = _gameProduct.Price;
            _productList[index].Price = 0;
            _gameProduct.Price = tempStore;

            if(NumberOfTries == 10)
            {
                _productList = PopulateProducts();
            }

            while(_gameProduct.Price == 0)
            {
                index = randGen.Next(0, 9);
                _gameProduct = _productList[index];
            }

            _numRounds++;
            return _gameProduct;
        }

        public List<int> getGuessList()
        {
            return previousGuesses;
        }
    }
}
