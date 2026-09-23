using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    using System;
    using System.Collections.Generic;

    public class QuestLog
    {
        private HashSet<int> _completedQuestIds = new HashSet<int>();

        public void CompleteQuest(int questId)
        {
            if (_completedQuestIds.Contains(questId))
            {
                Console.WriteLine($"Квест {questId} уже был сдан!");
            }
            else
            {
                _completedQuestIds.Add(questId);
                Console.WriteLine($"Квест {questId} успешно завершен!");
            }
        }

        public bool IsQuestCompleted(int questId)
        {
            return _completedQuestIds.Contains(questId);
        }
    }


}
