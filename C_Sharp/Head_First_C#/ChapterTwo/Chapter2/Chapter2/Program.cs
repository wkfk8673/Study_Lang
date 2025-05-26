
namespace Chapter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            // 변수 선언 및 초기화
            int width = 3;

            // 변수 +1 증가
            width++;

            // 변수 2개 선언 후
            // +, * 연산자 사용하여 연산
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            // 변수 2개 선언 후
            // +, * 연산자 사용하여 연결
            string result = "The area";
            result = result + "is" + "area";
            Console.WriteLine(result);

            // bool type 변수는 t/f 값을 가짐
            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}
