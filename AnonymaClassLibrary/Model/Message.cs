using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymaClassLibrary.Model
{
    public class Message
    {
        public string Content { get; private set; }
        
        public Message(string content)
        {
            Content = content;
        }
        /// <summary>
        /// this methos will serialize the message content into the firebase!
        /// This is used in retrieving/storing data into the firebase
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> serialize()
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Content", Content);
            return dictionary;
        }
    }
}
