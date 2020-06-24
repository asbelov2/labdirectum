﻿namespace Rights
{
    using System;

    /// <summary>
    /// Тип прав.
    /// </summary>
    [Flags, Serializable]
    public enum AccessRights : byte
    {
        /// <summary>
        /// 1 Просмотр.
        /// </summary>
        View = 1,

        /// <summary>
        /// 2 Выполнение.
        /// </summary>
        Run = 2,

        /// <summary>
        /// 4 Добавление.
        /// </summary>
        Add = 4,

        /// <summary>
        /// 8 Изменение.
        /// </summary>
        Edit = 8,

        /// <summary>
        /// 16 Утверждение.
        /// </summary>
        Ratify = 16,

        /// <summary>
        /// 32 Удаление.
        /// </summary>
        Delete = 32,

        /// <summary>
        /// Нет доступа.
        /// </summary>
        /// <remarks>
        /// Этот флаг имеет максимальный приоритет.
        /// Если он установлен, остальные флаги игнорируются
        /// </remarks>
        AccessDenied = 64
    }

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            AccessRights ex1, ex2, ex3, ex4;
            ex1 = AccessRights.Add | AccessRights.Delete | AccessRights.Edit;
            ex2 = AccessRights.Run | AccessRights.View;
            ex3 = AccessRights.AccessDenied | AccessRights.Add;
            ex4 = AccessRights.Ratify;
            ShowRights(ex1);
            ShowRights(ex2);
            ShowRights(ex3);
            ShowRights(ex4);
        }

        /// <summary>
        /// Print rights in console
        /// </summary>
        /// <param name="rights">Right flags</param>
        public static void ShowRights(AccessRights rights)
        {
            if ((rights & AccessRights.AccessDenied) != 0)  // Лучше проверять через rights.HasFlag(AccessRights.AccessDenied)
            {
                Console.Write("Access denied\n");
                return;
            }

            if ((rights & AccessRights.View) != 0)
            {
                Console.Write("View ");
            }

            if ((rights & AccessRights.Run) != 0)
            {
                Console.Write("Run ");
            }

            if ((rights & AccessRights.Add) != 0)
            {
                Console.Write("Add ");
            }

            if ((rights & AccessRights.Edit) != 0)
            {
                Console.Write("Edit ");
            }

            if ((rights & AccessRights.Ratify) != 0)
            {
                Console.Write("Ratify ");
            }

            if ((rights & AccessRights.Delete) != 0)
            {
                Console.Write("Delete");
            }

            Console.WriteLine();
        }
    }
}
