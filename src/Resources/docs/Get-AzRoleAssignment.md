---
external help file: Az.Resources-help.xml
Module Name: Az.Resources
online version: https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azroleassignment
schema: 2.0.0
---

# Get-AzRoleAssignment

## SYNOPSIS
Gets a role assignment by ID.

## SYNTAX

### ListSubscriptionIdViaHost5 (Default)
```
Get-AzRoleAssignment [-Filter <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get1
```
Get-AzRoleAssignment -Id <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get2
```
Get-AzRoleAssignment -Name <String> -Scope <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List7
```
Get-AzRoleAssignment -Scope <String> [-Filter <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get3
```
Get-AzRoleAssignment -RoleId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListSubscriptionIdViaHost3
```
Get-AzRoleAssignment -ParentResourcePath <String> -ResourceGroupName <String> -ResourceName <String>
 -ResourceProviderNamespace <String> -ResourceType <String> [-Filter <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List4
```
Get-AzRoleAssignment -ParentResourcePath <String> -ResourceGroupName <String> -ResourceName <String>
 -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String> [-Filter <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListSubscriptionIdViaHost4
```
Get-AzRoleAssignment -ResourceGroupName <String> [-Filter <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List5
```
Get-AzRoleAssignment -ResourceGroupName <String> -SubscriptionId <String> [-Filter <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List6
```
Get-AzRoleAssignment -SubscriptionId <String> [-Filter <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets a role assignment by ID.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
The filter to apply on the operation.
Use $filter=atScope() to return all role assignments at or above the scope.
Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal.

```yaml
Type: System.String
Parameter Sets: ListSubscriptionIdViaHost5, List7, ListSubscriptionIdViaHost3, List4, ListSubscriptionIdViaHost4, List5, List6
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The ID of the role assignment to get.

```yaml
Type: System.String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the role assignment to get.

```yaml
Type: System.String
Parameter Sets: Get2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentResourcePath
The parent resource identity.

```yaml
Type: System.String
Parameter Sets: ListSubscriptionIdViaHost3, List4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: ListSubscriptionIdViaHost3, List4, ListSubscriptionIdViaHost4, List5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceName
The name of the resource to get role assignments for.

```yaml
Type: System.String
Parameter Sets: ListSubscriptionIdViaHost3, List4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceProviderNamespace
The namespace of the resource provider.

```yaml
Type: System.String
Parameter Sets: ListSubscriptionIdViaHost3, List4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceType
The resource type of the resource.

```yaml
Type: System.String
Parameter Sets: ListSubscriptionIdViaHost3, List4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleId
The ID of the role assignment to get.

```yaml
Type: System.String
Parameter Sets: Get3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
The scope of the role assignment.

```yaml
Type: System.String
Parameter Sets: Get2, List7
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: List4, List5, List6
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20171001Preview.IRoleAssignment
### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20180901Preview.IRoleAssignment
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azroleassignment](https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azroleassignment)
