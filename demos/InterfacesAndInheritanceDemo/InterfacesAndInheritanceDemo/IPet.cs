namespace InterfacesAndInheritanceDemo
{
    interface ISpeakable
    {
        void Speak();
    }

    interface IMoveable
    {
        void Move();
    }

    interface IPet : ISpeakable, IMoveable
    {

    }
}
