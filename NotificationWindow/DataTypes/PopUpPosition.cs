namespace NotificationWindow.DataTypes
{
    public class PopUpPosition
    {
        public int Index { get; set; }
        public int TopPosition { get; set; }
        public PopupNotifier PopupNotifier { get; set; }

        public PopUpPosition(int index, int topPosition, PopupNotifier popupNotifier)
        {
            this.Index = index;
            this.TopPosition = topPosition;
            PopupNotifier = popupNotifier;
        }
    }
}