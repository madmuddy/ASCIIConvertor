namespace ASCIIEncoder
{
    public static class Encode
    {
        public static string Convert(int value)
        {
            string Character = null;

            switch(value)
            {
                case 32:
                    Character = "SP";
                    break;
                case 33:
                    Character = "!";
                    break;
                case 34:
                    Character = "'";
                    break;
                case 35:
                    Character = "#";
                    break;
                case 36:
                    Character = "$";
                    break;
                case 37:
                    Character = "%";
                    break;
                case 38:
                    Character = "&";
                    break;
                case 39:
                    Character = "";
                    break;
                case 40:
                    Character = "(";
                    break;
                case 41:
                    Character = ")";
                    break;
                case 42:
                    Character = "*";
                    break;
                case 43:
                    Character = "+";
                    break;
                case 44:
                    Character = ",";
                    break;
                case 45:
                    Character = "-";
                    break;
                case 46:
                    Character = ".";
                    break;
                case 47:
                    Character = "/";
                    break;
                case 48:
                    Character = "0";
                    break;
                case 49:
                    Character = "1";
                    break;
                case 50:
                    Character = "2";
                    break;
                case 51:
                    Character = "3";
                    break;
                case 52:
                    Character = "4";
                    break;
                case 53:
                    Character = "5";
                    break;
                case 54:
                    Character = "6";
                    break;
                case 55:
                    Character = "7";
                    break;
                case 56:
                    Character = "8";
                    break;
                case 57:
                    Character = "9";
                    break;
                case 58:
                    Character = ":";
                    break;
                case 59:
                    Character = ";";
                    break;
                case 60:
                    Character = "<";
                    break;
                case 61:
                    Character = "=";
                    break;
                case 62:
                    Character = ">";
                    break;
                case 63:
                    Character = "?";
                    break;
                case 64:
                    Character = "@";
                    break;
                case 65:
                    Character = "A";
                    break;
                case 66:
                    Character = "B";
                    break;
                case 67:
                    Character = "C";
                    break;
                case 68:
                    Character = "D";
                    break;
                case 69:
                    Character = "E";
                    break;
                case 70:
                    Character = "F";
                    break;
                case 71:
                    Character = "G";
                    break;
                case 72:
                    Character = "H";
                    break;
                case 73:
                    Character = "I";
                    break;
                case 74:
                    Character = "J";
                    break;
                case 75:
                    Character = "K";
                    break;
                case 76:
                    Character = "L";
                    break;
                case 77:
                    Character = "M";
                    break;
                case 78:
                    Character = "N";
                    break;
                case 79:
                    Character = "O";
                    break;
                case 80:
                    Character = "P";
                    break;
                case 81:
                    Character = "Q";
                    break;
                case 82:
                    Character = "R";
                    break;
                case 83:
                    Character = "S";
                    break;
                case 84:
                    Character = "T";
                    break;
                case 85:
                    Character = "U";
                    break;
                case 86:
                    Character = "V";
                    break;
                case 87:
                    Character = "W";
                    break;
                case 88:
                    Character = "X";
                    break;
                case 89:
                    Character = "Y";
                    break;
                case 90:
                    Character = "Z";
                    break;
                case 91:
                    Character = "[";
                    break;
                case 92:
                    Character = "";
                    break;
                case 93:
                    Character = "]";
                    break;
                case 94:
                    Character = "^";
                    break;
                case 95:
                    Character = "_";
                    break;
                case 96:
                    Character = "`";
                    break;
                case 97:
                    Character = "a";
                    break;
                case 98:
                    Character = "b";
                    break;
                case 99:
                    Character = "c";
                    break;
                case 100:
                    Character = "d";
                    break;
                case 101:
                    Character = "e";
                    break;
                case 102:
                    Character = "f";
                    break;
                case 103:
                    Character = "g";
                    break;
                case 104:
                    Character = "h";
                    break;
                case 105:
                    Character = "i";
                    break;
                case 106:
                    Character = "j";
                    break;
                case 107:
                    Character = "k";
                    break;
                case 108:
                    Character = "l";
                    break;
                case 109:
                    Character = "m";
                    break;
                case 110:
                    Character = "n";
                    break;
                case 111:
                    Character = "o";
                    break;
                case 112:
                    Character = "p";
                    break;
                case 113:
                    Character = "q";
                    break;
                case 114:
                    Character = "r";
                    break;
                case 115:
                    Character = "s";
                    break;
                case 116:
                    Character = "t";
                    break;
                case 117:
                    Character = "u";
                    break;
                case 118:
                    Character = "v";
                    break;
                case 119:
                    Character = "w";
                    break;
                case 120:
                    Character = "x";
                    break;
                case 121:
                    Character = "y";
                    break;
                case 122:
                    Character = "z";
                    break;
                case 123:
                    Character = "{";
                    break;
                case 124:
                    Character = "|";
                    break;
                case 125:
                    Character = "}";
                    break;
                case 126:
                    Character = "~";
                    break;
                case 127:
                    Character = "DEL";
                    break;
                default:
                    Character = "SP";
                    break;
            }

            return Character;
        }
    }
}
