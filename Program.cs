using System;

namespace StrutureenumDemos
{
    struct Record
    {
        int rn;
        string name;
        int marks;
        string batch;
        //  public Record() { }
        public Record(int rn, string name, string batch, int marks)
        {
            this.rn = rn;
            this.name = name;
            this.batch = batch;
            this.marks = marks;
        }
        
        public void Get()
        {

        }
        public void Display() { }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Record record = new Record();
            record.Get();
            record.Display();
        }
    }
}
