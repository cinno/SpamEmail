using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Threading; 

namespace SpamEmail
{
    class Program
    {

        

        static void Main(string[] args)
        {


            while (true)
            {
                SendMail();
                Thread.Sleep(300000); 
            }
            Console.ReadKey(); 
            
        }

        static void SendMail()
        {


            List<string> classEmails = new List<string>
            {
                "christian.smith661@gmail.com",
                "l.averyhart@gmail.com",
                "zamirajohnsonsfaelos@gmail.com",
                "jacquan113@gmail.com", 
                "prettygirlkayla11@gmail.com",
                "taevondruwhite@gmail.com",
                "aniyam404@gmail.com",
                "misskitkittz@gmail.com",
                "syearabd@gmail.com",
                "jrainey831@gmail.com", 
                "kaylinclowers@gmail.com",
                "brittanygrell0@gmail.com",
                "kelvinblazey78@gmail.com",
                "britster113@gmail.com",
                "mannymcqueen267@gmail.com",
                "kobebryant5245@gmail.com",
                "milesmc85@gmail.com",
                "lightning2184@gmail.com",
                "yehudahasahel@gmail.com",
                "robertnorwood32@gmail.com",
                "judiahqueen@gmail.com",
                "missfab1215@gmail.com",
                "kaylaphilllips18@gmail.com",
                "chyna6885@gmail.com",
                "shalai2008@gmail.com",
                "fatousecka98@gmail.com",
                "kikibattle3@gmail.com",
                "kikibattle3@gmail.com",
                "agallegos458@gmail.com",
                "princejalen10@gmail.com",
                "caleblamar326@gmail.com",
                "briamccombs14@gmail.com",
                "jamielewis2@yahoo.com"

            };

            List<string> emailSenders = new List<string>
            {
                "hisisbecauseimbored@gmail.com",
                "robertsauge@gmail.com"
            };
            List<string> emailPasswords = new List<string>
            {
                "FakeEmail01",
                "FakeEmail02"
            };

            List<string> emailSubjects = new List<string>
        {
            "Please Read",
            "Come On Down!!",
            "Special Offer!",
            "Having trouble falling asleep?",
        };
            List<string> emailBodys = new List<string>
        {
            "If you are reading this please help me, for I havent been touched by a person of the opposite gender in such a long time :(." +
            "For 5 cents a day you can help people like me get some love... not real love, mechanical love... from a Dildo."+
            "I need your money so I can by a new sex toy." +
            "If you would like to help me and many others like me plesae email me back. Thank You",

            "COME ON DOOOWWWWNNNN to BIIGGG PAPA's, Big PaPa's is a male strip club for explicitly MALES ONLY!!!" + 
            "I can not stress enough how this is a male only club. Like we get complaints constantly about how we should only open it up for both genders"+
            "But Women dont understand the whole concept of no touching unlike the men(Gay Men). But i digress, COME ON DOWN TO BIIGGGG PAPAAA'SS!!",

            "FIND HOT YOUNG SINGLES IN YOU'RE LOCAL AREA!!, ok, you got me. They may not be hot... or single but hear me out." +
            "What you can do is find look at hot young singles free of charge. I mean, its a free country, right?" +
            "all you gotta do is find a gal or guy that you think is attractive and just stare at them but not for too long" +
            "i can not tell you enough that you cannot stare at them for to long, because then they'll think youre weird. like me "+ 
            "the point is that i am sorry for lying and I hope you have a good day",

            "Are you having trouble falling asleep. well here at NT (Negro Tech), we have a brand-new invention called SLAP MAN!!© " +
            "SLAP MAN is the newest innovation that came from top of the line research at out top secret facilities. What SLAP MAN does is "+
            "wait for you to call our company and ask 'Can you send a SLAP MAN over?' And BOOM like that a SLAP MAN of your choice will arrive"+
            " at your home and as soon as you answer the door, you'll be getting slapped so hard that you have no choice but to fall asleep." +
            "SLAP MAN comes in African American, Caucasian, Asian, Native American, Iranian, African, Hispanic, AND MANY MORE" +
            "Call today at 504-123-4318 for your free SLAP MAN Trial" +
            "Side effects may include, chronic headaches, bloody noses, chronic bruising, lack of thoughts, concusions, short-term memory loss"+
            " long-term memory loss, Complete memory loss, death, death, and even more dead." +
            "CALL NOW!!"
        };



            Thread.Sleep(500); 

            Random victem = new Random();
            Random rMail = new Random(); 
            Random rand = new Random();
            int victNum = victem.Next(classEmails.Count); 
            int sEmail = rand.Next(emailSenders.Count);
            int mRand = rMail.Next(emailBodys.Count); 

            
            
            try
            {
                Console.WriteLine("Sending email to " + classEmails[victNum]); 


                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(emailSenders[sEmail]);
               mail.To.Add(classEmails[victNum]);

              //  mail.To.Add("Dankerprouduct2@gmail.com");

                mail.Subject = emailSubjects[mRand];
                mail.Body = emailBodys[mRand]; 



                smtpServer.Port = 25;
                smtpServer.Credentials = new System.Net.NetworkCredential(emailSenders[sEmail], emailPasswords[sEmail]);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail); 
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

            try
            {
                


                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(emailSenders[sEmail]);
                mail.To.Add("Dankerprouduct2@gmail.com");

                //  mail.To.Add("Dankerprouduct2@gmail.com");

                mail.Subject = "Sent Email";
                mail.Body = "Sent Email to " + classEmails[victNum];



                smtpServer.Port = 25;
                smtpServer.Credentials = new System.Net.NetworkCredential(emailSenders[sEmail], emailPasswords[sEmail]);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

        }
    }
}
