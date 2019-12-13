# Thycotic.UiPath.SecureStore
Credential Store plugins for UI Path orchestrator.

# DevOps Secrets Vault
The DevOps Secrets Vault (DSV) integration is read / write, so as assets are created and updated in UI Path Orchestrator they will get added to DSV.

## Setup
* In your DSV tenant create a new client credential assigned a role that has read / write / update /delete access to the base path where UI Path secrets will be stored.
  * https://docs.thycotic.com/dsv/1.0.0/cli-ref/client.md
* Drop the DevOpsVault.SecureStore.dll into the plugins directory in UI Path Orchestrator and modify the web.config as specified here: https://github.com/UiPath/Orchestrator-CredentialStorePlugins
* Go to Credential Stores in UI Path and add a new DevOpsSecretsVault credential store
  * DevOps Secrets Vault URL - your tenant url, i.e. https://tenantname.secretsvaultcloud.com
  * Client Id - the clientid from the client credential created earlier
  * Client Secret - the client secret for that client credential
  * Base Path Prefix - prefix that UI Path will append to the asset and robot lookups when getting credentials from DSV. For example if your prefix is `uipath/prod` then all secrets created will be under `/secrets/uipath/prod/<credentialname>` in DSV.

  

