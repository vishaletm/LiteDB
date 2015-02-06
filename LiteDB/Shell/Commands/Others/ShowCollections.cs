﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LiteDB.Shell.Commands
{
    public class ShowCollections : ILiteCommand
    {
        public bool IsCommand(StringScanner s)
        {
            return s.Match(@"show\scollections");
        }

        public void Execute(LiteDatabase db, StringScanner s, Display display)
        {
            if (db == null) throw new LiteException("No database");

            display.WriteResult(string.Join("\n", db.GetCollectionNames().OrderBy(x => x).ToArray()));
        }
    }
}
