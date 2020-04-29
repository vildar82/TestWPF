using System.Collections.Generic;

namespace WpfApp1
{
    public class MainModel
    {
        public List<string> GetTypes()
        {
            return new List<string> { "Откос", "Вертикаль", "Горизонталь" };
        }
    }
}