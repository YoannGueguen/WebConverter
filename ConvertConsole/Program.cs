using Dal;
using DomainModel;
using System;
using System.Collections.Generic;

namespace ConvertConsole
{
    //Cette classe permet d'afficher 
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();

            using (ConverterContext context = new ConverterContext())
            {
                foreach (Converter cvt in context.Converters)
                {
                    Console.WriteLine(cvt.NumberConverted);
                }
            }

            Console.ReadLine();
        }
        static void Initialize()
        {
            using (ConverterContext context = new ConverterContext())
            {
                //drop create database always
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                #region Converters
                var converters = new List<Converter>()
                {
                    new Converter
                    {
                        TypeOfConvert = "kilometer to miles",
                        NumbertoConvert = 0,
                        NumberConverted = 5.00,
                    },
                };

                context.Converters.AddRange(converters);
                context.SaveChanges();
                #endregion
            }
        }
            }
        }
