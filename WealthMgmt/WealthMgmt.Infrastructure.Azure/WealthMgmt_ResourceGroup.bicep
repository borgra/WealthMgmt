targetScope = 'subscription'

param rgName string = 'rg_WealthMgmt'
param rgLocation string = 'westus2'

resource rg 'Microsoft.Resources/resourceGroups@2023-07-01' = {
  name: rgName
  location: rgLocation
}
