//-----------------------------------------------------------------------
// <copyright file="EmailApiModel.cs" company="lanedirt">
// Copyright (c) lanedirt. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

namespace AliasVault.WebApp.Pages.Logins.Mailbox.Models.Spamok;

/// <summary>
/// Represents an email API model.
/// </summary>
public class EmailApiModel : EmailApiModelBase
{
    /// <summary>
    /// Gets or sets the HTML content of the email message.
    /// </summary>
    public string? MessageHtml { get; set; }

    /// <summary>
    /// Gets or sets the plain text content of the email message.
    /// </summary>
    public string? MessagePlain { get; set; }

    /// <summary>
    /// Gets or sets the list of attachments in the email.
    /// </summary>
    public List<AttachmentApiModel> Attachments { get; set; } = [];
}
