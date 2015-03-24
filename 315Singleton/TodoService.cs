using _315Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _315Singleton
{
    public class TodoService
    {
        private static TodoService _instance = null;

        public static TodoService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TodoService();
                }
                return _instance;
            }
        }
        private List<Todo> _todos { get; set; }
    }
}