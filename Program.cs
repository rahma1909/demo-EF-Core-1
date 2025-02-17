using demo.Data;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***************************************

            ////1 companyDbContext context = new companyDbContext();
            // try
            // {
            //     //code
            // }
            // finally
            // {
            //     context.Dispose();
            // }

            //*********************************

            //syntax suger  //using (companyDbContext context = new companyDbContext())
            //{
            //    //code
            //}

            ///*********************************************
            //update
            using companyDbContext context = new companyDbContext();
        }
    }
}
