﻿public class CreditData
{
    private string author_;
    private string creditedItem_;

    public CreditData(string creditedItem, string author)
    {
        author_ = author;
        creditedItem_ = creditedItem;
    }

    public string formattedString
    {
        get
        {
            return $"<b>{creditedItem_}</b>\n<size=\"16pt\">{author_}</size>";
        }
    }
}
