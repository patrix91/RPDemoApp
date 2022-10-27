using MVCDemo.Data;
using MVCDemo.Interfaces;

namespace MVCDemo.Infrastucture
{
    public class Repository: Interface
    {
        private readonly DemoDBContext demoDBContext;

        public Repository(DemoDBContext demoDBContext)
        {
            this.demoDBContext = demoDBContext;
        }

        public void LoadData()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
