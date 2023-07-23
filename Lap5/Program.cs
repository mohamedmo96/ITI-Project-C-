

namespace Lap5
{
    internal class Program
    {
        class Qussetion
        {
            public Qussetion()
            {

            }
            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }
            public Qussetion(string heade, string body, int mark)
            {
                this.Header = heade;
                this.Body = body;
                this.Mark = mark;
            }
            public virtual void display()
            {
                Console.WriteLine($"Subject is {Header}  Qustion {Body} And Mark is {Mark}");
            }
        }
        class MCQ : Qussetion
        {
            string[] Chooses { get; set; }
            public MCQ(string heade, string body, int mark, string[] Chooses) : base(heade, body, mark)
            {
                this.Chooses = Chooses;
            }
            public override void display()
            {
                Console.WriteLine($" Suject  {Header} , the Qusetuin is {Body} , the mark is {Mark}");
                Console.WriteLine("The choices are:");
                foreach (string choice in Chooses)
                {
                    Console.WriteLine(choice);
                }
            }
        }
        class TOF : Qussetion
        {
            public bool Answer { get; set; }
            public TOF(string heade, string body, int mark, bool answer) : base(heade, body, mark)
            {
                this.Answer = answer;
            }
            public override void display()
            {
                Console.WriteLine($" Suject  {Header} , the Qusetuin is {Body} , the mark is {Mark}");
                Console.WriteLine("The answer is: " + Answer.ToString());
            }
        }

        static void Main(string[] args)
        {

            Qussetion[] questions = new Qussetion[3];

            string[] c1 = new string[] { "True ", " False" };
            MCQ q1 = new MCQ("Cs", "If animal have hand", 50, c1);

            TOF q2 = new TOF("DS", "IF u Have Hand ", 50, true);

            string[] c2 = new string[] { "Yes ", " No" };
            MCQ q3 = new MCQ("IT", "Do you like C#?", 50, c2);

            questions[0] = q1;
            questions[1] = q2;
            questions[2] = q3;

            foreach (Qussetion q in questions)
            {
                Console.WriteLine("--------");
                q.display();
            }

        }
    }
}

