using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Dependencies {

    //Interfaces
    public interface ISingleton{}
    public interface IScoped{}
    public interface ITransient{}

    public class RandomNumber: ISingleton, IScoped, ITransient{
        public readonly int Value;
        public RandomNumber() {
            Value = new Random().Next(100);
        }
    }
}