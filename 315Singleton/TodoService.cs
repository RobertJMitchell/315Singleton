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

        private int _seedId;

        private TodoService()
        {
            _seedId = 1;
            _todos = new List<Todo>();
        }

        //read and get all Todos in list
        public List<Todo> GetTodos()
        {
            return _todos;
        }

        // read get for a single Todo item

        public Todo GetTodoItem(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        
        }

        //Create/POST - Create a new Todo

        public int CreateToDo(string task)
        {
            Todo nt = new Todo()
            {
                Id = _seedId,
                Task = task,
                isCompleted = false

            };
            _todos.Add(nt);
            _seedId++;
            return nt.Id;
        }

    }
}