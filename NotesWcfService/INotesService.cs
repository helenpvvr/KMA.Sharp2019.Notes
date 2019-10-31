using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NotesWcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "INotesService" в коде и файле конфигурации.
    [ServiceContract]
    public interface INotesService
    {
        [OperationContract]
        string DoWork();
    }
}
