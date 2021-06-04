using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)///// method main
        {


            Console.WriteLine("HOROSCOPE");

            int number = 7;
            int count = 1;
            count = number - 1;
            for (int j = 1; j <= number; j++)
            {
                for (int i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (int i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (int j = 1; j <= number - 1; j++)
            {
                for (int i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (int i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }


            Console.WriteLine("");




            ////// อธิบายขั้นตอนวิธีการดูดวง //////
            
            //// หลักการทำงานของโปรแกรมดูดวงนี้ คืือ การที่ให้ผู้ใช้งานใส่ชื่อ/นามสกุล และให้ใส่เรื่องที่ตนเองอยากรู้ลงไป โดยจะมีเรื่องดังนี้
            /// 1.เรื่องความรัก ให้พิมพ์ ----> Love
            /// 2.เรื่องเงิน  ให้พิมพ์ ----> Money
            /// 3.เรื่องงาน ให้พิมพ์ -----> Work
            ///
            //// เมื่อใส่เรื่องที่อยากรู้ลงไปแล้วระบบก็จะทำการสุ่มเรื่องที่ต้องการดูจากทั้งหมด 5 หัวข้อ และ ปริ้นข้อความออกมา
            ///
            ///// ***** โดยโค้ดอันนี้ผมได้แรงบันดาลใจมาจากการเขย่าเซียมซีตามวัดต่างๆ และเอามาปรับใช้โดยการใช้ Random ครับ *****


            ////เริ่มต้นการดูดวง////

            Console.WriteLine("Please Choose what topic do you want to know in this year? ");
            Console.Write("What is your Real name: ");
            String name = Console.ReadLine();
            Console.Write("What is your Surename: ");
            string surename = Console.ReadLine();
            Console.Write("Love,Money or Work? --------> Your answer: ");
            string horoscope = Console.ReadLine();

            Console.WriteLine();

            switch(horoscope)
            {


                /////เรื่องความรัก////
                case "Love":

                    Console.WriteLine(name);
                    

                    ///////RANDOM เลขดวง ////////
                    Random num = new Random();
                    int numberal = num.Next(1, 5);
                    Console.WriteLine("Your love situation in this year is on the Number : {0}", numberal);

                    
                    Console.WriteLine("");
                    Console.WriteLine("***************************");
                    Console.WriteLine("***************************");
                    Console.WriteLine("");
                    Console.WriteLine("* Precisicion *");
                    Console.WriteLine("");

                    int love = numberal;
                    if (love == 1)
                    {
                        Console.WriteLine("There could be a battle going on between your heart and your head.");
                        Console.WriteLine("Today's interplay of celestial energies may indicate that your head tells you to go one way and commit to one particular plan,");
                        Console.WriteLine("while your heart tells you something else.");
                    }
                    else if (love == 2)
                    {
                        Console.WriteLine("You can get into as many head trips as you want concerning a certain relationship,");
                        Console.WriteLine("but this isn't going to change the reality of what is going on between you.");
                        Console.WriteLine("The current astral configuration encourages you not to fantasize about how things could be, but to tackle them as they are.");

                    }
                    else if (love == 3)
                    {
                        Console.WriteLine("Rome wasn't built in a day, and neither is a relationship,");
                        Console.WriteLine("they take, effort and a strong sense of commitment.");
                        Console.WriteLine("The current planetary alignment indicates that if your thoughts have been straying away from your current partner ");
                        Console.WriteLine("and dwelling on someone else,you may need to reflect on why this is happening.");
                    }
                    else if (love == 4)
                    {
                        Console.WriteLine("The current planetary alignment indicates that you have quite a lot to say for yourself");
                        Console.WriteLine("concerning a certain event, but don't actually feel like talking right now.");
                        Console.WriteLine("If your relationship is going through a stormy patch,");
                        Console.WriteLine("then it is naturally far easier to withdraw in hurt silence then to make the effort to discuss the situation. ");
                    }
                    else 
                    {
                        Console.WriteLine("Your evening may not go entirely according to plan, but it won't be boring.");
                        Console.WriteLine("Today's celestial energy encourages you to discover someone's intellectual preferences");
                        Console.WriteLine("before you turn to more passionate matters.");
                        Console.WriteLine(" If you both have the same beliefs and ideals, then everything else will fall into place.");
                    }
                    
                    break;



                /////เรื่องเงินทอง/////
                case "Money":

                    Console.WriteLine(name);

                    ///////RANDOM เลขดวง ////////
                    Random numb = new Random();
                    int numberall = numb.Next(1, 5);
                    Console.WriteLine("Your Money situation in this year is on the Number : {0}", numberall);


                    Console.WriteLine("");
                    Console.WriteLine("***************************");
                    Console.WriteLine("***************************");
                    Console.WriteLine("");
                    Console.WriteLine("* Precisicion *");
                    Console.WriteLine("");

                    int money = numberall;
                    if (money == 1)
                    {
                        Console.WriteLine("You have activity in your relationships this week.");
                        Console.WriteLine("A new relationship could materialize out of nowhere and prove financially beneficial for both of you.");
                        Console.WriteLine("At this time your attention needs to be on building your career.");
                        Console.WriteLine("Putting together a five-year plan may not be a bad idea, either.");
                    }
                    else if (money == 2)
                    {
                        Console.WriteLine("This week is about trying to stay balanced and sane.");
                        Console.WriteLine("Look to the Universe for information about where you're headed");
                        Console.WriteLine("-this week it's found in your house of communication.");
                    }
                    else if (money == 3)
                    {
                        Console.WriteLine("You have new opportunities to earn additional hours or find a new job with better pay and benefits.");
                        Console.WriteLine(" Your romantic, family, and fun household activities mean that you are forced to find it delicate");
                        Console.WriteLine("that you are encouraged to choose between work and family.");
                 
                    }
                    else if (money == 4)
                    {
                        Console.WriteLine("The aspects are great not only for energy and getting things done but also for physical pursuits like exercise.");
                        Console.WriteLine("If you've been meaning to get out more or begin a new yoga practice, this is the week to start.");
                        Console.WriteLine("It's also great for sublimating that energy into changing your money situation for the better.");
                    }
                    else 
                    {
                        Console.WriteLine("This week is about your money and values.");
                        Console.WriteLine("It may be a stellar week as more opportunities for earning money come your way, seemingly out of nowhere.");
                        Console.WriteLine("This means that you may need to spend more time at work for the moment and less time socializing.");
                    }
                    break;




                    ///// เรื่องการงาน /////
                case "Work":


                    Console.WriteLine(name);

                    ///////RANDOM เลขดวง ////////
                    Random numbz = new Random();
                    int numberoll = numbz.Next(1, 5);
                    Console.WriteLine("Your work situation in this year is on the Number : {0}", numberoll);

                    Console.WriteLine("");
                    Console.WriteLine("***************************");
                    Console.WriteLine("***************************");
                    Console.WriteLine("");
                    Console.WriteLine("* Precisicion *");
                    Console.WriteLine("");

                    int work = numberoll;
                    if (work == 1)
                    {
                        Console.WriteLine("This is a powerful time for you regarding leveling up and revolutionizing your career.");
                        Console.WriteLine("Perhaps you have been going through upheaval and change lately.");
                        Console.WriteLine("And forming a in your career sector.");
                    }
                    else if (work == 2)
                    {
                        Console.WriteLine("Confusion around your career can occur today.");
                        Console.WriteLine("And bring lack of clarity and can also bring up the truth.");
                        Console.WriteLine("Being transparent, carefully editing, and lightly navigating today would be the best idea.");
                    }
                    else if (work == 3)
                    {
                        Console.WriteLine("Hidden news that you weren’t private to at work could develop today recurring from the past.");
                        Console.WriteLine("Avoiding important conversations or staying away from controversial opinions could serve you well at this time. Instead,");
                        Console.WriteLine("think of how you can improve the situation and be the natural leader you are.");
                    }
                    else if (work == 4)
                    {
                        Console.WriteLine("You have been waiting for this time, can bring career growth, luck, and prosperity.");
                        Console.WriteLine("Affecting your work in a major way. Embrace this change for the better.");
                    }
                    else 
                    {
                        Console.WriteLine(".This is a time where partnering with others could serve you well, ");
                        Console.WriteLine("lower your stress levels, add another point of view, and give you more time for creative work.");
                        Console.WriteLine("Today a potential business partner from the past could resurface and offer help.");
                        Console.WriteLine("This is a good communication easier and working with others can help improve your work at this time.");
                    }
                    break;


                default:
                    Console.WriteLine("Error please try again!!!!");
                    break;




            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**** Developer this aligolithm : Khunanon Ngaobenjakul ****");

            ////// ถึงพี่ที่ตรวจโค้ดของผม ที่พี่บอกว่าให้ทำโปรแกรมอย่างง่าย(ยำ้ว่าอย่างง่าย) ในตอนที่ผมเขียน Flowchart ผมรู้สึกว่ามันไม่ได้เยอะมาก
            ///แต่่หลังจากที่ผมได้ลองเขียนจริงๆก็พบว่ามันเยอะกว่าที่คิดไว้เยอะเลย ขอโทษด้วยครับ
           
           


            










        }







    }
}
