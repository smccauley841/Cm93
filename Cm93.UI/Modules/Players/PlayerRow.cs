﻿/*
        Copyright © Iain McDonald 2013-2016
        This file is part of Cm93.

        Cm93 is free software: you can redistribute it and/or modify
        it under the terms of the GNU General Public License as published by
        the Free Software Foundation, either version 3 of the License, or
        (at your option) any later version.

        Cm93 is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
        GNU General Public License for more details.

        You should have received a copy of the GNU General Public License
        along with Cm93. If not, see <http://www.gnu.org/licenses/>.
*/
namespace Cm93.UI.Modules.Players
{
	/*
	 * IF YOU'RE CHANGING THIS enum...
	 * Read the comments in PlayersView.xaml.cs
	 */
	public enum PlayerFilter
	{
		Position,
		Age,
		Rating,
		Team,
		Goals
	}

	public class PlayerRow
	{
		public int Number { get; internal set; }
		public string Name { get; internal set; }
		public string Team { get; internal set; }
		public string Position { get; internal set; }
		public int Age { get; internal set; }
		public double Rating { get; internal set; }
		public int Goals { get; internal set; }
	}
}
