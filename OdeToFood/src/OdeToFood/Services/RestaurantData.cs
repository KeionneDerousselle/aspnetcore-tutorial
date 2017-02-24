﻿using System;
using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "The House of Kobe"},
                new Restaurant {Id = 2, Name = "LJs and the Kat"},
                new Restaurant {Id = 3, Name = "King's Contrivance"},
            };
        } 
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}