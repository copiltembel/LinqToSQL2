﻿using Db.DataAccess.DataSet;
using LinqToSQL2NetCore.Example.DataAccess;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace LinqToSQL2NetCore.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = GetConnectionString("connectionstrings.json");

            DbContext dbContext = new DbContext(connectionString);

            TestDeleteMultiple(dbContext);
    

            //var addresses = dbContext.Addresses.ToList();
        }

        private static void TestLoadMany(DbContext dbContext)
        {
            var testTable1s = dbContext.TestTable1s.ToList();
        }

        static string GetConnectionString(string jsonFileName)
        {
            var connectionSettings = JsonConvert.DeserializeObject<ConnectionSettings>(File.ReadAllText(jsonFileName));
            var connectionStrings = connectionSettings.DbConnectionStrings.Db1;
            return connectionStrings;
        }

        static void InsertSomeEntities(DbContext dbContext)
        {
            for (int i = 0; i < 1000; i++)
            {
                var table1s = new TestTable1();
                table1s.Dummy = "Testin";
                table1s.Dummy2 = i;
                dbContext.GetTable<TestTable1>().InsertOnSubmit(table1s);
            }
            dbContext.SubmitChanges();
        }

        static void TestInsertOrder(DbContext dbContext)
        {
            var testTable1 = new TestTable1();
            testTable1.Dummy = "First";
            testTable1.Dummy2 = 1;
            var testTable3 = new TestTable3();
            testTable3.TestTable1 = testTable1;
            dbContext.GetTable<TestTable3>().InsertOnSubmit(testTable3);
            dbContext.SubmitChanges();
        }

        static void TestDeleteMultiple(DbContext dbContext)
        {
            var testTable1 = new TestTable1();
            testTable1.Dummy = "Del";
            testTable1.Dummy2 = 69;
            dbContext.GetTable<TestTable1>().InsertOnSubmit(testTable1);
            var testTable31 = new TestTable3();
            testTable31.TestTable1 = testTable1;
            var testTable32 = new TestTable3();
            testTable32.TestTable1 = testTable1;

            dbContext.SubmitChanges();

            dbContext.DeleteOnSubmit(testTable31);
            dbContext.DeleteOnSubmit(testTable32);
            dbContext.DeleteOnSubmit(testTable1);
            dbContext.SubmitChanges();
        }
    }
}
