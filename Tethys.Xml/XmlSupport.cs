// ---------------------------------------------------------------------------
// <copyright file="XmlSupport.cs" company="Tethys">
//   Copyright (C) 2017-2023 T. Graf
// </copyright>
//
// Licensed under the Apache License, Version 2.0.
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied.
// SPDX-License-Identifier: Apache-2.0
// ---------------------------------------------------------------------------

namespace Tethys.Xml
{
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// XML support methods.
    /// </summary>
    public class XmlSupport
    {
        #region PUBLIC METHODS
        /// <summary>
        /// Gets the attribute value.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="name">The name.</param>
        /// <param name="throwException">if set to <c>true</c> throws an exception
        /// if the node was not found.</param>
        /// <returns>The requested attribute value.</returns>
        public static string GetAttributeValue(XElement parent, string name, bool throwException = true)
        {
            var attribute = parent.Attributes().FirstOrDefault(e => e.Name.LocalName == name);
            if (attribute == null)
            {
                if (throwException)
                {
                    throw new XmlException($"No attribute '{name}' found!");
                } // if

                return null;
            } // if

            return attribute.Value;
        } // GetAttributeValue()

        /// <summary>
        /// Gets the first sub node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="name">The name.</param>
        /// <param name="throwException">if set to <c>true</c> throws an exception
        /// if the node was not found.</param>
        /// <returns>The requested sub node.</returns>
        public static XElement GetFirstSubNode(XContainer parent, string name, bool throwException = true)
        {
            var nodes = parent.Elements().Where(e => e.Name.LocalName == name);
            var xnode = nodes.FirstOrDefault();
            if ((xnode == null) && throwException)
            {
                throw new XmlException($"No node '{name}' found!");
            } // if

            return xnode;
        } // GetFirstSubNode()

        /// <summary>
        /// Gets the value of the first sub node with the given name.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="name">The name.</param>
        /// <param name="throwException">if set to <c>true</c> throws an exception
        /// if the node was not found.</param>
        /// <returns>The requested sub node value as string.</returns>
        public static string GetFirstSubNodeValue(XContainer parent, string name, bool throwException = true)
        {
            var nodes = parent.Elements().Where(e => e.Name.LocalName == name);
            var xnode = nodes.FirstOrDefault();
            if (xnode == null)
            {
                if (throwException)
                {
                    throw new XmlException($"No node '{name}' found!");
                } // if

                return null;
            } // if

            return xnode.Value;
        } // GetFirstSubNode()
        #endregion // PUBLIC METHODS
    } // XmlSupport
}
