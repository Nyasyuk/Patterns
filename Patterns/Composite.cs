using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{    
    abstract class Component
    {
        public Component() { }
        
        public abstract string Operation();
        
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
        
        public virtual bool IsComposite()
        {
            return true;
        }
    }
    
    class Content : Component
    {
        public override string Operation()
        {
            return "Содержимое";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
    
    class Composite : Component
    {
        protected List<Component> children = new List<Component>();

        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }
        
        public override string Operation()
        {
            int i = 0;
            string result = "Коробка(";

            foreach (Component component in this.children)
            {
                result += component.Operation();
                if (i != this.children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }

    class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"{leaf.Operation()}\n");
        }
        
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"{component1.Operation()}");
        }
    }

}
