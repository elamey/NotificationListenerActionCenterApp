using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationListenerActionCenterApp
{
   public interface IFileService
   {
      Task<string> LoadFileContentUsingPathFromEnvironemntVariable(string environmentVariableName);
   }
}