﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmTest.Model;

namespace WpfMvvmTest.ViewModel.Helper
{
   public class UserHepler
    {
        public static async Task<TestDTO> GetTest(string testName)
        {
            TestthisProg testthisProg = new TestthisProg();
            testthisProg.NewTest();
            //  using()
            {

            }
            List<TestDTO> tests = new List<TestDTO>();
            foreach (var item in testthisProg.tests)
            {

            tests.Add(item);
            }
          
            if(tests.Find(x => x.NameTest == testName)!=null)
            {

            return tests.Find(x => x.NameTest == testName);
            }
            else
            {
                throw new Exception("Not Founded");
            }
        }
        public static async Task<List<QuestionDTO>> GetQuestions(string testName)
        {

            TestthisProg testthisProg = new TestthisProg();
            testthisProg.NewTest();


            TestDTO test = await GetTest(testName);           
            List<QuestionDTO> questions = new List<QuestionDTO>();
          
            foreach (var item in test.Questions)
            {
                questions.Add(item);
              
            }
           


            return questions;
        }
        public static async Task<List<AswerOpinionDTO>> GetAnswers(TestDTO test,QuestionDTO question)
        {
            //TestthisProg testthisProg = new TestthisProg();
            //testthisProg.NewTest();
            List<AswerOpinionDTO> aswerOpinions = new List<AswerOpinionDTO>();

            AswerOpinionDTO aswerOpinionDTO1 = new AswerOpinionDTO();
            AswerOpinionDTO aswerOpinionDTO2 = new AswerOpinionDTO();
            AswerOpinionDTO aswerOpinionDTO3 = new AswerOpinionDTO();

            aswerOpinions.Add(aswerOpinionDTO1);
            aswerOpinions.Add(aswerOpinionDTO2);
            aswerOpinions.Add(aswerOpinionDTO3);

            //  QuestionDTO questionDTO = testthisProg.questions.First(x=>x==question);

            List<AswerOpinionDTO> aswers = new List<AswerOpinionDTO>();

            foreach (var item in aswerOpinions)
            {
                aswers.Add(item);

            }

            return aswers;
        }


    }
}
