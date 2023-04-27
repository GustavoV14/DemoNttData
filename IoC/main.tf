provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "myResourceGroup" {
  name     = "NTTData"
  location = "eastus"
}

resource "azurerm_kubernetes_cluster" "myKubernetesCluster" {
  name                = "ClusterNttData"
  location            = "${azurerm_resource_group.myResourceGroup.location}"
  resource_group_name = "${azurerm_resource_group.myResourceGroup.name}"


  linux_profile {
    admin_username = "azureuser"

    ssh_key {
      key_data = "Clave-Publica-Sdd"
    }
  }

  agent_pool_profile {
    name            = "default"
    count           = 1
    vm_size         = "Standard_DS2_v2"
    os_type         = "Linux"
    vnet_subnet_id  = "/subscriptions/[subscription-id]/resourceGroups/[resource-group-name]/providers/Microsoft.Network/virtualNetworks/[virtual-network-name]/subnets/[subnet-name]"
  }

  service_principal {
    client_id     = "[service-principal-client-id]"
    client_secret = "[service-principal-client-secret]"
  }

  tags = {
    environment = "dev"
  }
}
