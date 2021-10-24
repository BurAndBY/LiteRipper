﻿using AssetRipper.Core.Classes.Shader.SerializedShader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetRipper.Library.Exporters.Shaders
{
	public class RequiredProperty
	{
		public RequiredProperty(string name, PropertyType type)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));
			Type = type;
		}

		public string Name { get; set; }
		public PropertyType Type { get; set; }

		public bool IsMatch(SerializedProperty property)
		{
			return this.Name == property.Name && Type.IsMatch(property.Type);
		}
	}
}
