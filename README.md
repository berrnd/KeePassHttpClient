# KeePassHttpClient

KeePassHttpClient is a .Net library of for accessing a [KeePass](http://keepass.info/) database through [KeePassHttp](https://github.com/pfn/keepasshttp/).

I've searched for a KeePass command line client, found nothing - so I created this together with [KeePassHttpCli](https://github.com/berrnd/KeePassHttpCli).

Currently not every request type is implemented, see the usage examples below.

## Installation
KeePassHttpClient is available via NuGet: https://www.nuget.org/packages/KeePassHttpClient

Or directly via the Package Manager Console: `Install-Package KeePassHttpClient`

## Usage examples
```cs
//Connect to a local default KeePassHttp instance and associate the database, if not already done
KeePassHttpConnection connection new KeePassHttpConnection();
if (!connection.Connect())
  connection.Associate();

//Get an object representing the current connection state (key and so on, store this somewhere to connect with the same id again)
ConnectionInfo connectionInfo = connection.GetConnectionInfo()

//So from now on we can create the connection like so
KeePassHttpConnection connection2 = KeePassHttpConnection.FromConnectionInfo(connectionInfo);

//Get all credentials matching the url "google.com"
KeePassCredential[] credentialsByUrl = connection.RetrieveCredentialsByUrl("google.com");

//Get all credentials matching the generic search string "google" (the search is execute like through the quick search box in KeePass)
//Please note that you may need a patched version of KeePassHttp, if it's not already merged, see https://github.com/berrnd/keepasshttp/commit/5361f72d03dd44ddb0c49f700f15e416e6983685
KeePassCredential[] credentialsBySearch = connection.RetrieveCredentialsByCustomSearchString("google");
```

Maybe also [KeePassHttpCli](https://github.com/berrnd/KeePassHttpCli) is a good reference for an usage example.

## ToDo
- Documentation
- Implement all KeePassHttp request types

_Parts of KeePassHttpClient were inspired by https://github.com/vprovalov/passie_
