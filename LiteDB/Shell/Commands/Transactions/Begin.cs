﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LiteDB.Shell.Commands
{
    public class Begin : ILiteCommand
    {
        public bool IsCommand(StringScanner s)
        {
            return s.Scan(@"begin(\s+trans)?$").Length > 0;
        }

        public void Execute(LiteDatabase db, StringScanner s, Display display)
        {
            if (db == null) throw new LiteException("No database");

            db.BeginTrans();
        }
    }
}
