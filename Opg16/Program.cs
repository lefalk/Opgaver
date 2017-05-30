﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg16
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            logger.Trace("Enter");
            logger.Debug("Nu kaldes test1");
            test1(5, 5);
            logger.Debug("Retur fra test1");
            logger.Debug("Nu kaldes test1");
            test2();
            logger.Debug("Retur fra test2");
            logger.Trace("Exit");

        }

        static void test1(int i, int x)
        {

            logger.Trace("Enter i,x {0}");
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
            logger.Trace("Exit");

        }

        static void test2()

        {

            logger.Trace("Enter");
            try

            {

                Console.WriteLine("test");
                throw new AccessViolationException("fejl");

            }

            catch (Exception ex)
            {

                logger.Error(ex);


            }

            logger.Trace("Exit");

        }



    }
}
