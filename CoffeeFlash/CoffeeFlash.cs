using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CoffeeFlash
{
    public static class CoffeeFlash
    {

        public const string SUCCESS_INDEX = "success-message";
        public const string ERROR_INDEX = "error-message";
        public const string INFO_INDEX = "info-message";

        public static void AddSuccessMessage(this Controller controller, string message)
        {
            var messageList = getMessageListByIndex(controller, SUCCESS_INDEX);
            messageList.Add(message);
            setMessageListByIndex(controller, messageList, SUCCESS_INDEX);
        }

        public static void AddErrorMessage(this Controller controller, string message)
        {
            var messageList = getMessageListByIndex(controller, ERROR_INDEX);
            messageList.Add(message);
            setMessageListByIndex(controller, messageList, ERROR_INDEX);
        }
        public static void AddInfoMessage(this Controller controller, string message)
        {
            var messageList = getMessageListByIndex(controller, INFO_INDEX);
            messageList.Add(message);
            setMessageListByIndex(controller, messageList, INFO_INDEX);
        }

        private static List<string> getMessageListByIndex(Controller c, string index)
        {
            return c.TempData[index] as List<string> ?? new List<string>();
        }
        private static void setMessageListByIndex(Controller controller, List<string> messageList, string index)
        {
            controller.TempData[index] = messageList;
        }
    }
}
