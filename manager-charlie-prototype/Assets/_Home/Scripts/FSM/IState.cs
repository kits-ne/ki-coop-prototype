using System.Collections;

namespace FSM
{
    /// <summary>
    /// ���¸� ���� �� ���
    /// </summary>
    /// <typeparam name="T">�ش� State�� ID Ÿ��</typeparam>
    public interface IState<T>
    {
        void Enter();
        void Excute();
        void Exit();

        T StateID
        {
            get;
        }
    }
}