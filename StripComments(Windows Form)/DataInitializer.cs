using System.Data.Entity;

namespace StripComments_Windows_Form_
{
    class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            Data data1 = new Data
            {
                DataId = 1,
                InputText = "apples, pears # and bananas\ngrapes\nbananas !apples",
                CommentSymbol = "# !",
                OutputText = "apples, pears\ngrapes\nbananas"
            };

            Data data2 = new Data
            {
                DataId = 2,
                InputText = "a #b\nc\nd $e f g",
                CommentSymbol = "# $",
                OutputText = "a\nc\nd"
            };

            Data data3 = new Data
            {
                DataId = 3,
                InputText = "string1\nstring2%with symbols\nstring3 with some text ^  comments ",
                CommentSymbol = "% ^",
                OutputText = "string1\nstring2\nstring3 with some text"
            };

            context.Datas.Add(data1);
            context.Datas.Add(data2);
            context.Datas.Add(data3);
            base.Seed(context);
        }
    }
}
