﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AeroFSSDK
{
    /// <summary>
    /// A specification of the AeroFS Authorization API accessible through an Auth client.
    /// </summary>
    public interface AeroFSAuthAPI
    {
        /// <summary>
        /// Generates URL to proceed with authorization flow.
        /// </summary>
        /// <param name="scopes">List of requested OAuth scopes.</param>
        string GenerateAuthorizationUrl(OAuthScope[] scopes);

        /// <summary>
        /// Generates URL to proceed with authorization flow.
        /// </summary>
        /// <param name="scopes">A single requested OAuthScope.</param>
        string GenerateAuthorizationUrl(OAuthScope scope);

        /// <summary>
        /// Exchanges an OAuthv2 authorization code for an access token to be used in future API requests.
        /// </summary>
        /// <returns>The new access token, which can be used for AeroFSClient.Create()</returns>
        string ExchangeAuthorizationCodeForAccessToken(string code);

    }

    public enum OAuthScope
    {
        FilesRead,
        FilesWrite,
        FilesAppdata,
        UserRead,
        UserWrite,
        UserPassword,
        ACLRead,
        ACLWrite,
        ACLInvitations,
        OrganizationAdmin
    }
}
