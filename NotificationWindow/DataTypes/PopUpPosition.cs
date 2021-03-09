namespace NotificationWindow.DataTypes
{
    public class PopUpPosition
    {
        public int index { get; set; }
        public int topPosition { get; set; }
        public PopupNotifier PopupNotifier { get; set; }

        public PopUpPosition(int index, int topPosition, PopupNotifier popupNotifier)
        {
            this.index = index;
            this.topPosition = topPosition;
            PopupNotifier = popupNotifier;
        }

    }
}
